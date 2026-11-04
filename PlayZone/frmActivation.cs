using PlayZone_Buisness;
using System;
using System.Windows.Forms;

namespace PlayZone
{
    public partial class frmActivation : Form
    {
        public frmActivation()
        {
            InitializeComponent();
        }

        private void frmActivation_Load(object sender, EventArgs e)
        {
            // عند فتح النافذة، جلب بصمة الجهاز وعرضها في مربع النص للزبون
            string machineId = LicensingHelper.GetMachineId();
            txtMachineId.Text = machineId; // تأكد أن اسم الـ TextBox الخاص ببصمة الجهاز هو txtMachineId
        }

        private void btnActivate_Click(object sender, EventArgs e)
        {
            string machineId = LicensingHelper.GetMachineId();
            string enteredKey = txtEnterKey.Text.Trim(); // خانة إدخال المفتاح من الزبون

            // التحقق من صحة المفتاح باستخدام الدالة التي أنشأناها سابقاً
            if (LicensingHelper.ValidateActivationKey(machineId, enteredKey))
            {
                // حفظ المفتاح في الملف الخارجي
                LicensingHelper.SaveLicenseKey(enteredKey);

                MessageBox.Show("تم تفعيل البرنامج بنجاح! شكراً لك.", "نجاح التفعيل", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close(); // إغلاق نافذة التفعيل وليبدأ البرنامج الرئيسي العمل
            }
            else
            {
                MessageBox.Show("مفتاح التفعيل غير صحيح، تأكد من الكود المدخل.", "خطأ في التفعيل", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        
    }
}