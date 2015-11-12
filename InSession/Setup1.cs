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
    public partial class Setup1: Form
    {
        SQLiteConnection sqlite_conn;
        bool Password_Validated = true;
        bool Email_Validated = true;
        frmMain parentForm;
        public Setup1(frmMain Main)
        {
            parentForm = Main;
            this.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);
            InitializeComponent();
            sqlite_conn = sqlite_conn = new SQLiteConnection("Data Source=database.db;Version=3;Compress=True;");
            txtPassword.Text = parentForm.school.password;
            txtPassConfirm.Text = parentForm.school.password;
            txtAdminEmail.Text= parentForm.school.email;
            txtSchoolName.Text= parentForm.school.name;
            txtAddress.Text= parentForm.school.address;
            txtCity.Text= parentForm.school.city;
            txtState.Text= parentForm.school.state;
            txtZip.Text= parentForm.school.zip;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (txtPassword.Text.Length == 0)
            {
                lblPass.ForeColor = System.Drawing.Color.Red;
                lblPass.Text = "A password is required.";
            }
            if (txtAdminEmail.Text.Length == 0)
            {
                lblEmailVerify.ForeColor = System.Drawing.Color.Red;
                lblEmailVerify.Text = "An email is required.";
            }
            if (Password_Validated && Email_Validated)
            {
                //Get this forms data saved to our school variable.
                parentForm.school.password = txtPassword.Text;
                parentForm.school.email = txtAdminEmail.Text;
                parentForm.school.name = txtSchoolName.Text;
                parentForm.school.address = txtAddress.Text;
                parentForm.school.city = txtCity.Text;
                parentForm.school.state = txtState.Text;
                parentForm.school.zip = txtZip.Text;

                Setup2 setup2 = new Setup2(parentForm);
                setup2.ShowDialog();
                this.Close();
            }
        }


        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            if(txtPassword.Text == txtPassConfirm.Text)
            {
                lblPass.ForeColor = System.Drawing.Color.Green;
                lblPass.Text = "Passwords match.";
                Password_Validated = true;

            }
            else
            {
                lblPass.ForeColor = System.Drawing.Color.Red;
                lblPass.Text = "Passwords do not match.";
                Password_Validated = false;
            }
        }
        private void txtPassConfirm_TextChanged(object sender, EventArgs e)
        {
            if (txtPassword.Text == txtPassConfirm.Text)
            {
                lblPass.ForeColor = System.Drawing.Color.Green;
                lblPass.Text = "Passwords match.";
                Password_Validated = true;
            }
            else
            {
                lblPass.ForeColor = System.Drawing.Color.Red;
                lblPass.Text = "Passwords do not match.";
                Password_Validated = false;
            }
        }

        private void txtAdminEmail_LostFocus(object sender, EventArgs e)
        {
            RegexUtilities test = new RegexUtilities();
            if(test.IsValidEmail(txtAdminEmail.Text))
            {
                lblEmailVerify.ForeColor = System.Drawing.Color.Green;
                lblEmailVerify.Text = "Email accepted.";
                Email_Validated = true;
            }
            else
            {
                lblEmailVerify.ForeColor = System.Drawing.Color.Red;
                lblEmailVerify.Text = "A valid email is required";
                Email_Validated = false;
            }
        }

        private void btnExitSetup_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
