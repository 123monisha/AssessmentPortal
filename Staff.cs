using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AssessmentPortal
{
    public partial class Staff : Form
    {
        SqlConnection con = new SqlConnection();
        int action = 1;
        public Staff()
        {
            InitializeComponent();
            con.ConnectionString = ApplicationSettings.ConnectionString;
        }

        private void cancelCloseStaffManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdminDashBoard admin = new AdminDashBoard();
            admin.Show();
            this.Close();
        }

        private void Staff_Load(object sender, EventArgs e)
        {
            lblUser.Text = User.UserName;

            lblUserId.Text = UserId().ToString();
            cmbRoles.DataSource = UserRoles();
            cmbRoles.DisplayMember = "ROle";
            cmbRoles.ValueMember = "roleid";
        }

        int UserId()
        {
            if (con.State == ConnectionState.Closed)
                con.Open();
            SqlCommand cmdId = new SqlCommand("Select max(uid)+1 from Users", con);
            return Convert.ToInt32(cmdId.ExecuteScalar());
        }

        DataTable UserRoles()
        {
            SqlDataAdapter daRoles = new SqlDataAdapter("Select * from RoleMaster where roleid in (1,2)", con);
            DataTable dtRoles = new DataTable();
            daRoles.Fill(dtRoles);
            DataRow r = dtRoles.NewRow();
            r[0] = -1;
            r[1] = "Choose Preferred Role";
            dtRoles.Rows.InsertAt(r, 0);
            return dtRoles;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            if (txtName.Text.Trim().Length == 0)
            {
                errorProvider1.SetError(txtName, "Enter Name");
                return;
            }
            else
            {
                errorProvider1.Clear();
            }
            if (txtEmail.Text.Trim().Length == 0)
            {
                errorProvider1.SetError(txtEmail, "Enter Email");
                return;
            }
            else
            {
                errorProvider1.Clear();
            }

            if (txtMobile.Text.Trim().Length == 0)
            {
                errorProvider1.SetError(txtMobile, "Enter Mobile");
                return;
            }
            else
            {
                if (!Regex.IsMatch(txtMobile.Text.Trim(), "^[6789]{1}[0-9]{9}$"))
                {
                    errorProvider1.SetError(txtMobile, "Invalid Mobile Number");
                    return;
                }
                else
                {
                    errorProvider1.Clear();
                }

            }
            if (cmbRoles.SelectedIndex == 0)
            {
                errorProvider1.SetError(cmbRoles, "Select a Role");
                return;
            }
            else
            {
                errorProvider1.Clear();
            }
            SqlCommand cmdSave = new SqlCommand();
            cmdSave.Connection = con;
            if (con.State == ConnectionState.Closed)
                con.Open();

            SqlParameter parmId = new SqlParameter("@id", SqlDbType.Int);
            SqlParameter parmName = new SqlParameter("@name", SqlDbType.VarChar, 40);
            SqlParameter parmEmail = new SqlParameter("@email", SqlDbType.VarChar, 40);
            SqlParameter parmMobile = new SqlParameter("@mobile", SqlDbType.BigInt);
            SqlParameter parmROle = new SqlParameter("@role", SqlDbType.Int);
            SqlParameter parmAddedBy = new SqlParameter("@addedBy", SqlDbType.Int);
            SqlParameter paramAddedOn = new SqlParameter("@addedOn", SqlDbType.DateTime);
            SqlParameter parmPassword = new SqlParameter("@password", SqlDbType.VarChar, 40);

            parmId.Value = Convert.ToInt32(lblUserId.Text);
            parmName.Value = txtName.Text.Trim();
            parmEmail.Value = txtEmail.Text.Trim();
            parmMobile.Value = Convert.ToInt64(txtMobile.Text.Trim());
            parmROle.Value = Convert.ToInt32(cmbRoles.SelectedValue);
            paramAddedOn.Value = dtpregisteredOn.Value;   // This is DateTime, safe

            parmAddedBy.Value = User.UserId;
            parmPassword.Value = txtMobile.Text.Trim();
            if (action == 1)
            {
                cmdSave.CommandText = "insert into users values(@id, @name, @email, @mobile, @addedBy, @addedOn, @role, @password)";
                cmdSave.Parameters.Add(parmName);
                cmdSave.Parameters.Add(parmId);
                cmdSave.Parameters.Add(parmEmail);
                cmdSave.Parameters.Add(parmMobile);
                cmdSave.Parameters.Add(paramAddedOn);
                cmdSave.Parameters.Add(parmAddedBy);
                cmdSave.Parameters.Add(parmPassword);
                cmdSave.Parameters.Add(parmROle);
            }
            else if (action == 2)
            {
                cmdSave.CommandText = "update users set name=@name,email=@email,mobile= @mobile, addedby=@addedBy, addedon=@addedOn, role=@role where uid=@id";
                cmdSave.Parameters.Add(parmName);
                cmdSave.Parameters.Add(parmId);
                cmdSave.Parameters.Add(parmEmail);
                cmdSave.Parameters.Add(parmMobile);
                cmdSave.Parameters.Add(paramAddedOn);
                cmdSave.Parameters.Add(parmAddedBy);
                // cmdSave.Parameters.Add(parmPassword);
                cmdSave.Parameters.Add(parmROle);
            }

            if (cmdSave.ExecuteNonQuery() > 0)
            {
                if (action == 1)
                {
                    lblMsg.Text = "The User has been Registered";
                }
                else if (action == 2)
                {
                    lblMsg.Text = "The Userdetails have been modified";
                    BindUsers();

                }
                lblMsg.ForeColor = System.Drawing.Color.Green;
            }
            else
            {
                lblMsg.Text = "Adding or updating user details has failed";
                lblMsg.ForeColor = System.Drawing.Color.Red;
            }

            btnSave.Enabled = false;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtNameSearch.Text.Trim().Length == 0)
            {
                lblSearchMsg.Text = "Enter your search criteria";
                lblSearchMsg.ForeColor = Color.Red;
                return;
            }
            else
            {
                DataTable dtUsersFound = BindUsers();
                lblSearchMsg.Text = dtUsersFound.Rows.Count + " Record(s) Found";
                lblSearchMsg.ForeColor = Color.Blue;
            }
        }
        DataTable BindUsers()
        {
            SqlDataAdapter daUsers = new SqlDataAdapter("Select uid as [User Id], Name, Mobile as [Contact Number], Email,Addedon as [Date of Registration], rm.role as [User Type] from users u inner join ROleMAster rm on rm.roleid=u.role where name like '%" + txtNameSearch.Text.Trim() + "%' and addedby=" + User.UserId + " ", con);
            DataTable dtUsersFound = new DataTable();
            daUsers.Fill(dtUsersFound);
            dataGridView1.DataSource = dtUsersFound;
            return dtUsersFound;
        }
        private void btnClearSearch_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            lblSearchMsg.Text = "";
            ClearFields();

        }

        private void dataGridView1_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            action = 2;
            lblUserId.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtName.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtEmail.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtMobile.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            dtpregisteredOn.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            cmbRoles.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }
        void ClearFields()
        {
            txtName.Text = "";
            txtMobile.Text = "";
            txtEmail.Text = "";
            cmbRoles.SelectedIndex = 0;
            lblUserId.Text = UserId().ToString();
            btnSave.Enabled = true;
            lblMsg.Text = "";
            action = 1;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}