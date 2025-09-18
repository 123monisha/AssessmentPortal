using System;
using System.Data;
using System.Data.SqlClient;
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
    public partial class ChangePassword : Form
    {
        SqlConnection con = new SqlConnection();
        public ChangePassword()
        {
            InitializeComponent();
            con.ConnectionString = ApplicationSettings.ConnectionString;
        }

        private void ChangePassword_Load(object sender, EventArgs e)
        {
            lblUser.Text = User.UserName;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(txtExistingPassword.Text.Trim().Length==0)
            {
                errorProvider1.SetError(txtExistingPassword, "Enter Existing Password");
                return;
            }
            else
            {
                errorProvider1.Clear();
            }
            if (txtNewPassword.Text.Trim().Length == 0)
            {
                errorProvider1.SetError(txtNewPassword, "Enter New Password");
                return;
            }
            else
            {
                errorProvider1.Clear();
            }
            if(!txtConfirmPasssword.Text.Trim().Equals(txtNewPassword.Text.Trim()) || txtConfirmPasssword.Text.Trim().Length==0)
            {
                errorProvider1.SetError(txtConfirmPasssword, "Passwords do not match");
                return;
            }
            else
            {
                errorProvider1.Clear();
            }
            // verify the existing password
            SqlCommand cmdVerify = new SqlCommand("Select password from Users where uid="+User.UserId,con);
            if (con.State == ConnectionState.Closed)
                con.Open();
           string pwdInDb= cmdVerify.ExecuteScalar().ToString();
            cmdVerify.Dispose();
            if(pwdInDb.Equals(txtExistingPassword.Text.Trim()))
            {
                SqlCommand cmdCp = new SqlCommand("Update Users set password=@pwd where uid=@uid",con);
                if (con.State == ConnectionState.Closed)
                    con.Open();
                SqlParameter paramPassword = new SqlParameter("@pwd", SqlDbType.VarChar,40);
                paramPassword.Value = txtNewPassword.Text.Trim();

                SqlParameter paramUid = new SqlParameter("@uid", SqlDbType.Int);
                paramUid.Value = User.UserId;

                cmdCp.Parameters.Add(paramPassword);
                cmdCp.Parameters.Add(paramUid);

                if(cmdCp.ExecuteNonQuery()>0)
                {
                    lblMsg.Text = "Password has been changed";
                    lblMsg.ForeColor = System.Drawing.Color.Green;
                }
                else
                {
                    lblMsg.Text = "Password has Not been changed";
                    lblMsg.ForeColor = System.Drawing.Color.Red;
                }
            }
            else
            {
                lblMsg.Text = "Your existing password is incorrect";
                lblMsg.ForeColor = System.Drawing.Color.Red;
            }
            con.Close();
        }

        private void cancelChangePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdminDashBoard ad = new AdminDashBoard();
            ad.MdiParent = this.MdiParent;
            this.Close();
            ad.Show();         


        }
    }
}
