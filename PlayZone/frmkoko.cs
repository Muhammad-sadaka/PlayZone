using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PlayZone_Buisness;

namespace PlayZone
{
    public partial class frmkoko : Form
    {
        public frmkoko()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            clsSpotType clsSpotType = new clsSpotType();
            clsSpotType.SpotTypeName = "koko";
            clsSpotType.PricePerHour = 120;

            if (clsSpotType.Save())
                MessageBox.Show("true");
            else
                MessageBox.Show("false");
        }
    }
}
