using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthPortal.Model.DTO
{
    internal class DTOUserAdministration : dbContext
    {
        // Atributos de tbRoles
        private int roleId;
        private string roleName;

        // Atributos de tbUsuarios
        private string username;
        private string password;
        private string token;
        private bool userStatus;
        private int userAttempts;
        private bool temporaryPassword;

        // Atributos de tbPersonas
        private int personId;
        private string personName;
        private string personLastName;
        private string email;
        private string phoneNumber;

        public int RoleId { get => roleId; set => roleId = value; }
        public string RoleName { get => roleName; set => roleName = value; }
        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        public string Token { get => token; set => token = value; }
        public bool UserStatus { get => userStatus; set => userStatus = value; }
        public int UserAttempts { get => userAttempts; set => userAttempts = value; }
        public bool TemporaryPassword { get => temporaryPassword; set => temporaryPassword = value; }
        public int PersonId { get => personId; set => personId = value; }
        public string PersonName { get => personName; set => personName = value; }
        public string PersonLastName { get => personLastName; set => personLastName = value; }
        public string Email { get => email; set => email = value; }
        public string PhoneNumber { get => phoneNumber; set => phoneNumber = value; }
    }
}
