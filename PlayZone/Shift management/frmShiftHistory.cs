using PlayZone_Buisness; // استبدل بما يناسب طبقة الأعمال لديك
using System;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlayZone
{
    public partial class frmShiftHistory : Form
    {
        private DataTable _dtShiftHistory;

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
            //_dtShiftHistory = await clsShift.GetAllShiftsHistoryAsync();
            dgvShiftHistory.DataSource = _dtShiftHistory;
        }

        private void _ApplyFilters()
        {
            if (_dtShiftHistory == null) return;

            string filterExpression = string.Empty;

            // 1. الفلترة حسب الكاشير المختار
            if (cmbCashier.SelectedValue is int cashierID && cashierID > 0)
            {
                string cashierName = cmbCashier.Text;
                filterExpression = $"Username = '{cashierName}'"; // تأكد أن اسم العمود في الجدول يطابق Username
            }

            // تطبيق الفلتر على الـ DataView
            try
            {
                DataView dv = _dtShiftHistory.DefaultView;
                dv.RowFilter = filterExpression;
                dgvShiftHistory.DataSource = dv.ToTable();
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
            if (_dtShiftHistory != null)
            {
                _dtShiftHistory.DefaultView.RowFilter = string.Empty;
                dgvShiftHistory.DataSource = _dtShiftHistory;
                cmbCashier.SelectedIndex = -1;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}