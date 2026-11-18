using PlayZone_Buisness;
using SharedDTOs;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlayZone
{
    public partial class frmArchives : Form
    {
        private List<ReservationListDTO> _Archive;

        public frmArchives()
        {
            InitializeComponent();
        }

        private async void frmArchives_Load(object sender, EventArgs e)
        {
            await _FillDeviceTypesInComboBox();
            await _LoadArchiveData();
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
            dgvArchive.DataSource = _Archive;
        }

        private void _ApplyFilters()
        {
            if (_Archive == null) return;

            string filterExpression = string.Empty;

            // 1. فلترة حسب التاريخ (تأكد أن اسم عمود التاريخ في الـ DataTable هو Date أو CreatedDate)
            string selectedDate = dateTimePicker1.Value.ToString("yyyy-MM-dd");
            // نفترض أن عمود التاريخ يخزن التاريخ بصيغة يمكن مقارنتها أو استخدام LIKE
            string dateFilter = $"CONVERT(DateColumnName, 'System.String') LIKE '%{dateTimePicker1.Value.ToString("MM/dd/yyyy")}%'";

            if (cmbDeviceType.SelectedValue is int deviceTypeID && deviceTypeID != -1)
            {
                string deviceTypeName = cmbDeviceType.Text;
                filterExpression = $"DeviceTypeName = '{deviceTypeName}'";
            }
            try
            {
                dgvArchive.DataSource = _Archive;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Filter Error: " + ex.Message);
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            _ApplyFilters();
        }

        private void cmbDeviceType_SelectedIndexChanged(object sender, EventArgs e)
        {
            _ApplyFilters();
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            if (_Archive != null)
            {
                dgvArchive.DataSource = _Archive;
                cmbDeviceType.SelectedIndex = -1; 
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
