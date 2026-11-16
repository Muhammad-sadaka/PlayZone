using PlayZone_Buisness;
using SharedDTOs;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace PlayZone
{
    public partial class frmRestockProduct : Form
    {
        private readonly int _ProductID;
        private clsProduct? _Product;

        public frmRestockProduct(int productId)
        {
            InitializeComponent();
            _ProductID = productId;
        }

        private async void frmRestockProduct_Load(object sender, EventArgs e)
        {
            try
            {
                _Product = await clsProduct.FindByIDAsync(_ProductID);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Could not load the product:\n{ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.DialogResult = DialogResult.Cancel;
                this.Close();
                return;
            }

            if (_Product == null)
            {
                MessageBox.Show("Product not found.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.DialogResult = DialogResult.Cancel;
                this.Close();
                return;
            }

            label1.Text = _Product.ProductName;
            lblCurrentStock.Text = _Product.StockQuantity.ToString();
            lblPrice.Text = _Product.Price.Value.ToString("0.00");

            nudQuantity.Minimum = 1;
            nudQuantity.Maximum = 100000;
            nudQuantity.Value = 1;

            _UpdateNewStock();
            nudQuantity.Focus();
        }

        private void nudQuantity_ValueChanged(object sender, EventArgs e)
            => _UpdateNewStock();

        private void _UpdateNewStock()
        {
            if (_Product == null) return;
            lblNewStock.Text = $"New Stock: {_Product.StockQuantity + (int)nudQuantity.Value}";
        }

        private async void btnAddToStock_Click(object sender, EventArgs e)
        {
            if (_Product == null) return;

            int qty = (int)nudQuantity.Value;
            if (qty <= 0)
            {
                errorProvider1.SetError(nudQuantity, "Quantity must be at least 1.");
                return;
            }
            errorProvider1.SetError(nudQuantity, null);

            btnAddToStock.Enabled = false;

            try
            {
                _Product.StockQuantity += qty;
                if (await _Product.SaveAsync())
                {
                    MessageBox.Show($"Stock updated. New quantity: {_Product.StockQuantity}", "Done",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Could not update the stock.", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    btnAddToStock.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error while updating the stock:\n{ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnAddToStock.Enabled = true;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
 