using System;
using System.Windows.Forms;
using PlayZone_Buisness; 

namespace PlayZone
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter username and password.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                clsUser? authenticatedUser = await clsUser.AuthenticateAsync(username, password);

                if (authenticatedUser != null)
                {
                    txtUsername.Clear(); txtPassword.Clear(); 
                    this.Hide();
                    if (authenticatedUser.RoleID == 3)
                    {
                        frmShift shiftForm = new frmShift(authenticatedUser, this);
                        shiftForm.Show();
                    }
                    else
                    {
                        frmMain frm = new frmMain(this,authenticatedUser);
                        frm.Show();
                    }
                }
                else
                {
                    MessageBox.Show("Invalid username or password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}