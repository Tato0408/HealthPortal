using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HealthPortal.Controller.Dashboard;
using HealthPortal.Helper;
using HealthPortal.Model.DTO;

namespace HealthPortal.Model.DAO
{
    internal class DAOInventoryAdministration : DTOInventoryAdministration
    {
        readonly SqlCommand command = new SqlCommand();
        public DataSet FillCombo()
        {
            try
            {
                //Se crea una conexion para garantizar que haya conexion con la base
                command.Connection = getConnection();
                string query = "SELECT * FROM [Inventario].[tbCategoriaMedicamento]";
                SqlCommand cmd = new SqlCommand(query, command.Connection);
                cmd.ExecuteNonQuery();
                SqlDataAdapter adpInventory = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adpInventory.Fill(ds, "tbCategoriaMedicamento");
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
        public DataTable RetrieveChartData()
        {
            try
            {
                command.Connection = getConnection();
                string query = "EXEC [ProcedimientosAlmacenados].[spIndiceUsoInventario] @fechaInicio, @fechaFin";
                SqlCommand cmd = new SqlCommand(query, command.Connection);
                cmd.Parameters.AddWithValue("fechaInicio", FechaInicio);
                cmd.Parameters.AddWithValue("fechaFin", FechaFin);
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adp.Fill(dt);
                return dt;
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
        public byte[] GetImageBytes()
        {
            try
            {
                command.Connection = getConnection();
                string query = "SELECT imagenInventario FROM [Inventario].[tbInventario] WHERE idInventario = @param1";
                SqlCommand cmd = new SqlCommand(query, command.Connection);
                cmd.Parameters.AddWithValue("param1", IdMedicamento);
                return cmd.ExecuteScalar() as byte[];
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

        /// <summary>
        /// Registrar usuario corresponde al primer mantenimiento del CRUD
        /// Inserción de datos a la base de datos
        /// </summary>
        /// <returns></returns>

        public int RegisterMedicine()
        {
            try
            {
                command.Connection = getConnection();
                string query = "EXEC [ProcedimientosAlmacenados].[spIngresarMedicamento] @param1, @param2, @param3, @param4, @param5, @param6, @param7, @param8, @param9, @param10, @param11";
                SqlCommand cmd = new SqlCommand(query, command.Connection);
                cmd.Parameters.AddWithValue("param1", NombreMedicamento);
                cmd.Parameters.AddWithValue("param2", Descripcion);
                cmd.Parameters.AddWithValue("param3", 1);
                cmd.Parameters.AddWithValue("param4", IdCategoria);
                cmd.Parameters.AddWithValue("param5", FechaVencimiento);
                cmd.Parameters.AddWithValue("param6", Imagen);
                cmd.Parameters.AddWithValue("param7", Ingreso);
                cmd.Parameters.AddWithValue("param8", Salida);
                cmd.Parameters.AddWithValue("param9", IdMedicamento);
                cmd.Parameters.AddWithValue("param10", Envases);
                cmd.Parameters.AddWithValue("param11", Existencia);
                int returnedValue = cmd.ExecuteNonQuery();
                return returnedValue;
            }
            catch (SqlException)
            {
                CommonMethods.HandleError("EC_111");
                return -1;
            }
            catch (Exception)
            {
                CommonMethods.HandleError("EC_111");
                return -1;
            }
            finally
            {
                command.Connection.Close();
            }
        }

        /// <summary>
        /// Leer usuario corresponde al segundo mantenimiento del CRUD
        /// Inserción de datos a la base de datos
        /// </summary>
        /// <returns></returns>
        public DataSet GetInventory()
        {
            try
            {
                command.Connection = getConnection();
                string query = "SELECT * FROM [Vistas].[viewInventario]";
                SqlCommand cmd = new SqlCommand(query, command.Connection);
                cmd.ExecuteNonQuery();
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adp.Fill(ds, "viewInventario");
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

        /// <summary>
        /// Actualzar usuario corresponde al tercer mantenimiento del CRUD
        /// Inserción de datos a la base de datos
        /// </summary>
        /// <returns></returns>
        public int UpdateInventory()
        {
            try
            {
                command.Connection = getConnection();
                string query = "EXEC [ProcedimientosAlmacenados].[spActualizarMedicamento] @medicineName, @description, @expirationDate, @image, @medicineID, @entryDate, @entryTime, @packages, @stock";
                SqlCommand cmd = new SqlCommand(query, command.Connection);
                cmd.Parameters.AddWithValue("medicineName", NombreMedicamento);
                cmd.Parameters.AddWithValue("description", Descripcion);
                cmd.Parameters.AddWithValue("expirationDate", FechaVencimiento);
                cmd.Parameters.AddWithValue("image", Imagen);
                cmd.Parameters.AddWithValue("medicineID", IdMedicamento);
                cmd.Parameters.AddWithValue("entryDate", Ingreso);
                cmd.Parameters.AddWithValue("entryTime", Salida);
                cmd.Parameters.AddWithValue("packages", Envases);
                cmd.Parameters.AddWithValue("stock", Existencia);
                int returnedValue = cmd.ExecuteNonQuery();
                return returnedValue;
            }
            catch (SqlException)
            {
                
                CommonMethods.HandleError("EC_311");
                return -1;
            }
            catch (Exception)
            {
                CommonMethods.HandleError("EC_311");
                return -1;
            }
            finally
            {
                command.Connection.Close();
            }
        }

        /// <summary>
        /// Eliminar usuario corresponde al cuarto mantenimiento del CRUD
        /// Inserción de datos a la base de datos
        /// </summary>
        /// <returns></returns>
        public int DeleteInventory()
        {
            try
            {
                command.Connection = getConnection();
                string query = "EXEC [ProcedimientosAlmacenados].[spEliminarMedicamento] @param1, @param2";
                SqlCommand cmd = new SqlCommand(query, command.Connection);
                cmd.Parameters.AddWithValue("param1", IdEntradaSalida);
                cmd.Parameters.AddWithValue("param2", IdMedicamento);
                return cmd.ExecuteNonQuery();
            }
            catch (SqlException)
            {

                CommonMethods.HandleError("EC_411");
                return -1;
            }
            catch (Exception)
            {

                CommonMethods.HandleError("EC_411");
                return -1;
            }
            finally
            {
                command.Connection.Close();
            }
        }
        public DataSet SearchMedicineInventory(string search)
        {
            try
            {
                command.Connection = getConnection();
                string query = $"SELECT * FROM [Vistas].[viewInventario] WHERE [Nombre del Producto] LIKE '%{search}%' OR [Categoría del Producto] LIKE '%{search}%'";
                SqlCommand cmd = new SqlCommand(query, command.Connection);
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adp.Fill(ds, "viewInventario");
                return ds;
            }
            catch (SqlException)
            {
                
                CommonMethods.HandleError("EC_507");
                return null;
            }
            catch (Exception)
            {
                CommonMethods.HandleError("EC_507");
                return null;
            }
            finally
            {
                command.Connection.Close();
            }
        }
        public int RegisterCategory()
        {
            try
            {
                command.Connection = getConnection();
                string query = "INSERT INTO [Inventario].[tbCategoriaMedicamento] VALUES (@param1)";
                SqlCommand cmd = new SqlCommand(query, command.Connection);
                cmd.Parameters.AddWithValue("param1", CategoriaMedicamento);
                int returnedValue = cmd.ExecuteNonQuery();
                return returnedValue;
            }
            catch (SqlException)
            {
                CommonMethods.HandleError("EC_111");
                return -1;
            }
            catch (Exception)
            {
                CommonMethods.HandleError("EC_111");
                return -1;
            }
            finally
            {
                command.Connection.Close();
            }
        }
        public int UpdateCategory()
        {
            try
            {
                command.Connection = getConnection();
                string query = "UPDATE [Inventario].[tbCategoriaMedicamento] SET [categoriaMedicamento] = (@param1) WHERE [idCategoriaMedicamento] = @param2 ";
                SqlCommand cmd = new SqlCommand(query, command.Connection);
                cmd.Parameters.AddWithValue("param1", CategoriaMedicamento);
                cmd.Parameters.AddWithValue("param2", IdCategoria);
                int returnedValue = cmd.ExecuteNonQuery();
                return returnedValue;
            }
            catch (SqlException)
            {
                CommonMethods.HandleError("EC_311");
                return -1;
            }
            catch (Exception)
            {
                CommonMethods.HandleError("EC_311");
                return -1;
            }
            finally
            {
                command.Connection.Close();
            }
        }
        public DataSet GetCategory()
        {
            try
            {

                //Se crea una conexion para garantizar que haya conexion con la base
                command.Connection = getConnection();
                string query = "SELECT * FROM [Inventario].[tbCategoriaMedicamento]";
                SqlCommand cmdCategory = new SqlCommand(query, command.Connection);
                cmdCategory.ExecuteNonQuery();
                SqlDataAdapter adpCategory = new SqlDataAdapter(cmdCategory);
                DataSet ds = new DataSet();
                adpCategory.Fill(ds, "tbCategoriaMedicamento");
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