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
        private readonly int _ReservationID;
        private readonly string _SpotTitle;
        private readonly string _CustomerName;
        private readonly DateTime _StartTime;
        private readonly decimal _PricePerHour;
        private clsReservationProduct _ReservationProduct = new clsReservationProduct();

        private List<ReservationProductDTO> _Orders = new();

        public frmDetails(int reservationID, string spotTypeName, string spotName,
            string customerName, DateTime startTime, decimal pricePerHour)
        {
            InitializeComponent();

            _ReservationID = reservationID;
            _SpotTitle = $"{spotTypeName} - {spotName}";
            _CustomerName = customerName;
            _StartTime = startTime;
            _PricePerHour = pricePerHour;
        }

        private async void frmDetails_Load(object sender, EventArgs e)
        {
            lblSpotInfo.Text = _SpotTitle;
            lblCustomer.Text = _CustomerName;
            lblStarted.Text = _StartTime.ToString("dd/MM/yyyy hh:mm tt");

            _SetupOrdersGrid();
            await _LoadProductsComboAsync();
            await _RefreshOrdersAsync();

            _SetMode(isCustom: false);

            _UpdateTimeAndCost();
            timer1.Interval = 1000;
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

            lblPlayingCost.Text = playing.ToString("0.00");
            lblPlayingCostTotal.Text = playing.ToString("0.00");
            lblGrandTotal.Text = products.Value.ToString("0.00");
            lblGrandTotal.Text = (playing + products).Value.ToString("0.00");
        }

        // ---------- جدول الطلبات ----------
        private void _SetupOrdersGrid()
        {
            dgvOrders.AutoGenerateColumns = false;
            dgvOrders.Columns.Clear();
            dgvOrders.AllowUserToAddRows = false;
            dgvOrders.ReadOnly = true;
            dgvOrders.RowHeadersVisible = false;
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
                Name = "Total",
                HeaderText = "Total",
                DataPropertyName = "Total",
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
            if (e.RowIndex < 0 || dgvOrders.Columns[e.ColumnIndex].Name != "Delete") return;

            var order = _Orders[e.RowIndex];

            //if (MessageBox.Show($"Remove \"{order.ProductName}\" from the order?", "Confirm",
            //        MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
            //    return;

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
                tbPriceMenu.Text = p.Price.Value.ToString("0.00");
        }

        // التبويب: From Menu / Custom Product
        private void tcAddProduct_SelectedIndexChanged(object sender, EventArgs e)
            => _SetMode(isCustom: tcAddProduct.SelectedTab == tpCustom);

        private void _SetMode(bool isCustom)
        {
            cbProducts.Visible = !isCustom;
            tbProductName.Visible = isCustom;
            tbPriceMenu.ReadOnly = !isCustom;

            errorProvider1.Clear();
            nudQuantityMenu.Value = 1;

            if (isCustom)
            {
                tbProductName.Clear();
                tbPriceMenu.Clear();
            }
            else
            {
                _ShowSelectedProductPrice();
            }
        }

        private async void btnAdd_Click(object sender, EventArgs e)
        {
            bool isCustom = tcAddProduct.SelectedTab == tpCustom;

            int? productId;
            string name;
            decimal price;
            int qty = (int)nudQuantityMenu.Value;

            if (isCustom)
            {
                name = tbProductName.Text.Trim();
                if (name.Length == 0)
                {
                    errorProvider1.SetError(tbProductName, "Product name is required!");
                    return;
                }
                if (!decimal.TryParse(tbPriceCustom.Text, out price) || price <= 0)
                {
                    errorProvider1.SetError(tbPriceCustom, "Enter a valid price!");
                    return;
                }
                productId = null;
            }
            else
            {
                if (cbProducts.SelectedItem is not ProductDTO p)
                {
                    errorProvider1.SetError(cbProducts, "Select a product!");
                    return;
                }
                productId = p.ProductID;
                name = p.ProductName;
                price = p.Price.Value;
            }

            errorProvider1.Clear();

            if (qty <= 0)
            {
                errorProvider1.SetError(nudQuantityMenu, "Quantity must be at least 1.");
                return;
            }

            //_ReservationProduct = new clsReservationProduct 
            //{ 
            //    OrderProductID = _ReservationID,
            //    ReservationID =  productId,
            //    ProductID = name,
            //    Quantity = qty,
            //    TotalPrice = price
            //};

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

        private void btnAddCustom_Click(object sender, EventArgs e)
        {

        }

        private void btnAddMenu_Click(object sender, EventArgs e)
        {

        }


    }
}