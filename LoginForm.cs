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
    public partial class LoginForm : Form
    {
        //variable declarations
        int loginAttempts = 3;
        bool Exists = false;

        public LoginForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //adding items to the combobox
            cmBxUserType.Items.Add("User");
            cmBxUserType.Items.Add("Admin");
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //creating instance of the userclass to be used in querying data from the database
            UserClass u = new UserClass();

            //variable to validate successsful login
            bool successLogin = false;

            //reading from database and validating login
            using (IDbConnection cn = new SQLiteConnection(DataClass.LoadConnectionString()))
            {
                
                using (SQLiteCommand cmd = new SQLiteCommand())
                {
                    cmd.CommandText = "SELECT * FROM UserTable WHERE UserName = '" + txBxUsername.Text + "' AND Password = '" + txBxPassword.Text + "' AND UserType = '" + cmBxUserType.Text + "'";
                    cmd.Connection = (SQLiteConnection)cn;

                    cn.Open();
                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        reader.Read();
                        if (reader.HasRows)
                        {
                            
                            u.UserName = reader["UserName"].ToString();                            
                            u.Password = reader["Password"].ToString();
                            u.UserType = reader["UserType"].ToString();
                            DataContainer.crUserName = u.UserName;
                            DataContainer.crUserType = u.UserType;
                            successLogin = true;
          
                        }
                        else
                        {
                            MessageBox.Show("There was an error, Please try again and ensure to fill in all fields");
                            txBxUsername.Text = "";
                            txBxPassword.Text = "";
                            cmBxUserType.Text = "";
                            loginAttempts = loginAttempts - 1;
                            
                            if(loginAttempts == 0)
                            {
                                MessageBox.Show("You have excceded the login attempt limit, the program will now close");
                                this.Close();
                            }
                        }
                    } 
                }
            }

            //on succeessful login
            if (successLogin == true)
            {
                this.Hide();
                SurveyListForm survey_list_form = new SurveyListForm();
                survey_list_form.ShowDialog();
                this.Close();
            }
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            //checking the database to see if account already exists
            using (IDbConnection cn = new SQLiteConnection(DataClass.LoadConnectionString()))
            {
                cn.Open();
                using (SQLiteCommand cmd = new SQLiteCommand())
                {
                    cmd.CommandText = "SELECT * FROM UserTable WHERE UserName = '" + txBxUsername.Text + "'";
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
            
            //validating sign up
            if(Exists == true)
            {
                MessageBox.Show("Error, Account Already Exists");
            }
            else if (cmBxUserType.Text == "Admin")
            {
                MessageBox.Show("Error, unable to create an Admin account");
                btnSignUp.Enabled = false;
            }
            else if(txBxUsername.Text == "" || txBxPassword.Text == "" || cmBxUserType.Text == "")
            {
                MessageBox.Show("Ensure to fill in all fields");
            }
            else
            {
                UserClass u = new UserClass();
                u.UserName = txBxUsername.Text;
                u.Password = txBxPassword.Text;
                u.UserType = cmBxUserType.Text;
                DataClass.SaveUser(u);
                MessageBox.Show("Account Successfully created!");
            }
        }
    }
}
