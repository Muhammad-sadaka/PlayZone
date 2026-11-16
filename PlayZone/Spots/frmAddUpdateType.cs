using PlayZone_Buisness; 
using System;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlayZone
{
    public partial class frmAddUpdateType : Form
    {
        public enum enMode { AddNew = 0, Update = 1 };
        private enMode _Mode;
        private int _SpotTypeID;
        private clsSpotType _SpotType;

        // وضع الإضافة
        public frmAddUpdateType()
        {
            InitializeComponent();
            _Mode = enMode.AddNew;
        }

        // وضع التعديل
        public frmAddUpdateType(int spotTypeID)
        {
            InitializeComponent();
            _SpotTypeID = spotTypeID;
            _Mode = enMode.Update;
        }

        private async void frmAddUpdateType_Load(object sender, EventArgs e)
        {
            _ResetDefaultValues();

            if (_Mode == enMode.Update)
            {
                await _LoadData();
            }
        }

        private void _ResetDefaultValues()
        {
            if (_Mode == enMode.AddNew)
            {
                lblTitle.Text = "Add New Type";
                _SpotType = new clsSpotType();
            }
            else
            {
                lblTitle.Text = "Update Type";
            }

            txtTypeName.Text = string.Empty;
            txtPricePerHour.Text = string.Empty;
            pictureBoxDeviceImage.Image = null; // تأكد أن اسم الـ PictureBox لديك مطابق أو قم بتعديله
        }

        private async Task _LoadData()
        {
            _SpotType = await clsSpotType.FindByIDAsync(_SpotTypeID);

            if (_SpotType == null)
            {
                MessageBox.Show("No Spot Type with ID = " + _SpotTypeID, "Spot Type Not Found", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.Close();
                return;
            }

            txtTypeName.Text = _SpotType.SpotTypeName;
            txtPricePerHour.Text = _SpotType.PricePerHour.ToString();

            // تحميل الصورة إذا كانت موجودة
            if (!string.IsNullOrEmpty(_SpotType.ImagePath) && File.Exists(_SpotType.ImagePath))
            {
                pictureBoxDeviceImage.ImageLocation = _SpotType.ImagePath;
            }
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files (*.jpg; *.jpeg; *.png; *.gif)|*.jpg; *.jpeg; *.png; *.gif";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    pictureBoxDeviceImage.ImageLocation = openFileDialog.FileName;
                }
            }
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            // التحقق من المدخلات الأساسية
            if (string.IsNullOrWhiteSpace(txtTypeName.Text))
            {
                MessageBox.Show("Please enter type name.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!decimal.TryParse(txtPricePerHour.Text, out decimal pricePerHour))
            {
                MessageBox.Show("Please enter a valid price per hour.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _SpotType.SpotTypeName = txtTypeName.Text.Trim();
            _SpotType.PricePerHour = pricePerHour;
            _SpotType.ImagePath = pictureBoxDeviceImage.ImageLocation;

            if (await _SpotType.SaveAsync())
            {
                MessageBox.Show("Data Saved Successfully.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // تغيير الوضع إلى تعديل في حال كانت إضافة جديدة لتحديث الشاشة بسلاسة
                _Mode = enMode.Update;
                lblTitle.Text = "Update Type";

                this.Close();
            }
            else
            {
                MessageBox.Show("Error: Data Is not Saved.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}