using PlayZone_Buisness;
using SharedDTOs;
using System;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlayZone
{
    public partial class frmArchives : Form
    {
        private DataTable _dtArchive;

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
            // جلب سجلات الأرشيف (الجلسات المكتملة) في DataTable
            // استبدل الدالة بما يناسب طبقة الأعمال لديك
            //_dtArchive = await clsReservation.GetCompletedReservationsArchiveAsync();
            dgvArchive.DataSource = _dtArchive;
        }

        private void _ApplyFilters()
        {
            if (_dtArchive == null) return;

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

            // تطبيق الفلاتر مجتمعة أو منفردة
            // يمكنك تخصيص أسماء الأعمدة (DateColumnName و DeviceTypeName) بحسب قاعدة بياناتك
            try
            {
                DataView dv = _dtArchive.DefaultView;
                // مثال مبسط لدمج الفلترة (حسب متطلبات الأعمدة لديك)
                dv.RowFilter = filterExpression;
                dgvArchive.DataSource = dv.ToTable();
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
            if (_dtArchive != null)
            {
                _dtArchive.DefaultView.RowFilter = string.Empty;
                dgvArchive.DataSource = _dtArchive;
                cmbDeviceType.SelectedIndex = -1; 
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
