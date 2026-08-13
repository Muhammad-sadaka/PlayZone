using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            _FillSpotTypesInComboBox();
            _LoadSpotTypeInfo(1);
        }

        private void _LoadSpotTypeInfo(int SpotTypeID)
        {
            if (clsSpotType.IsSpotTypeExist(SpotTypeID))
                SpotType = clsSpotType.FindByID(SpotTypeID);

            if(SpotType != null)
            {
                tbSpotTypeName.Text = SpotType.SpotTypeName;
                tbSpotTypePrice.Text = SpotType.PricePerHour.ToString();
                _LoadSpotTypeImage();
            }


        }

        private void _FillSpotTypesInComboBox()
        {
            DataTable dtCountries = clsSpotType.GetAllSpotType();
            foreach (DataRow row in dtCountries.Rows)
            {
                cbSpotTypes.Items.Add(row["SpotTypeName"]);
            }
            if (cbSpotTypes.Items.Count > 0)
                cbSpotTypes.SelectedIndex = 0;
        }

        private void _LoadSpotTypeImage()
        {
            string ImagePath = SpotType.ImagePath;
            if (ImagePath != "")
                if (File.Exists(ImagePath))
                    pictureBox1.ImageLocation = ImagePath;
                else
                    MessageBox.Show("Could not find this image: = " + ImagePath, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void cbSpotTypes_SelectedIndexChanged(object sender, EventArgs e)
        {
            _LoadSpotTypeInfo(cbSpotTypes.SelectedIndex + 1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnChangeImage_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // Process the selected file
                string selectedFilePath = openFileDialog1.FileName;
                pictureBox1.Load(selectedFilePath);
                // ...
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!_HandlePersonImage())
                return;

            SpotType.SpotTypeName = tbSpotTypeName.Text;
            SpotType.PricePerHour = Convert.ToDecimal(tbSpotTypePrice.Text);
      
            if (pictureBox1.ImageLocation != null)
                SpotType.ImagePath = pictureBox1.ImageLocation;

            if (SpotType.Save())
                MessageBox.Show("Spot Type Updated Successfuly", "Updated", MessageBoxButtons.OK,MessageBoxIcon.Information); 
            else
                MessageBox.Show("Spot Type did not Updated Successfuly", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private bool _HandlePersonImage()
        {
            //this procedure will handle the person image,
            //it will take care of deleting the old image from the folder
            //in case the image changed. and it will rename the new image with guid and 
            // place it in the images folder.

            //_Person.ImagePath contains the old Image, we check if it changed then we copy the new image
            if (SpotType.ImagePath != pictureBox1.ImageLocation)
            {
                if (SpotType.ImagePath != "")
                {
                    //first we delete the old image from the folder in case there is any.

                    try
                    {
                        File.Delete(SpotType.ImagePath);
                    }
                    catch (IOException)
                    {
                        // We could not delete the file.
                        //log it later   
                    }
                }

                if (pictureBox1.ImageLocation != null)
                {
                    //then we copy the new image to the image folder after we rename it
                    string SourceImageFile = pictureBox1.ImageLocation.ToString();

                    if (clsUtil.CopyImageToProjectImagesFolder(ref SourceImageFile))
                    {
                        pictureBox1.ImageLocation = SourceImageFile;
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("Error Copying Image File", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }

            }
            return true;
        }
    }
}
