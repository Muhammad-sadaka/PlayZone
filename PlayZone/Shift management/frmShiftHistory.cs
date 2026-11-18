using PlayZone_Buisness;
using SharedDTOs;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace PlayZone
{
    public partial class frmShiftHistory : Form
    {
        private List<ShiftsListDTO> _ShiftHistory = new();

        public frmShiftHistory()
        {
            InitializeComponent();
        }

        private async void frmShiftHistory_Load(object sender, EventArgs e)
        {
            dateTimePicker1.Value = DateTime.Now;

            await _FillCashiersInComboBox();
            await _LoadShiftHistoryData();
        }

        private async Task _FillCashiersInComboBox()
        {
            // جلب قائمة المستخدمين/الكاشير لملء الـ ComboBox
            var users = await clsUser.GetAllUsersAsync();

            cmbCashier.DataSource = users;
            cmbCashier.DisplayMember = "Username"; // أو اسم العمود الذي يعرض اسم المستخدم
            cmbCashier.ValueMember = "UserID";     // الرقم التعريفي للمستخدم

            cmbCashier.SelectedIndex = -1; // ترك القائمة فارغة افتراضياً
        }

        private async Task _LoadShiftHistoryData()
        {
            // جلب سجلات الورديات (Shift History) من طبقة الأعمال
            _ShiftHistory = await clsShift.GetAllShiftsAsync();
            dgvShiftHistory.DataSource = _ShiftHistory;
        }

        private void _ApplyFilters()
        {
            if (_ShiftHistory == null) return;

            try
            {
                dgvShiftHistory.DataSource = _ShiftHistory.Where(s =>
                 s.CashierName == cmbCashier.Text).ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Filter Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmbCashier_SelectedIndexChanged(object sender, EventArgs e)
        {
            _ApplyFilters();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            // يمكنك إضافة فلترة التاريخ هنا إذا كان مصفوفاً في الجدول
            _ApplyFilters();
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            if (_ShiftHistory != null)
            {
                dgvShiftHistory.DataSource = _ShiftHistory;
                cmbCashier.SelectedIndex = -1;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}