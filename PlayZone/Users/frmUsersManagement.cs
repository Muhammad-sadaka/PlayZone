using PlayZone_Buisness;
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
    public partial class frmUsersManagement : Form
    {
        public frmUsersManagement()
        {
            InitializeComponent();
        }

        private async void frmUsersManagement_Load(object sender, EventArgs e)
        {
            await _RefreshUsersList();
        }

        private async Task _RefreshUsersList()
        {
            dgvUsers.DataSource = await clsUser.GetAllUsersAsync();

            // إخفاء أعمدة الحساسة مثل كلمة المرور إن وجدت
            if (dgvUsers.Columns.Contains("PasswordHash"))
            {
                dgvUsers.Columns["PasswordHash"].Visible = false;
            }
        }

        private async void btnAddUser_Click(object sender, EventArgs e)
        {
            frmAddUpdateUser frm = new frmAddUpdateUser();
            frm.ShowDialog();
            await _RefreshUsersList();
        }

        private async void addNewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmAddUpdateUser().ShowDialog();
            await _RefreshUsersList();
        }

        private async void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvUsers.CurrentRow == null) return;

            frmAddUpdateUser frm = new frmAddUpdateUser(Convert.ToInt32(dgvUsers.CurrentRow.Cells["UserID"].Value));
            frm.ShowDialog();
            await _RefreshUsersList();
        }

        private async void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvUsers.CurrentRow == null) return;

            if (MessageBox.Show("Are you sure you want to delete this user?", "Confirm Delete",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                if (await clsUser.DeleteUserAsync(Convert.ToInt32(dgvUsers.CurrentRow.Cells["UserID"].Value)))
                {
                    MessageBox.Show("User Deleted Successfully.", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    await _RefreshUsersList();
                }
                else
                {
                    MessageBox.Show("Failed to delete user.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            if (Convert.ToInt32(dgvUsers.CurrentRow.Cells["UserID"].Value) == 1)
            {
                deleteToolStripMenuItem.Enabled = false;
                updateToolStripMenuItem.Enabled = false;
            }
            else
            {
                deleteToolStripMenuItem.Enabled = true;
                updateToolStripMenuItem.Enabled = true;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}