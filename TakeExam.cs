using System;
using System.Collections;
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
    public partial class TakeExam : Form
    {
        private List<int> selectedQuestionIds = new List<int>();
        private int currentQuestionIndex = 0;
        private Hashtable answeredQuestions = new Hashtable();
        private Timer examTimer = new Timer();
        private int timeInSeconds = 0;

        public TakeExam()
        {
            InitializeComponent();
            examTimer.Interval = 1000;
            examTimer.Tick += new EventHandler(examTimer_Tick);
        }

        private void TakeExam_Load(object sender, EventArgs e)
        {
            LoadSubjects();
            lblUser.Text = User.UserName;
        }

        private void LoadSubjects()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(ApplicationSettings.ConnectionString))
                {
                    con.Open();
                    string query = "SELECT subjectid, subject FROM subjects";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        cmbselectsubject.DataSource = dt;
                        cmbselectsubject.DisplayMember = "subject";
                        cmbselectsubject.ValueMember = "subjectid";
                        cmbselectsubject.SelectedIndex = -1;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while loading subjects: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmbselectsubject_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void btnstart_Click(object sender, EventArgs e)
        {
            if (cmbselectsubject.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a subject to start the exam.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                int selectedSubjectId = Convert.ToInt32(cmbselectsubject.SelectedValue);
                selectedQuestionIds.Clear();
                answeredQuestions.Clear();

                List<int> allQuestionIds = new List<int>();//it will stores the all the questions
                using (SqlConnection con = new SqlConnection(ApplicationSettings.ConnectionString))
                {
                    con.Open();
                    string query = "SELECT questionid FROM questionabank WHERE subjectid = @subjectId";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@subjectId", selectedSubjectId);
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                allQuestionIds.Add(reader.GetInt32(0));
                            }
                        }
                    }
                }

                Random random = new Random();
                int questionsToSelect = 20;
                if (allQuestionIds.Count < questionsToSelect)
                {
                    questionsToSelect = allQuestionIds.Count;
                }

                while (selectedQuestionIds.Count < questionsToSelect)
                {
                   
                    int randomIndex = random.Next(allQuestionIds.Count);
                    int randomQuestionId = allQuestionIds[randomIndex];
                    selectedQuestionIds.Add(randomQuestionId);

                    allQuestionIds.RemoveAt(randomIndex);
                }

                if (selectedQuestionIds.Count > 0)
                {
                    currentQuestionIndex = 0;
                    DisplayQuestion(selectedQuestionIds[currentQuestionIndex]);

                    cmbselectsubject.Enabled = false;
                    btnstart.Enabled = false;
                    btnSubmit.Enabled = true;
                    btnSaveNext.Enabled = true;
                    btnMarkReview.Enabled = true;

                    
                    timeInSeconds = 1200;
                    examTimer.Start();
                }
                else
                {
                    MessageBox.Show("No questions found for the selected subject.", "No Questions", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void DisplayQuestion(int questionId)
        {
            rbA.Checked = false;
            radioButton2.Checked = false;
            rbC.Checked = false;
            rbD.Checked = false;

            try
            {
                using (SqlConnection con = new SqlConnection(ApplicationSettings.ConnectionString))
                {
                    con.Open();
                    string query = "SELECT question, optionA, optionB, optionC, optionD FROM questionabank WHERE questionid = @questionId";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@questionId", questionId);
                        SqlDataReader reader = cmd.ExecuteReader();
                        if (reader.Read())
                        {
                            lblquestion.Text = reader["question"].ToString();
                            rbA.Text = "A) " + reader["optionA"].ToString();
                            radioButton2.Text = "B) " + reader["optionB"].ToString();
                            rbC.Text = "C) " + reader["optionC"].ToString();
                            rbD.Text = "D) " + reader["optionD"].ToString();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to display question: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSaveNext_Click(object sender, EventArgs e)
        {
            string selectedAnswer = GetSelectedAnswer();
            if (string.IsNullOrEmpty(selectedAnswer))
            {
                MessageBox.Show("Please select an answer to save and move to the next question.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int currentQuestionId = selectedQuestionIds[currentQuestionIndex];
            answeredQuestions[currentQuestionId] = selectedAnswer;

            ColorQuestionButton(currentQuestionIndex + 1, System.Drawing.Color.Green);
            currentQuestionIndex++;

            if (currentQuestionIndex < selectedQuestionIds.Count)
            {
                DisplayQuestion(selectedQuestionIds[currentQuestionIndex]);
                LoadSavedAnswer(selectedQuestionIds[currentQuestionIndex]); 
            }
            else
            {
                MessageBox.Show("All questions have been answered. Please submit your test.", "Exam Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnSaveNext.Enabled = false;
            }
        }

        private string GetSelectedAnswer()
        {
            if (rbA.Checked) return "A";
            if (radioButton2.Checked) return "B";
            if (rbC.Checked) return "C";
            if (rbD.Checked) return "D";
            return null;
        }

        private void ColorQuestionButton(int buttonNumber, System.Drawing.Color color)
        {
            Control[] foundButtons = this.Controls.Find("btn" + buttonNumber, true);
            if (foundButtons.Length > 0 && foundButtons[0] is Button)
            {
                Button btn = (Button)foundButtons[0];
                btn.BackColor = color;
            }
        }
        private void groupBox1_Enter(object sender, EventArgs e) { }
        private void groupBox2_Enter(object sender, EventArgs e) { }

        private void btnMarkReview_Click(object sender, EventArgs e)
        {
            int currentQuestionId = selectedQuestionIds[currentQuestionIndex];
            string selectedAnswer = GetSelectedAnswer();

            if (!string.IsNullOrEmpty(selectedAnswer))
            {
                answeredQuestions[currentQuestionId] = selectedAnswer;
            }

            else
            {
                answeredQuestions[currentQuestionId] = "Review";
            }

            ColorQuestionButton(currentQuestionIndex + 1, System.Drawing.Color.Orange);
            currentQuestionIndex++;

            if (currentQuestionIndex < selectedQuestionIds.Count)
            {
                DisplayQuestion(selectedQuestionIds[currentQuestionIndex]);
                LoadSavedAnswer(selectedQuestionIds[currentQuestionIndex]); 
            }
            else
            {
                MessageBox.Show("All questions have been answered. Please submit your test.", "Exam Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnSaveNext.Enabled = false;
                btnMarkReview.Enabled = false;
            }
        }
        private void btnQuestion_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;


            if (int.TryParse(clickedButton.Text, out int questionNumber))//clickedbutton.text read that text to analyze
            {
                currentQuestionIndex = questionNumber - 1;

                DisplayQuestion(selectedQuestionIds[currentQuestionIndex]);


                LoadSavedAnswer(selectedQuestionIds[currentQuestionIndex]);
            }
        }
        private void LoadSavedAnswer(int questionId)
        {
            rbA.Checked = false;
            radioButton2.Checked = false;
            rbC.Checked = false;
            rbD.Checked = false;
            if (answeredQuestions.ContainsKey(questionId))
            {

                string savedAnswer = answeredQuestions[questionId]?.ToString();

                if (savedAnswer == "A")
                {
                    rbA.Checked = true;
                }
                else if (savedAnswer == "B")
                {
                    radioButton2.Checked = true;
                }
                else if (savedAnswer == "C")
                {
                    rbC.Checked = true;
                }
                else if (savedAnswer == "D")
                {
                    rbD.Checked = true;
                }
            }
        }
        private void examTimer_Tick(object sender, EventArgs e)
        {
            timeInSeconds--;
            if (timeInSeconds >= 0)
            {
                int minutes = timeInSeconds / 60;
                int seconds = timeInSeconds % 60;
                lblTimer.Text = $"Time Remaining: {minutes:D2}:{seconds:D2}";
            }
            else
            {
                examTimer.Stop();
                MessageBox.Show("Time's up! The exam will now be submitted automatically.", "Time's Up", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnSubmit_Click(this, EventArgs.Empty);
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            examTimer.Stop();
            try
            {
                if (currentQuestionIndex < selectedQuestionIds.Count)
                {
                    int lastQuestionId = selectedQuestionIds[currentQuestionIndex];
                    string selectedAnswer = GetSelectedAnswer();
                    if (!string.IsNullOrEmpty(selectedAnswer))
                    {
                        answeredQuestions[lastQuestionId] = selectedAnswer;
                    }
                }

                int examId;
                int subjectId = Convert.ToInt32(cmbselectsubject.SelectedValue);

                using (SqlConnection con = new SqlConnection(ApplicationSettings.ConnectionString))
                {
                    con.Open();
                    string getExamIdQuery = "SELECT ISNULL(MAX(examId), 0) + 1 FROM exam";
                    using (SqlCommand cmd = new SqlCommand(getExamIdQuery, con))
                    {
                        examId = Convert.ToInt32(cmd.ExecuteScalar());
                    }
                    string insertExamQuery = "INSERT INTO exam (examId, studentId, subjectId, dateofexam) VALUES (@examId, @studentId, @subjectId, @dateofexam)";
                    using (SqlCommand cmd = new SqlCommand(insertExamQuery, con))
                    {
                        cmd.Parameters.AddWithValue("@examId", examId);
                        cmd.Parameters.AddWithValue("@studentId", User.UserId);
                        cmd.Parameters.AddWithValue("@subjectId", subjectId);
                        cmd.Parameters.AddWithValue("@dateofexam", DateTime.Today); 
                        cmd.ExecuteNonQuery();
                    }

                    
                    string insertAnswerQuery = "INSERT INTO answers (examId, questionId, answer) VALUES (@examId, @questionId, @answer);";
                    using (SqlCommand cmd = new SqlCommand(insertAnswerQuery, con))
                    {
                        cmd.Parameters.Add("@examId", SqlDbType.Int).Value = examId;
                        cmd.Parameters.Add("@questionId", SqlDbType.Int);
                        cmd.Parameters.Add("@answer", SqlDbType.Char, 2);

                        foreach (DictionaryEntry entry in answeredQuestions)
                        {
                            cmd.Parameters["@questionId"].Value = Convert.ToInt32(entry.Key);
                            cmd.Parameters["@answer"].Value = entry.Value.ToString();
                            cmd.ExecuteNonQuery();

                        }
                    }
                }
                MessageBox.Show("Exam submitted successfully!", "Submission Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);

                
                btnSaveNext.Enabled = false;
                btnMarkReview.Enabled = false;
                btnSubmit.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred during submission: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
