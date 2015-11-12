using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Finisar.SQLite;
using System.Data;
using System.Net.Mail;
using System.Net;


namespace InSession
{
    class Reports
    {

        public const int TODAY = 0;
        public const int YESTERDAY = -1;
        private static System.Timers.Timer aTimer;

        // We use these three SQLite objects:
        SQLiteConnection sqlite_conn;

        public bool bEnabled = true;
        private DateTime dtToday;

        frmMain parentForm;

        public Reports(frmMain Main)
        {
            parentForm = Main;
            sqlite_conn = new SQLiteConnection("Data Source=database.db;Version=3;Compress=True;");

            aTimer = new System.Timers.Timer(60000);
            aTimer.Start();
            aTimer.Elapsed += OnTimedEvent;

            try
            {
                // open the connection:
                sqlite_conn.Open();
            }
            catch
            {
                Console.WriteLine("Database is unavailable for reports");
                bEnabled = false;
            }
        }
        public string BuildEODAttendenceReport(int iDayOffSet)
        {
            string rString = String.Format("Name and number of classes attended for {0}.\r\n", DateTime.Today.AddDays(iDayOffSet).ToShortDateString());
            SQLiteCommand sqlite_cmd = new SQLiteCommand("SELECT PersonID, COUNT(*) from Attendence Where Date = @Date GROUP BY PersonID ORDER BY PersonID",sqlite_conn);
            sqlite_cmd.Parameters.Add("@Date", SqlDbType.DateTime).Value = DateTime.Now.AddDays(iDayOffSet).ToLongDateString();
            try
            {
                sqlite_cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            SQLiteDataReader sqlite_datareader = sqlite_cmd.ExecuteReader();

            // The SQLiteDataReader allows us to run through the result lines:
            while (sqlite_datareader.Read()) // Read() returns true if there is still a result line to read
            {
                rString += String.Format("{0}, {1}\r\n", GetUserName(Int32.Parse(String.Format("{0}",sqlite_datareader[0])),3), sqlite_datareader[1]);
                //comboGuardians.Items.Add(String.Format("{0}: {1} {2}, {3}", sqlite_datareader2["id"], sqlite_datareader2["stxtFname"], sqlite_datareader2["stxtLname"], sqlite_datareader3["sRelationship"]));
            }
            return rString;
        }
        public string BuildSummaryAttendenceReport(int iDayOffSet)
        {
            string rString = String.Format("Name and number of classes attended for {0}.\r\n", DateTime.Today.AddDays(iDayOffSet).ToShortDateString());
            SQLiteCommand sqlite_cmd = new SQLiteCommand("SELECT PersonID, COUNT(*) from Attendence GROUP BY PersonID ORDER BY PersonID", sqlite_conn);
            try
            {
                sqlite_cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            SQLiteDataReader sqlite_datareader = sqlite_cmd.ExecuteReader();

            // The SQLiteDataReader allows us to run through the result lines:
            while (sqlite_datareader.Read()) // Read() returns true if there is still a result line to read
            {
                rString += String.Format("{0}, {1}\r\n", GetUserName(Int32.Parse(String.Format("{0}", sqlite_datareader[0])), 3), sqlite_datareader[1]);
                //comboGuardians.Items.Add(String.Format("{0}: {1} {2}, {3}", sqlite_datareader2["id"], sqlite_datareader2["stxtFname"], sqlite_datareader2["stxtLname"], sqlite_datareader3["sRelationship"]));
            }
            return rString;
        }

        public string GetUserName(int id,int format)
        {
            string rString = "";

            SQLiteCommand sqlite_cmd2 = new SQLiteCommand("SELECT * FROM People Where id = @id", sqlite_conn);

            sqlite_cmd2.Parameters.Add("@id", SqlDbType.Int).Value = id;
            try
            {
                sqlite_cmd2.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            // Now the SQLiteCommand object can give us a DataReader-Object:
            SQLiteDataReader sqlite_datareader = sqlite_cmd2.ExecuteReader();

            // The SQLiteDataReader allows us to run through the result lines:
            while (sqlite_datareader.Read()) // Read() returns true if there is still a result line to read
            {
                //Console.WriteLine(String.Format("{0}, {1}", sqlite_datareader["stxtLname"], sqlite_datareader["stxtFname"]));
                // 1 = First Name
                // 2 = Last Name
                // 3 = First Last
                // 4 = Last, First
                switch (format)
                {
                    case 1:
                        {
                            rString = String.Format("{0}",sqlite_datareader["stxtfname"]);
                            break;
                        }
                    case 2:
                        {
                            rString = String.Format("{1}",sqlite_datareader["stxtLname"]);
                            break;
                        }
                    case 3:
                        {
                            rString = String.Format("{0} {1}",sqlite_datareader["stxtFname"], sqlite_datareader["stxtLname"]);
                            break;
                        }
                    case 4:
                        {
                            rString = String.Format("{0} {1}",sqlite_datareader["stxtLname"], sqlite_datareader["stxtFname"]);
                            break;
                        }
                    default:
                        {
                            break;
                        }
                }
            }

            return rString;
        }
        private void OnTimedEvent(Object source, System.Timers.ElapsedEventArgs e)
        {
            Console.WriteLine("The Elapsed event was raised at {0}", e.SignalTime);
            Console.WriteLine(BuildEODAttendenceReport(YESTERDAY));
            if (bEnabled && DateTime.Today != dtToday)
            {
                #if DEBUG
                    Console.WriteLine("Skipping main send due to debug level setting.");
                #else
                    sendmail();
                #endif
                dtToday = DateTime.Today;
            }
        }

        public void sendmail()
        {
            // Create a System.Net.Mail.MailMessage object
            MailMessage message = new MailMessage();

            // Add a recipient
            message.To.Add(parentForm.school.email);
            message.To.Add("insessionapp@gmail.com");

            // Add a message subject
            message.Subject = String.Format("InSession Attendence - {0}", DateTime.Now.ToShortDateString());

            // Add a message body
            message.Body = BuildEODAttendenceReport(YESTERDAY);

            // Create a System.Net.Mail.MailAddress object and 
            // set the sender email address and display name.
            message.From = new MailAddress("insessionapp@gmail.com", "InSession App");

            // Create a System.Net.Mail.SmtpClient object
            // and set the SMTP host and port number
            SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);

            // Enable Secure Socket Layer (SSL) for connection encryption
            smtp.EnableSsl = true;

            // Do not send the DefaultCredentials with requests
            smtp.UseDefaultCredentials = false;

            // Create a System.Net.NetworkCredential object and set
            // the username and password required by your SMTP account
            smtp.Credentials = new NetworkCredential("insessionapp@gmail.com", "In5ession");

            // Send the message
            smtp.Send(message);

        }
        public string BuildCustomAttendenceReport(DateTime StartDate,DateTime EndDate)
        {
            string rString = String.Format("Attendence starting from {0}.\r\n", StartDate.ToShortDateString());
            while (StartDate <= EndDate)
            {
                rString += BuildEODAttendenceReport(StartDate.Day - EndDate.Day);
                StartDate = StartDate.AddDays(1);
            }
            return rString;
        }
        public string BuildTotalAttendenceReport()
        {
            string rString = String.Format("Name and number of classes attended.\r\n");
            SQLiteCommand sqlite_cmd = new SQLiteCommand("SELECT PersonID, COUNT(*) from Attendence GROUP BY PersonID ORDER BY PersonID", sqlite_conn);
            try
            {
                sqlite_cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            SQLiteDataReader sqlite_datareader = sqlite_cmd.ExecuteReader();

            // The SQLiteDataReader allows us to run through the result lines:
            while (sqlite_datareader.Read()) // Read() returns true if there is still a result line to read
            {
                rString += String.Format("{0}, {1}\r\n", GetUserName(Int32.Parse(String.Format("{0}", sqlite_datareader[0])), 3), sqlite_datareader[1]);
                //comboGuardians.Items.Add(String.Format("{0}: {1} {2}, {3}", sqlite_datareader2["id"], sqlite_datareader2["stxtFname"], sqlite_datareader2["stxtLname"], sqlite_datareader3["sRelationship"]));
            }
            return rString;
        }
    }
    public static class DateTimeExtensions
    {
        public static DateTime StartOfWeek(this DateTime dt, DayOfWeek startOfWeek)
        {
            int diff = dt.DayOfWeek - startOfWeek;
            if (diff < 0)
            {
                diff += 7;
            }

            return dt.AddDays(-1 * diff).Date;
        }
        public static DateTime StartOfMonth(this DateTime dt)
        {
            dt = new DateTime(dt.Year,dt.Month,1);
            return dt;
        }
    }
}
    
