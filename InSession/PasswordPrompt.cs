using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InSession
{
    public partial class PasswordPrompt : Form
    {
        frmMain parent;
        public PasswordPrompt(frmMain fParent)
        {
            InitializeComponent();
            parent = fParent;
        }

        private void bSubmit_Click(object sender, EventArgs e)
        {
            parent.SetPassword(txtPassword.Text);
            parent.SetStayAdmin(chxStayAdmin.Checked);
            this.Close();
        }

        private void bCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
