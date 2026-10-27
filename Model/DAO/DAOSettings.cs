using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HealthPortal.Helper;
using HealthPortal.Model.DTO;

namespace HealthPortal.Model.DAO
{
    internal class DAOSettings : DTOSettings
    {
        readonly SqlCommand command = new SqlCommand();
        public bool RegisterQuestion()
        {
            try
            {
                command.Connection = getConnection();
                string query = "INSERT INTO [Institución].[tbPreguntas] VALUES (@question)";
                SqlCommand cmd = new SqlCommand(query, command.Connection);
                cmd.Parameters.AddWithValue("question", Question);
                return cmd.ExecuteNonQuery() == 1 ? true : false;
            }
            catch (SqlException)
            {
                CommonMethods.HandleError("EC_101");
                return false;
            }
            catch (Exception)
            {
                CommonMethods.HandleError("EC_101");
                return false;
            }
            finally
            {
                command.Connection.Close();
            }
        }
        public bool UpdateQuestion()
        {
            try
            {
                command.Connection = getConnection();
                string query = "UPDATE [Institución].[tbPreguntas] SET pregunta = @question WHERE idPregunta = @questionID";
                SqlCommand cmd = new SqlCommand(query, command.Connection);
                cmd.Parameters.AddWithValue("question", Question);
                cmd.Parameters.AddWithValue("questionID", QuestionID);
                return cmd.ExecuteNonQuery() == 1 ? true : false;
            }
            catch (SqlException)
            {
                CommonMethods.HandleError("EC_003");
                return false;
            }
            catch (Exception)
            {
                return false;
            }
            finally
            {
                command.Connection.Close();
            }
        }
        public bool RegisterAnswer()
        {
            try
            {
                command.Connection = getConnection();
                string query = "INSERT INTO [Institución].[tbRespuestas] VALUES (@username, @questionID, @answer)";
                SqlCommand cmd = new SqlCommand(query, command.Connection);
                cmd.Parameters.AddWithValue("username", Username);
                cmd.Parameters.AddWithValue("questionID", QuestionID);
                cmd.Parameters.AddWithValue("answer", Answer);
                return cmd.ExecuteNonQuery() == 1 ? true : false;
            }
            catch (SqlException)
            {
                
                CommonMethods.HandleError("EC_002");
                return false;
            }
            catch (Exception)
            {
                return false;
            }
            finally
            {
                command.Connection.Close();
            }
        }
        public bool UpdateAnswer()
        {
            try
            {
                command.Connection = getConnection();
                string query = "UPDATE [Institución].[tbRespuestas] SET respuesta = @answer WHERE idRespuesta = @answerID";
                SqlCommand cmd = new SqlCommand(query, command.Connection);
                cmd.Parameters.AddWithValue("answer", Answer);
                cmd.Parameters.AddWithValue("answerID", AnswerID);
                return cmd.ExecuteNonQuery() == 1 ? true : false;
            }
            catch (SqlException)
            {
                CommonMethods.HandleError("EC_003");
                return false;
            }
            catch (Exception)
            {
                return false;
            }
            finally
            {
                command.Connection.Close();
            }
        }
        public bool DeleteSecurityQuestion()
        {
            try
            {
                command.Connection = getConnection();
                string query = "DELETE FROM [Institución].[tbPreguntas] WHERE idPregunta = @questionID";
                SqlCommand cmd = new SqlCommand(query, command.Connection);
                cmd.Parameters.AddWithValue("questionID", QuestionID);
                return cmd.ExecuteNonQuery() == 1 ? true : false;
            }
            catch (SqlException)
            {
                CommonMethods.HandleError("EC_005");
                return false;
            }
            catch (Exception)
            {
                return false;
            }
            finally
            {
                command.Connection.Close();
            }
        }
        public bool DeleteSecurityAnswer()
        {
            try
            {
                command.Connection = getConnection();
                string query = "DELETE FROM [Institución].[tbRespuestas] WHERE idRespuesta = @answerID";
                SqlCommand cmd = new SqlCommand(query, command.Connection);
                cmd.Parameters.AddWithValue("answerID", AnswerID);
                return cmd.ExecuteNonQuery() == 1 ? true : false;
            }
            catch (SqlException)
            {
                CommonMethods.HandleError("EC_005");
                return false;
            }
            catch (Exception)
            {
                return false;
            }
            finally
            {
                command.Connection.Close();
            }
        }
        public bool CheckSecurityQuestions()
        {
            try
            {
                command.Connection = getConnection();
                string query = "SELECT COUNT(*) FROM [Institución].[tbPreguntas]";
                SqlCommand cmd = new SqlCommand(query, command.Connection);
                return (int)cmd.ExecuteScalar() > 0 ? true : false;
            }
            catch (SqlException)
            {
                CommonMethods.HandleError("EC_201");
                return false;
            }
            catch (Exception)
            {
                CommonMethods.HandleError("EC_201");
                return false;
            }
            finally
            {
                command.Connection.Close();
            }
        }
        public DataSet RetrieveSecurityQuestions()
        {
            try
            {
                command.Connection = getConnection();
                string query = "SELECT * FROM [Vistas].[viewPreguntasDeSeguridad]";
                SqlCommand cmd = new SqlCommand(query, command.Connection);
                cmd.ExecuteNonQuery();
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adp.Fill(ds, "viewPreguntasDeSeguridad");
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
        public DataSet RetrieveOnlySecurityQuestions()
        {
            try
            {
                command.Connection = getConnection();
                string query = "SELECT * FROM [Institución].[tbPreguntas]";
                SqlCommand cmd = new SqlCommand(query, command.Connection);
                cmd.ExecuteNonQuery();
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adp.Fill(ds, "tbPreguntas");
                return ds;
            }
            catch (SqlException)
            {
                CommonMethods.HandleError("EC_005");
                return null;
            }
            catch (Exception)
            {
                return null;
            }
            finally
            {
                command.Connection.Close();
            }
        }
        public DataSet RetrieveSecurityAnswers()
        {
            try
            {
                command.Connection = getConnection();
                string query = "SELECT [ID], [Pregunta], [ID Pregunta] FROM [Vistas].[viewRespuestasDeSeguridad] WHERE usuario = @username";
                SqlCommand cmd = new SqlCommand(query, command.Connection);
                cmd.Parameters.AddWithValue("username", Username);
                cmd.ExecuteNonQuery();
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adp.Fill(ds, "viewRespuestasDeSeguridad");
                return ds;
            }
            catch (SqlException)
            {
                CommonMethods.HandleError("EC_005");
                return null;
            }
            catch (Exception)
            {
                return null;
            }
            finally
            {
                command.Connection.Close();
            }
        }
        public string GetSecurityQuestion()
        {
            try
            {
                command.Connection = getConnection();
                string query = "SELECT pregunta FROM [Institución].[tbPreguntas] WHERE idPregunta = @questionID";
                SqlCommand cmd = new SqlCommand(query, command.Connection);
                cmd.Parameters.AddWithValue("questionID", QuestionID);
                return (string)cmd.ExecuteScalar();
            }
            catch (SqlException)
            {
                CommonMethods.HandleError("EC_005");
                return null;
            }
            catch (Exception)
            {
                return null;
            }
            finally
            {
                command.Connection.Close();
            }
        }
    }
}
