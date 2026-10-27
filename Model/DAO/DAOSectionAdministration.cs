using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HealthPortal.Model.DTO;
using HealthPortal.Helper;

namespace HealthPortal.Model.DAO
{
    class DAOSectionAdministration : DTOSectionAdministration
    {
        readonly SqlCommand command = new SqlCommand();

        public DataSet FillCombo(string table, string schema)
        {
            try
            {
                command.Connection = getConnection();
                string query = $"SELECT * FROM {schema}.{table}";
                SqlCommand cmd = new SqlCommand(query, command.Connection);
                cmd.ExecuteNonQuery();
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adp.Fill(ds, $"{table}");
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
        public int AddSpecialty()
        {
            try
            {
                command.Connection = getConnection();
                string query = "EXEC [ProcedimientosAlmacenados].[spIngresarEspecialidad] @param1";
                SqlCommand cmd = new SqlCommand(query, command.Connection);
                cmd.Parameters.AddWithValue("param1", Specialty);
                return cmd.ExecuteNonQuery();
            }
            catch (SqlException)
            {
                CommonMethods.HandleError("EC_104");
                return -1;
            }
            finally
            {
                command.Connection.Close();
            }
        }
        public int AddAcademicSection()
        {
            try
            {
                command.Connection = getConnection();
                string query = "EXEC [ProcedimientosAlmacenados].[spIngresarSeccionAcademica] @param1";
                SqlCommand cmd = new SqlCommand(query, command.Connection);
                cmd.Parameters.AddWithValue("param1", AcademicSection);
                return cmd.ExecuteNonQuery();
            }
            catch (SqlException)
            {
                CommonMethods.HandleError("EC_105");
                return -1;

            }
            finally
            {
                command.Connection.Close();
            }
        }
        public int AddSection()
        {
            try
            {
                command.Connection = getConnection();
                string query = "EXEC [ProcedimientosAlmacenados].[spIngresarSeccion] @param1, @param2, @param3, @param4";
                SqlCommand cmd = new SqlCommand(query, command.Connection);
                cmd.Parameters.AddWithValue("param1", TechnicalGroup);
                cmd.Parameters.AddWithValue("param2", GradeID);
                cmd.Parameters.AddWithValue("param3", AcademicSectionID);
                cmd.Parameters.AddWithValue("param4", SpecialtyID);
                return cmd.ExecuteNonQuery();
            }
            catch (SqlException)
            {
                CommonMethods.HandleError("EC_107");
                return -1;
            }
            finally
            {
                command.Connection.Close();
            }
        }
        public int AddGrade()
        {
            try
            {
                command.Connection = getConnection();
                string query = "EXEC [ProcedimientosAlmacenados].[spIngresarGrado] @grade";
                SqlCommand cmd = new SqlCommand(query, command.Connection);
                cmd.Parameters.AddWithValue("grade", Grade);
                return cmd.ExecuteNonQuery();
            }
            catch (SqlException)
            {
                CommonMethods.HandleError("EC_106");
                return -1;
            }
            catch (Exception)
            {
                CommonMethods.HandleError("EC_106");
                return -1;
            }
            finally
            {
                command.Connection.Close();
            }
        }
        public int UpdateSpecialty()
        {
            try
            {
                command.Connection = getConnection();
                string query = "EXEC  [ProcedimientosAlmacenados].[spActualizarEspecialidad] @param1, @param2";
                SqlCommand cmd = new SqlCommand(query, command.Connection);
                cmd.Parameters.AddWithValue("@param1", Specialty);
                cmd.Parameters.AddWithValue("@param2", SpecialtyID);
                return cmd.ExecuteNonQuery();
            }
            catch (SqlException)
            {
                CommonMethods.HandleError("EC_104");
                return -1;

            }
            finally
            {
                command.Connection.Close();
            }
        }
        public int UpdateAcademicSection()
        {
            try
            {
                command.Connection = getConnection();
                string query = "EXEC [ProcedimientosAlmacenados].[spActualizarSeccionAcademica] @param1, @param2";
                SqlCommand cmd = new SqlCommand(query, command.Connection);
                cmd.Parameters.AddWithValue("@param1", AcademicSection);
                cmd.Parameters.AddWithValue("@param2", AcademicSectionID);
                return cmd.ExecuteNonQuery();
            }
            catch (SqlException)
            {
                CommonMethods.HandleError("EC_305");
                return -1;

            }
            finally
            {
                command.Connection.Close();
            }
        }
        public int UpdateSection()
        {
            try
            {
                command.Connection = getConnection();
                string query = "EXEC [ProcedimientosAlmacenados].[spActualizarSeccion] @param1, @param2, @param3, @param4, @param5";
                MessageBox.Show($"{TechnicalGroup} {GradeID} {SpecialtyID} {AcademicSectionID} {SectionID}");
                SqlCommand cmd = new SqlCommand(query, command.Connection);
                cmd.Parameters.AddWithValue("@param1", TechnicalGroup);
                cmd.Parameters.AddWithValue("@param2", GradeID);
                cmd.Parameters.AddWithValue("@param3", SpecialtyID);
                cmd.Parameters.AddWithValue("@param4", AcademicSectionID);
                cmd.Parameters.AddWithValue("@param5", SectionID);
                return cmd.ExecuteNonQuery();
            }
            catch (SqlException)
            {
                CommonMethods.HandleError("EC_307");
                return -1;
            }
            finally
            {
                command.Connection.Close();
            }
        }
        public int UpdateGrade()
        {
            try
            {
                command.Connection = getConnection();
                string query = "EXEC [ProcedimientosAlmacenados].[spActualizarGrado] @grade, @gradeID";
                SqlCommand cmd = new SqlCommand(query, command.Connection);
                cmd.Parameters.AddWithValue("grade", Grade);
                cmd.Parameters.AddWithValue("gradeID", GradeID);
                return cmd.ExecuteNonQuery();
            }
            catch (SqlException)
            {
                CommonMethods.HandleError("EC_306");
                return -1;
            }
            catch (Exception)
            {
                return -1;
            }
            finally
            {
                command.Connection.Close();
            }
        }
        public int DeleteAcademicSection()
        {
            try
            {
                command.Connection = getConnection();
                string query = "EXEC [ProcedimientosAlmacenados].[spEliminarSeccionAcademica] @param1";
                SqlCommand cmd = new SqlCommand(query, command.Connection);
                cmd.Parameters.AddWithValue("param1", AcademicSectionID);
                return cmd.ExecuteNonQuery();
            }
            catch (SqlException)
            {
                CommonMethods.HandleError("EC_405");
                return -1;

            }
            finally
            {
                command.Connection.Close();
            }
        }
        public int DeleteSpecialty()
        {
            try
            {
                command.Connection = getConnection();
                string query = "EXEC [ProcedimientosAlmacenados].[spEliminarEspecialidad] @param1";
                SqlCommand cmd = new SqlCommand(query, command.Connection);
                cmd.Parameters.AddWithValue("param1", SpecialtyID);
                return cmd.ExecuteNonQuery();
            }
            catch (SqlException)
            {
                CommonMethods.HandleError("EC_404");
                return -1;

            }
            finally
            {
                command.Connection.Close();
            }
        }
        public int DeleteSection()
        {
            try
            {
                command.Connection = getConnection();
                string query = "EXEC [ProcedimientosAlmacenados].[spEliminarSeccion] @param1";
                SqlCommand cmd = new SqlCommand(query, command.Connection);
                cmd.Parameters.AddWithValue("param1", SectionID);
                return cmd.ExecuteNonQuery();
            }
            catch (SqlException)
            {
                CommonMethods.HandleError("EC_407");
                return -1;

            }
            finally
            {
                command.Connection.Close();
            }
        }
        public int DeleteGrade()
        {
            try
            {
                command.Connection = getConnection();
                string query = "EXEC [ProcedimientosAlmacenados].[spEliminarGrado] @gradeID";
                SqlCommand cmd = new SqlCommand(query, command.Connection);
                cmd.Parameters.AddWithValue("gradeID", GradeID);
                return cmd.ExecuteNonQuery();
            }
            catch (SqlException)
            {
                CommonMethods.HandleError("EC_406");
                return -1;
            }
            catch (Exception)
            {
                return -1;
            }
            finally
            {
                command.Connection.Close();
            }
        }
        public DataSet RetrieveSectionData()
        {
            try
            {
                command.Connection = getConnection();
                string query = "SELECT * FROM [Vistas].[viewGradoSeccion]";
                SqlCommand cmd = new SqlCommand(query, command.Connection);
                cmd.ExecuteNonQuery();
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adp.Fill(ds, "viewGradoSeccion");
                return ds;
            }
            catch (SqlException)
            {
                CommonMethods.HandleError("EC_201");
                return null;
            }
            finally
            {
                command.Connection.Close();
            }
        }
        public DataSet RetrieveSpecialtyData()
        {
            try
            {
                command.Connection = getConnection();
                string query = "SELECT * FROM [Vistas].[viewEspecialidades]";
                SqlCommand cmd = new SqlCommand(query, command.Connection);
                cmd.ExecuteNonQuery();
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adp.Fill(ds, "viewEspecialidades");
                return ds;
            }
            catch (SqlException)
            {
                CommonMethods.HandleError("EC_201");
                return null;
            }
            finally
            {
                command.Connection.Close();
            }
        }
        public DataSet RetrieveAcademicSectionData()
        {
            try
            {
                command.Connection = getConnection();
                string query = "SELECT * FROM [Vistas].[viewSeccionesAcademicas]";
                SqlCommand cmd = new SqlCommand(query, command.Connection);
                cmd.ExecuteNonQuery();
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adp.Fill(ds, "viewSeccionesAcademicas");
                return ds;
            }
            catch (SqlException)
            {
                CommonMethods.HandleError("EC_201");
                return null;
            }
            finally
            {
                command.Connection.Close();
            }
        }
        public DataSet RetrieveGradeData()
        {
            try
            {
                command.Connection = getConnection();
                string query = "SELECT * FROM [Vistas].[viewGrados]";
                SqlCommand cmd = new SqlCommand(query, command.Connection);
                cmd.ExecuteNonQuery();
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adp.Fill(ds, "viewGrados");
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
    }
}