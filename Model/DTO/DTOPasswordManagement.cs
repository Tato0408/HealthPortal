using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthPortal.Model.DTO
{
    internal class DTOPasswordManagement : dbContext
    {
        private string username;
        private string password;
        private int questionID;
        private string answer;
        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        public int QuestionID { get => questionID; set => questionID = value; }
        public string Answer { get => answer; set => answer = value; }
    }
}
