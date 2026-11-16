using PlayZone_Buisness;
using System;
using System.Windows.Forms;

namespace PlayZone
{
    public partial class frmActivation : Form
    {
        public frmActivation()
        {
            InitializeComponent();
        }

        private void frmActivation_Load(object sender, EventArgs e)
        {
            txtMachineId.Text = LicensingHelper.GetMachineId();
        }

        private void btnActivate_Click(object sender, EventArgs e)
        {
            string enteredKey = txtEnterKey.Text.Trim(); 

            if (LicensingHelper.ValidateActivationKey( enteredKey))
            {
                // حفظ المفتاح في الملف الخارجي
                LicensingHelper.SaveLicenseKey(enteredKey);

                MessageBox.Show("The program has been successfully! activated thank you.", "Success Activation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("The activation key is incorrect, make sure the entered code.", "Activation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
                Clipboard.SetText(txtMachineId.Text);
        }
    }
}