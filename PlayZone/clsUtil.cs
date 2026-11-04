using System;
using System.IO;
using System.Windows.Forms;

namespace PlayZone
{
    public class clsUtil
    {
        public static string GenerateGUID()
        {
            //Guid newGuid = Guid.NewGuid();
            //return newGuid.ToString();

            return Guid.NewGuid().ToString();
        }

        public static bool CreateFolderIfDoesNotExist(string FolderPath)
        {
            if (!Directory.Exists(FolderPath))
            {
                try
                {
                    Directory.CreateDirectory(FolderPath);
                    return true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error creating folder: " + ex.Message);
                    return false;
                }
            }

            return true;
        }

        public static string ReplaceFileNameWithGUID(string sourceFile)
        {
            //string fileName = sourceFile;
            //FileInfo fi = new FileInfo(fileName);
            //string extn = fi.Extension;
            //return GenerateGUID() + extn;

            return GenerateGUID() + new FileInfo(sourceFile).Extension;
        }

        public static bool CopyImageToProjectImagesFolder(ref string sourceFile)
        {
            string DestinationFolder = @"F:\Programming Advices\My Projects\PlayZone\PlayZoneImages";
            if (!CreateFolderIfDoesNotExist(DestinationFolder))
            {
                return false;
            }

            string destinationFile = DestinationFolder + ReplaceFileNameWithGUID(sourceFile);
            try
            {
                File.Copy(sourceFile, destinationFile, true);
            }
            catch (IOException iox)
            {
                MessageBox.Show(iox.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            sourceFile = destinationFile;
            return true;
        }
    }
}
