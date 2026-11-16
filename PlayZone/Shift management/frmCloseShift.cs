using PlayZone_Buisness;
using SharedDTOs;
using System;
using System.ComponentModel;
using System.Globalization;
using System.Windows.Forms;

namespace PlayZone
{
    public partial class frmCloseShift : Form
    {
        private readonly int _ShiftID;
        private clsShift? _Summary;

        // True when the shift was closed successfully (the caller can log the user out)
        public bool ShiftClosed { get; private set; } = false;

        public frmCloseShift(int shiftId)
        {
            InitializeComponent();
            _ShiftID = shiftId;
        }

        private async void frmCloseShift_Load(object sender, EventArgs e)
        {
            try
            {
                _Summary = await clsShift.GetSummaryAsync(_ShiftID);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Could not load the shift summary:\n{ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }

            if (_Summary == null)
            {
                MessageBox.Show("Shift not found.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }

            lblCashier.Text = _Summary.CashierName;
            lblShiftNumber.Text = _Summary.ShiftID.ToString();
            lblOpened.Text = _Summary.StartTime.ToString("dd/MM/yyyy hh:mm tt");
            lblClosing.Text = DateTime.Now.ToString("dd/MM/yyyy hh:mm tt");

            lblSessionsRevenue.Text = _Summary.SessionsRevenue.ToString("0.00");
            lblCafeteriaRevenue.Text = _Summary.CafeteriaRevenue.ToString("0.00");
            lblTotalSales.Text = _Summary.TotalSales.ToString("0.00");
            lblStartingCash.Text = _Summary.StartingCash.ToString("0.00");
            lblExpectedCash.Text = _Summary.ExpectedCash.ToString("0.00");

            tbClosingCash.Focus();
        }

        // Allow digits and a single decimal separator only
        private void tbClosingCash_KeyPress(object sender, KeyPressEventArgs e)
        {
            string sep = CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator;

            if (char.IsControl(e.KeyChar) || char.IsDigit(e.KeyChar))
                return;

            if (e.KeyChar.ToString() == sep && !tbClosingCash.Text.Contains(sep))
                return;

            e.Handled = true;
        }

        private void tbClosingCash_Validating(object sender, CancelEventArgs e)
        {
            if (!decimal.TryParse(tbClosingCash.Text, out decimal value) || value < 0)
            {
                e.Cancel = true;
                errorProvider1.SetError(tbClosingCash, "Enter the actual cash amount in the drawer.");
            }
            else
            {
                errorProvider1.SetError(tbClosingCash, null);
            }
        }

        private async void btnCloseShift_Click(object sender, EventArgs e)
        {
            if (_Summary == null) return;

            if (!ValidateChildren())
                return;

            decimal closingCash = decimal.Parse(tbClosingCash.Text);
            decimal difference = closingCash - _Summary.ExpectedCash;

            string diffText = difference == 0
                ? "The drawer matches the expected amount."
                : difference > 0
                    ? $"The drawer has an EXCESS of {difference:0.00}."
                    : $"The drawer has a SHORTAGE of {Math.Abs(difference):0.00}.";

            var result = MessageBox.Show(
                $"Expected cash: {_Summary.ExpectedCash:0.00}\n" +
                $"Actual cash: {closingCash:0.00}\n\n{diffText}\n\n" +
                "Close the shift now? This cannot be undone.",
                "Confirm Close Shift", MessageBoxButtons.YesNo,
                difference == 0 ? MessageBoxIcon.Question : MessageBoxIcon.Warning);

            if (result != DialogResult.Yes)
                return;

            btnCloseShift.Enabled = false;

            try
            {
                _Summary.ActualCash = closingCash;
                if (await _Summary.SaveAsync()/*clsShift.CloseShiftAsync(_ShiftID, closingCash, _Summary.ExpectedCash)*/)
                {
                    ShiftClosed = true;
                    MessageBox.Show("Shift closed successfully.", "Done",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Could not close the shift. It may already be closed.", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    btnCloseShift.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error while closing the shift:\n{ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnCloseShift.Enabled = true;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}