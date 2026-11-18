using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PlayZone_Buisness;

namespace PlayZone
{
    public partial class frmShift : Form
    {
        public delegate void DataBackEventHandler(object sender, int shiftID);
        public event DataBackEventHandler DataBack;

        private clsUser _currentUser;

        public frmShift(clsUser currentUser)
        {
            InitializeComponent();
            _currentUser = currentUser;
        }

        private void frmShift_Load(object sender, EventArgs e)
        {
            lblUsernameValue.Text = _currentUser.Username;
            lblDateTimeValue.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
        }

        private async void btnOpenShift_Click(object sender, EventArgs e)
        {
            if (!decimal.TryParse(txtStartingCash.Text.Trim(), out decimal startingCash) || startingCash < 0)
            {
                MessageBox.Show("Please enter a valid amount", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                clsShift? newShift = await clsShift.OpenNewShiftAsync(_currentUser.UserID.Value, startingCash);

                if (newShift != null)
                {
                    txtStartingCash.Clear();
                    this.Close();
                    DataBack?.Invoke(this, newShift.ShiftID.Value);
                }
                else
                {
                    MessageBox.Show("Failed to open shift.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}