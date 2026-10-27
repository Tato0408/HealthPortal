using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthPortal.Model.DTO
{
    internal class DTOSettings : dbContext
    {
        private int questionID;
        private string question;
        private string username;
        private int answerID;
        private string answer;

        public int QuestionID { get => questionID; set => questionID = value; }
        public string Question { get => question; set => question = value; }
        public string Username { get => username; set => username = value; }
        public int AnswerID { get => answerID; set => answerID = value; }
        public string Answer { get => answer; set => answer = value; }
    }
}
