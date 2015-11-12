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
    public partial class ClassManagement : Form
    {
        SQLiteCommand sqlite_cmd;
        SQLiteConnection sqlite_conn;
        public ClassManagement(SQLiteConnection sqllite_conn, SQLiteCommand sqllite_cmd)
        {
            InitializeComponent();
            sqlite_conn = sqllite_conn;
            sqlite_cmd = sqllite_cmd;
        }
    }
}
