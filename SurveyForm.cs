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
    public partial class SurveyForm : Form
    {
        public SurveyForm()
        {
            InitializeComponent();
        }

        private void SurveyForm_Load(object sender, EventArgs e)
        {
            //adding items to combobox
            cmBxQuestionType.Items.Add("Yes/No");
            cmBxQuestionType.Items.Add("Dropdown Menu");
            cmBxQuestionType.Items.Add("Likert Scale");
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

        private void btnClear_Click(object sender, EventArgs e)
        {
            //enabling user to clear all fields
            DialogResult clear;
            clear = MessageBox.Show("Are you sure you want clear all data?", "Clear", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (clear == DialogResult.Yes)
            {
                txBxSrTitle.Clear();
                txBxSrDescription.Clear();
                txBxQuestion.Clear();
                cmBxQuestionType.Text = "";
                lstVwQuestions.Items.Clear();               
            }
        }

        private void btnSurveySave_Click(object sender, EventArgs e)
        {
            //instance of survey class to be used to obtain data from the database
            SurveyClass s = new SurveyClass();

            //saving survey details to the database
            s.SurveyTitle = txBxSrTitle.Text;
            s.SurveyAuthor = DataContainer.crUserName;
            s.SurveyDescription = txBxSrDescription.Text;
            DataClass.SaveSurvey(s);

            //obtaining data from database
            using (IDbConnection cn = new SQLiteConnection(DataClass.LoadConnectionString()))
            {
                cn.Open();
                using (SQLiteCommand cmd = new SQLiteCommand())
                {
                    cmd.CommandText = "SELECT * FROM SurveyTable WHERE SurveyTitle = '" + s.SurveyTitle + "' AND SurveyAuthor = '" + s.SurveyAuthor + "' AND SurveyDescription = '" + s.SurveyDescription + "'";
                    cmd.Connection = (SQLiteConnection)cn;

                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        reader.Read();
                        if (reader.HasRows)
                        {
                            s.SurveyId = Convert.ToInt32(reader["SurveyId"]);
                            DataContainer.crSurveyId = s.SurveyId;
                        }
                        else
                        {
                            MessageBox.Show("There was an error");
                        }
                    }
                }
            }

            //looping through all questions and saving them
            for (int i = 0; i < lstVwQuestions.Items.Count; i++)
            {
                int ii = 1;

                //instance of question class used for saving questions to the database
                QuestionClass q = new QuestionClass();
                q.QuestionText = lstVwQuestions.Items[i].Text;
                q.AnswerType = lstVwQuestions.Items[i].SubItems[ii].Text;
                q.SurveyId = DataContainer.crSurveyId;
                DataClass.SaveQuestions(q); 
            }

            MessageBox.Show("Survey Successfully saved");
        }

        private void btnAddQuestion_Click(object sender, EventArgs e)
        {
            //adding question to the listview
            ListViewItem item = new ListViewItem(txBxQuestion.Text);
            item.SubItems.Add(cmBxQuestionType.Text);
            lstVwQuestions.Items.Add(item);
            txBxQuestion.Clear();
            cmBxQuestionType.Text = "";
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            //deleting question from listview
            try
            {
                if (lstVwQuestions.Items.Count > 0)
                {
                    lstVwQuestions.Items.Remove(lstVwQuestions.SelectedItems[0]);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Please click on the question you want to delete");
            }
        }
    }
}
