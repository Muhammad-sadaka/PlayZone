using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace PlayZone
{
    public partial class frmSetName : Form
    {
        public delegate void DataBackEventHandler(object sender, string SpotTypeName, int? Period = null);
        public event DataBackEventHandler DataBack;

        public frmSetName()
        {
            InitializeComponent();
        }

        private void frmSetName_Load(object sender, EventArgs e)
        {
            dateTimePicker1.MinDate = DateTime.Now;
            dateTimePicker1.MaxDate = DateTime.Now.AddHours(6);
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (ValidateChildren())
            {
                MessageBox.Show("Some fields are not valid", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DataBack?.Invoke(this, tbPlayerName.Text.Trim(), Convert.ToInt32(tbPeriod.Text));

            btnCancel_Click(null, null);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tbPeriod_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void tbPeriod_Validating(object sender, CancelEventArgs e)
        {
            //int Period = Convert.ToInt32(tbPeriod.Text.Trim());
            //if (Period > 2 || Period < 30)
            //{
            //    e.Cancel = true;
            //    errorProvider1.SetError(tbPeriod, $"Value should be between !");
            //}
            //else
            //{
            //    errorProvider1.SetError(tbPeriod, null);
            //}
        }

        private void tbPlayerName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(tbPlayerName.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(tbPlayerName, $"{tbPlayerName.Tag ?? "This field"} is required!");
            }
            else
            {
                errorProvider1.SetError(tbPlayerName, null);
            }
        }


    }
}
