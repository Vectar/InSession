using System;
using System.Drawing;
using System.Windows.Forms;
using Finisar.SQLite;
using System.IO;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;

namespace InSession
{
    public partial class Setup2 : Form
    {
        frmMain parentForm;
        GeoCode geoCode;
        StreamReader geoReader;

        public Setup2(frmMain Main)
        {
            geoCode = new GeoCode();
            
            geoReader = geoCode.GetGeoCode(Main.school.GetGeoCodeAddress());


            string sLine = "";
            string jsonReturn ="";

            int i = 0;

            while (sLine != null)
            {
                i++;
                sLine = geoReader.ReadLine();
                if (sLine != null)
                {
                    jsonReturn += sLine;
                    Console.WriteLine("{0}:{1}", i, sLine);
                }
            }

            JArray array = new JArray();
            GoogleGeoCodeResponse m = JsonConvert.DeserializeObject<GoogleGeoCodeResponse>(jsonReturn);

            Main.school.latitude = m.results[0].geometry.location.lat;
            Main.school.longitude = m.results[0].geometry.location.lng;


            parentForm = Main;
            this.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);
            InitializeComponent();


            txtLat.Text = Main.school.latitude;
            txtLng.Text = Main.school.longitude;
            txtFilePath.Text = Main.school.ImageFile;
            if(!txtFilePath.Text.Equals(""))
            {
                radioButton2.Checked = true;
                radioButton1.Checked = false;
                pbImage.ImageLocation = txtFilePath.Text;
            }

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            parentForm.school.ImageFile = txtFilePath.Text;
            Setup3 setup3 = new Setup3(parentForm);
            setup3.ShowDialog();

            this.Close();
        }
        
        private void btnPrevious_Click(object sender, EventArgs e)
        {
            Setup1 setup1 = new Setup1(parentForm);
            setup1.ShowDialog();
            this.Close();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            btnBrowse.Enabled = true;
            txtFilePath.Enabled = true;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            btnBrowse.Enabled = false;
            txtFilePath.Enabled = false;
        }

        private void btnBrowse_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog FileBrowser = new OpenFileDialog();

            FileBrowser.InitialDirectory = ".\\";

            if (FileBrowser.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                //Set the SizeMode to center the image. 
                pbImage.SizeMode = PictureBoxSizeMode.CenterImage;
                pbImage.BorderStyle = BorderStyle.Fixed3D;
                pbImage.SizeMode = PictureBoxSizeMode.StretchImage;
                txtFilePath.Text = FileBrowser.FileName;
                pbImage.ImageLocation = FileBrowser.FileName;
            }

        }
    }
    public class GoogleGeoCodeResponse
    {

        public string status { get; set; }
        public results[] results { get; set; }

    }

    public class results
    {
        public string formatted_address { get; set; }
        public geometry geometry { get; set; }
        public string[] types { get; set; }
        public address_component[] address_components { get; set; }
    }

    public class geometry
    {
        public string location_type { get; set; }
        public location location { get; set; }
    }

    public class location
    {
        public string lat { get; set; }
        public string lng { get; set; }
    }

    public class address_component
    {
        public string long_name { get; set; }
        public string short_name { get; set; }
        public string[] types { get; set; }
    }
}