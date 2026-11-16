using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace PlayZone
{
    public partial class frmSetName : Form
    {
        // durationMinutes = null  => جلسة Open Time (بلا مدة محددة)
        public delegate void DataBackEventHandler(object sender, string customerName, int? durationMinutes);
        public event DataBackEventHandler DataBack;

        private readonly string _SpotTypeName;
        private readonly string _SpotName;
        private readonly decimal? _PricePerHour;

        public frmSetName(string spotTypeName, string spotName, decimal? pricePerHour)
        {
            InitializeComponent();

            _SpotTypeName = spotTypeName;
            _SpotName = spotName;
            _PricePerHour = pricePerHour;
        }

        private void frmSetName_Load(object sender, EventArgs e)
        {
            lblSpotInfo.Text = $"{_SpotTypeName} - {_SpotName}";
            lblPrice.Text = $"{_PricePerHour:0.00} / hour";

            nudHours.Minimum = 0;
            nudHours.Maximum = 23;
            nudMinutes.Minimum = 0;
            nudMinutes.Maximum = 59;

            rbOpenTime.Checked = true;
            _UpdateTimedState();

            tbPlayerName.Focus();
        }



        private void _UpdateTimedState()
        {
            pnlTimed.Enabled = rbTimed.Checked;

            if (!rbTimed.Checked)
            {
                nudHours.Value = 0;
                nudMinutes.Value = 0;
            }

            errorProvider1.SetError(nudMinutes, null);
        }

        private void btnStartSession_Click(object sender, EventArgs e)
        {
            if (!ValidateChildren())
            {
                MessageBox.Show("Some fields are not valid", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int? duration = null;

            if (rbTimed.Checked)
            {
                duration = (int)(nudHours.Value * 60 + nudMinutes.Value);

                if (duration == 0)
                {
                    errorProvider1.SetError(nudMinutes, "Please set a duration greater than zero.");
                    return;
                }
            }

            errorProvider1.SetError(nudMinutes, null);

            DataBack?.Invoke(this, tbPlayerName.Text.Trim(), duration);

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void tbPlayerName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbPlayerName.Text))
            {
                //e.Cancel = true;
                errorProvider1.SetError(tbPlayerName, "Customer name is required!");
            }
            else
            {
                errorProvider1.SetError(tbPlayerName, null);
            }
        }

        private void rbTimed_CheckedChanged(object sender, EventArgs e)
        {
            _UpdateTimedState();
        }
    }
}