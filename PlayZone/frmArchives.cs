using PlayZone_Buisness;
using System;
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
