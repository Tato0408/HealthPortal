using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HealthPortal.Model.DTO;
using HealthPortal.Helper;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace HealthPortal.Model.DAO
{
    internal class DAOFirstUsage : DTOFirstUsage
    {
        SqlCommand command = new SqlCommand();
        public DataSet FillCombobox()
        {
            try
            {
                command.Connection = getConnection();
                string query = "SELECT * FROM [Institución].[tbCategoríaInstitución]";
                SqlCommand cmd = new SqlCommand(query, command.Connection);
                cmd.ExecuteNonQuery();
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adp.Fill(ds, "tbCategoríaInstitución");
                return ds;
            }
            catch (SqlException)
            {
                CommonMethods.HandleError("EC_101");
                return null;
            }
            catch (Exception)
            {
                CommonMethods.HandleError("EC_101");
                return null;
            }
            finally
            {
                command.Connection.Close();
            }
        }
        public string InstitutionDomain()
        {
            try
            {
                command.Connection = getConnection();
                string query = "SELECT [dominioInstitución] FROM [Institución].[tbInstitución]";
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
        public int RegisterInstitution()
        {
            try
            {
                command.Connection = getConnection();
                string query = "INSERT INTO [Institución].[tbInstitución] VALUES (@institutionName, @institutionAddress, @institutionLogo, @institutionEmail, @institutionDomain, @institutionPhone, @institutionCategoryID)";
                SqlCommand cmd = new SqlCommand(query, command.Connection);
                cmd.Parameters.AddWithValue("institutionName", InstitutionName);
                cmd.Parameters.AddWithValue("institutionAddress", InstitutionAddress);
                cmd.Parameters.AddWithValue("institutionLogo", InstitutionLogo);
                cmd.Parameters.AddWithValue("institutionEmail", InstitutionEmail);
                cmd.Parameters.AddWithValue("institutionDomain", InstitutionEmail.Substring(InstitutionEmail.LastIndexOf('@') + 1));
                cmd.Parameters.AddWithValue("institutionPhone", InstitutionPhone);
                cmd.Parameters.AddWithValue("institutionCategoryId", InstitutionCategoryID);
                return cmd.ExecuteNonQuery();
            }
            catch (SqlException)
            {
                CommonMethods.HandleError("EC_101");
                return -1;
            }
            catch (Exception)
            {
                CommonMethods.HandleError("EC_101");
                return -1;
            }
            finally
            {
                command.Connection.Close();
            }
        }
        public int RegisterFirstUser()
        {
            try
            {
                command.Connection = getConnection();
                string query = "EXEC [ProcedimientosAlmacenados].[spRegistrarUsuario] @username, @password, @token, @userStatus, @userAttempts, @temporaryPassword, @rememberCredentials, @roleId, @institutionId, @name, @lastName, @email, @phoneNumber";
                SqlCommand cmd = new SqlCommand(query, command.Connection);
                cmd.Parameters.AddWithValue("username", Username);
                cmd.Parameters.AddWithValue("password", Password);
                cmd.Parameters.AddWithValue("token", Token);
                cmd.Parameters.AddWithValue("userStatus", true);
                cmd.Parameters.AddWithValue("userAttempts", 0);
                cmd.Parameters.AddWithValue("temporaryPassword", false);
                cmd.Parameters.AddWithValue("rememberCredentials", false);
                cmd.Parameters.AddWithValue("roleId", 1);
                cmd.Parameters.AddWithValue("institutionId", 0);
                cmd.Parameters.AddWithValue("name", Name);
                cmd.Parameters.AddWithValue("lastName", LastName);
                cmd.Parameters.AddWithValue("email", Email);
                cmd.Parameters.AddWithValue("phoneNumber", Phone);
                return cmd.ExecuteNonQuery();
            }
            catch (SqlException)
            {
                CommonMethods.HandleError("EC_102");
                return -1;
            }
            catch (Exception)
            {
                //Inseratr usuarios
                CommonMethods.HandleError("EC_102");
                return -1;
            }
            finally
            {
                command.Connection.Close();
            }
        }
        public int GetMaxID()
        {
            try
            {
                command.Connection = getConnection();
                string query = "SELECT MAX(idPersona) FROM [Institución].[tbPersonas]";
                SqlCommand cmd = new SqlCommand(query, command.Connection);
                return Convert.ToInt32(cmd.ExecuteScalar());
            }
            catch (SqlException)
            {
                CommonMethods.HandleError("EC_201");
                return -1;
            }
            catch (Exception)
            {
                CommonMethods.HandleError("EC_201");
                return -1;
            }
            finally
            {
                command.Connection.Close();
            }
        }
        public int DeleteUser()
        {
            try
            {
                command.Connection = getConnection();
                string query = "EXEC [ProcedimientosAlmacenados].[spEliminarUsuario] @param1, @param2";
                SqlCommand cmd = new SqlCommand(query, command.Connection);
                cmd.Parameters.AddWithValue("param1", PersonID);
                cmd.Parameters.AddWithValue("param2", Username);
                return cmd.ExecuteNonQuery();
            }
            catch (SqlException)
            {
                CommonMethods.HandleError("EC_301");
                return -1;
            }
            catch (Exception)
            {
                CommonMethods.HandleError("EC_301");
                return -1;
            }
            finally
            {
                command.Connection.Close();
            }
        }
    }
}