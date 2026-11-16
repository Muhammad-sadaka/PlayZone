using System;
using System.Windows.Forms;
using System.IO;
using PlayZone_Buisness;

namespace PlayZone
{
    public partial class frmSettings : Form
    {
        clsSpotType SpotType = new clsSpotType();
        public frmSettings()
        {
            InitializeComponent();
        }

        private void frmSettings_Load(object sender, EventArgs e)
        {

        }

        private void klblEmail_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
            {
                FileName = "mailto:muhammadsadka95@gmail.com",
                UseShellExecute = true
            });
        }

        private void klblGitHub_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
            {
                FileName = "https://github.com/Muhammad-sadaka",
                UseShellExecute = true
            });
        }

        private void klblLinkedIn_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
            {
                FileName = "https://www.linkedin.com/in/muhammad-al-sadaka-338956323",
                UseShellExecute = true
            });
        }

        private void Phone_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
            {
                FileName = "https://walme/963983873645",
                UseShellExecute = true
            });
        }
    }
}
