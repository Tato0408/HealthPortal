using HealthPortal.Helper;
using HealthPortal.Model.DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Windows.Forms;

namespace HealthPortal.Model.DAO
{
    internal class DAOMainPage : DTOMainPage
    {
        SqlCommand command = new SqlCommand();
        public string GetInstitutionName()
        {
            try
            {
                command.Connection = getConnection();
                string query = "SELECT nombreInstitución FROM [Institución].[tbInstitución]";
                SqlCommand cmd = new SqlCommand(query, command.Connection);
                return (string)cmd.ExecuteScalar();
            }
            catch (SqlException)
            {
                CommonMethods.HandleError("EC_201");
                return null;
            }
            catch (Exception)
            {
                CommonMethods.HandleError("EC_201");
                return null;
            }
            finally
            {
                command.Connection.Close();
            }
        }
    }
}