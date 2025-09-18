using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AssessmentPortal
{
    public partial class StaffDashBoard : Form
    {
        public StaffDashBoard()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ChangePassword cp = new ChangePassword();
            cp.MdiParent = this.MdiParent;
            this.Close();
            cp.Show();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            QuetionBankManagement qm = new QuetionBankManagement();
            qm.MdiParent = this.MdiParent;
            this.Close();
            qm.Show();
        }

        private void StaffDashBoard_Load(object sender, EventArgs e)
        {
            lblUser.Text = User.UserName;
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
         
            Login l = new Login();
            l.MdiParent = this.MdiParent;
            l.Show();
            User.IsLoggedIn = true;
            this.Close();
        }
    }
}
