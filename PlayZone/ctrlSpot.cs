using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;
using PlayZone_Buisness;
using System.Xml.Linq;
using System.IO;



namespace PlayZone
{
    public partial class ctrlSpot : UserControl
    {
        enum enMode {  Start = 0, Pause = 1  }

        enMode Mode = enMode.Start;

        string PlayerName = null;

        clsSpotType SpotType = new clsSpotType();

        int TotalSeconds = 0;
        clsReservation reservation = new clsReservation();

        private void timer1_Tick(object sender, EventArgs e)
        {
            TotalSeconds++;
            TimeSpan time = TimeSpan.FromSeconds(TotalSeconds);
            lblTimer.Text = time.ToString(@"hh\:mm\:ss");
        }

        private void Form2_DataBack(object sender, string SpotTypeName)
        {
            PlayerName = SpotTypeName;
            lblSpotName.Text = PlayerName;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (Mode == enMode.Start)
            {
                if (PlayerName == null)
                {
                    frmSetName frm = new frmSetName();
                    frm.DataBack += Form2_DataBack; // Subscribe to the event
                    frm.ShowDialog();
                }
                if (PlayerName != null)
                {
                    if (TotalSeconds < 1)
                        _AddNewReservation();
                    Mode = enMode.Pause;
                    btnStart.Text = "Pause";
                    panel1.BackColor = Color.Green;
                    timer1.Start();
                    cbSpotTypes.Enabled = false;
                }
            }
            else
            {
                Mode = enMode.Start;
                btnStart.Text = "Start";
                panel1.BackColor = Color.Yellow;

                timer1.Stop();
            }
        }

        private void btnEnd_Click(object sender, EventArgs e)
        {
            if (TotalSeconds < 1)
                return;

            _UpdateReservation();
            MessageBox.Show($"\nSpot Type: {SpotType.SpotTypeName}\nSpot Number: {this.Tag}\nDuration of play: {reservation.Period}\nPrice Per Hour: {SpotType.PricePerHour}\nTotal Price: {reservation.TotalPrice}","Reservation Details",MessageBoxButtons.OK);
            ResetControl();
        }

        public ctrlSpot()
        {
            InitializeComponent();
        }

        private void ctrlSpot_Load(object sender, EventArgs e)
        {
            lblSpotNumber.Text = this.Tag?.ToString();
            _FillSpotTypesInComboBox();
            if (cbSpotTypes.Items.Count > 0)
                cbSpotTypes.SelectedIndex = 0;
        }

        private void _FillSpotTypesInComboBox()
        {
            DataTable dtCountries = clsSpotType.GetAllSpotType();
            foreach (DataRow row in dtCountries.Rows)
            {
                cbSpotTypes.Items.Add(row["SpotTypeName"]);
            }
        }

        private void btnONOFF_Click(object sender, EventArgs e)
        {
            if (TotalSeconds > 0)
            {
                MessageBox.Show("The Spot is Busy ! End the task first and try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (btnONOFF.BackColor == Color.Green)
            {
                btnONOFF.BackColor = Color.Red;
                lblOutOfOrder.Visible = true;
            }
            else
            {
                btnONOFF.BackColor = Color.Green;
                lblOutOfOrder.Visible = false;
            }
        }

        private void _LoadSpotTypeInfo()
        {
            SpotType = clsSpotType.FindByID(cbSpotTypes.SelectedIndex + 1);
            string ImagePath = SpotType.ImagePath;
            if (ImagePath != "")
                if (File.Exists(ImagePath))
                    pictureBox1.ImageLocation = ImagePath;
                else
                    MessageBox.Show("Could not find this image: = " + ImagePath, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void cbSpotTypes_SelectedIndexChanged(object sender, EventArgs e)
        {
            _LoadSpotTypeInfo();
        }

        public void LoadControl()
        {
            if (SpotType == null)
                SpotType = clsSpotType.FindByID(1);
            cbSpotTypes.Items.Clear();
            _FillSpotTypesInComboBox();
            if (cbSpotTypes.Items.Count > 0)
                cbSpotTypes.SelectedIndex = SpotType.SpotTypeID - 1;
            _LoadSpotTypeInfo();

        }

        void ResetControl()
        {
            Mode = enMode.Start;
            btnStart.Text = "Start";
            panel1.BackColor = Color.Red;
            lblSpotName.Text = "Un Used Spot";
            TotalSeconds = 0;
            timer1.Stop();
            PlayerName = null;
            cbSpotTypes.Enabled = true;
            reservation = new clsReservation();
        }

        void _AddNewReservation()
        {
            reservation.CustomerName = lblSpotName.Text;
            reservation.StartDate = DateTime.Now;
            reservation.SpotTypeID = cbSpotTypes.SelectedIndex + 1;
            if (!reservation.Save())
                MessageBox.Show("Add Reservation did not Successfull", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        void _UpdateReservation()
        {
            reservation.EndDate = DateTime.Now;
            reservation.Period =   reservation.EndDate - reservation.StartDate;
            reservation.TotalPrice = SpotType.PricePerHour * (Convert.ToDecimal(TotalSeconds) / 60 / 60);
            reservation.Mode = clsReservation.enMode.Update;
            if (!reservation.Save())
                MessageBox.Show("Update Reservation did not Successfull", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }
    }
}
