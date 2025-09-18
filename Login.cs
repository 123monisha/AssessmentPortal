using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AssessmentPortal
{
    public partial class Login : Form
    {
        SqlConnection con = new SqlConnection();
        public Login()
        {
            InitializeComponent();
            con.ConnectionString = ApplicationSettings.ConnectionString;
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            User.IsLoggedIn = false;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(txtEmail.Text.Trim().Length==0)
            {
                errorProvider1.SetError(txtEmail, "Enter Email");
                return;
            }
            else
            {
                errorProvider1.Clear();
            }

            if(txtPassword.Text.Trim().Length==0)
            {
                errorProvider1.SetError(txtPassword, "Enter Password");
                return;
            }
            else
            {
                errorProvider1.Clear();

            }
            if (con.State == ConnectionState.Closed)
                con.Open();
            SqlCommand cmd = new SqlCommand("select uid, name, password, role from Users where email=@email",con);
            SqlParameter paramEmail = new SqlParameter("@email", SqlDbType.VarChar, 40);
            paramEmail.Value = txtEmail.Text.Trim();
            cmd.Parameters.Add(paramEmail);

           SqlDataReader dr= cmd.ExecuteReader();
            if(dr.HasRows)
            {
                dr.Read();
                if(dr[2].ToString().Equals(txtPassword.Text.Trim()))
                {
                    int role = Convert.ToInt32(dr[3]);
                    User.UserId = Convert.ToInt32(dr[0]);
                    User.UserName = dr[1].ToString();
                    User.RoleId = Convert.ToInt32(dr[3]);
                    if(role==1)
                    {
                        AdminDashBoard admin = new AdminDashBoard();
                        admin.MdiParent = this.MdiParent;
                        admin.Show();
                        this.Close();
                        
                    }
                    else if(role==2)
                    {
                        StaffDashBoard staff = new StaffDashBoard();
                        staff.MdiParent = this.MdiParent;
                        staff.Show();
                        this.Close();
                    }
                    else if (role==3)
                    {
                        StudentDashBoard student = new StudentDashBoard();
                        student.MdiParent = this.MdiParent;
                        student.Show();
                        this.Close();

                    }
                }
                else
                {
                    lblMsg.Text = "Authentication Failed";
                }

                dr.Close();
                con.Close();
            }

            else
            {
                lblMsg.Text = "Authentication Failed";
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {


        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            
                
                txtEmail.Clear();
                txtPassword.Clear();

                lblMsg.Text = "";
                errorProvider1.Clear();
    
        }

        private void lnkStudentRegistration_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            StudentRegistration sr = new StudentRegistration();
            sr.MdiParent = this.MdiParent;
            this.Close();
            sr.Show();
        }
    }
}
