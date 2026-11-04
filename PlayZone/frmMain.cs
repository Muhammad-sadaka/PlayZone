using PlayZone_Buisness;
using System;
using System.Windows.Forms;

namespace PlayZone
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //foreach (Control ctrl in this.Controls)    /// Check if all the spots unused
            //{
            //    if (ctrl is ctrlSpot ctrl1)
            //        ctrl1.IsDone();
            //}
            this.Close();
        }

        private void SettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSettings frm = new frmSettings();
            frm.ShowDialog();
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is ctrlSpot ctrl1)
                    ctrl1.LoadControl();
            }
        }

        private void ArchivesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmArchives frm = new frmArchives();
            frm.ShowDialog();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            // 1. جلب بصمة الجهاز الحالية
            string currentMachineId = LicensingHelper.GetMachineId();

            // 2. قراءة المفتاح المحفوظ من الملف الخارجي (license.dat)
            string savedKey = LicensingHelper.ReadLicenseKey();

            if (!LicensingHelper.ValidateActivationKey(currentMachineId, savedKey))
            {
                MessageBox.Show("البرنامج غير مفعل على هذا الجهاز!\nرقم الجهاز الخاص بك هو: " + currentMachineId,
                                "تنبيه ترخيص البرنامج", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                // فتح نافذة إدخال مفتاح التفعيل
                frmActivation frmAct = new frmActivation();
                frmAct.ShowDialog();

                // إعادة التحقق بعد إغلاق نافذة التفعيل
                savedKey = LicensingHelper.ReadLicenseKey();
                if (!LicensingHelper.ValidateActivationKey(currentMachineId, savedKey))
                {
                    // إذا لم يتم التفعيل، أغلق البرنامج
                    Environment.Exit(0);
                }
            }
            else
            {
                // البرنامج مفعل بنجاح
            }
        }
    }
}

