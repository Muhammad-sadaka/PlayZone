using BCrypt.Net;
using PlayZone_Buisness;
using SharedDTOs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlayZone
{
    public partial class frmAddUpdateUser : Form
    {
        public enum enMode { AddNew = 0, Update = 1 };
        enMode _Mode = enMode.AddNew;

        clsUser _user = new clsUser();
        int? _userID = null;

        public frmAddUpdateUser()
        {
            InitializeComponent();
            _Mode = enMode.AddNew;
        }

        public frmAddUpdateUser(int userID)
        {
            InitializeComponent();
            _Mode = enMode.Update;
            _userID = userID;
        }

        private void frmAddUpdateUser_Load(object sender, EventArgs e)
        {
            _FillRolesInComboBox();
            _ResetDefaultValues();

            if (_Mode == enMode.Update)
                _LoadData();

            tbUsername.Validating += tbUsername_Validating;
            tbConfirmPassword.Validating += tbConfirmPassword_Validating;

            if (_Mode == enMode.AddNew)
            {
                //tbPassword.Validating += clsValidation.ValidateEmptyTextBox; // أو التحقق الافتراضي لديك
            }
        }


        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private async Task _FillRolesInComboBox()
        {
            cmbRole.DataSource = await clsRole.GetAllRolesAsync();
            cmbRole.DisplayMember = "RoleName";
            cmbRole.ValueMember = "RoleID";

        }

        private void _ResetDefaultValues()
        {
            if (_Mode == enMode.AddNew)
            {
                this.Text = "Add New User";
                lblTitle.Text = "Add New User";
                _user = new clsUser();
            }
            else
            {
                this.Text = "Update User";
                lblTitle.Text = "Update User";
                lblInfo.Visible = true;
            }

            tbUsername.Clear();
            tbPassword.Clear();
            tbConfirmPassword.Clear();
            chkIsActive.Checked = true;

            chkManageShifts.Checked = false;
            chkViewReports.Checked = false;
            chkManageSpotTypes.Checked = false;
            chkManageUsers.Checked = false;
        }

        private async void _LoadData()
        {
            if (!_userID.HasValue) return;

            _user = await clsUser.FindByIDAsync(_userID.Value);

            if (_user == null)
            {
                MessageBox.Show("No User with ID = " + _userID.Value, "User Not Found", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.Close();
                return;
            }

            tbUsername.Text = _user.Username;
            chkIsActive.Checked = _user.IsActive;

            if (_user.RoleID > 0)
            {
                cmbRole.SelectedValue = _user.RoleID;
            }
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                MessageBox.Show("Some fields are not valid!, check the red icons.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _user.Username = tbUsername.Text.Trim();
            _user.RoleID = cmbRole.SelectedValue != null ? (int)Convert.ToInt32(cmbRole.SelectedValue) : -1;
            _user.IsActive = chkIsActive.Checked;

            if (_Mode == enMode.AddNew || !string.IsNullOrEmpty(tbConfirmPassword.Text))
            {
                _user.PasswordHash = BCrypt.Net.BCrypt.HashPassword(tbConfirmPassword.Text.Trim());
            }

            if (await _user.SaveAsync())
            {
                _Mode = enMode.Update;
                this.Text = "Update User";
                MessageBox.Show("Data Saved Successfully.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else

            {
                MessageBox.Show("Error: Data Is not Saved Successfully.", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tbConfirmPassword_Validating(object sender, CancelEventArgs e)
        {
            ErrorProvider errorProvider = new ErrorProvider();
            if (tbPassword.Text != tbConfirmPassword.Text)
            {
                e.Cancel = true;
                errorProvider.SetError(tbConfirmPassword, "Confirm Password doesn't match Password.");
            }
            else
            {
                errorProvider.SetError(tbConfirmPassword, null);
            }
        }

        private async void tbUsername_Validating(object sender, CancelEventArgs e)
        {
            ErrorProvider errorProvider = new ErrorProvider();
            if (string.IsNullOrWhiteSpace(tbUsername.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(tbUsername, "Username cannot be blank.");
                return;
            }

            clsUser? existingUser = await clsUser.FindByUsernameAsync(tbUsername.Text.Trim());
            if (existingUser != null && (_Mode == enMode.AddNew || existingUser.UserID != _user.UserID))
            {
                e.Cancel = true;
                errorProvider.SetError(tbUsername, "This Username is already taken by another user.");
            }
            else
            {
                errorProvider.SetError(tbUsername, null);
            }
        }

        private void cmbRole_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbRole.SelectedValue == null) return;

            if (cmbRole.SelectedIndex == 0)
            {
                chkManageShifts.Checked = true;
                chkViewReports.Checked = true;
                chkManageSpotTypes.Checked = true;
                chkManageUsers.Checked = true;
                chkManageProducts.Checked = true;
            }
            else
            {
                chkManageShifts.Checked = false;
                chkViewReports.Checked = false;
                chkManageSpotTypes.Checked = true;
                chkManageUsers.Checked = false;
                chkManageProducts.Checked = false;
            }


        }
    }
}