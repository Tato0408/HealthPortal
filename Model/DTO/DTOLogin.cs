using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthPortal.Model.DTO
{   public class DTOLogin : dbContext
    {
        private string username;
        private string password;
        private string token;

        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        public string Token { get => token; set => token = value; }
    }
}
