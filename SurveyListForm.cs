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
    public partial class SurveyListForm : Form
    {
        public SurveyListForm()
        {
            InitializeComponent();
        }

        private void SurveyList_Load(object sender, EventArgs e)
        {
            //enabling full row select
            lstVwSurvey.FullRowSelect = true;

            //determining user type to limit form controls
            if (DataContainer.crUserType == "Admin")
            {
                btnLoad.Hide();
            }
            else 
            {
                btnNewSurvey.Hide();
                btnReview.Hide();
            }

            //populating listview with available surveys from the database
            using (IDbConnection cn = new SQLiteConnection(DataClass.LoadConnectionString()))
            {                
                cn.Open();
                using (SQLiteCommand cmd = new SQLiteCommand())
                {
                    cmd.CommandText = "SELECT * FROM SurveyTable";
                    cmd.Connection = (SQLiteConnection)cn;

                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            ListViewItem item = new ListViewItem(reader["SurveyId"].ToString());
                            item.SubItems.Add(reader["SurveyTitle"].ToString());
                            item.SubItems.Add(reader["SurveyDescription"].ToString());
                            item.SubItems.Add(reader["SurveyAuthor"].ToString());
                            lstVwSurvey.Items.Add(item);  
                        }         
                    }
                }
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            //ensuring survey has been selected
            if(lstVwSurvey.SelectedItems.Count > 0)
            {
                this.Hide();
                AnswerForm answer_form = new AnswerForm();
                answer_form.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Please select the survey you want to answer");
            }          
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            //enable Admin to create new survey
            this.Hide();
            SurveyForm survey_form = new SurveyForm();
            survey_form.ShowDialog();
            this.Close();
        }

        private void lstVwSurvey_MouseClick(object sender, MouseEventArgs e)
        {
            //adding values to global variables to be used in other forms
            DataContainer.crLVSurveyId = Convert.ToInt32(lstVwSurvey.SelectedItems[0].SubItems[0].Text);
            DataContainer.crSurveyTitle = lstVwSurvey.SelectedItems[0].SubItems[1].Text;
            DataContainer.crSurveyDescription = lstVwSurvey.SelectedItems[0].SubItems[2].Text;
            DataContainer.crSurveyAuthor = lstVwSurvey.SelectedItems[0].SubItems[3].Text;
        }

        private void btnReview_Click(object sender, EventArgs e)
        {
            //ensuring survey has been selected
            if (lstVwSurvey.SelectedItems.Count > 0)
            {
                this.Hide();
                ReviewForm review_form = new ReviewForm();
                review_form.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Please select the survey you want to review");
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
