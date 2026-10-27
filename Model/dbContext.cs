using HealthPortal.Helper;
using System;
using System.Data;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HealthPortal.Model.DTO;

namespace HealthPortal.Model
{
    public class dbContext
    {
        public static SqlConnection getConnection()
        {
            try
            {
                SqlConnection connection;
                if (string.IsNullOrEmpty(DTOdbContext.User) && string.IsNullOrEmpty(DTOdbContext.Password))
                {
                    connection = new SqlConnection($"Server = {DTOdbContext.Server}; DataBase = {DTOdbContext.Database}; Integrated Security = true");
                }
                else
                {
                    connection = new SqlConnection($"Server = {DTOdbContext.Server}; DataBase = {DTOdbContext.Database}; User Id = {DTOdbContext.User}; Password = {DTOdbContext.Password}");
                }
                connection.Open();
                return connection;
            }
            catch (SqlException)
            {
                CommonMethods.HandleError("EC_001");
                return null;
            }
            catch (Exception)
            {
                return null;
            }
        }
        public static SqlConnection testConnection(string server, string database, string user, string password)
        {
            try
            {
                SqlConnection connection;
                if (string.IsNullOrEmpty(user) && string.IsNullOrEmpty(password))
                {
                    connection = new SqlConnection($"Server = {server}; DataBase = {database}; Integrated Security = true");
                }
                else
                {
                    connection = new SqlConnection($"Server = {server}; DataBase = {database}; User Id = {user}; Password = {password}");
                }
                connection.Open();
                return connection;
            }
            catch (SqlException)
            {
                CommonMethods.HandleError("EC_001");
                return null;
            }
        }
    }
}
