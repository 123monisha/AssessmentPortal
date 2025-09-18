using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AssessmentPortal
{
    public partial class QuetionBankManagement : Form
    {
        SqlConnection con = new SqlConnection();
        private int questionIdToUpdate = 0;

        public QuetionBankManagement()
        {
            InitializeComponent();
            con.ConnectionString = ApplicationSettings.ConnectionString;
        }

        private void QuetionBankManagement_Load(object sender, EventArgs e)
        {
            lblUser.Text = User.UserName;
            LoadAllocatedSubjects();
            BindQuestions();
        }

        private void LoadAllocatedSubjects()
        {
            try
            {
                DataTable dtSubjects = new DataTable();

                using (SqlConnection con = new SqlConnection(ApplicationSettings.ConnectionString))
                {
                    con.Open();

                    string query = "SELECT Subject, SubjectId FROM subjects WHERE subjectid IN (SELECT subid FROM StaffSubjectAllocation WHERE staffid = @userId)";

                    using (SqlCommand cmdSubjects = new SqlCommand(query, con))
                    {
                        cmdSubjects.Parameters.AddWithValue("@userId", User.UserId);
                        using (SqlDataAdapter da = new SqlDataAdapter(cmdSubjects))
                        {
                            da.Fill(dtSubjects);
                        }
                    }
                }

                if (dtSubjects.Rows.Count > 0)
                {
                    cmbsubject.DataSource = dtSubjects;
                    cmbsubject.DisplayMember = "Subject";
                    cmbsubject.ValueMember = "SubjectId";
                    cmbsubject.SelectedIndex = -1;
                }
                else
                {
                    MessageBox.Show("No subjects have been allocated to you. Please contact the admin.");
                    btnsave.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading subjects: " + ex.Message);
            }
        }

        private void cmbsubject_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbsubject.SelectedItem != null)
            {
                BindQuestions();
            }
        }

        private void BindQuestions(string searchTerm = null)
        {
            try
            {

                using (SqlConnection con = new SqlConnection(ApplicationSettings.ConnectionString))
                {
                    con.Open();


                    string query = "SELECT questionid, ROW_NUMBER() OVER(ORDER BY questionid) AS QuestionNo, question, optionA, optionB, optionC, optionD, correctanswer FROM questionabank WHERE subjectid = @subjectId AND createdby = @addedBy";

                    if (!string.IsNullOrWhiteSpace(searchTerm))
                    {
                        query += " AND question LIKE '%' + @searchTerm + '%'";
                    }

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {

                        if (cmbsubject.SelectedValue != null)
                        {
                            cmd.Parameters.AddWithValue("@subjectId", cmbsubject.SelectedValue);
                        }
                        else
                        {
                            dataGridView1.DataSource = null;
                            lblmsg2.Text = "No subject selected.";
                            return;
                        }


                        cmd.Parameters.AddWithValue("@addedBy", User.UserId);

                        if (!string.IsNullOrWhiteSpace(searchTerm))
                        {
                            cmd.Parameters.AddWithValue("@searchTerm", searchTerm);
                        }

                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        dataGridView1.DataSource = dt;
                        lblmsg2.Text = $"{dt.Rows.Count} question(s) found.";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred during search: " + ex.Message);
            }
            finally
            {
                txtsearch.Clear();
            }
        }
        private void btnsave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtquetion.Text) || cmbsubject.SelectedValue == null)
            {
                MessageBox.Show("Please select a subject and enter the question.");
                return;
            }

            if (string.IsNullOrWhiteSpace(txta.Text) || string.IsNullOrWhiteSpace(txtb.Text) ||
                string.IsNullOrWhiteSpace(txtc.Text) || string.IsNullOrWhiteSpace(txtd.Text))
            {
                MessageBox.Show("Please enter text for all four options (A, B, C, D).");
                return;
            }

            string answer = GetSelectedAnswer();
            if (string.IsNullOrWhiteSpace(answer))
            {
                MessageBox.Show("Please select the correct answer.");
                return;
            }

            int subjectId;
            if (!int.TryParse(cmbsubject.SelectedValue.ToString(), out subjectId))
            {
                MessageBox.Show("Invalid subject selected. Please refresh the form.");
                return;
            }


            try
            {
                using (SqlConnection con = new SqlConnection(ApplicationSettings.ConnectionString))
                {
                    con.Open();
                    string query;
                    if (this.questionIdToUpdate > 0)
                    {
                        query = "UPDATE questionabank SET question = @question, optionA = @a, optionB = @b, optionC = @c, optionD = @d, correctanswer = @answer WHERE questionid = @questionid";
                    }
                    else
                    {
                        query = "INSERT INTO questionabank (subjectid, question, optionA, optionB, optionC, optionD, correctanswer, createdby, createddate) VALUES (@subjectId, @question, @a, @b, @c, @d, @answer, @createdby, @createddate)";
                    }

                    using (SqlCommand cmdSave = new SqlCommand(query, con))
                    {
                        SqlParameter parmQuestion = new SqlParameter("@question", SqlDbType.NVarChar);
                        SqlParameter parmOptionA = new SqlParameter("@a", SqlDbType.NVarChar);
                        SqlParameter parmOptionB = new SqlParameter("@b", SqlDbType.NVarChar);
                        SqlParameter parmOptionC = new SqlParameter("@c", SqlDbType.NVarChar);
                        SqlParameter parmOptionD = new SqlParameter("@d", SqlDbType.NVarChar);
                        SqlParameter parmAnswer = new SqlParameter("@answer", SqlDbType.VarChar, 1);

                        parmQuestion.Value = txtquetion.Text.Trim();
                        parmOptionA.Value = txta.Text.Trim();
                        parmOptionB.Value = txtb.Text.Trim();
                        parmOptionC.Value = txtc.Text.Trim();
                        parmOptionD.Value = txtd.Text.Trim();
                        parmAnswer.Value = answer;


                        cmdSave.Parameters.Add(parmQuestion);
                        cmdSave.Parameters.Add(parmOptionA);
                        cmdSave.Parameters.Add(parmOptionB);
                        cmdSave.Parameters.Add(parmOptionC);
                        cmdSave.Parameters.Add(parmOptionD);
                        cmdSave.Parameters.Add(parmAnswer);

                        if (this.questionIdToUpdate > 0)
                        {
                            SqlParameter parmQuestionId = new SqlParameter("@questionid", SqlDbType.Int);
                            parmQuestionId.Value = this.questionIdToUpdate;
                            cmdSave.Parameters.Add(parmQuestionId);
                        }
                        else
                        {
                            SqlParameter parmSubjectId = new SqlParameter("@subjectId", SqlDbType.Int);
                            SqlParameter parmAddedBy = new SqlParameter("@createdby", SqlDbType.Int);
                            SqlParameter parmAddedOn = new SqlParameter("@createddate", SqlDbType.DateTime);

                            parmSubjectId.Value = subjectId;
                            parmAddedBy.Value = User.UserId;
                            parmAddedOn.Value = DateTime.Now;

                            cmdSave.Parameters.Add(parmSubjectId);
                            cmdSave.Parameters.Add(parmAddedBy);
                            cmdSave.Parameters.Add(parmAddedOn);
                        }


                        if (cmdSave.ExecuteNonQuery() > 0)
                        {
                            if (this.questionIdToUpdate > 0)
                            {
                                MessageBox.Show("Question updated successfully!");
                            }
                            else
                            {
                                MessageBox.Show("Question saved successfully!");
                            }

                            ClearFields();
                            BindQuestions();
                            this.questionIdToUpdate = 0;
                        }
                        else
                        {
                            MessageBox.Show("Failed to save or update question.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }
        private void btnsearch_Click(object sender, EventArgs e)
        {

            string searchTerm = txtsearch.Text.Trim();
            BindQuestions(searchTerm);

        }



        private string GetSelectedAnswer()
        {
            if (rba.Checked) return "A";
            if (rbb.Checked) return "B";
            if (rbc.Checked) return "C";
            if (rbd.Checked) return "D";
            return string.Empty;
        }

        private void ClearFields()
        {
            txtquetion.Clear();
            txta.Clear();
            txtb.Clear();
            txtc.Clear();
            txtd.Clear();
            rba.Checked = rbb.Checked = rbc.Checked = rbd.Checked = false;
        }

        private void lnkclose_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            StaffDashBoard staff = new StaffDashBoard();
            staff.MdiParent = this.MdiParent;
            staff.Show();
            this.Close();
        }

        private void label4_Click(object sender, EventArgs e) { }
        private void groupBox3_Enter(object sender, EventArgs e) { }
        private void groupBox1_Enter(object sender, EventArgs e) { }

        private void QuetionBankManagement_Load_1(object sender, EventArgs e)
        {
            LoadAllocatedSubjects();
        }
        private void lblQueId_Click(object sender, EventArgs e)

        {


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                this.questionIdToUpdate = Convert.ToInt32(row.Cells[0].Value);


                txtquetion.Text = row.Cells["question"].Value.ToString();
                txta.Text = row.Cells["optionA"].Value.ToString();
                txtb.Text = row.Cells["optionB"].Value.ToString();
                txtc.Text = row.Cells["optionC"].Value.ToString();
                txtd.Text = row.Cells["optionD"].Value.ToString();

                string correctAnswer = row.Cells["correctanswer"].Value.ToString();
                if (correctAnswer == "A")
                {
                    rba.Checked = true;
                }
                else if (correctAnswer == "B")
                {
                    rbb.Checked = true;
                }
                else if (correctAnswer == "C")
                {
                    rbc.Checked = true;
                }
                else if (correctAnswer == "D")
                {
                    rbd.Checked = true;
                }
            }
        }
    }
}
