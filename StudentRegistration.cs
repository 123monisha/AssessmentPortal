using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace AssessmentPortal
{
    public partial class StudentRegistration : Form
    {
        public StudentRegistration()
        {
            InitializeComponent();
        }

        private void lnkClose_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login l = new Login();
            l.Show();
            this.Close();
        }

        int UserId()
        {
            SqlConnection con = new SqlConnection(ApplicationSettings.ConnectionString);
            try
            {
                con.Open();
                SqlCommand cmdId = new SqlCommand("SELECT MAX(uid)+1 FROM Users", con);
                object result = cmdId.ExecuteScalar();
                if (result != DBNull.Value && result != null)
                {
                    return Convert.ToInt32(result);
                }
                else
                {
                    return 1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error getting new User ID: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1;
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = txtName.Text.Trim();
            string email = txtEmail.Text.Trim();
            string mobile = txtMobNo.Text.Trim();
            string password = txtPassword.Text.Trim();

           
            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(mobile) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Please fill in all the required fields.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                
                using (SqlConnection con = new SqlConnection(ApplicationSettings.ConnectionString))
                {
                    con.Open();
                    string query = "INSERT INTO users (uid, name, email, mobile, password, addedon, role) VALUES (@uid, @name, @email, @mobile, @password, @addedon, @role)";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        
                        SqlParameter parmUid = new SqlParameter("@uid", SqlDbType.Int);
                        SqlParameter parmName = new SqlParameter("@name", SqlDbType.NVarChar, 50);
                        SqlParameter parmEmail = new SqlParameter("@email", SqlDbType.NVarChar, 50);
                        SqlParameter parmMobile = new SqlParameter("@mobile", SqlDbType.NVarChar, 15);
                        SqlParameter parmPassword = new SqlParameter("@password", SqlDbType.NVarChar, 50);
                        SqlParameter parmAddedOn = new SqlParameter("@addedon", SqlDbType.DateTime);
                        SqlParameter parmRole = new SqlParameter("@role", SqlDbType.Int);

                       
                        parmUid.Value = Convert.ToInt32(lblUserId.Text);
                        parmName.Value = name;
                        parmEmail.Value = email;
                        parmMobile.Value = mobile;
                        parmPassword.Value = password;
                        parmAddedOn.Value = DateTime.Now;
                        parmRole.Value = 3; // Role 3 is for a student.

                        
                        cmd.Parameters.Add(parmUid);
                        cmd.Parameters.Add(parmName);
                        cmd.Parameters.Add(parmEmail);
                        cmd.Parameters.Add(parmMobile);
                        cmd.Parameters.Add(parmPassword);
                        cmd.Parameters.Add(parmAddedOn);
                        cmd.Parameters.Add(parmRole);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Student registered successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            
                            Login loginForm = new Login();
                            loginForm.Show();
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Registration failed. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred during registration: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void StudentRegistration_Load(object sender, EventArgs e)
        {
            lblUserId.Text = UserId().ToString();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {
            
        }
    }
}
