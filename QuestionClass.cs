using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurveyApp
{
    public class QuestionClass
    {
        public int QuestionId { get; set; }
        public string QuestionText { get; set; }
        public string AnswerType { get; set; }
        public string Answer { get; set; }
        public int SurveyId { get; set; }
        public string Respondent { get; set; }
    }
}
