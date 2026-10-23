using PlayZone_Buisness;
using SharedDTOs;
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
    public partial class frmArchives : Form
    {
        public frmArchives()
        {
            InitializeComponent();
        }

        private async void frmArchives_Load(object sender, EventArgs e)
        {
            DGVReservations.DataSource = await clsReservation.GetAllReservationsAsync();
        }
    }
}
