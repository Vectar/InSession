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
    public partial class SearchForUser : Form
    {
        SQLiteConnection sqlite_conn;
        SQLiteDataReader sqlite_datareader;
        PeopleManagement frmParent;

        string[] SelectedUser;

        public SearchForUser(int iRequestType, PeopleManagement parent, SQLiteConnection sql_conn)
        {
            InitializeComponent();
            sqlite_conn = sql_conn;
            LoadUserSelect();
            frmParent = parent;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            frmParent.SetUser(Int32.Parse(SelectedUser[0]));
            frmParent.SetRelation(txtRelationship.Text);
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        void LoadUserSelect()
        {
            comboUser.Items.Clear();
            SQLiteCommand sqlite_cmd = new SQLiteCommand("SELECT * FROM People", sqlite_conn);

            // Now the SQLiteCommand object can give us a DataReader-Object:
            sqlite_datareader = sqlite_cmd.ExecuteReader();

            // The SQLiteDataReader allows us to run through the result lines:
            while (sqlite_datareader.Read()) // Read() returns true if there is still a result line to read
            {
                //Console.WriteLine(String.Format("{0}, {1}", sqlite_datareader["stxtLname"], sqlite_datareader["stxtFname"]));
                comboUser.Items.Add(String.Format("{0}: {1}, {2}", sqlite_datareader["id"], sqlite_datareader["stxtLname"], sqlite_datareader["stxtFname"]));
            }
        }

        private void comboUser_SelectedIndexChanged(object sender, EventArgs e)
        {
            SQLiteCommand sqlite_cmd = new SQLiteCommand("SELECT * FROM People Where id = @id", sqlite_conn);
            SelectedUser = comboUser.SelectedItem.ToString().Split(':');

        }
    }
}
