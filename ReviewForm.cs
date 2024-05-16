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
using System.IO;

namespace SurveyApp
{
    public partial class ReviewForm : Form
    {
        public ReviewForm()
        {
            InitializeComponent();
        }
        

        private void ReviewForm_Load(object sender, EventArgs e)
        {
            //populating textboxes with data from global variables
            txBxSurveyId.Text = DataContainer.crLVSurveyId.ToString();
            txBxSurveyTitle.Text = DataContainer.crSurveyTitle;
            txBxSurveyDescription.Text = DataContainer.crSurveyDescription;
            txBxSurveyAuthor.Text = DataContainer.crSurveyAuthor;

            //counting the number of 'Yes' answers in the database
            using (IDbConnection cn = new SQLiteConnection(DataClass.LoadConnectionString()))
            {
                cn.Open();
                using (SQLiteCommand cmd = new SQLiteCommand())
                {
                    cmd.CommandText = "SELECT COUNT(Answer) FROM AnsweredSurvey WHERE Answer = 'Yes'"; 
                    cmd.Connection = (SQLiteConnection)cn;

                    int YesCount = Convert.ToInt32(cmd.ExecuteScalar());
                    txBxYes.Text = YesCount.ToString();
                }
            }

            //counting the number of 'No' answers in the database
            using (IDbConnection cn = new SQLiteConnection(DataClass.LoadConnectionString()))
            {
                cn.Open();
                using (SQLiteCommand cmd = new SQLiteCommand())
                {
                    cmd.CommandText = "SELECT COUNT(Answer) FROM AnsweredSurvey WHERE Answer = 'No'"; 
                    cmd.Connection = (SQLiteConnection)cn;

                    int NoCount = Convert.ToInt32(cmd.ExecuteScalar());
                    txBxNo.Text = NoCount.ToString();
                }
            }

            //counting the number of 'Definitely not' answers in the database
            using (IDbConnection cn = new SQLiteConnection(DataClass.LoadConnectionString()))
            {
                cn.Open();
                using (SQLiteCommand cmd = new SQLiteCommand())
                {
                    cmd.CommandText = "SELECT COUNT(Answer) FROM AnsweredSurvey WHERE Answer = 'Definitely not'";
                    cmd.Connection = (SQLiteConnection)cn;

                    int DefinitelyNotCount = Convert.ToInt32(cmd.ExecuteScalar());
                    txBxDefinetlyNot.Text = DefinitelyNotCount.ToString();
                }
            }

            //counting the number of 'Would consider it' answers in the database
            using (IDbConnection cn = new SQLiteConnection(DataClass.LoadConnectionString()))
            {
                cn.Open();
                using (SQLiteCommand cmd = new SQLiteCommand())
                {
                    cmd.CommandText = "SELECT COUNT(Answer) FROM AnsweredSurvey WHERE Answer = 'Would consider it'";
                    cmd.Connection = (SQLiteConnection)cn;

                    int ConsiderCount = Convert.ToInt32(cmd.ExecuteScalar());
                    txBxConsider.Text = ConsiderCount.ToString();
                }
            }

            //counting the number of 'Definitely' answers in the database
            using (IDbConnection cn = new SQLiteConnection(DataClass.LoadConnectionString()))
            {
                cn.Open();
                using (SQLiteCommand cmd = new SQLiteCommand())
                {
                    cmd.CommandText = "SELECT COUNT(Answer) FROM AnsweredSurvey WHERE Answer = 'Definitely'";
                    cmd.Connection = (SQLiteConnection)cn;

                    int DefinitelyCount = Convert.ToInt32(cmd.ExecuteScalar());
                    txBxDefinitely.Text = DefinitelyCount.ToString();
                }
            }

            //counting the number of 'Strongly Disagree' answers in the database
            using (IDbConnection cn = new SQLiteConnection(DataClass.LoadConnectionString()))
            {
                cn.Open();
                using (SQLiteCommand cmd = new SQLiteCommand())
                {
                    cmd.CommandText = "SELECT COUNT(Answer) FROM AnsweredSurvey WHERE Answer = 'Strongly Disagree'";
                    cmd.Connection = (SQLiteConnection)cn;

                    int StronglyDisagreeCount = Convert.ToInt32(cmd.ExecuteScalar());
                    txBxStronglyDisagree.Text = StronglyDisagreeCount.ToString();
                }
            }

            //counting the number of 'Disagree' answers in the database
            using (IDbConnection cn = new SQLiteConnection(DataClass.LoadConnectionString()))
            {
                cn.Open();
                using (SQLiteCommand cmd = new SQLiteCommand())
                {
                    cmd.CommandText = "SELECT COUNT(Answer) FROM AnsweredSurvey WHERE Answer = 'Disagree'";
                    cmd.Connection = (SQLiteConnection)cn;

                    int DisagreeCount = Convert.ToInt32(cmd.ExecuteScalar());
                    txBxDisagree.Text = DisagreeCount.ToString();
                }
            }

            //counting the number of 'Neutral' answers in the database
            using (IDbConnection cn = new SQLiteConnection(DataClass.LoadConnectionString()))
            {
                cn.Open();
                using (SQLiteCommand cmd = new SQLiteCommand())
                {
                    cmd.CommandText = "SELECT COUNT(Answer) FROM AnsweredSurvey WHERE Answer = 'Neutral'";
                    cmd.Connection = (SQLiteConnection)cn;

                    int NeutralCount = Convert.ToInt32(cmd.ExecuteScalar());
                    txBxNeutral.Text = NeutralCount.ToString();
                }
            }

            //counting the number of 'Agree' answers in the database
            using (IDbConnection cn = new SQLiteConnection(DataClass.LoadConnectionString()))
            {
                cn.Open();
                using (SQLiteCommand cmd = new SQLiteCommand())
                {
                    cmd.CommandText = "SELECT COUNT(Answer) FROM AnsweredSurvey WHERE Answer = 'Agree'";
                    cmd.Connection = (SQLiteConnection)cn;

                    int AgreeCount = Convert.ToInt32(cmd.ExecuteScalar());
                    txBxAgree.Text = AgreeCount.ToString();
                }
            }

            //counting the number of 'Strongly Agree' answers in the database
            using (IDbConnection cn = new SQLiteConnection(DataClass.LoadConnectionString()))
            {
                cn.Open();
                using (SQLiteCommand cmd = new SQLiteCommand())
                {
                    cmd.CommandText = "SELECT COUNT(Answer) FROM AnsweredSurvey WHERE Answer = 'Strongly Agree'";
                    cmd.Connection = (SQLiteConnection)cn;

                    int StronglyAgreeCount = Convert.ToInt32(cmd.ExecuteScalar());
                    txBxStronglyAgree.Text = StronglyAgreeCount.ToString();
                }
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            //writing survey analysis to text file
            StreamWriter SurveyFile = new StreamWriter("C:.\\Survey_Analysis.txt");

            SurveyFile.WriteLine(label1.Text + ": " + txBxSurveyId.Text);
            SurveyFile.WriteLine(label2.Text + ": " + txBxSurveyTitle.Text);
            SurveyFile.WriteLine(label4.Text + ": " + txBxSurveyDescription.Text);
            SurveyFile.WriteLine(label3.Text + ": " + txBxSurveyAuthor.Text);
            SurveyFile.WriteLine("");
            SurveyFile.WriteLine("SURVEY ANALYSIS DATA");
            SurveyFile.WriteLine("---------------------");
            SurveyFile.WriteLine("Below is the quantity of each answer choice");
            SurveyFile.WriteLine("");
            SurveyFile.WriteLine(label5.Text + ": " + txBxYes.Text);
            SurveyFile.WriteLine(label6.Text + ": " + txBxNo.Text);
            SurveyFile.WriteLine("");
            SurveyFile.WriteLine(label7.Text + ": " + txBxDefinetlyNot.Text);
            SurveyFile.WriteLine(label8.Text + ": " + txBxConsider.Text);
            SurveyFile.WriteLine(label9.Text + ": " + txBxDefinitely.Text);
            SurveyFile.WriteLine("");
            SurveyFile.WriteLine(label10.Text + ": " + txBxStronglyDisagree.Text);
            SurveyFile.WriteLine(label11.Text + ": " + txBxDisagree.Text);
            SurveyFile.WriteLine(label12.Text + ": " + txBxNeutral.Text);
            SurveyFile.WriteLine(label13.Text + ": " + txBxAgree.Text);
            SurveyFile.WriteLine(label14.Text + ": " + txBxStronglyAgree.Text);
            SurveyFile.Close();

            MessageBox.Show("Analysis Printed Successfully");
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
