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
    public partial class frmArchives : Form
    {
        private static DataTable _dtAllReservations = clsReservation.GetAllReservations();
        ////only select the columns that you want to show in the grid
        //private DataTable _dtReservations = _dtAllReservations.DefaultView.ToTable(false, "PersonID", "NationalNo",
        //                                                 "FirstName", "SecondName", "ThirdName", "LastName",
        //                                                 "Gender", "DateOfBirth", "Nationality",
        //                                                 "Phone", "Email");
        public frmArchives()
        {
            InitializeComponent();
        }

        private void frmArchives_Load(object sender, EventArgs e)
        {
            _dtAllReservations = clsReservation.GetAllReservations();
            if( _dtAllReservations != null )
            DGVReservations.DataSource = _dtAllReservations;
        }
    }
}
