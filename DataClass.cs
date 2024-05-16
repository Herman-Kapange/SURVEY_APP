using Dapper;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurveyApp
{
    //class responsible for dealing with database data
    public class DataClass
    {
        //method to save new user to the database
        public static void SaveUser(UserClass user)
        {
            using (IDbConnection cn = new SQLiteConnection(LoadConnectionString()))
            {
                cn.Execute("insert into UserTable (UserName, Password, UserType) values (@UserName, @Password, @UserType)", user);
            }
        }

        //method responsible for saving a survey to the database
        public static void SaveSurvey(SurveyClass survey)
        {
            using (IDbConnection cn = new SQLiteConnection(LoadConnectionString()))
            {
                cn.Execute("insert into SurveyTable (SurveyTitle, SurveyAuthor, SurveyDescription) values (@SurveyTitle, @SurveyAuthor, @SurveyDescription)", survey);
            }
        }

        //method responsible for saving questions to the database
        public static void SaveQuestions(QuestionClass question)
        {
            using (IDbConnection cn = new SQLiteConnection(LoadConnectionString()))
            {
                cn.Execute("insert into SurveyQuestion (QuestionText, AnswerType, SurveyId) values (@QuestionText, @AnswerType, @SurveyId)", question);
            }
        }

        //method responsible for saving answered questions to the database
        public static void SaveAnsweredQuestion(QuestionClass answeredSurvey)
        {
            using (IDbConnection cn = new SQLiteConnection(LoadConnectionString()))
            {
                cn.Execute("insert into AnsweredSurvey (QuestionId, QuestionText, AnswerType, Answer, Respondent) values (@QuestionId, @QuestionText, @AnswerType, @Answer, @Respondent)", answeredSurvey);
            }
        }

        //connection string retriever
        public static string LoadConnectionString(string id = "cnString")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }
    }
}
