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
    public partial class Subject : Form
    {
        SqlConnection con = new SqlConnection();
        int action = 1;
        public Subject()
        {
            InitializeComponent();
            con.ConnectionString = ApplicationSettings.ConnectionString;

        }

        private void Subject_Load(object sender, EventArgs e)
        {
            DisplaySubjects();
            lblSubId.Text = SubjectId().ToString();
            lblUser.Text = User.UserName;
        }

        void DisplaySubjects()
        {
            SqlDataAdapter daSUb = new SqlDataAdapter("Select subjectid as [Subject Code], Subject, u.Name from users u inner join subjects s on s.addedby=u.uid",con);
            DataTable dtSUbjects = new DataTable();
            daSUb.Fill(dtSUbjects);
            dataGridView1.DataSource = dtSUbjects;

            // Load Staff
            cmbStaff.DataSource = ListStaff();
            cmbStaff.DisplayMember = "Name";
            cmbStaff.ValueMember = "Uid";

            // Load the allotted subjects
            dataGridView2.DataSource = ListSubjectsAllocations();
        }

       DataTable ListSubjectsAllocations()
        {
            SqlDataAdapter daAllocations = new SqlDataAdapter("Select sub.Subject, u.Name as [Staff], a.Name as [Allotted By] from staffsubjectallocation allot inner join users u on u.uid = allot.staffid inner    join Users a on a.uid = allot.allotedby inner join subjects sub on sub.subjectid =allot.subid",con);
            DataTable dtAllocations = new DataTable();
            daAllocations.Fill(dtAllocations);
            return dtAllocations;
        }
        int SubjectId()
        {
            SqlCommand cmdSubjectId = new SqlCommand("Select max(subjectid)+1 from Subjects", con);
            if (con.State == ConnectionState.Closed)
                con.Open();
            return Convert.ToInt32(cmdSubjectId.ExecuteScalar());
        }

        DataTable ListStaff()
        {
            SqlDataAdapter daStaff = new SqlDataAdapter("Select uid, Name from Users where role=2",con);
            DataTable dtStaff = new DataTable();
            daStaff.Fill(dtStaff);
            DataRow r = dtStaff.NewRow();
            r[0] = -1;
            r[1] = "Choose Staff";
            dtStaff.Rows.InsertAt(r,0);
            return dtStaff;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(IsSubjectPresent(txtSubject.Text.Trim()))
            {
                MessageBox.Show("Subject is already been added");
            }
            if (string.IsNullOrWhiteSpace(txtSubject.Text)) { MessageBox.Show("Please enter a subject."); return; }

            else
            {
                SqlCommand cmdSAve = new SqlCommand();
                cmdSAve.Connection = con;
                SqlParameter paramSubid = new SqlParameter("@subid", SqlDbType.Int);
                SqlParameter paramSubject = new SqlParameter("@subject", SqlDbType.VarChar,100);
                SqlParameter paramAdmin = new SqlParameter("@admin", SqlDbType.Int);
                cmdSAve.Parameters.Add(paramSubid);
                cmdSAve.Parameters.Add(paramSubject);

                paramAdmin.Value = User.UserId;
                paramSubject.Value = txtSubject.Text.Trim();
                paramSubid.Value = Convert.ToInt32(lblSubId.Text);

                if (action==1)
                {
                    cmdSAve.CommandText = "insert into SUbjects values(@subid, @subject, @admin)";
                    cmdSAve.Parameters.Add(paramAdmin);

                }
                else if(action==2)
                {
                    cmdSAve.CommandText = "Update Subjects set subject=@subject where subjectid=@subid";
                }
                if(cmdSAve.ExecuteNonQuery()>0)
                {
                    if (action == 1)
                    {
                        lblMsg.Text = "Subject has been added";
                        lblMsg.ForeColor = Color.Green;
                    }
                    else if (action == 2)
                    {
                        lblMsg.Text = "Subject has been Modified";
                        lblMsg.ForeColor = Color.Green;
                    }

                    DisplaySubjects();
                    btnSave.Enabled = false;

                }
                else
                {
                    lblMsg.Text = "Your request to add or update a subject has failed";
                    lblMsg.ForeColor = Color.Red;
                }
            }
        }

        bool IsSubjectPresent(string subjectName)
        {
            bool isSubjectAvailable = false;
            SqlDataAdapter daSUb = new SqlDataAdapter("Select  Subject from Subjects", con);
            DataTable dtSUbjects = new DataTable();
            daSUb.Fill(dtSUbjects);
            foreach (DataRow r in dtSUbjects.Rows)
            {
                if(r[0].ToString().Equals(subjectName))
                {
                    isSubjectAvailable = true;
                    break;                   
                }
            }
            return isSubjectAvailable;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Reset();
        }

       void Reset()
        {
            action = 1;
            DisplaySubjects();
            lblSubId.Text = SubjectId().ToString();
            txtSubject.Text = "";
            lblMsg.Text = "";
            btnSave.Enabled = true;
        }

        private void dataGridView1_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            lblSubId.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtSubject.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            action = 2;
        }

        private void cmbStaff_SelectedIndexChanged(object sender, EventArgs e)
        {
            BindGrid();   
        }
       void BindGrid()
        {
            try
            {
                SqlDataAdapter daNotAllottedSubjects = new SqlDataAdapter("Select SubjectId, Subject from Subjects where subjectid not in (select subid from staffsubjectallocation where staffid=" + Convert.ToInt32(cmbStaff.SelectedValue)+")", con);
                DataTable dtSubjects = new DataTable();
                daNotAllottedSubjects.Fill(dtSubjects);

                cmbSubjects.DataSource = dtSubjects;
                cmbSubjects.DisplayMember = "Subject";
                cmbSubjects.ValueMember = "subjectid";
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        private void btnAllot_Click(object sender, EventArgs e)
        {
            SqlCommand cmdAllot = new SqlCommand("insert into staffsubjectallocation values(@subid, @staffid, @adminId, getdate())",con);
            cmdAllot.Connection = con;
            cmdAllot.Parameters.AddWithValue("@subid", Convert.ToInt32(cmbSubjects.SelectedValue));
            cmdAllot.Parameters.AddWithValue("@staffid", Convert.ToInt32(cmbStaff.SelectedValue));
            cmdAllot.Parameters.AddWithValue("@adminId", User.UserId);
            if(con.State==ConnectionState.Closed)
            {
                con.Open();
            }
            if(cmdAllot.ExecuteNonQuery()>0)
            {
                MessageBox.Show("The subject has been allotted");
                cmbStaff.SelectedIndex = 0;

                // display the allotted subjects
                dataGridView2.DataSource = ListSubjectsAllocations();

                // clear the subjects List
                cmbSubjects.DataSource = null;

            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AdminDashBoard admin = new AdminDashBoard();
            admin.Show();
            this.Close();
        }

        private void lblSubId_Click(object sender, EventArgs e)
        {

        }
    }
}
