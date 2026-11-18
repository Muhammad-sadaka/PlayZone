using PlayZone_Buisness;
using PlayZone_DataAccessEF.Models;
using SharedDTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlayZone
{
    public partial class frmDetails : Form
    {
        public delegate void DataBackEventHandler(object sender, decimal SessionRevenue, decimal CafeteriaRevenue, decimal GrandTotal);
        public event DataBackEventHandler DataBack;

        private readonly string _SpotTitle;
        private readonly string _CustomerName;
        private readonly DateTime _StartTime;
        private readonly decimal _PricePerHour;
        private int _ReservationID;
        private bool _EndMode = false;

        private List<ReservationProductListDTO> _Orders = new();

        public frmDetails(int reservationID, string spotTypeName, string spotName,
            string customerName, DateTime startTime, decimal pricePerHour, bool endMode = false)
        {
            InitializeComponent();

            _ReservationID = reservationID;
            _SpotTitle = $"{spotTypeName} - {spotName}";
            _CustomerName = customerName;
            _StartTime = startTime;
            _PricePerHour = pricePerHour;
            _EndMode = endMode;
        }

        private async void frmDetails_Load(object sender, EventArgs e)
        {
            lblSpotInfo.Text = _SpotTitle;
            lblCustomer.Text = _CustomerName;
            lblStarted.Text = _StartTime.ToString("dd/MM/yyyy hh:mm tt");
            lblPricePerHour.Text = _PricePerHour.ToString();

            _SetupOrdersGrid();

            await _LoadProductsComboAsync();
            await _RefreshOrdersAsync();

            _SetMode(isCustom: false);

            _UpdateTimeAndCost();
            timer1.Interval = 1000;

            if (_EndMode)
            {
                timer1.Stop();
                panel2.Enabled = false;
            }
            else
                timer1.Start();
        }

        // ---------- الوقت والتكلفة ----------
        private void timer1_Tick(object sender, EventArgs e) => _UpdateTimeAndCost();

        private decimal _GetPlayingCost()
        {
            TimeSpan elapsed = DateTime.Now - _StartTime;
            return Math.Round((decimal)elapsed.TotalHours * _PricePerHour, 2);
        }

        private void _UpdateTimeAndCost()
        {
            TimeSpan elapsed = DateTime.Now - _StartTime;
            lblElapsed.Text = $"{(int)elapsed.TotalHours:00}:{elapsed.Minutes:00}:{elapsed.Seconds:00}";

            decimal playing = _GetPlayingCost();
            decimal? products = _Orders.Sum(o => o.TotalPrice);
            decimal GrandTotal = playing + products.Value;
            lblPlayingCost.Text = playing.ToString("0.00");
            lblProductsTotal.Text = products.Value.ToString("0.00");
            lblGrandTotal.Text = GrandTotal.ToString("0.00");

            DataBack?.Invoke(this, playing, products.Value, GrandTotal );
        }

        // ---------- جدول الطلبات ----------
        private void _SetupOrdersGrid()
        {
            dgvOrders.AutoGenerateColumns = false;
            dgvOrders.Columns.Clear();
            //dgvOrders.AllowUserToAddRows = false;
            //dgvOrders.ReadOnly = true;
            //dgvOrders.RowHeadersVisible = false;
            dgvOrders.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            dgvOrders.Columns.Add(new DataGridViewTextBoxColumn
            { Name = "ProductName", HeaderText = "Product", DataPropertyName = "ProductName", FillWeight = 40 });
            dgvOrders.Columns.Add(new DataGridViewTextBoxColumn
            { Name = "Quantity", HeaderText = "Quantity", DataPropertyName = "Quantity", FillWeight = 15 });
            dgvOrders.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "UnitPrice",
                HeaderText = "Unit Price",
                DataPropertyName = "UnitPrice",
                FillWeight = 20,
                DefaultCellStyle = new DataGridViewCellStyle { Format = "0.00" }
            });
            dgvOrders.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "TotalPrice",
                HeaderText = "TotalPrice",
                DataPropertyName = "TotalPrice",
                FillWeight = 20,
                DefaultCellStyle = new DataGridViewCellStyle { Format = "0.00" }
            });
            dgvOrders.Columns.Add(new DataGridViewButtonColumn
            { Name = "Delete", HeaderText = "", Text = "✖", UseColumnTextForButtonValue = true, FillWeight = 10 });

            dgvOrders.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private async Task _RefreshOrdersAsync()
        {
            _Orders = await clsReservationProduct.GetAllReservationProductsAsync(_ReservationID);
            dgvOrders.DataSource = null;
            dgvOrders.DataSource = _Orders;
            _UpdateTimeAndCost();
        }

        private async void dgvOrders_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || dgvOrders.Columns[e.ColumnIndex].Name != "Delete" || _EndMode) return;

            var order = _Orders[e.RowIndex];

            if (MessageBox.Show($"Remove \"{order.ProductName}\" from the order?", "Confirm",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                return;

            if (await clsReservationProduct.DeleteReservationProductAsync(order.OrderProductID!.Value))
                await _RefreshOrdersAsync();
            else
                MessageBox.Show("Could not delete the item.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        // ---------- إضافة المنتجات ----------
        private async Task _LoadProductsComboAsync()
        {
            cbProducts.DisplayMember = "ProductName";
            cbProducts.ValueMember = "ProductID";
            cbProducts.DataSource = await clsProduct.GetAllProductsAsync();
            cbProducts.SelectedIndex = cbProducts.Items.Count > 0 ? 0 : -1;
            _ShowSelectedProductPrice();
        }

        private void cbProducts_SelectedIndexChanged(object sender, EventArgs e)
           => _ShowSelectedProductPrice();

        private void _ShowSelectedProductPrice()
        {
            if (cbProducts.SelectedItem is ProductDTO p)
                tbPrice.Text = p.Price.Value.ToString("0.00");
        }

        // التبويب: From Menu / Custom Product
        private void tcAddProduct_SelectedIndexChanged(object sender, EventArgs e)
            => _SetMode(isCustom: tcAddProduct.SelectedTab == tpCustom);

        private void _SetMode(bool isCustom)
        {
            cbProducts.Visible = !isCustom;
            tbProductName.Visible = isCustom;
            tbPrice.ReadOnly = !isCustom;

            errorProvider1.Clear();
            nudQuantity.Value = 1;

            if (isCustom)
            {
                tbProductName.Clear();
                tbPrice.Clear();
            }
            else
            {
                _ShowSelectedProductPrice();
            }
        }

        private async void btnAdd_Click(object sender, EventArgs e)
        {
            clsReservationProduct _ReservationProduct = new clsReservationProduct();
            bool isCustom = tcAddProduct.SelectedTab == tpCustom;

            string name;
            decimal price;
            int qty = (int)nudQuantity.Value;

            if (isCustom)
            {
                name = tbProductName.Text.Trim();
                if (name.Length == 0)
                {
                    errorProvider1.SetError(tbProductName, "Product name is required!");
                    return;
                }
                if (!decimal.TryParse(tbPrice.Text, out price) || price <= 0)
                {
                    errorProvider1.SetError(tbPrice, "Enter a valid price!");
                    return;
                }
                _ReservationProduct.ProductID = null;
                _ReservationProduct.ProductName = name;
            }
            else
            {
                if (cbProducts.SelectedItem is not ProductDTO p)
                {
                    errorProvider1.SetError(cbProducts, "Select a product!");
                    return;
                }
                _ReservationProduct.ProductID = p.ProductID;
                _ReservationProduct.ProductName = null;
                price = p.Price.Value;
            }

            errorProvider1.Clear();

            if (qty <= 0)
            {
                errorProvider1.SetError(nudQuantity, "Quantity must be at least 1.");
                return;
            }

            _ReservationProduct.ReservationID = _ReservationID;
            _ReservationProduct.Quantity = qty;
            _ReservationProduct.TotalPrice = price * qty;


            if (!await _ReservationProduct.SaveAsync())
            {
                MessageBox.Show("Could not add the product.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            await _RefreshOrdersAsync();
            _SetMode(isCustom);   // تصفير الحقول بعد الإضافة
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            this.Close();
        }
    }
}