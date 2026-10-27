using HealthPortal.Helper;
using HealthPortal.Model.DTO;
using HealthPortal.View.UserAdministration;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace HealthPortal.Model.DAO
{
    internal class DAOUserAdministration : DTOUserAdministration
    {
        readonly SqlCommand command = new SqlCommand();
        public DataSet GetUserInfo()
        {
            try
            {
                command.Connection = getConnection();
                string query = "SELECT * FROM [Vistas].[viewPersonas]";
                SqlCommand cmd = new SqlCommand(query, command.Connection);
                cmd.ExecuteNonQuery();
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adp.Fill(ds, "viewPersonas");
                return ds;
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
        public DataSet GetSortedUserInfo(string column)
        {
            try
            {
                command.Connection = getConnection();
                string query = $"SELECT * FROM [Vistas].[viewPersonas] ORDER BY [{column}]";
                SqlCommand cmd = new SqlCommand(query, command.Connection);
                cmd.ExecuteNonQuery();
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adp.Fill(ds, "viewPersonas");
                return ds;
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
        public DataSet SearchDesiredUserInfo(string search)
        {
            try
            {
                command.Connection = getConnection();
                string query = $"SELECT * FROM [Vistas].[viewPersonas] WHERE [Nombres] LIKE '%{search}%' OR [Apellidos] LIKE '%{search}%' or [Correo Electrónico] LIKE '%{search}%'";
                SqlCommand cmd = new SqlCommand(query, command.Connection);
                //cmd.Parameters.AddWithValue("param1", column);
                cmd.ExecuteNonQuery();
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adp.Fill(ds, "viewPersonas");
                return ds;
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
        public DataSet GetRoles()
        {
            try
            {
                command.Connection = getConnection();
                string query = "SELECT * FROM [Institución].[tbRoles]";
                SqlCommand cmd = new SqlCommand(query, command.Connection);
                cmd.ExecuteNonQuery();
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adp.Fill(ds, "tbRoles");
                return ds;
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
        public int RegisterUser()
        {
            try
            {
                command.Connection = getConnection();
                string query = "EXEC [ProcedimientosAlmacenados].[spRegistrarUsuario] @username, @password, @token, @userStatus, @userAttempts, @temporaryPassword, @rememberCredentials, @roleId, @institutionId, @name, @lastName, @email, @phoneNumber";
                SqlCommand cmd = new SqlCommand(query, command.Connection);
                cmd.Parameters.AddWithValue("username", Username);
                cmd.Parameters.AddWithValue("password", Password);
                cmd.Parameters.AddWithValue("token", Token);
                cmd.Parameters.AddWithValue("userStatus", UserStatus);
                cmd.Parameters.AddWithValue("userAttempts", UserAttempts);
                cmd.Parameters.AddWithValue("temporaryPassword", true);
                cmd.Parameters.AddWithValue("rememberCredentials", false);
                cmd.Parameters.AddWithValue("roleId", RoleId);
                cmd.Parameters.AddWithValue("institutionId", 0);
                cmd.Parameters.AddWithValue("name", PersonName);
                cmd.Parameters.AddWithValue("lastName", PersonLastName);
                cmd.Parameters.AddWithValue("email", Email);
                cmd.Parameters.AddWithValue("phoneNumber", PhoneNumber);
                return cmd.ExecuteNonQuery();
            }
            catch (SqlException)
            {
                CommonMethods.HandleError("EC_103");
                return -1;
            }
            catch (Exception)
            {
                CommonMethods.HandleError("EC_103");
                return -1;
            }
            finally
            {
                command.Connection.Close();
            }
        }
        public int UpdateUserInfo()
        {
            try
            {
                command.Connection = getConnection();
                string queryPersonas = "UPDATE [Institución].[tbPersonas] SET nombrePersona = @param1, apellidoPersona = @param2, correoPersona = @param3, telefonoPersona = @param4 WHERE idPersona = @param5";
                SqlCommand cmdPersonas = new SqlCommand(queryPersonas, command.Connection);
                cmdPersonas.Parameters.AddWithValue("param1", PersonName);
                cmdPersonas.Parameters.AddWithValue("param2", PersonLastName);
                cmdPersonas.Parameters.AddWithValue("param3", Email);
                cmdPersonas.Parameters.AddWithValue("param4", PhoneNumber);
                cmdPersonas.Parameters.AddWithValue("param5", PersonId);
                int result = cmdPersonas.ExecuteNonQuery();
                if (result == 1)
                {
                    string query = "UPDATE [Institución].[tbUsuarios] SET idRol = @param1 WHERE usuario = @param2";
                    SqlCommand cmd = new SqlCommand(query, command.Connection);
                    cmd.Parameters.AddWithValue("param1", RoleId);
                    cmd.Parameters.AddWithValue("param2", Username);
                    result = cmd.ExecuteNonQuery();
                    if (result == 1) result = 2;
                }
                return result;
            }
            catch (SqlException)
            {
                CommonMethods.HandleError("EC_303");
                return -1;
            }
            catch (Exception)
            {
                CommonMethods.HandleError("EC_303");
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
                cmd.Parameters.AddWithValue("param1", PersonId);
                cmd.Parameters.AddWithValue("param2", Username);
                return cmd.ExecuteNonQuery();
            }
            catch (SqlException)
            {
                CommonMethods.HandleError("EC_403");
                return -1;
            }
            catch (Exception)
            {
                CommonMethods.HandleError("EC_403");
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
        public bool ReestablishUserPassword()
        {
            try
            {
                command.Connection = getConnection();
                string query = "EXEC [ProcedimientosAlmacenados].[spCambiarContraseña] @param1, @param2, @param3";
                SqlCommand cmd = new SqlCommand(query, command.Connection);
                cmd.Parameters.AddWithValue("param1", Password);
                cmd.Parameters.AddWithValue("param2", Username);
                cmd.Parameters.AddWithValue("param3", true);
                if (cmd.ExecuteNonQuery() == 2)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (SqlException)
            {
                CommonMethods.HandleError("EC_302");
                return false;
            }
            catch (Exception)
            {
                CommonMethods.HandleError("EC_302");
                return false;
            }
            finally
            {
                command.Connection.Close();
            }
        }
    }
}