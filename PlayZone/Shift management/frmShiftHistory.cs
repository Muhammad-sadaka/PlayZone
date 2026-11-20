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
    public partial class frmShiftHistory : Form
    {
        private List<ShiftsListDTO> _ShiftHistory = new();
        private bool _IsLoading = true;          // يمنع الفلترة أثناء التعبئة والتصفير
        private bool _DateFilterActive = false;  // لا يعمل فلتر التاريخ حتى يختار المستخدم تاريخاً

        public frmShiftHistory()
        {
            InitializeComponent();
        }

        private async void frmShiftHistory_Load(object sender, EventArgs e)
        {
            _SetupGrid();
            dateTimePicker1.Value = DateTime.Now;

            await _FillCashiersInComboBox();
            await _LoadShiftHistoryData();

            _IsLoading = false;
            _ApplyFilters();
        }

        // ============ Grid ============
        private void _SetupGrid()
        {
            dgvShiftHistory.AutoGenerateColumns = false;
            dgvShiftHistory.Columns.Clear();
            dgvShiftHistory.ReadOnly = true;
            dgvShiftHistory.AllowUserToAddRows = false;
            dgvShiftHistory.AllowUserToDeleteRows = false;
            dgvShiftHistory.AllowUserToResizeRows = false;
            dgvShiftHistory.RowHeadersVisible = false;
            dgvShiftHistory.MultiSelect = false;
            dgvShiftHistory.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvShiftHistory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            var money = new DataGridViewCellStyle
            {
                Format = "0.00",
                NullValue = "-",
                Alignment = DataGridViewContentAlignment.MiddleRight
            };

            dgvShiftHistory.Columns.Add(new DataGridViewTextBoxColumn
            { Name = "ShiftID", HeaderText = "Shift #", DataPropertyName = "ShiftID", FillWeight = 8 });

            dgvShiftHistory.Columns.Add(new DataGridViewTextBoxColumn
            { Name = "CashierName", HeaderText = "Cashier", DataPropertyName = "CashierName", FillWeight = 16 });

            dgvShiftHistory.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "StartTime",
                HeaderText = "Start",
                DataPropertyName = "StartTime",
                FillWeight = 18,
                DefaultCellStyle = new DataGridViewCellStyle { Format = "dd/MM/yyyy hh:mm tt" }
            });

            dgvShiftHistory.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "EndTime",
                HeaderText = "End",
                DataPropertyName = "EndTime",
                FillWeight = 18,
                DefaultCellStyle = new DataGridViewCellStyle { Format = "dd/MM/yyyy hh:mm tt", NullValue = "Open" }
            });

            dgvShiftHistory.Columns.Add(new DataGridViewTextBoxColumn
            { Name = "StartingCash", HeaderText = "Starting Cash", DataPropertyName = "StartingCash", FillWeight = 11, DefaultCellStyle = money });

            dgvShiftHistory.Columns.Add(new DataGridViewTextBoxColumn
            { Name = "TotalSales", HeaderText = "Total Sales", DataPropertyName = "TotalSales", FillWeight = 11, DefaultCellStyle = money });

            dgvShiftHistory.Columns.Add(new DataGridViewTextBoxColumn
            { Name = "ExpectedCash", HeaderText = "Expected", DataPropertyName = "ExpectedCash", FillWeight = 11, DefaultCellStyle = money });

            dgvShiftHistory.Columns.Add(new DataGridViewTextBoxColumn
            { Name = "ActualCash", HeaderText = "Actual", DataPropertyName = "ActualCash", FillWeight = 11, DefaultCellStyle = money });
        }

        // ============ Data ============
        private async Task _FillCashiersInComboBox()
        {
            var users = await clsUser.GetAllUsersAsync();

            cmbCashier.DataSource = users;
            cmbCashier.DisplayMember = "Username";
            cmbCashier.ValueMember = "UserID";

            cmbCashier.SelectedIndex = -1;
        }

        private async Task _LoadShiftHistoryData()
        {
            _ShiftHistory = await clsShift.GetAllShiftsAsync();
            dgvShiftHistory.DataSource = new BindingList<ShiftsListDTO>(_ShiftHistory);
        }

        // ============ Filters ============
        private void _ApplyFilters()
        {
            if (_IsLoading || _ShiftHistory == null) return;

            try
            {
                IEnumerable<ShiftsListDTO> filtered = _ShiftHistory;

                // 1) الكاشير
                if (cmbCashier.SelectedIndex != -1 && !string.IsNullOrEmpty(cmbCashier.Text))
                {
                    string cashier = cmbCashier.Text;
                    filtered = filtered.Where(s =>
                        string.Equals(s.CashierName, cashier, StringComparison.OrdinalIgnoreCase));
                }

                // 2) التاريخ: الورديات التي بدأت في اليوم المحدد
                if (_DateFilterActive)
                {
                    DateTime day = dateTimePicker1.Value.Date;
                    filtered = filtered.Where(s => s.StartTime.Date == day);
                }

                dgvShiftHistory.DataSource = new BindingList<ShiftsListDTO>(filtered.ToList());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Filter Error: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmbCashier_SelectedIndexChanged(object sender, EventArgs e)
        {
            _ApplyFilters();
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
            cmbCashier.SelectedIndex = -1;
            dateTimePicker1.Value = DateTime.Now;
            _IsLoading = false;

            dgvShiftHistory.DataSource = new BindingList<ShiftsListDTO>(_ShiftHistory);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}