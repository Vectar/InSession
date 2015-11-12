using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Finisar.SQLite;
using System.Data;
using System.Net.Mail;
using System.Net;

namespace InSession
{
    public partial class frmMain : Form
    {

        // We use these three SQLite objects:
        SQLiteConnection sqlite_conn;
        SQLiteCommand sqlite_cmd;
        SQLiteDataReader sqlite_datareader;

        private string AdminPassword;
        public School school;
        private bool bStayAdmin;
        private bool bIsAdmin;

        private static Reports cReports;
        private string  SoftwareVersion;
        private string DatabaseVersion;


        public frmMain()
        {
            SoftwareVersion = "1.1";
            DatabaseVersion = "1.0";

            school = new School();
            InitDatabase();
            InitializeComponent();
            //Used for when a person wants to remain logged in.
            bStayAdmin = false;
            GetSchool();
            cReports = new Reports(this);
            this.Icon = System.Drawing.Icon.ExtractAssociatedIcon(Application.ExecutablePath);
            lblSchool.Text = String.Format("Welcome to {0}", school.name);
            pbLeft.ImageLocation = school.ImageFile;
            pbRight.ImageLocation = school.ImageFile;
            menuDatabaseVersion.Text = "Database Version : " + DatabaseVersion;
            menuSoftwareVersion.Text = "Software Version : " + SoftwareVersion;

        }
        public void RefreshLogo(string imageFile)
        {
            pbLeft.ImageLocation = imageFile;
            pbRight.ImageLocation = imageFile;
        }
 
        private void InitDatabase()
        {
            // create a new database connection:
            sqlite_conn = new SQLiteConnection("Data Source=database.db;Version=3;Compress=True;");

            try
            {
                // open the connection:
                sqlite_conn.Open();
            }
            catch(Exception e)
            {
                Console.Write(e.ToString());
                sqlite_conn = new SQLiteConnection("Data Source=database.db;Version=3;Compress=True;New=True;");
                sqlite_conn.Open();
            }
            
            
            // create a new SQL command:
            sqlite_cmd = sqlite_conn.CreateCommand();

            if (!TableExists(sqlite_conn, "ProgramConfig"))
            {
                Console.WriteLine("New Install Detected, prompt for school info.");
                //Create the table.
                // Let the SQLiteCommand object know our SQL-Query:
                sqlite_cmd.CommandText = @"CREATE TABLE ProgramConfig (
                        id integer primary key, 
                        sPassword varchar(20),
                        sEmail varchar(40),
                        sSchoolName varchar(50),
                        sAddress varchar(40),
                        sCity varchar(20),
                        sState varchar(20),
                        sZip varchar(20),
                        sLatitude varchar(20),
                        sLongitude varchar(20),
                        sImageFile varchar(80),
                        sDatabaseVersion varchar(10)
                        );";

                // Now lets execute the SQL ;D
                sqlite_cmd.ExecuteNonQuery();

                Form newForm = new Setup1(this);
                newForm.ShowDialog();

                // Let the SQLiteCommand object know our SQL-Query:
                sqlite_cmd.CommandText = @"CREATE TABLE People (
                id integer primary key, 
                stxtFname varchar(20),
                stxtLname varchar(20),
                stxtPhone varchar(20),
                stxtAddress varchar(40),
                stxtCity varchar(20),
                stxtState varchar(20),
                stxtZip varchar(20)
                );";

                // Now lets execute the SQL ;D
                sqlite_cmd.ExecuteNonQuery();


                // Let the SQLiteCommand object know our SQL-Query:
                sqlite_cmd.CommandText = @"CREATE TABLE Ranks (
                id integer primary key, 
                sTitle varchar(20),
                sColor varchar(20),
                iPointsRequirement integer,
                iTimeRequirementInDays integer,
                sPathToImageFile varchar(60)
                );";

                // Now lets execute the SQL ;D
                sqlite_cmd.ExecuteNonQuery();

