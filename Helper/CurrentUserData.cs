using HealthPortal.View.Dashboard;
using HealthPortal.View.Settings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthPortal.Helper
{
    static class CurrentUserData
    {
        private static string username = string.Empty;
        private static bool status = false;
        private static string fullName = string.Empty;
        private static string password = string.Empty;
        private static string token = string.Empty;
        private static int roleId = 0;
        private static bool temporaryPassword = false;
        private static string email = string.Empty;
        private static int personID = 0;
        private static int serverSettingsOrigin = 1;
        private static int screenWidth;
        private static int screenHeight;
        private static bool isSideBarExpanded = true;
        private static bool fullScreen = false;

        public static string Username { get => username; set => username = value; }
        public static bool Status { get => status; set => status = value; }
        public static string FullName { get => fullName; set => fullName = value; }
        public static string Password { get => password; set => password = value; }
        public static string Token { get => token; set => token = value; }
        public static int RoleId { get => roleId; set => roleId = value; }
        public static bool TemporaryPassword { get => temporaryPassword; set => temporaryPassword = value; }
        public static string Email { get => email; set => email = value; }
        public static int PersonID { get => personID; set => personID = value; }
        public static int ServerSettingsOrigin { get => serverSettingsOrigin; set => serverSettingsOrigin = value; }
        public static int ScreenWidth { get => screenWidth; set => screenWidth = value; }
        public static int ScreenHeight { get => screenHeight; set => screenHeight = value; }
        public static bool IsSideBarExpanded { get => isSideBarExpanded; set => isSideBarExpanded = value; }
        public static bool FullScreen { get => fullScreen; set => fullScreen = value; }
    }
}
