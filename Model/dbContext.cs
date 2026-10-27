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
        public static string BuildConnectionString()
        {
            if (string.IsNullOrEmpty(DTOdbContext.User) && string.IsNullOrEmpty(DTOdbContext.Password))
            {
                return $"Server = {DTOdbContext.Server}; DataBase = {DTOdbContext.Database}; Integrated Security = true";
            }
            return $"Server = {DTOdbContext.Server}; DataBase = {DTOdbContext.Database}; User Id = {DTOdbContext.User}; Password = {DTOdbContext.Password}";
        }
        // Los TableAdapters de los reportes leen su conexión de Properties.Settings; se reemplaza en
        // tiempo de ejecución para que usen el mismo servidor configurado en config_server.xml.
        public static void ApplyConnectionToReports()
        {
            Properties.Settings.Default["db_aad48c_healthportalConnectionString"] = BuildConnectionString();
        }
        public static SqlConnection getConnection()
        {
            try
            {
                SqlConnection connection = new SqlConnection(BuildConnectionString());
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
