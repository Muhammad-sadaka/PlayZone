using PlayZone_Buisness;
using SharedDTOs;
using System;
using System.ComponentModel;
using System.Globalization;
using System.Windows.Forms;

namespace PlayZone
{
    public partial class frmAddUpdateProduct : Form
    {
        private readonly int? _ProductID;                 // null = Add mode
        private bool IsUpdateMode => _ProductID.HasValue;
        clsProduct _product = new clsProduct();

        // Add mode
        public frmAddUpdateProduct()
        {
            InitializeComponent();
        }

        // Update mode
        public frmAddUpdateProduct(int productId) : this()
        {
            _ProductID = productId;
        }

        private async void frmAddUpdateProduct_Load(object sender, EventArgs e)
        {
            if (!IsUpdateMode)
            {
                lblTitle.Text = "Add New Product";
                lblSubtitle.Text = "Enter the product details";
                tbProductName.Focus();
                return;
            }

            lblTitle.Text = "Edit Product";
            lblSubtitle.Text = "Update the product details";
            tbQuantity.Enabled = false;

            try
            {
                _product = await clsProduct.FindByIDAsync(_ProductID!.Value);
                if (_product == null)
                {
                    MessageBox.Show("Product not found.", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.DialogResult = DialogResult.Cancel;
                    this.Close();
                    return;
                }

                tbProductName.Text = _product.ProductName;
                tbPrice.Text = _product.Price.Value.ToString("0.00");
                tbQuantity.Text = _product.StockQuantity.Value.ToString(); 
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Could not load the product:\n{ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        // ============ Validation ============
        private void tbProductName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbProductName.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(tbProductName, "Product name is required!");
            }
            else
            {
                errorProvider1.SetError(tbProductName, null);
            }
        }

        private void tbPrice_Validating(object sender, CancelEventArgs e)
        {
            if (!decimal.TryParse(tbPrice.Text, out decimal price) || price <= 0)
            {
                e.Cancel = true;
                errorProvider1.SetError(tbPrice, "Enter a valid price greater than zero.");
            }
            else
            {
                errorProvider1.SetError(tbPrice, null);
            }
        }

        // Digits and one decimal separator only
        private void tbPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            string sep = CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator;

            if (char.IsControl(e.KeyChar) || char.IsDigit(e.KeyChar))
                return;

            if (e.KeyChar.ToString() == sep && !tbPrice.Text.Contains(sep))
                return;

            e.Handled = true;
        }

        // ============ Save ============
        private async void btnSave_Click(object sender, EventArgs e)
        {
            if (!ValidateChildren())
            {
                MessageBox.Show("Some fields are not valid. Hover over the red icons to see the details.",
                    "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string name = tbProductName.Text.Trim();
            decimal price = decimal.Parse(tbPrice.Text);

            btnSave.Enabled = false;

            try
            {
                // Prevent duplicate names
                if (await clsProduct.IsProductExistAsync(name))
                {
                    errorProvider1.SetError(tbProductName, "A product with this name already exists.");
                    btnSave.Enabled = true;
                    return;
                }
                
                _product.ProductName = string.Empty;
                _product.Price = Convert.ToInt32(tbPrice.Text); 
                _product.StockQuantity = Convert.ToInt32( tbQuantity.Text);

                if (await _product.SaveAsync())
                {
                    MessageBox.Show("Product saved successfully.", "Saved",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Could not save the product.", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    btnSave.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error while saving:\n{ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnSave.Enabled = true;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
 