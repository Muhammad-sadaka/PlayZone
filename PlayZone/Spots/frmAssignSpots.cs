using PlayZone_Buisness;
using SharedDTOs;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlayZone
{
    public partial class frmAssignSpots : Form
    {
        public frmAssignSpots()
        {
            InitializeComponent();

            dgvSpots.CellPainting += dgvSpots_CellPainting;
            dgvSpots.CurrentCellDirtyStateChanged += dgvSpots_CurrentCellDirtyStateChanged;
            dgvSpots.CellValueChanged += dgvSpots_CellValueChanged;
            dgvSpots.DataError += dgvSpots_DataError;
        }

        private async void frmAssignSpots_Load(object sender, EventArgs e)
        {
            await _SetupColumnsAsync();   // مرة واحدة فقط
            await _RefreshSpotsList();    // تحميل البيانات
        }

        // ============ الأعمدة ============
        private async Task _SetupColumnsAsync()
        {
            dgvSpots.ReadOnly = false;
            dgvSpots.EditMode = DataGridViewEditMode.EditOnEnter;
            dgvSpots.AllowUserToAddRows = false;
            dgvSpots.AutoGenerateColumns = false;
            dgvSpots.Columns.Clear();

            // 1) Spot ID
            dgvSpots.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "SpotID",
                HeaderText = "Spot ID",
                DataPropertyName = "SpotID",
                ReadOnly = true
            });

            // 2) Spot Name
            dgvSpots.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "SpotName",
                HeaderText = "Spot Name",
                DataPropertyName = "SpotName",
                ReadOnly = true
            });

            // 3) Spot Type (ComboBox من جدول SpotTypes)
            dgvSpots.Columns.Add(new DataGridViewComboBoxColumn
            {
                Name = "SpotTypeId",
                HeaderText = "Spot Type",
                DataPropertyName = "SpotTypeId",
                DataSource = await clsSpotType.GetAllSpotTypesAsync(),
                DisplayMember = "SpotTypeName",
                ValueMember = "SpotTypeID",
                FlatStyle = FlatStyle.Flat,
                DisplayStyle = DataGridViewComboBoxDisplayStyle.DropDownButton
            });

            // 4) Active
            dgvSpots.Columns.Add(new DataGridViewCheckBoxColumn
            {
                Name = "Active",
                HeaderText = "Active",
                DataPropertyName = "Active",
                FlatStyle = FlatStyle.Flat
            });
        }

        // ============ تحميل البيانات ============
        private async Task _RefreshSpotsList()
        {
            var spots = await clsSpot.GetAllSpotsAsync();
            dgvSpots.DataSource = new BindingList<SpotDTO>(spots);
        }

        // ============ رسم الـ CheckBox ============
        private void dgvSpots_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0 ||
                dgvSpots.Columns[e.ColumnIndex].Name != "Active")
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
                using (var pen = new Pen(Color.DodgerBlue, 2.5f))
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

        // يثبّت القيمة فور النقر (بدون انتظار مغادرة الخلية)
        private void dgvSpots_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dgvSpots.IsCurrentCellDirty &&
                dgvSpots.CurrentCell is DataGridViewCheckBoxCell)
            {
                dgvSpots.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }

        // يعيد رسم الخلية بعد تغيّر القيمة
        private void dgvSpots_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0 &&
                dgvSpots.Columns[e.ColumnIndex].Name == "Active")
            {
                dgvSpots.InvalidateCell(e.ColumnIndex, e.RowIndex);
            }
        }

        // ============ الحفظ ============
        private async void btnSaveChanges_Click(object sender, EventArgs e)
        {
            dgvSpots.EndEdit();

            int failed = 0;

            foreach (DataGridViewRow row in dgvSpots.Rows)
            {
                if (row.IsNewRow) continue;

                int spotId = Convert.ToInt32(row.Cells["SpotID"].Value);
                int spotTypeId = Convert.ToInt32(row.Cells["SpotTypeId"].Value);
                bool active = row.Cells["Active"].Value != null
                              && row.Cells["Active"].Value != DBNull.Value
                              && Convert.ToBoolean(row.Cells["Active"].Value);

                if (!await clsSpot.UpdateSpotTypeAsync(spotId, spotTypeId, active))
                    failed++;
            }

            if (failed == 0)
                MessageBox.Show("Changes Saved Successfully.", "Saved",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show($"{failed} row(s) were not saved.", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);

            await _RefreshSpotsList();
        }

        // يتجاهل أخطاء القيم غير الموجودة في القائمة
        private void dgvSpots_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.ThrowException = false;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}