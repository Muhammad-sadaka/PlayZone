using PlayZone_Buisness;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlayZone
{
    public partial class frmSalesAndIncomeReport : Form
    {
        private List<SalesListDTO> _Sales;

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
            _Sales = await clsShift.GetAllSalesAndIncomeAsync(); // أو جلب البيانات عبر طبقة الأعمال
            dgvReports.DataSource = _Sales;

            _CalculateCardsSummary(_Sales);
        }

        private void _CalculateCardsSummary(List<SalesListDTO> dt)
        {
            if (dt == null)
                return;

            decimal totalSessions = 0;
            decimal totalCafeteria = 0;
            decimal grandTotal = 0;



            lblSessionsRevenue.Text = totalSessions.ToString("N2");
            lblCafeteriaRevenue.Text = totalCafeteria.ToString("N2");
            lblTotalIncome.Text = grandTotal.ToString("N2");
        }

        private async void btnShowAll_Click(object sender, EventArgs e)
        {
            if (_Sales != null)
            {
                dgvReports.DataSource = _Sales;
                _CalculateCardsSummary(_Sales);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            if (_Sales == null) return;

            string selectedDate = dateTimePicker1.Value.ToString("yyyy-MM-dd"); // أو الصيغة المطابقة لحفظ التاريخ في قاعدة البيانات
        }

    }
}