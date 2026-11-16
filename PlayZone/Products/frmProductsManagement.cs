using PlayZone_Buisness;
using SharedDTOs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlayZone
{
    public partial class frmProductsManagement : Form
    {
        private List<ProductDTO> _AllProducts = new();
        private readonly System.Windows.Forms.Timer _SearchTimer = new() { Interval = 300 };
        private int _MinQuantity = 5;

        public frmProductsManagement()
        {
            InitializeComponent();

            _SearchTimer.Tick += (s, e) =>
            {
                _SearchTimer.Stop();
                _ApplyFilter();
            };
        }

        private async void frmProductsManagement_Load(object sender, EventArgs e)
        {
            _SetupGrid();
            await _LoadProductsAsync();
        }

        // ============ Grid ============
        private void _SetupGrid()
        {
            dgvProducts.AutoGenerateColumns = false;
            dgvProducts.Columns.Clear();
            dgvProducts.ReadOnly = true;
            dgvProducts.AllowUserToAddRows = false;
            dgvProducts.AllowUserToDeleteRows = false;
            dgvProducts.RowHeadersVisible = false;
            dgvProducts.MultiSelect = false;
            dgvProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dgvProducts.Columns.Add(new DataGridViewTextBoxColumn
            { Name = "ProductID", HeaderText = "ID", DataPropertyName = "ProductID", FillWeight = 10 });
            dgvProducts.Columns.Add(new DataGridViewTextBoxColumn
            { Name = "ProductName", HeaderText = "Product Name", DataPropertyName = "ProductName", FillWeight = 40 });
            dgvProducts.Columns.Add(new DataGridViewTextBoxColumn
            { Name = "Price", HeaderText = "Price", DataPropertyName = "Price", FillWeight = 15,
              DefaultCellStyle = new DataGridViewCellStyle { Format = "0.00" } });
            dgvProducts.Columns.Add(new DataGridViewTextBoxColumn
            { Name = "Quantity", HeaderText = "In Stock", DataPropertyName = "Quantity", FillWeight = 15 });
            dgvProducts.Columns.Add(new DataGridViewTextBoxColumn
            { Name = "Status", HeaderText = "Status", FillWeight = 20 });

            dgvProducts.CellFormatting += dgvProducts_CellFormatting;
            dgvProducts.CellMouseDown += dgvProducts_CellMouseDown;
            dgvProducts.CellDoubleClick += dgvProducts_CellDoubleClick;
        }

        // Status column + row colors (low stock = orange, out of stock = red)
        private void dgvProducts_CellFormatting(object? sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex < 0 || dgvProducts.Rows[e.RowIndex].DataBoundItem is not ProductDTO p)
                return;

            if (dgvProducts.Columns[e.ColumnIndex].Name == "Status")
            {
                e.Value = p.StockQuantity <= 0 ? "Out of stock"
                        : p.StockQuantity <= _MinQuantity ? "Low stock"
                        : "In stock";
            }

            if (p.StockQuantity <= 0)
                e.CellStyle.ForeColor = System.Drawing.Color.IndianRed;
            else if (p.StockQuantity <= _MinQuantity)
                e.CellStyle.ForeColor = System.Drawing.Color.Orange;
        }

        // Right click selects the row under the mouse before the context menu opens
        private void dgvProducts_CellMouseDown(object? sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && e.RowIndex >= 0)
            {
                dgvProducts.ClearSelection();
                dgvProducts.Rows[e.RowIndex].Selected = true;
                dgvProducts.CurrentCell = dgvProducts.Rows[e.RowIndex].Cells[0];
            }
        }

        private async void dgvProducts_CellDoubleClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
                await _EditSelectedAsync();
        }

        // ============ Data ============
        private async Task _LoadProductsAsync()
        {
            try
            {
                _AllProducts = await clsProduct.GetAllProductsAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Could not load products:\n{ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _ApplyFilter();
        }

        private void _ApplyFilter()
        {
            string text = tbSearch.Text.Trim();

            // The placeholder "Search" is treated as empty
            if (text.Equals("Search", StringComparison.OrdinalIgnoreCase))
                text = string.Empty;

            var filtered = string.IsNullOrEmpty(text)
                ? _AllProducts
                : _AllProducts.Where(p =>
                      p.ProductName.Contains(text, StringComparison.OrdinalIgnoreCase) ||
                      p.ProductID.ToString() == text).ToList();

            dgvProducts.DataSource = new BindingList<ProductDTO>(filtered);
            _UpdateStats();
        }

        // Stats are computed from ALL products, not only the filtered ones
        private void _UpdateStats()
        {
            lblProducts.Text = $"Products: {_AllProducts.Count}";
            lblLowStock.Text = $"Low stock: {_AllProducts.Count(p => p.StockQuantity > 0 && p.StockQuantity <= _MinQuantity)}";
            lblOutOfStock.Text = $"Out of stock: {_AllProducts.Count(p => p.StockQuantity <= 0)}";
        }

        private ProductDTO? _GetSelected()
        {
            if (dgvProducts.CurrentRow?.DataBoundItem is ProductDTO p)
                return p;

            MessageBox.Show("Please select a product first.", "No Selection",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            return null;
        }

        // ============ Search ============
        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            // Debounce: search 300ms after the user stops typing
            _SearchTimer.Stop();
            _SearchTimer.Start();
        }

        // ============ Buttons ============
        private async void btnAddProduct_Click(object sender, EventArgs e)
        {
            using var frm = new frmAddUpdateProduct();
            if (frm.ShowDialog() == DialogResult.OK)
                await _LoadProductsAsync();
        }

        private async void editToolStripMenuItem_Click(object sender, EventArgs e)
            => await _EditSelectedAsync();

        private async Task _EditSelectedAsync()
        {
            var p = _GetSelected();
            if (p == null) return;

            using var frm = new frmAddUpdateProduct(p.ProductID.Value);   // update mode
            if (frm.ShowDialog() == DialogResult.OK)
                await _LoadProductsAsync();
        }

        // Context menu: Restock
        private async void restockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var p = _GetSelected();
            if (p == null) return;

            using var frm = new frmRestockProduct(p.ProductID.Value);
            if (frm.ShowDialog() == DialogResult.OK)
                await _LoadProductsAsync();
        }

        private async void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var p = _GetSelected();
            if (p == null) return;

            if (MessageBox.Show($"Delete \"{p.ProductName}\"?\nThis cannot be undone.", "Confirm Delete",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning) != DialogResult.Yes)
                return;

            try
            {
                if (await clsProduct.DeleteProductAsync(p.ProductID.Value))
                    await _LoadProductsAsync();
                else
                    MessageBox.Show("Could not delete the product.", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception)
            {
                // Usually a foreign key conflict: the product was used in past orders
                MessageBox.Show(
                    "This product cannot be deleted because it is used in previous orders.",
                    "Cannot Delete", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
