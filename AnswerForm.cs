using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SQLite;
using Dapper;

namespace SurveyApp
{
    public partial class AnswerForm : Form
    {
        public AnswerForm()
        {
            InitializeComponent();
        }

        //variable declaration
        string answer = "";
        bool Exists = false;

        private void AnswerForm_Load(object sender, EventArgs e)
        {
            //hiding user controls related to answering questions
            cmBxAnswer.Hide();
            rdYes.Hide();
            rdNo.Hide();
            rdAgree.Hide();
            rdDisagree.Hide();
            rdNeutral.Hide();
            rdStronglyAgree.Hide();
            rdStronglyDisagree.Hide();

            //adding items to combobox
            cmBxAnswer.Items.Add("Definitely not");
            cmBxAnswer.Items.Add("Would consider it");
            cmBxAnswer.Items.Add("Definitely");

            //populating textboxes with data from global variables
            txBxSurveyId.Text = DataContainer.crLVSurveyId.ToString();
            txBxSurveyTitle.Text = DataContainer.crSurveyTitle;
            txBxSurveyDescription.Text = DataContainer.crSurveyDescription;
            txBxSurveyAuthor.Text = DataContainer.crSurveyAuthor;


            //populating listview with data
            using (IDbConnection cn = new SQLiteConnection(DataClass.LoadConnectionString()))
            {
                cn.Open();
                using (SQLiteCommand cmd = new SQLiteCommand())
                {
                    cmd.CommandText = "SELECT * FROM SurveyQuestion WHERE SurveyId = '" + DataContainer.crLVSurveyId + "' ";
                    cmd.Connection = (SQLiteConnection)cn;

                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            ListViewItem item = new ListViewItem(reader["QuestionId"].ToString());
                            item.SubItems.Add(reader["QuestionText"].ToString());
                            item.SubItems.Add(reader["AnswerType"].ToString());
                            item.SubItems.Add("");
                            item.SubItems.Add(DataContainer.crUserName);
                            lstVwQuestions.Items.Add(item);
                        }
                    }
                }
            }
        }

        private void btnSubmitAnswer_Click(object sender, EventArgs e)
        {
            //instance of question class to be used for storing data in the database
            QuestionClass q = new QuestionClass();

            //conditional staements to enable the answering of questions
            if (rdYes.Checked)
            {
                answer = "Yes";
                lstVwQuestions.SelectedItems[0].SubItems[3].Text = answer;
                rdYes.Checked = false;
            }
            else if (rdNo.Checked)
            {
                answer = "No";
                lstVwQuestions.SelectedItems[0].SubItems[3].Text = answer;
                rdNo.Checked = false;
            }
            else if (rdStronglyDisagree.Checked)
            {
                answer = "Strongly Disagree";
                lstVwQuestions.SelectedItems[0].SubItems[3].Text = answer;
                rdStronglyDisagree.Checked = false;
            }
            else if (rdDisagree.Checked)
            {
                answer = "Disagree";
                lstVwQuestions.SelectedItems[0].SubItems[3].Text = answer;
                rdDisagree.Checked = false;
            }
            else if (rdNeutral.Checked)
            {
                answer = "Neutral";
                lstVwQuestions.SelectedItems[0].SubItems[3].Text = answer;
                rdNeutral.Checked = false;
            }
            else if (rdAgree.Checked)
            {
                answer = "Agree";
                lstVwQuestions.SelectedItems[0].SubItems[3].Text = answer;
                rdAgree.Checked = false;
            }
            else if (rdStronglyAgree.Checked)
            {
                answer = "Strongly Agree";
                lstVwQuestions.SelectedItems[0].SubItems[3].Text = answer;
                rdStronglyAgree.Checked = false;
            }
            else if (cmBxAnswer.Text == "Definitely not")
            {
                answer = "Definitely not";
                lstVwQuestions.SelectedItems[0].SubItems[3].Text = answer;
            }
            else if (cmBxAnswer.Text == "Would consider it")
            {
                answer = "Would consider it";
                lstVwQuestions.SelectedItems[0].SubItems[3].Text = answer;
            }
            else if (cmBxAnswer.Text == "Definitely")
            {
                answer = "Definitely";
                lstVwQuestions.SelectedItems[0].SubItems[3].Text = answer;
            }

            //checking databse to see if question has already been answered to prevent duplicate records in the database
            using (IDbConnection cn = new SQLiteConnection(DataClass.LoadConnectionString()))
            {
                cn.Open();
                using (SQLiteCommand cmd = new SQLiteCommand())
                {
                    cmd.CommandText = "SELECT * FROM AnsweredSurvey WHERE QuestionId = '" + Convert.ToInt32(lstVwQuestions.SelectedItems[0].SubItems[0].Text) + "' AND Respondent = '" + lstVwQuestions.SelectedItems[0].SubItems[4].Text + "'";
                    cmd.Connection = (SQLiteConnection)cn;

                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        reader.Read();
                        if (reader.HasRows)
                        {
                            Exists = true;
                        }
                        else
                        {
                            Exists = false;
                        }
                    }
                }
            }

            if (Exists == true)
            {
                MessageBox.Show("Error, Please ensure not to leave any question unanswered, a question may only be answered once.");
            }
            else
            {
                //saving question to the database
                q.QuestionId = Convert.ToInt32(lstVwQuestions.SelectedItems[0].SubItems[0].Text);
                q.QuestionText = lstVwQuestions.SelectedItems[0].SubItems[1].Text;
                q.AnswerType = lstVwQuestions.SelectedItems[0].SubItems[2].Text;
                q.Answer = lstVwQuestions.SelectedItems[0].SubItems[3].Text;
                q.Respondent = lstVwQuestions.SelectedItems[0].SubItems[4].Text;
                DataClass.SaveAnsweredQuestion(q);
                MessageBox.Show("Answer Saved successfully");
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            //ensuring a question is selected from the listview
            if (lstVwQuestions.SelectedItems.Count > 0)
            {
                //assigning data to global variables to be used in other forms
                DataContainer.QuestionText = (lstVwQuestions.SelectedItems[0].SubItems[1].Text);
                DataContainer.AnswerType = (lstVwQuestions.SelectedItems[0].SubItems[2].Text);
                lblQuestion.Text = DataContainer.QuestionText;


                //manipulation user controls to be displayed according to specific question type
                if (DataContainer.AnswerType == "Yes/No")
                {
                    rdYes.Show();
                    rdNo.Show();
                    cmBxAnswer.Hide();
                    rdAgree.Hide();
                    rdDisagree.Hide();
                    rdNeutral.Hide();
                    rdStronglyAgree.Hide();
                    rdStronglyDisagree.Hide();
                }
                else if (DataContainer.AnswerType == "Dropdown Menu")
                {
                    cmBxAnswer.Show();
                    rdYes.Hide();
                    rdNo.Hide();
                    rdAgree.Hide();
                    rdDisagree.Hide();
                    rdNeutral.Hide();
                    rdStronglyAgree.Hide();
                    rdStronglyDisagree.Hide();
                }
                else if (DataContainer.AnswerType == "Likert Scale")
                {
                    rdYes.Hide();
                    rdNo.Hide();
                    cmBxAnswer.Hide();
                    rdAgree.Show();
                    rdDisagree.Show();
                    rdNeutral.Show();
                    rdStronglyAgree.Show();
                    rdStronglyDisagree.Show();
                }
            }
            else
            {
                MessageBox.Show("Please select the qustion you want to answer");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //enabling user to exit
            DialogResult exit;
            exit = MessageBox.Show("Are you sure you want to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (exit == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
