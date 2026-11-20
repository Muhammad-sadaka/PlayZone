using PlayZone_Buisness;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
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
            dgvUsers.CellPainting += dgvUsers_CellPainting;
            _SetupGrid();
            await _RefreshUsersList();
        }

        // ============ Grid ============
        private void _SetupGrid()
        {
            dgvUsers.AutoGenerateColumns = false;
            dgvUsers.Columns.Clear();
            dgvUsers.ReadOnly = true;
            dgvUsers.AllowUserToAddRows = false;
            dgvUsers.AllowUserToDeleteRows = false;
            dgvUsers.AllowUserToResizeRows = false;
            dgvUsers.RowHeadersVisible = false;
            dgvUsers.MultiSelect = false;
            dgvUsers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvUsers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dgvUsers.Columns.Add(new DataGridViewTextBoxColumn
            { Name = "UserId", HeaderText = "ID", DataPropertyName = "UserId", FillWeight = 10 });

            dgvUsers.Columns.Add(new DataGridViewTextBoxColumn
            { Name = "Username", HeaderText = "Username", DataPropertyName = "Username", FillWeight = 30 });

            dgvUsers.Columns.Add(new DataGridViewTextBoxColumn
            { Name = "Role", HeaderText = "Role", DataPropertyName = "Role", FillWeight = 30 });

            dgvUsers.Columns.Add(new DataGridViewCheckBoxColumn
            { Name = "IsActive", HeaderText = "Active", DataPropertyName = "IsActive", FillWeight = 10 });

            // الزر الأيمن يحدد الصف تحت المؤشر قبل فتح القائمة
            dgvUsers.CellMouseDown += (s, e) =>
            {
                if (e.Button == MouseButtons.Right && e.RowIndex >= 0)
                {
                    dgvUsers.ClearSelection();
                    dgvUsers.Rows[e.RowIndex].Selected = true;
                    dgvUsers.CurrentCell = dgvUsers.Rows[e.RowIndex].Cells[0];
                }
            };
        }

        private void dgvUsers_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0 ||
                dgvUsers.Columns[e.ColumnIndex].Name != "IsActive")
                return;

            e.PaintBackground(e.CellBounds, true);

            bool isChecked = e.Value != null && e.Value != DBNull.Value
                             && Convert.ToBoolean(e.Value);

            int size = 18;
            int x = e.CellBounds.X + (e.CellBounds.Width - size) / 2;
            int y = e.CellBounds.Y + (e.CellBounds.Height - size) / 2;
            var rect = new Rectangle(x, y, size, size);

            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            using (var bg = new SolidBrush(Color.White))
            using (var border = new Pen(Color.Gray, 1.5f))
            {
                e.Graphics.FillRectangle(bg, rect);
                e.Graphics.DrawRectangle(border, rect);
            }

            if (isChecked)
            {
                using (var pen = new Pen(Color.DarkBlue, 2.5f))
                {
                    Point[] points =
                    {
                        new Point(rect.X + 4, rect.Y + size / 2),
                        new Point(rect.X + size / 3 + 1, rect.Y + size - 5),
                        new Point(rect.X + size - 4, rect.Y + 4)
                    };
                    e.Graphics.DrawLines(pen, points);
                }
            }

            e.Handled = true;
        }


        private async Task _RefreshUsersList()
        {
            var users = await clsUser.GetAllUsersAsync();
            dgvUsers.DataSource = new BindingList<dynamic>(users.Cast<dynamic>().ToList());
        }

        // ============ Buttons ============
        private async void btnAddUser_Click(object sender, EventArgs e)
        {
            using var frm = new frmAddUpdateUser();
            frm.ShowDialog();
            await _RefreshUsersList();
        }

        private async void addNewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using var frm = new frmAddUpdateUser();
            frm.ShowDialog();
            await _RefreshUsersList();
        }

        private async void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvUsers.CurrentRow == null) return;

            int id = Convert.ToInt32(dgvUsers.CurrentRow.Cells["UserID"].Value);
            using var frm = new frmAddUpdateUser(id);
            frm.ShowDialog();
            await _RefreshUsersList();
        }

        private async void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvUsers.CurrentRow == null) return;

            if (MessageBox.Show("Are you sure you want to delete this user?", "Confirm Delete",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) != DialogResult.Yes)
                return;

            int id = Convert.ToInt32(dgvUsers.CurrentRow.Cells["UserID"].Value);

            try
            {
                if (await clsUser.DeleteUserAsync(id))
                {
                    MessageBox.Show("User deleted successfully.", "Deleted",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    await _RefreshUsersList();
                }
                else
                {
                    MessageBox.Show("Failed to delete user.", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("This user cannot be deleted because they have related records (shifts).",
                    "Cannot Delete", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // المستخدم رقم 1 (المالك) محمي من التعديل والحذف
        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            if (dgvUsers.CurrentRow == null)
            {
                e.Cancel = true;
                return;
            }

            bool isOwner = Convert.ToInt32(dgvUsers.CurrentRow.Cells["UserID"].Value) == 1;
            deleteToolStripMenuItem.Enabled = !isOwner;
            updateToolStripMenuItem.Enabled = !isOwner;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}