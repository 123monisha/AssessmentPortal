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
    public partial class StudentDashBoard : Form
    {
        public StudentDashBoard()
        {
            InitializeComponent();
        }

        private void StudentDashBoard_Load(object sender, EventArgs e)
        {
            lblUser.Text = User.UserName;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login l = new Login();
            l.Show();
            this.Close();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ChangePassword cp = new ChangePassword();
            cp.MdiParent = this.MdiParent;
            this.Close();
            cp.Show();
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            TakeExam te = new TakeExam();
            te.MdiParent = this.MdiParent;
            this.Close();
            te.Show();

        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ViewResults vr = new ViewResults();
            vr.MdiParent = this.MdiParent;
            this.Close();
            vr.Show();


        }
    }
}
