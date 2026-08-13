using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            this.Close();
        }

        private void SettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSettings frm = new frmSettings();
            frm.ShowDialog();
            foreach(Control ctrl in this.Controls)
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
    }
}
