using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Finisar.SQLite;

namespace InSession
{
    public partial class Setup3 : Form
    {
        frmMain parentForm;
        SQLiteConnection sqlite_conn;
        public Setup3(frmMain Main)
        {
            parentForm = Main;
            this.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            // Let the SQLiteCommand object know our SQL-Query:
            sqlite_conn = new SQLiteConnection("Data Source=database.db;Version=3;Compress=True;");
            sqlite_conn.Open();
            //UPDATE People set stxtFname=@stxtFname,stxtLname = @stxtLName, 
            SQLiteCommand sqlite_cmd = new SQLiteCommand(@"Update ProgramConfig Set sPassword = @password, sEmail = @email, sSchoolName = @name,
                            sAddress = @address, sCity = @city, sState = @state, sZip = @zip, sLatitude = @latitude,
                            sLongitude = @longitude, sImageFile = @ImageFile Where id = 1", sqlite_conn);
            
            sqlite_cmd.Parameters.Add("@password", SqlDbType.Text).Value = parentForm.school.password;
            sqlite_cmd.Parameters.Add("@email", SqlDbType.Text).Value = parentForm.school.email;
            sqlite_cmd.Parameters.Add("@name", SqlDbType.Text).Value = parentForm.school.name;
            sqlite_cmd.Parameters.Add("@address", SqlDbType.Text).Value = parentForm.school.address;
            sqlite_cmd.Parameters.Add("@city", SqlDbType.Text).Value = parentForm.school.city;
            sqlite_cmd.Parameters.Add("@state", SqlDbType.Text).Value = parentForm.school.state;
            sqlite_cmd.Parameters.Add("@zip", SqlDbType.Text).Value = parentForm.school.zip;
            sqlite_cmd.Parameters.Add("@latitude", SqlDbType.Text).Value = parentForm.school.latitude;
            sqlite_cmd.Parameters.Add("@longitude", SqlDbType.Text).Value = parentForm.school.longitude;
            sqlite_cmd.Parameters.Add("@ImageFile", SqlDbType.Text).Value = parentForm.school.ImageFile;
            sqlite_cmd.CommandType = CommandType.Text;
            
            try
            {
                int i = sqlite_cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            parentForm.RefreshLogo(parentForm.school.ImageFile);
            this.Close();
        }

        private void btnPrevious_Click_1(object sender, EventArgs e)
        {
            Setup2 setup2 = new Setup2(parentForm);
            setup2.ShowDialog();
            this.Close();
        }
    }
}
