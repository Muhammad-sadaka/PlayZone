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
    public partial class frmSetName : Form
    {
        public delegate void DataBackEventHandler(object sender, string SpotTypeName);
        public event DataBackEventHandler DataBack;

        public frmSetName()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (tbPlayerName.Text == "")
            {
                MessageBox.Show("You should set a name first !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbPlayerName.Focus();
                return;
            }

            DataBack?.Invoke(this, tbPlayerName.Text.Trim());

            this.Close();
        }
    }
}
