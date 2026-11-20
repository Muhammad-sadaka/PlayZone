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
    public partial class frmArchives : Form
    {
        private List<ReservationListDTO> _Archive = new();
        private bool _IsLoading = true;       // يمنع الفلترة أثناء تعبئة الأدوات
        private bool _DateFilterActive = false;

        public frmArchives()
        {
            InitializeComponent();
        }

        private async void frmArchives_Load(object sender, EventArgs e)
        {
            _SetupGrid();
            await _FillDeviceTypesInComboBox();
            await _LoadArchiveData();

            _IsLoading = false;
            _ApplyFilters();
        }

        private void _SetupGrid()
        {
            dgvArchive.AutoGenerateColumns = false;
            dgvArchive.Columns.Clear();
            dgvArchive.ReadOnly = true;
            dgvArchive.AllowUserToAddRows = false;
            dgvArchive.AllowUserToDeleteRows = false;
            dgvArchive.AllowUserToResizeRows = false;
            dgvArchive.RowHeadersVisible = false;
            dgvArchive.MultiSelect = false;
            dgvArchive.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvArchive.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dgvArchive.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "ReservationID",
                HeaderText = "ID",
                DataPropertyName = "ReservationID",
                FillWeight = 8
            });

            dgvArchive.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "CustomerName",
                HeaderText = "Customer",
                DataPropertyName = "CustomerName",
                FillWeight = 20
            });

            dgvArchive.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "SpotTypeName",
                HeaderText = "Spot Type",
                DataPropertyName = "SpotTypeName",
                FillWeight = 16
            });

            dgvArchive.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "SpotNumber",
                HeaderText = "Spot Number",
                DataPropertyName = "SpotNumber",
                FillWeight = 10
            });

            dgvArchive.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "StartDate",
                HeaderText = "Start",
                DataPropertyName = "StartDate",
                FillWeight = 18,
                DefaultCellStyle = new DataGridViewCellStyle { Format = "dd/MM/yyyy hh:mm tt" }
            });

            dgvArchive.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "EndDate",
                HeaderText = "End",
                DataPropertyName = "EndDate",
                FillWeight = 18,
                DefaultCellStyle = new DataGridViewCellStyle { Format = "dd/MM/yyyy hh:mm tt", NullValue = "-" }
            });

            dgvArchive.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Period",
                HeaderText = "Duration",
                DataPropertyName = "Period",
                FillWeight = 12,
                DefaultCellStyle = new DataGridViewCellStyle { Format = @"hh\:mm\:ss", NullValue = "-" }
            });

            dgvArchive.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "TotalPrice",
                HeaderText = "Total",
                DataPropertyName = "TotalPrice",
                FillWeight = 10,
                DefaultCellStyle = new DataGridViewCellStyle
                {
                    Format = "0.00",
                    NullValue = "0.00",
                    Alignment = DataGridViewContentAlignment.MiddleRight
                }
            });
        }

        private async Task _FillDeviceTypesInComboBox()
        {
            cmbDeviceType.DataSource = await clsSpotType.GetAllSpotTypesAsync();
            cmbDeviceType.DisplayMember = "SpotTypeName";
            cmbDeviceType.ValueMember = "SpotTypeID";

            cmbDeviceType.SelectedIndex = -1;
        }

        private async Task _LoadArchiveData()
        {
            _Archive = await clsReservation.GetAllReservationsAsync();
            dgvArchive.DataSource = new BindingList<ReservationListDTO>(_Archive);
        }

        private void _ApplyFilters()
        {
            if (_IsLoading || _Archive == null) return;

            IEnumerable<ReservationListDTO> filtered = _Archive;

            // 1) فلترة حسب التاريخ (اليوم المحدد فقط) إذا اختار المستخدم تاريخاً
            if (_DateFilterActive)
            {
                DateTime day = dateTimePicker1.Value.Date;
                filtered = filtered.Where(r => r.StartDate.Date == day);
            }

            // 2) فلترة حسب نوع الجهاز
            if (cmbDeviceType.SelectedIndex != -1 && !string.IsNullOrEmpty(cmbDeviceType.Text))
            {
                string typeName = cmbDeviceType.Text;
                filtered = filtered.Where(r =>
                    string.Equals(r.SpotTypeName, typeName, StringComparison.OrdinalIgnoreCase));
            }

            dgvArchive.DataSource = new BindingList<ReservationListDTO>(filtered.ToList());
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            _DateFilterActive = true;   // الفلتر لا يعمل إلا بعد أن يختار المستخدم تاريخاً
            _ApplyFilters();
        }

        private void cmbDeviceType_SelectedIndexChanged(object sender, EventArgs e)
        {
            _ApplyFilters();
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            _IsLoading = true;                 // لا نفلتر أثناء التصفير
            _DateFilterActive = false;
            cmbDeviceType.SelectedIndex = -1;
            dateTimePicker1.Value = DateTime.Today;
            _IsLoading = false;

            dgvArchive.DataSource = new BindingList<ReservationListDTO>(_Archive);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}