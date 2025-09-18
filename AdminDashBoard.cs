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
    public partial class AdminDashBoard : Form
    {
        public AdminDashBoard()
        {
            InitializeComponent();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login l = new Login();
            l.MdiParent = this.MdiParent;
            l.Show();
            User.IsLoggedIn = true;
            this.Close();
        }

        private void AdminDashBoard_Load(object sender, EventArgs e)
        {
            lblUser.Text = User.UserName;
        }

        private void lnkChangePassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ChangePassword cp = new ChangePassword();
            cp.MdiParent = this.MdiParent;
            this.Close();
            cp.Show();

        }

        private void lnkStaffManagement_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Staff st = new Staff();
            st.MdiParent = this.MdiParent;
            this.Close();
            st.Show();
        }

        private void lnkSubjectManagement_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Subject sub = new Subject();
            sub.MdiParent = this.MdiParent;
            this.Close();
            sub.Show();
        }
    }
}
