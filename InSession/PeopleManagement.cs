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
    public partial class PeopleManagement : Form
    {
        //Variables for helping to get the 
        int EMERGENCY_ASSOCIATION_REQUEST = 1;
        int GUARDIAN_ASSOCIATION_REQUEST = 2;

        int iUser;
        string sRelationship;

        SQLiteConnection sqlite_conn;
        SQLiteDataReader sqlite_datareader;
        public PeopleManagement(SQLiteConnection rhs_sqllite_conn)
        {
            InitializeComponent();
            sqlite_conn = rhs_sqllite_conn;
            LoadUserSelect();

        }

        private void btnAddPerson_Click(object sender, EventArgs e)
        {
            SQLiteCommand insertSQL = new SQLiteCommand(@"INSERT INTO People (
                id,stxtFname,stxtLname,stxtPhone,
                stxtAddress,stxtCity,stxtState,stxtZip) VALUES 
                (@id,@stxtFname,@stxtLname,@stxtPhone,@stxtAddress,@stxtCity,
                @stxtState, @stxtZip)", sqlite_conn);
            //SQLiteCommand test = new SQLiteCommand("")
            insertSQL.Parameters.Add("@id", SqlDbType.Int).Value = null;
            insertSQL.Parameters.Add("@stxtFname", SqlDbType.Text).Value = txtEditFName.Text;
            insertSQL.Parameters.Add("@stxtLname", SqlDbType.Text).Value = txtEditLName.Text;
            insertSQL.Parameters.Add("@stxtPhone", SqlDbType.Text).Value = txtEditPhone.Text;
            insertSQL.Parameters.Add("@stxtAddress", SqlDbType.Text).Value = txtEditAddress.Text;
            insertSQL.Parameters.Add("@stxtCity", SqlDbType.Text).Value = txtEditCity.Text;
            insertSQL.Parameters.Add("@stxtState", SqlDbType.Text).Value = txtEditState.Text;
            insertSQL.Parameters.Add("@stxtZip", SqlDbType.Text).Value = txtEditZip.Text;
            insertSQL.CommandType = CommandType.Text;
            try
            {
                insertSQL.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            LoadUserSelect();
        }

        private void btnEditPerson_Click(object sender, EventArgs e)
        {
            SQLiteCommand updateSQL = new SQLiteCommand("UPDATE People set stxtFname=@stxtFname,stxtLname = @stxtLName, stxtPhone=@stxtPhone, stxtAddress=@stxtAddress,stxtCity=@stxtCity,stxtState=@stxtState,stxtZip=@stxtZip Where id=@id", sqlite_conn);
            //,stxtLname,stxtPhone,stxtAddress,stxtCity,stxtState,stxtZip Where id = $) VALUES (@id,@stxtFname,@stxtLname,@stxtPhone,@stxtAddress,@stxtCity,@stxtState, @stxtZip)", sqlite_conn);
            
            int iUserID = Int32.Parse(txtID.Text);

            updateSQL.Parameters.Add("@id", SqlDbType.Int).Value = iUserID;
            updateSQL.Parameters.Add("@stxtFname", SqlDbType.Text).Value = txtEditFName.Text;
            updateSQL.Parameters.Add("@stxtLname", SqlDbType.Text).Value = txtEditLName.Text;
            updateSQL.Parameters.Add("@stxtPhone", SqlDbType.Text).Value = txtEditPhone.Text;
            updateSQL.Parameters.Add("@stxtAddress", SqlDbType.Text).Value = txtEditAddress.Text;
            updateSQL.Parameters.Add("@stxtCity", SqlDbType.Text).Value = txtEditCity.Text;
            updateSQL.Parameters.Add("@stxtState", SqlDbType.Text).Value = txtEditState.Text;
            updateSQL.Parameters.Add("@stxtZip", SqlDbType.Text).Value = txtEditZip.Text;
            updateSQL.CommandType = CommandType.Text;
            try
            {
                updateSQL.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            LoadUserSelect();
        }

        private void btnDeletePerson_Click(object sender, EventArgs e)
        {
            int iUserID = Int32.Parse(txtID.Text);
            SQLiteCommand deleteSQL = new SQLiteCommand("Delete from People WHERE id=@id", sqlite_conn);
            deleteSQL.Parameters.Add("@id", SqlDbType.Int).Value = iUserID;
            try
            {
                deleteSQL.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            LoadUserSelect();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboUserSelect_SelectedIndexChanged(object sender, EventArgs e)
        {

            SQLiteCommand sqlite_cmd = new SQLiteCommand("SELECT * FROM People Where id = @id", sqlite_conn);
            string[] SelectedUser = comboUserSelect.SelectedItem.ToString().Split(':');
            int iUserID = Int32.Parse(SelectedUser[0]);

            sqlite_cmd.Parameters.Add("@id", SqlDbType.Int).Value = iUserID;
            // Now the SQLiteCommand object can give us a DataReader-Object:
            sqlite_datareader = sqlite_cmd.ExecuteReader();

            // The SQLiteDataReader allows us to run through the result lines:
            while (sqlite_datareader.Read()) // Read() returns true if there is still a result line to read
            {
                txtID.Text = String.Format("{0}", sqlite_datareader["id"]);
                txtEditLName.Text = String.Format("{0}",sqlite_datareader["stxtLname"]);
                txtEditFName.Text = String.Format("{0}", sqlite_datareader["stxtFname"]);
                txtEditAddress.Text = String.Format("{0}", sqlite_datareader["stxtAddress"]);
                txtEditCity.Text = String.Format("{0}", sqlite_datareader["stxtCity"]);
                txtEditState.Text = String.Format("{0}", sqlite_datareader["stxtState"]);
                txtEditZip.Text = String.Format("{0}", sqlite_datareader["stxtZip"]);
            }

            LoadEContacts();
            LoadGuardians();
        }
        void LoadUserSelect()
        {
            comboUserSelect.Items.Clear();
            SQLiteCommand sqlite_cmd = new SQLiteCommand("SELECT * FROM People", sqlite_conn);

            // Now the SQLiteCommand object can give us a DataReader-Object:
            sqlite_datareader = sqlite_cmd.ExecuteReader();

            // The SQLiteDataReader allows us to run through the result lines:
            while (sqlite_datareader.Read()) // Read() returns true if there is still a result line to read
            {
                //Console.WriteLine(String.Format("{0}, {1}", sqlite_datareader["stxtLname"], sqlite_datareader["stxtFname"]));
                comboUserSelect.Items.Add(String.Format("{0}: {1}, {2}", sqlite_datareader["id"], sqlite_datareader["stxtLname"], sqlite_datareader["stxtFname"]));
            }
        }

        private void btnAddEmergencyContact_Click(object sender, EventArgs e)
        {
            SearchForUser GetContact = new SearchForUser(EMERGENCY_ASSOCIATION_REQUEST, this, sqlite_conn);
            GetContact.ShowDialog();
            Console.Write("{0}{1}", iUser, sRelationship);
            SQLiteCommand sqlite_cmd = new SQLiteCommand("INSERT INTO EmergencyContacts (id,iStudent,iPerson,sRelationship) VALUES (@id,@iStudent,@iPerson,@sRelationship)", sqlite_conn);
            sqlite_cmd.Parameters.Add("@id", SqlDbType.Int).Value = null;
            sqlite_cmd.Parameters.Add("@iStudent", SqlDbType.Int).Value = Int32.Parse(txtID.Text);
            sqlite_cmd.Parameters.Add("@iPerson", SqlDbType.Int).Value = iUser;
            sqlite_cmd.Parameters.Add("@sRelationship", SqlDbType.Text).Value = sRelationship;
            try
            {
                sqlite_cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            LoadEContacts();
        }
        private void btnAddGuardian_Click(object sender, EventArgs e)
        {
            SearchForUser GetContact = new SearchForUser(GUARDIAN_ASSOCIATION_REQUEST, this, sqlite_conn);
            GetContact.ShowDialog();
            Console.Write("{0}{1}", iUser, sRelationship);
            SQLiteCommand sqlite_cmd = new SQLiteCommand("INSERT INTO Guardians (id,iStudent,iPerson,sRelationship) VALUES (@id,@iStudent,@iPerson,@sRelationship)", sqlite_conn);
            sqlite_cmd.Parameters.Add("@id", SqlDbType.Int).Value = null;
            sqlite_cmd.Parameters.Add("@iStudent", SqlDbType.Int).Value = Int32.Parse(txtID.Text);
            sqlite_cmd.Parameters.Add("@iPerson", SqlDbType.Int).Value = iUser;
            sqlite_cmd.Parameters.Add("@sRelationship", SqlDbType.Text).Value = sRelationship;
            try
            {
                sqlite_cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            LoadGuardians();
        }
        public void SetUser(int value)
        {
            iUser = value;
        }
        public void SetRelation(string value)
        {
            sRelationship = value;
        }
        void LoadEContacts()
        {
            comboEmergencyContact.Items.Clear();
            SQLiteCommand sqlite_cmd3 = new SQLiteCommand("SELECT * FROM EmergencyContacts Where iStudent=@iStudent", sqlite_conn);
            sqlite_cmd3.Parameters.Add("@iStudent", SqlDbType.Int).Value = Int32.Parse(txtID.Text);
            try
            {
                sqlite_cmd3.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            // Now the SQLiteCommand object can give us a DataReader-Object:
            SQLiteDataReader sqlite_datareader3 = sqlite_cmd3.ExecuteReader();

            // The SQLiteDataReader allows us to run through the result lines:
            while (sqlite_datareader3.Read()) // Read() returns true if there is still a result line to read
            {


                SQLiteCommand sqlite_cmd2 = new SQLiteCommand("SELECT * FROM People Where id = @id", sqlite_conn);
                string[] SelectedUser = comboUserSelect.SelectedItem.ToString().Split(':');
                int iUserID = Int32.Parse(SelectedUser[0]);

                sqlite_cmd2.Parameters.Add("@id", SqlDbType.Int).Value = sqlite_datareader3["iPerson"];
                try
                {
                    sqlite_cmd2.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
                // Now the SQLiteCommand object can give us a DataReader-Object:
                SQLiteDataReader sqlite_datareader2= sqlite_cmd2.ExecuteReader();

                // The SQLiteDataReader allows us to run through the result lines:
                while (sqlite_datareader2.Read()) // Read() returns true if there is still a result line to read
                {
                    //Console.WriteLine(String.Format("{0}, {1}", sqlite_datareader["stxtLname"], sqlite_datareader["stxtFname"]));
                    comboEmergencyContact.Items.Add(String.Format("{0}: {1} {2}, {3}", sqlite_datareader2["id"], sqlite_datareader2["stxtFname"], sqlite_datareader2["stxtLname"], sqlite_datareader3["sRelationship"]));
                }
            }
        }

        void LoadGuardians()
        {
            comboGuardians.Items.Clear();
            SQLiteCommand sqlite_cmd3 = new SQLiteCommand("SELECT * FROM Guardians Where iStudent=@iStudent", sqlite_conn);
            sqlite_cmd3.Parameters.Add("@iStudent", SqlDbType.Int).Value = Int32.Parse(txtID.Text);
            try
            {
                sqlite_cmd3.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            // Now the SQLiteCommand object can give us a DataReader-Object:
            SQLiteDataReader sqlite_datareader3 = sqlite_cmd3.ExecuteReader();

            // The SQLiteDataReader allows us to run through the result lines:
            while (sqlite_datareader3.Read()) // Read() returns true if there is still a result line to read
            {


                SQLiteCommand sqlite_cmd2 = new SQLiteCommand("SELECT * FROM People Where id = @id", sqlite_conn);
                string[] SelectedUser = comboUserSelect.SelectedItem.ToString().Split(':');
                int iUserID = Int32.Parse(SelectedUser[0]);

                sqlite_cmd2.Parameters.Add("@id", SqlDbType.Int).Value = sqlite_datareader3["iPerson"];
                try
                {
                    sqlite_cmd2.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
                // Now the SQLiteCommand object can give us a DataReader-Object:
                SQLiteDataReader sqlite_datareader2 = sqlite_cmd2.ExecuteReader();

                // The SQLiteDataReader allows us to run through the result lines:
                while (sqlite_datareader2.Read()) // Read() returns true if there is still a result line to read
                {
                    //Console.WriteLine(String.Format("{0}, {1}", sqlite_datareader["stxtLname"], sqlite_datareader["stxtFname"]));
                    comboGuardians.Items.Add(String.Format("{0}: {1} {2}, {3}", sqlite_datareader2["id"], sqlite_datareader2["stxtFname"], sqlite_datareader2["stxtLname"], sqlite_datareader3["sRelationship"]));
                }
            }
        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {
            if (txtID.Text != "")
            {
                LoadEContacts();
            }
        }
    }
}
