using PlayZone_Buisness;
using System;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlayZone
{
    public partial class frmSalesAndIncomeReport : Form
    {
        private DataTable _dtReports;

        public frmSalesAndIncomeReport()
        {
            InitializeComponent();
        }

        private async void frmSalesAndIncomeReport_Load(object sender, EventArgs e)
        {
            dateTimePicker1.Value = DateTime.Now;

            await _LoadReportData();
        }

        private async Task _LoadReportData()
        {
            // جلب بيانات المبيعات (يمكنك استبدالها بدالة من طبقة الأعمال لديك)
            // افتراضياً سنفترض أن الدالة ترجع DataTable بأعمدة: Date, Sessions, Cafeteria, Total
            //_dtross = await clsReport.GetAllSalesAndIncomeAsync(); // أو جلب البيانات عبر طبقة الأعمال

            dgvReports.DataSource = _dtReports;

            _CalculateCardsSummary(_dtReports);
        }

        private void _CalculateCardsSummary(DataTable dt)
        {
            if (dt == null)
                return;

            decimal totalSessions = 0;
            decimal totalCafeteria = 0;
            decimal grandTotal = 0;

            foreach (DataRow row in dt.Rows)
            {
                totalSessions += Convert.ToDecimal(row["Sessions"]);
                totalCafeteria += Convert.ToDecimal(row["Cafeteria"]);
                grandTotal += Convert.ToDecimal(row["Total"]);
            }

            lblSessionsRevenue.Text = totalSessions.ToString("N2");
            lblCafeteriaRevenue.Text = totalCafeteria.ToString("N2");
            lblTotalIncome.Text = grandTotal.ToString("N2");
        }

        private async void btnShowAll_Click(object sender, EventArgs e)
        {
            if (_dtReports != null)
            {
                _dtReports.DefaultView.RowFilter = string.Empty;
                dgvReports.DataSource = _dtReports;
                _CalculateCardsSummary(_dtReports);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            if (_dtReports == null) return;

            string selectedDate = dateTimePicker1.Value.ToString("yyyy-MM-dd"); // أو الصيغة المطابقة لحفظ التاريخ في قاعدة البيانات

            DataView dv = _dtReports.DefaultView;
            // فلترة الجدول بناءً على عمود التاريخ (تأكد من اسم عمود التاريخ في الـ DataTable لديك، مثلاً Date أو CreatedDate)
            dv.RowFilter = $"CONVERT(Date, 'System.String') LIKE '%{dateTimePicker1.Value.ToString("MM/dd")}%'";

            DataTable filteredDt = dv.ToTable();
            dgvReports.DataSource = filteredDt;

            _CalculateCardsSummary(filteredDt);
        }

    }
}