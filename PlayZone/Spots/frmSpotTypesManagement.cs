using PlayZone_Buisness; // افترض أنك ستنشئ طبقة أعمال للـ SpotTypes بنفس النمط
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
    public partial class frmSpotTypesManagement : Form
    {
        public frmSpotTypesManagement()
        {
            InitializeComponent();
        }

        private async void frmSpotTypesManagement_Load(object sender, EventArgs e)
        {
            _SetupGrid();
            // ربط الـ ContextMenuStrip بالـ DataGridView برمجياً
            dgvSpotTypes.ContextMenuStrip = contextMenuStrip1;

            await _RefreshSpotTypesList();
        }

        private void _SetupGrid()
        {
            dgvSpotTypes.AutoGenerateColumns = false;
            dgvSpotTypes.Columns.Clear();
            dgvSpotTypes.ReadOnly = true;
            dgvSpotTypes.AllowUserToAddRows = false;
            dgvSpotTypes.AllowUserToDeleteRows = false;
            dgvSpotTypes.AllowUserToResizeRows = false;
            dgvSpotTypes.RowHeadersVisible = false;
            dgvSpotTypes.MultiSelect = false;
            dgvSpotTypes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSpotTypes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dgvSpotTypes.Columns.Add(new DataGridViewTextBoxColumn
            { Name = "SpotTypeId", HeaderText = "ID", DataPropertyName = "SpotTypeId", FillWeight = 10 });

            dgvSpotTypes.Columns.Add(new DataGridViewTextBoxColumn
            { Name = "SpotTypeName", HeaderText = "Spot Type Name", DataPropertyName = "SpotTypeName", FillWeight = 30 });

            dgvSpotTypes.Columns.Add(new DataGridViewTextBoxColumn
            { Name = "PricePerHour", HeaderText = "Price Per Hour", DataPropertyName = "PricePerHour", FillWeight = 25 });

            dgvSpotTypes.Columns.Add(new DataGridViewCheckBoxColumn
            { Name = "SpotsCount", HeaderText = "Spots Count", DataPropertyName = "SpotsCount", FillWeight = 20 });
            
            // الزر الأيمن يحدد الصف تحت المؤشر قبل فتح القائمة
            dgvSpotTypes.CellMouseDown += (s, e) =>
            {
                if (e.Button == MouseButtons.Right && e.RowIndex >= 0)
                {
                    dgvSpotTypes.ClearSelection();
                    dgvSpotTypes.Rows[e.RowIndex].Selected = true;
                    dgvSpotTypes.CurrentCell = dgvSpotTypes.Rows[e.RowIndex].Cells[0];
                }
            };
        }

        private async Task _RefreshSpotTypesList()
        {
            // استبدل clsSpotType.GetAllSpotTypesAsync() بالدالة الخاصة بك لجلب أنواع الأجهزة/الـ Spots
            dgvSpotTypes.DataSource = await clsSpotType.GetAllSpotTypesAsync();
        }

        private async void btnAddNew_Click(object sender, EventArgs e)
        {
            // افتح شاشة الإضافة والتعديل الخاصة بالـ SpotTypes (مثال: frmAddUpdateSpotType)
            frmAddUpdateType frm = new frmAddUpdateType();
            frm.ShowDialog();

            await _RefreshSpotTypesList();
        }

        // --- أحداث الـ ContextMenuStrip ---

        private async void addNewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddUpdateType frm = new frmAddUpdateType();
            frm.ShowDialog();
            await _RefreshSpotTypesList();
        }

        private async void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvSpotTypes.CurrentRow == null) return;

            // جلب الـ ID الخاص بالـ SpotType (تأكد أن اسم العمود يطابق الموديل لديك، غالباً SpotTypeID)
            int spotTypeID = Convert.ToInt32(dgvSpotTypes.CurrentRow.Cells["SpotTypeID"].Value);

            frmAddUpdateType frm = new frmAddUpdateType(spotTypeID);
            frm.ShowDialog();
            await _RefreshSpotTypesList();
        }

        private async void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvSpotTypes.CurrentRow == null) return;

            int spotTypeID = Convert.ToInt32(dgvSpotTypes.CurrentRow.Cells["SpotTypeID"].Value);

            if (MessageBox.Show("Are you sure you want to delete this spot type?", "Confirm Delete",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                if (await clsSpotType.DeleteSpotTypeAsync(spotTypeID))
                {
                    MessageBox.Show("Spot Type Deleted Successfully.", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    await _RefreshSpotTypesList();
                }
                else
                {
                    MessageBox.Show("Failed to delete spot type.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}