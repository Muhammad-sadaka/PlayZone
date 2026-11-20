using PlayZone_Buisness;
using SharedDTOs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlayZone
{
    public partial class frmSalesAndIncomeReport : Form
    {
        private List<SalesListDTO> _Sales = new();
        private bool _IsLoading = true;
        private bool _DateFilterActive = false;

        public frmSalesAndIncomeReport()
        {
            InitializeComponent();
        }

        private async void frmSalesAndIncomeReport_Load(object sender, EventArgs e)
        {
            _SetupGrid();
            dateTimePicker1.Value = DateTime.Now;

            await _LoadReportData();

            _IsLoading = false;
            _ApplyFilters();
        }

        // ============ Grid ============
        private void _SetupGrid()
        {
            dgvReports.AutoGenerateColumns = false;
            dgvReports.Columns.Clear();
            dgvReports.ReadOnly = true;
            dgvReports.AllowUserToAddRows = false;
            dgvReports.AllowUserToDeleteRows = false;
            dgvReports.AllowUserToResizeRows = false;
            dgvReports.RowHeadersVisible = false;
            dgvReports.MultiSelect = false;
            dgvReports.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvReports.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            var money = new DataGridViewCellStyle
            {
                Format = "N2",
                NullValue = "0.00",
                Alignment = DataGridViewContentAlignment.MiddleRight
            };

            dgvReports.Columns.Add(new DataGridViewTextBoxColumn
            { Name = "ShiftID", HeaderText = "Shift #", DataPropertyName = "ShiftID", FillWeight = 10 });

            dgvReports.Columns.Add(new DataGridViewTextBoxColumn
            { Name = "CashierName", HeaderText = "Cashier", DataPropertyName = "CashierName", FillWeight = 20 });

            dgvReports.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "ShiftDate",
                HeaderText = "Date",
                DataPropertyName = "ShiftDate",
                FillWeight = 20,
                DefaultCellStyle = new DataGridViewCellStyle { Format = "dd/MM/yyyy hh:mm tt" }
            });

            dgvReports.Columns.Add(new DataGridViewTextBoxColumn
            { Name = "SessionsRevenue", HeaderText = "Sessions", DataPropertyName = "SessionsRevenue", FillWeight = 16, DefaultCellStyle = money });

            dgvReports.Columns.Add(new DataGridViewTextBoxColumn
            { Name = "CafeteriaRevenue", HeaderText = "Cafeteria", DataPropertyName = "CafeteriaRevenue", FillWeight = 16, DefaultCellStyle = money });

            dgvReports.Columns.Add(new DataGridViewTextBoxColumn
            { Name = "TotalSales", HeaderText = "Total", DataPropertyName = "TotalSales", FillWeight = 16, DefaultCellStyle = money });
        }

        // ============ Data ============
        private async Task _LoadReportData()
        {
            try
            {
                _Sales = await clsShift.GetAllSalesAndIncomeAsync() ?? new List<SalesListDTO>();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Could not load the report:\n{ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                _Sales = new List<SalesListDTO>();
            }
        }

        // ============ Filters ============
        private void _ApplyFilters()
        {
            if (_IsLoading || _Sales == null) return;

            IEnumerable<SalesListDTO> filtered = _Sales;

            if (_DateFilterActive)
            {
                DateTime day = dateTimePicker1.Value.Date;
                //filtered = filtered.Where(s => s.ShiftDate.Date == day);
            }

            var list = filtered.ToList();
            dgvReports.DataSource = new BindingList<SalesListDTO>(list);
            _CalculateCardsSummary(list);
        }

        // الأرقام تُحسب من القائمة المعروضة، فتتغير مع كل فلتر
        private void _CalculateCardsSummary(List<SalesListDTO> list)
        {
            if (list == null) return;

            decimal totalSessions = list.Sum(s => s.SessionsRevenue);
            decimal totalCafeteria = list.Sum(s => s.CafeteriaRevenue);
            decimal grandTotal = totalSessions + totalCafeteria;

            lblSessionsRevenue.Text = totalSessions.ToString("N2");
            lblCafeteriaRevenue.Text = totalCafeteria.ToString("N2");
            lblTotalIncome.Text = grandTotal.ToString("N2");
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            _DateFilterActive = true;
            _ApplyFilters();
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            _IsLoading = true;
            _DateFilterActive = false;
            dateTimePicker1.Value = DateTime.Now;
            _IsLoading = false;

            _ApplyFilters();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}