                // Let the SQLiteCommand object know our SQL-Query:
                sqlite_cmd.CommandText = @"CREATE TABLE Students (
                id integer primary key, 
                iPerson integer,
                iRank integer
                );";

                // Now lets execute the SQL ;D
                sqlite_cmd.ExecuteNonQuery();

                // Let the SQLiteCommand object know our SQL-Query:
                sqlite_cmd.CommandText = @"CREATE TABLE EmergencyContacts (
                id integer primary key, 
                iStudent int,
                iPerson int,
                sRelationship varchar(20)
                );";

                // Now lets execute the SQL ;D
                sqlite_cmd.ExecuteNonQuery();

                // Let the SQLiteCommand object know our SQL-Query:
                sqlite_cmd.CommandText = @"CREATE TABLE Guardians (
                id integer primary key, 
                iStudent int,
                iPerson int,
                sRelationship varchar(20)
                );";

                // Now lets execute the SQL ;D
                sqlite_cmd.ExecuteNonQuery();

                // Let the SQLiteCommand object know our SQL-Query:
                sqlite_cmd.CommandText = @"CREATE TABLE Class_Sessions (
                class_id integer primary key, 
                class_ud integer,
                class_name varchar(20),
                freq_type integer,
                freq_interval integer,
                freq_relative integer,
                active_start_date integer,
                active_end_date integer,
                active_start_time integer,
                active_end_time integer,
                date_created datetime,
                date_modified datetime,
                bIsKids boolean,
                bIsClosed boolean
                );";

                // Now lets execute the SQL ;D
                sqlite_cmd.ExecuteNonQuery();

                sqlite_cmd.CommandText = @"CREATE TABLE Attendence 
                (
                    id integer primary key,
                    PersonID integer,
                    Date varchar(25),
                    ClassID integer
                );";
                // Now lets execute the SQL ;D
                sqlite_cmd.ExecuteNonQuery();
            }
        }
        bool TableExists(SQLiteConnection db, String tableName)
        {
            bool bReturn = false;
            //Query to see if we have our program config data
            try
            {
                sqlite_cmd.CommandText = "SELECT count(*) FROM 'ProgramConfig'";
                // Now lets execute the SQL, if this does not error the table already exists, if it does we create it in the catch
                sqlite_cmd.ExecuteNonQuery();

                bReturn = true;
                Console.WriteLine("InSession has been initialized");
            }
            catch (SQLiteException e)
            {
                Console.WriteLine("Database not found. {0}", e.ToString());
            }
            return bReturn;
        }
        private void Menu_Click(object sender, EventArgs e)
        {
            MainMenu.Show(this, MousePosition.X - (MousePosition.X - pbMenu.Location.X) - MainMenu.Width, MousePosition.Y - (MousePosition.Y - pbMenu.Location.Y));
        }
        private void bOne_Click(object sender, EventArgs e)
        {
            txtID.Text += 1;
        }
        private void bTwo_Click(object sender, EventArgs e)
        {
            txtID.Text += 2;
        }
        private void bThree_Click(object sender, EventArgs e)
        {
            txtID.Text += 3;
        }
        private void bFour_Click(object sender, EventArgs e)
        {
            txtID.Text += 4;
        }
        private void bFive_Click(object sender, EventArgs e)
        {
            txtID.Text += 5;
        }
        private void bSix_Click(object sender, EventArgs e)
        {
            txtID.Text += 6;
        }
        private void bSeven_Click(object sender, EventArgs e)
        {
            txtID.Text += 7;
        }
        private void bEight_Click(object sender, EventArgs e)
        {
            txtID.Text += 8;
        }
        private void bNine_Click(object sender, EventArgs e)
        {
            txtID.Text += 9;
        }
        private void bZero_Click(object sender, EventArgs e)
        {
            txtID.Text += 0;
        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            if (txtID.Text.Length > 0)
            {
                txtID.Text = txtID.Text.Substring(0, txtID.Text.Length - 1);
            }
        }
        private void MenuEditPeople_Click(object sender, EventArgs e)
        {
            if (!bIsAdmin)
            {
                Form fPassword = new PasswordPrompt(this);
                fPassword.ShowDialog(this);
            }

            if (bIsAdmin || CheckPassword())
            {
                bIsAdmin = bStayAdmin;
                Form fPeople = new PeopleManagement(sqlite_conn);
                fPeople.Show();
            }
            else
            {
                MessageBox.Show("Invalid password.");
            }
        }
        private void MenuEditClasses_Click(object sender, EventArgs e)
        {
            if (!bIsAdmin)
            {
                Form fPassword = new PasswordPrompt(this);
                fPassword.ShowDialog(this);
            }
            if (bIsAdmin || CheckPassword())
            {
                bIsAdmin = bStayAdmin;
                Form fClasses = new ClassManagement(sqlite_conn, sqlite_cmd);
                fClasses.Show();
            }
            else
            {
                MessageBox.Show("Invalid password.");
            }
        }
        private void MenuEditRanks_Click(object sender, EventArgs e)
        {
            if (!bIsAdmin)
            {
                Form fPassword = new PasswordPrompt(this);
                fPassword.ShowDialog(this);
            }
            if (bIsAdmin || CheckPassword())
            {
                bIsAdmin = bStayAdmin;
                Form fRanks = new RankManagement(sqlite_conn, sqlite_cmd);
                fRanks.Show();
            }
            else
            {
                MessageBox.Show("Invalid password.");
            }
        }
        private void menuEditOptions_Click(object sender, EventArgs e)
        {
            if (!bIsAdmin)
            {
                bIsAdmin = bStayAdmin;
                Form fPassword = new PasswordPrompt(this);
                fPassword.ShowDialog(this);
            }
            if (bIsAdmin || CheckPassword())
            {
                Form fOptions = new OptionsManagement(sqlite_conn, sqlite_cmd);
                fOptions.Show();
            }
            else
            {
                MessageBox.Show("Invalid password.");
            }
        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
        public void SetPassword(string sNewPassword)
        {
            AdminPassword = sNewPassword;
        }
        public void SetStayAdmin(bool bValue)
        {
            bStayAdmin = bValue;
        }
        private bool CheckPassword()
        {
            #if DEBUG
                return true;
            #else
                return AdminPassword == school.password ? true : false;
            #endif
        }
        private void txtID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                SQLiteCommand sqlite_cmd = new SQLiteCommand("SELECT * FROM People Where id = @id", sqlite_conn);
                int iUserID;
                bool Success = false;
                if (Int32.TryParse(txtID.Text, out iUserID))
                {
                    Success = ProcessRegistration(iUserID);
                }
                else
                {
                    MessageBox.Show("IDs should be numbers only, please try again.");
                }
                txtID.Text = "";
            }
        }
        private void bRegister_Click(object sender, EventArgs e)
        {
            int iUserID;
            bool Success = false;
            if (Int32.TryParse(txtID.Text, out iUserID))
            {
                Success = ProcessRegistration(iUserID);
            }
            else
            {
                MessageBox.Show("Please verify your ID and try again.");
            }
            txtID.Text = "";
        }
        private void attendenceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReportDisplay rd = new ReportDisplay(cReports.BuildEODAttendenceReport(Reports.TODAY));
            rd.Show();
        }
        private bool ProcessRegistration(int iUserID)
        {
            SQLiteCommand sqlite_cmd = new SQLiteCommand("SELECT * FROM People Where id = @id", sqlite_conn);
            bool bReturn = false;
            DateTime dtToday = DateTime.Now;
            sqlite_cmd.Parameters.Add("@id", SqlDbType.Int).Value = iUserID;
            // Now the SQLiteCommand object can give us a DataReader-Object:
            sqlite_datareader = sqlite_cmd.ExecuteReader();
            string fName = "";
            string lName = "";
            bool bFound = false;
            // The SQLiteDataReader allows us to run through the result lines:
            while (sqlite_datareader.Read()) // Read() returns true if there is still a result line to read
            {
                lName = String.Format("{0}", sqlite_datareader["stxtLname"]);
                fName = String.Format("{0}", sqlite_datareader["stxtFname"]);
                bFound = true;
            }
            if (bFound)
            {
                DialogResult result1 = MessageBox.Show(String.Format("Hello {0} {1}, If you are checking in for class click yes.", fName, lName), "Confirm registration", MessageBoxButtons.YesNo);
                if (result1 == DialogResult.Yes)
                {
                    sqlite_cmd = new SQLiteCommand("INSERT INTO Attendence (id,PersonID,Date,ClassID) VALUES (@id,@UserID,@today,@ClassID)", sqlite_conn);
                    sqlite_cmd.Parameters.Add("@id", SqlDbType.Int).Value = null;
                    sqlite_cmd.Parameters.Add("@UserID", SqlDbType.Int).Value = iUserID;
                    sqlite_cmd.Parameters.Add("@today", SqlDbType.Text).Value = dtToday.ToLongDateString();
                    sqlite_cmd.Parameters.Add("@ClassID", SqlDbType.Int).Value = 0;
                    try
                    {
                        sqlite_cmd.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        throw new Exception(ex.Message);
                    }
                    bReturn = true;
                    MessageBox.Show("You are registered for class.");
                    
                }
            }
            else
            {
                MessageBox.Show("ID was not found, please confirm your ID with the admins.");
            }
            return bReturn;
        }
        private void WeeklyAttendence_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(cReports.BuildCustomAttendenceReport(DateTime.Now.StartOfWeek(DayOfWeek.Sunday),DateTime.Now));
            ReportDisplay rd = new ReportDisplay(cReports.BuildCustomAttendenceReport(DateTime.Now.StartOfWeek(DayOfWeek.Sunday), DateTime.Now));
            rd.Show();
        }
        private void MonthlyAttendence_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(cReports.BuildCustomAttendenceReport(DateTime.Now.StartOfMonth(), DateTime.Now));
            ReportDisplay rd = new ReportDisplay(cReports.BuildCustomAttendenceReport(DateTime.Now.StartOfMonth(), DateTime.Now));
            rd.Show();
        }
        private void editSetupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form setup = new Setup1(this);
            setup.ShowDialog();

        }
        public bool GetSchool()
        {
            bool bReturn = false;
            sqlite_cmd = new SQLiteCommand("Select * from ProgramConfig where id = 1", sqlite_conn);
            // Now the SQLiteCommand object can give us a DataReader-Object:
            sqlite_datareader = sqlite_cmd.ExecuteReader();
            // The SQLiteDataReader allows us to run through the result lines:
            while (sqlite_datareader.Read()) // Read() returns true if there is still a result line to read
            {
                Console.WriteLine(sqlite_datareader["sLatitude"].ToString());
                school = new School(sqlite_datareader["sPassword"].ToString(), sqlite_datareader["sEmail"].ToString(), sqlite_datareader["sSchoolName"].ToString(),
                    sqlite_datareader["sAddress"].ToString(), sqlite_datareader["sCity"].ToString(), sqlite_datareader["sState"].ToString(), sqlite_datareader["sZip"].ToString(),
                    sqlite_datareader["sLatitude"].ToString(), sqlite_datareader["sLongitude"].ToString(), sqlite_datareader["sImageFile"].ToString());
                try
                {
                    string sExistingDatabaseVersion = sqlite_datareader["sDatabaseVersion"].ToString();
                    if(OldDBVersion(sExistingDatabaseVersion,DatabaseVersion))
                    {
                        UpgradeDB(sExistingDatabaseVersion, DatabaseVersion);
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.ToString());
                    Console.WriteLine("No database version available.  Need to upgrade to DB Version 1.0 after backing things up.");
                }
                bReturn = true;
            }
            return bReturn;
        }
        private void summaryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(cReports.BuildTotalAttendenceReport());
            ReportDisplay rd = new ReportDisplay(cReports.BuildTotalAttendenceReport());
            rd.Show();
        }
        private bool OldDBVersion(string ExistingDBVersion, string CurrentDBVersion)
        {
            bool bReturn = false;
            string[] MajorMinExistingDB = ExistingDBVersion.Split('.');
            string[] MajorMinMostRecent = CurrentDBVersion.Split('.');
            if (Int32.Parse(MajorMinExistingDB[0]) < Int32.Parse(MajorMinMostRecent[0]))
            {
                bReturn = true;
            }
            else if (Int32.Parse(MajorMinExistingDB[0]) == Int32.Parse(MajorMinMostRecent[0])
                && Int32.Parse(MajorMinExistingDB[1]) < Int32.Parse(MajorMinMostRecent[1]))
            {
                bReturn = true;
            }
            return bReturn;
        }
        private void UpgradeDB(string currentDBVersion, string newDBVersion)
        {
            if(currentDBVersion.Equals("1.0"))
            {
                Console.WriteLine("This is where the next table changes need to happen.");
                currentDBVersion = "1.1";
            }

        }
    }
}

