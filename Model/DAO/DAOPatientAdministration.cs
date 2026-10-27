using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HealthPortal.Model.DTO;
using System.Windows.Forms;
using Microsoft.SqlServer.Server;
using System.Collections;
using System.Windows.Input;
using System.Diagnostics.Eventing.Reader;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using HealthPortal.Helper;

namespace HealthPortal.Model.DAO
{
    class DAOPatientAdministration : DTOPatientAdministration
    {
        int returnedValue;
        int updateReturn;
        int deleteReturn;
        int searchReturn;
        readonly SqlCommand command = new SqlCommand();
        public DataTable RetrieveChartData()
        {
            try
            {
                command.Connection = getConnection();
                string query = "SELECT * FROM [Vistas].[viewPorcentajeEstudiantesPorSeccion]";
                SqlCommand cmd = new SqlCommand(query, command.Connection);
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adp.Fill(dt);
                return dt;
            }
            catch (Exception)
            {
                CommonMethods.HandleError("EC_108");
                return null;
            }
            finally
            {
                command.Connection.Close();
            }
        }
        public DataSet FillCombo(string table, string schema)
        {
            try
            {
                //Se crea una conexión para garantizar que efectivamente haya conexión a la base.
                command.Connection = getConnection();
                //**
                //Se crea el query que indica la acción que el sistema desea realizar con la base de datos
                //En caso sea una consulta parametrizada se deberá respetar la sintaxis sobre como colocar parametros en la instrucción sql (REVISAR LOS DEMÁS MANTENIMIENTOS PARA VER COMO SE CREAN PARAMETROS Y SE LES DA VALORES).
                string query = $"SELECT * FROM {schema}.{table}";
                //Se crea un comando de tipo sql al cual se le pasa el query y la conexión, esto para que el sistema sepa que hacer y donde hacerlo.
                SqlCommand cmd = new SqlCommand(query, command.Connection);
                //ExecuteNonQuery indicará cuantos filas fueron afectadas, es decir, cuantas filas de datos se ingresaron o encontraron, por lo general cuando es una consulta su valor puede ser 1 o mayor a 1.
                cmd.ExecuteNonQuery();
                //Se crea un objeto SqlDataAdapter para poder llenar el DataSet que posteriormente utilizaremos, además recibe el comando sql
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                //Se crea un DataSet que será el objeto de retorno del método
                DataSet ds = new DataSet();
                //Rellenamos el DataSet con los datos encontrados con el SqlDataAdapter, además, indicamos de donde provienen los datos
                adp.Fill(ds, $"{table}");
                //Retornamos el objeto DataSet
                return ds;
            }
            catch (Exception)
            {
                //Se retorna null si durate la ejecución del try ocurrió algún error
                CommonMethods.HandleError("EC_201");
                return null;
            }
            finally
            {
                //Independientemente se haga o no el proceso cerramos la conexión
                getConnection().Close();
            }
        }

        //INSERT

        public int PatientInsert()
        {
            try
            {
                command.Connection = getConnection();
                GetGradeIdSection();
                //Insertar datos en la tabala de paciente
                string query = "INSERT INTO [Pacientes].[tbPacientes] VALUES (@nombrePaciente, @apellidoPaciente, @codigo, @IdGradoSeccion, @IdTipoPersona)";
                SqlCommand cmdInsertPatient = new SqlCommand(query, command.Connection);
                //Insertar o darle valor a los parametros
                cmdInsertPatient.Parameters.AddWithValue("nombrePaciente", Name);
                cmdInsertPatient.Parameters.AddWithValue("apellidoPaciente", LastName);
                cmdInsertPatient.Parameters.AddWithValue("codigo", Code);
                cmdInsertPatient.Parameters.AddWithValue("IdGradoSeccion", IdGradeSection);
                cmdInsertPatient.Parameters.AddWithValue("IdTipoPersona", Role);
                returnedValue = cmdInsertPatient.ExecuteNonQuery();
                return returnedValue;
            }
            catch (Exception)
            {

                RollBack();
                //Codificación de errores: esta sale del catch EC = error critico, EC_001 = no se pudo ingresar al paciente
                CommonMethods.HandleError("EC_108");
                return -1;
            }
            finally
            {
                command.Connection.Close();
            }
        }

        //Registrar Paciente
        public int PatientRegistration()
        {

            try
            {
                command.Connection = getConnection();
                GetGradeIdSection();
                //Insertar datos en la tabala de paciente
                string query = "INSERT INTO [Pacientes].[tbPacientes] VALUES (@nombrePaciente, @apellidoPaciente, @codigo, @IdGradoSeccion, @IdTipoPersona)";
                SqlCommand cmdInsertPatient = new SqlCommand(query, command.Connection);
                //Insertar o darle valor a los parametros
                cmdInsertPatient.Parameters.AddWithValue("nombrePaciente", Name);
                cmdInsertPatient.Parameters.AddWithValue("apellidoPaciente", LastName);
                cmdInsertPatient.Parameters.AddWithValue("codigo", Code);
                cmdInsertPatient.Parameters.AddWithValue("IdGradoSeccion", IdGradeSection);
                cmdInsertPatient.Parameters.AddWithValue("IdTipoPersona", Role);
                returnedValue = cmdInsertPatient.ExecuteNonQuery();
                if (returnedValue == 1)
                {

                    GetIdPatient();
                    if (returnedValue == 1)
                    {
                        AddVisit();
                        if (returnedValue == 1)
                        {
                            if (returnedValue == 1)
                            {
                                NewInventory();
                                UpdateInventory();
                                if (updateReturn == 1)
                                {
                                    return 1;
                                }
                                else
                                {
                                    RollBack();
                                    return 0;
                                }
                            }
                            return 1;
                        }
                        else
                        {
                            RollBack();
                            return 0;
                        }
                    }
                    else
                    {
                        return 0;
                    }
                }
                else
                {
                    RollBack();
                    return 0;
                }
            }
            catch (SqlException)
            {
                RollBack();
                //Codificación de errores: esta sale del catch EC = error critico, EC_001 = no se pudo ingresar al paciente
                CommonMethods.HandleError("EC_108");
                return -1;

            }
            finally
            {
                command.Connection.Close();
            }
        }
        //Registrra Visitas
        public int AddVisit()
        {
            try
            {
                GetIdPerson();
                string query = "INSERT INTO [Visitas].[tbVisitas] Values(@idPaciente,@fechaVisita,@horaVisita,@idInventario,@observaciones, @idPersona)";
                SqlCommand cmdVisita = new SqlCommand(query, command.Connection);
                cmdVisita.Parameters.AddWithValue("idPaciente", IdPatient);
                cmdVisita.Parameters.AddWithValue("fechaVisita", Date);
                cmdVisita.Parameters.AddWithValue("horaVisita", Time);
                cmdVisita.Parameters.AddWithValue("idInventario", Medicine);
                cmdVisita.Parameters.AddWithValue("observaciones", Observation);
                cmdVisita.Parameters.AddWithValue("idPersona", IdPersona);
                returnedValue = cmdVisita.ExecuteNonQuery();
                return returnedValue;
            }
            catch (SqlException)
            {
                //EC_002 = no se pudo agregar la visita
                CommonMethods.HandleError("EC_109");
                return returnedValue = -1;
            }



        }

        //Obtener

        //Este metodo sirve para obtener el Id de Cada paciente
        public int GetIdPatient()
        {
            string query = "Select MAX (idPaciente) FROM [Pacientes].[tbPacientes]";
            SqlCommand cmdIdpatient = new SqlCommand(query, command.Connection);
            SqlDataReader consulta = cmdIdpatient.ExecuteReader();

            while (consulta.Read())
            {
                IdPatient = consulta.GetInt32(0); // Suponiendo que IdGrado_Seccion está en el índice 0
            }
            consulta.Close();

            return IdPatient;
        }

        public int GetIdPerson()
        {
            string query = "SELECT IdPersona FROM [Institución].[tbPersonas] WHERE usuario = @param1";
            SqlCommand cmdIdPerson = new SqlCommand(query, command.Connection);
            cmdIdPerson.Parameters.AddWithValue("param1", Username);
            SqlDataReader consulta = cmdIdPerson.ExecuteReader();

            while (consulta.Read())
            {
                IdPersona = consulta.GetInt32(0); // Suponiendo que IdGrado_Seccion está en el índice 0
            }
            consulta.Close();

            return IdPersona;
        }

        //Este metodo sirve para onbtener el ID del Grado_seccion para ocuparlo como llave foranea
        public void GetGradeIdSection()
        {
            //buscar grados
            //Hacer una seleccion filtrada
            string query = "SELECT idGradoSeccion FROM [Secciones].[tbGradoSeccion] WHERE grupoTecnico = @GrupoTecnico AND idGrado = @IdGrado AND idSeccionAcademica = @IdSeccionAcademica AND idEspecialidad = @IdEspecialidad";
            SqlCommand cmdGradoSeccion = new SqlCommand(query, command.Connection);
            //Parametros
            cmdGradoSeccion.Parameters.AddWithValue("GrupoTecnico", TechnicalGroup);
            cmdGradoSeccion.Parameters.AddWithValue("IdGrado", Grade);
            cmdGradoSeccion.Parameters.AddWithValue("IdSeccionAcademica", AcademicSection);
            cmdGradoSeccion.Parameters.AddWithValue("IdEspecialidad", Specialty);
            SqlDataReader consulta = cmdGradoSeccion.ExecuteReader();

            while (consulta.Read())
            {
                IdGradeSection = consulta.GetInt32(0); // Suponiendo que IdGrado_Seccion está en el índice 0
            }
            consulta.Close();
        }

        public int GetQuantityInventary()
        {
            string query = "SELECT cantidadInventario, cantidadEnvasesInventario FROM [Inventario].[tbEntradaSalidaInventario] WHERE idInventario = @param1";
            SqlCommand cmdIdPerson = new SqlCommand(query, command.Connection);
            cmdIdPerson.Parameters.AddWithValue("param1", Medicine);
            SqlDataReader consulta = cmdIdPerson.ExecuteReader();

            while (consulta.Read())
            {
                QuantityPackage = consulta.GetInt32(0);
                Package1 = consulta.GetInt32(1);
                // Suponiendo que IdGrado_Seccion está en el índice 0
            }
            consulta.Close();

            return QuantityPackage;
        }

        public int GetIdVisit()
        {
            command.Connection = getConnection();
            string query = "Select MAX (idVisita) FROM [Visitas].[tbVisitas]";
            SqlCommand cmdIdVisit = new SqlCommand(query, command.Connection);
            SqlDataReader consulta = cmdIdVisit.ExecuteReader();

            while (consulta.Read())
            {
                IdVisit = consulta.GetInt32(0); // Suponiendo que IdGrado_Seccion está en el índice 0
            }
            consulta.Close();

            return IdVisit;
        }
        public DataSet RetrieveDgvInfo()
        {
            try
            {
                command.Connection = getConnection();
                string query = "SELECT * FROM [Vistas].[viewAdminPacientes]";
                SqlCommand cmd = new SqlCommand(query, command.Connection);
                cmd.ExecuteNonQuery();
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adp.Fill(ds, "viewAdminPacientes");
                return ds;
            }
            catch (SqlException)
            {
                //EC_004 = no se puso seleccionar la vista UpdateEstudiantes
                CommonMethods.HandleError("EC_201");
                return null;
            }
            finally
            {
                getConnection().Close();
            }

        }
        public DataSet RetrieveDgvInfoPatient()
        {
            try
            {
                command.Connection = getConnection();
                string query = "SELECT * FROM [Vistas].[viewInfoPacientes]";
                SqlCommand cmd = new SqlCommand(query, command.Connection);
                cmd.ExecuteNonQuery();
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adp.Fill(ds, "viewInfoPacientes");
                return ds;
            }
            catch (SqlException)
            {
                CommonMethods.HandleError("EC_201");
                return null;
            }
            finally
            {
                getConnection().Close();
            }

        }

        //UPDATE

        //Sirve para actuzlaizar los datos del paciente
        public int UpdatePatient()
        {
            try
            {
                command.Connection = getConnection();
                GetGradeIdSection();
                // Update en tbPacientes
                string query = "UPDATE [Pacientes].[tbPacientes] SET " +
                                            "nombrePaciente = @param1, " +
                                            "apellidoPaciente = @param2, " +
                                            "codigo = @param3, " +
                                            "idGradoSeccion = @param4, " +
                                            "idTipoPersona = @param5 " +
                                            "WHERE idPaciente = @param6";
                SqlCommand cmdUpdatePatient = new SqlCommand(query, command.Connection);
                cmdUpdatePatient.Parameters.AddWithValue("param1", Name);
                cmdUpdatePatient.Parameters.AddWithValue("param2", LastName);
                cmdUpdatePatient.Parameters.AddWithValue("param3", Code);
                cmdUpdatePatient.Parameters.AddWithValue("param4", IdGradeSection);
                cmdUpdatePatient.Parameters.AddWithValue("param5", Role);
                cmdUpdatePatient.Parameters.AddWithValue("param6", IdPatient);
                updateReturn = cmdUpdatePatient.ExecuteNonQuery();
                //Update en la tbEstudiantes o en la tbPersonalInstitucion dpeendiendo el rol que se le asigno al paciente


                return updateReturn;
            }
            catch (SqlException)
            {
                //EC_006 No se pudo actuzalizar el registro del paciente

                CommonMethods.HandleError("EC_308");
                return -1;
            }
            finally
            {
                command.Connection.Close();
            }


        }
        //El metodo UpdateVisit sirve para actuzalizar Los datos de la visita
        public int UpdateVisit()
        {
            try
            {
                command.Connection = getConnection();
                string query = "UPDATE [Visitas].[tbVisitas] SET " +
                                             "Observaciones = @param4 " +
                                            "WHERE idVisita = @param5";
                SqlCommand cmdUpdateVisita = new SqlCommand(query, command.Connection);

                cmdUpdateVisita.Parameters.AddWithValue("param4", Observation);
                cmdUpdateVisita.Parameters.AddWithValue("param5", IdVisit);
                updateReturn = cmdUpdateVisita.ExecuteNonQuery();
                return updateReturn;

            }
            catch (SqlException)
            {
                //EC_003 = No se pudo actualizar la información del apartado o tabla visita
                CommonMethods.HandleError("EC_309");
                return -1;

            }
            finally
            {
                command.Connection.Close();
            }

        }
        public int UpdateInventory()
        {
            try
            {
                string query = "UPDATE [Inventario].[tbEntradaSalidaInventario] SET " +
                                            " cantidadInventario = @param1," +
                                            " cantidadEnvasesInventario = @param2 " +
                                            "Where idInventario = @param3";

                SqlCommand cmdUpdateVisita = new SqlCommand(query, command.Connection);
                cmdUpdateVisita.Parameters.AddWithValue("param1", NewQuantity);
                cmdUpdateVisita.Parameters.AddWithValue("param2", Package1);
                cmdUpdateVisita.Parameters.AddWithValue("param3", Medicine);

                updateReturn = cmdUpdateVisita.ExecuteNonQuery();
                return updateReturn;

            }
            catch (SqlException)
            {
                //EC_003 = No se pudo actualizar la información del apartado o tabla visita
                return -1;

            }
            finally
            {
                command.Connection.Close();
            }

        }

        //DELETE

        //Eliminar la tabla de pacientes para asi eliminar el registro de este
        public int DeletePatient()
        {
            try
            {
                DeletePatientVisit();
                command.Connection = getConnection();
                string query = "DELETE FROM [Pacientes].[tbPacientes] WHERE idPaciente = @param1";
                SqlCommand cmdDelete = new SqlCommand(query, command.Connection);
                cmdDelete.Parameters.AddWithValue("param1", IdPatient);
                deleteReturn = cmdDelete.ExecuteNonQuery();
                return deleteReturn;
            }
            catch (SqlException)
            {
                CommonMethods.HandleError("EC_408");
                return -1;
            }
            finally { command.Connection.Close(); }

        }

        public int DeletePatientVisit()
        {
            try
            {
                command.Connection = getConnection();
                string query = "DELETE FROM [Visitas].[tbVisitas] WHERE idPaciente = @param1";
                SqlCommand cmdDelete = new SqlCommand(query, command.Connection);
                cmdDelete.Parameters.AddWithValue("param1", IdPatient);
                deleteReturn = cmdDelete.ExecuteNonQuery();
                return deleteReturn;
            }
            catch (SqlException)
            {
                CommonMethods.HandleError("EC_408");
                return -1;
            }
            finally { command.Connection.Close(); }

        }

        //Eliminar registro de la tabla visita
        public int DeleteVisit()
        {
            try
            {
                command.Connection = getConnection();
                string query = "DELETE FROM [Visitas].[tbVisitas] WHERE idVisita = @param1";
                SqlCommand cmdDelete = new SqlCommand(query, command.Connection);
                cmdDelete.Parameters.AddWithValue("param1", IdVisit);
                deleteReturn = cmdDelete.ExecuteNonQuery();
                return deleteReturn;
            }
            catch (SqlException)
            {
                //EC_008 = No se pudo eleiminar la información de la visita que el paciente realizo
                CommonMethods.HandleError("EC_409");
                return -1;
            }
            finally
            {
                //Independientemente se haga o no el proceso cerramos la conexión
                getConnection().Close();
            }

        }
        //Eliminar el registro del paciente que viene del area personal

        //Eliminar el registro del paciente
        public int DeleteRegistrationPatient()
        {
            try
            {
                DeleteVisit();
                if (deleteReturn == 1)
                {
                    DeletePatient();
                    if (deleteReturn == 1)
                    {
                        return 1;

                    }
                    else
                    {
                        return -1;
                    }
                }
                else { return -1; }

            }
            catch (SqlException)
            {
                //EC_009 = No se pudo eliminar la información del paciente
                CommonMethods.HandleError("EC_410");
                return -1;
            }
            finally { getConnection().Close(); }


        }

        //SEARCH

        //Buscar coincidencias en pacinete
        public DataSet SearchPatient(string search)
        {
            try
            {
                command.Connection = getConnection();
                string query = $"SELECT * FROM [Vistas].[viewAdminPacientes] " +
                               $"WHERE idVisita LIKE '%{search}%' " +
                               $"OR nombrePaciente LIKE '%{search}%' " +
                               $"OR apellidoPaciente LIKE '%{search}%' " +
                               $"OR tipoPersona LIKE '%{search}%' " +
                               $"OR codigo LIKE '%{search}%'" +
                               $"OR grado LIKE '%{search}%'" +
                               $"OR especialidad LIKE '%{search}%' " +
                               $"OR horaVisita LIKE '%{search}%'";
                SqlCommand cmd = new SqlCommand(query, command.Connection);
                cmd.ExecuteNonQuery();
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adp.Fill(ds, "viewAdminPacientes");
                return ds;
            }
            catch (SqlException)
            {
                CommonMethods.HandleError("EC_506");
                return null;
            }
            catch (Exception)
            {
                CommonMethods.HandleError("EC_506");
                return null;
            }
            finally
            {
                command.Connection.Close();
            }
        }

        public DataSet SearchPatientInfo(string search)
        {
            try
            {
                command.Connection = getConnection();
                string query = $"SELECT * FROM [Vistas].[viewInfoPacientes]" +
                               $"WHERE idPaciente LIKE '%{search}%' " +
                               $"OR nombrePaciente LIKE '%{search}%' " +
                               $"OR apellidoPaciente LIKE '%{search}%' " +
                               $"OR tipoPersona LIKE '%{search}%' " +
                               $"OR codigo LIKE '%{search}%'" +
                               $"OR grado LIKE '%{search}%'" +
                               $"OR [Sección Académica]LIKE '%{search}%'" +
                               $"OR [Grupo Técnico] LIKE '%{search}%'" +
                               $"OR especialidad LIKE '%{search}%' ";

                SqlCommand cmdPatient = new SqlCommand(query, command.Connection);
                cmdPatient.ExecuteNonQuery();
                SqlDataAdapter adp = new SqlDataAdapter(cmdPatient);
                DataSet ds = new DataSet();
                adp.Fill(ds, "viewInfoPacientes");
                return ds;
            }
            catch (SqlException)
            {
                CommonMethods.HandleError("EC_506");
                return null;
            }
            catch (Exception)
            {
                CommonMethods.HandleError("EC_506");
                return null;
            }
            finally
            {
                command.Connection.Close();
            }
        }

        //Buscar por date
        public DataSet SearchPatientDate(DateTime searchDate)
        {
            try
            {
                string fecha = searchDate.Date.ToString();
                MessageBox.Show(fecha);
                command.Connection = getConnection();
                string query = "SELECT * FROM [Vistas].[viewAdminPacientes] WHERE fechaVisita = @fechaVisita";
                SqlCommand cmd = new SqlCommand(query, command.Connection);
                cmd.Parameters.AddWithValue("fechaVisita", searchDate);
                cmd.ExecuteNonQuery();
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adp.Fill(ds, "viewAdminPacientes");
                return ds;
            }
            catch (SqlException)
            {
                CommonMethods.HandleError("EC_505");
                return null;
            }
            catch (Exception)
            {
                CommonMethods.HandleError("EC_505");
                return null;
            }
            finally
            {
                command.Connection.Close();
            }
        }

        //Buscar por specialty
        public DataSet SearchPatientSpecialty(string search)
        {
            try
            {
                command.Connection = getConnection();
                string query = $"SELECT * FROM [Vistas].[viewAdminPacientes] " +
                               $"WHERE especialidad LIKE '%{search}%' ";
                SqlCommand cmd = new SqlCommand(query, command.Connection);
                cmd.ExecuteNonQuery();
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adp.Fill(ds, "viewAdminPacientes");
                return ds;
            }
            catch (SqlException)
            {
                CommonMethods.HandleError("EC_504");
                return null;
            }
            catch (Exception)
            {
                CommonMethods.HandleError("EC_504");
                return null;
            }
            finally
            {
                command.Connection.Close();
            }
        }



        //Buscar por grade
        public DataSet SearchPatientGrade(string search)
        {
            try
            {
                command.Connection = getConnection();
                string query = $"SELECT * FROM [Vistas].[viewAdminPacientes] " +
                               $"WHERE grado LIKE '%{search}%'  ";
                SqlCommand cmd = new SqlCommand(query, command.Connection);
                cmd.ExecuteNonQuery();
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adp.Fill(ds, "viewAdminPacientes");
                return ds;
            }
            catch (SqlException)
            {
                CommonMethods.HandleError("EC_503");
                return null;
            }
            catch (Exception)
            {
                CommonMethods.HandleError("EC_503");
                return null;
            }
            finally
            {
                command.Connection.Close();
            }
        }



        //Buscar por tipo de persona
        public DataSet SearchPatientRole(string search)
        {
            try
            {
                command.Connection = getConnection();
                string query = $"SELECT * FROM [Vistas].[viewAdminPacientes] " +
                               $"WHERE tipoPersona LIKE '%{search}%'  ";
                SqlCommand cmd = new SqlCommand(query, command.Connection);
                cmd.ExecuteNonQuery();
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adp.Fill(ds, "viewAdminPacientes");
                return ds;
            }
            catch (SqlException)
            {
                CommonMethods.HandleError("EC_501");
                return null;
            }
            catch (Exception)
            {
                CommonMethods.HandleError("EC_501");
                return null;
            }
            finally
            {
                command.Connection.Close();
            }
        }



        //Este metodo funciona para saber si ya existe un paciente ingresado con ese code
        public int existcode()
        {
            try
            {
                command.Connection = getConnection();
                string query = "SELECT COUNT(1) FROM [Vistas].[viewFiltrarCodigo] WHERE codigo = @param1";
                SqlCommand cmd = new SqlCommand(query, command.Connection);
                cmd.Parameters.AddWithValue("param1", Code);
                SqlDataReader consulta = cmd.ExecuteReader();

                while (consulta.Read())
                {
                    searchReturn = consulta.GetInt32(0);
                    // Suponiendo que IdGrado_Seccion está en el índice 0
                }
                consulta.Close();

                if (searchReturn >= 1)
                {
                    return 1;
                }
                else if (searchReturn == 0)
                {
                    return 0;
                }
                else
                {
                    return -1;
                }
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
                getConnection().Close();
            }

        }

        //Buscar por code
        public string[] SearchCode()
        {
            try
            {
                int returnedValue = existcode();
                if (returnedValue == 1)
                {
                    string[] datos = new string[8];
                    command.Connection = getConnection();
                    string query = "SELECT * FROM [Vistas].[viewFiltrarCodigo] WHERE codigo = @param1";
                    SqlCommand cmd = new SqlCommand(query, command.Connection);
                    cmd.Parameters.AddWithValue("param1", Code);

                    SqlDataReader rd = cmd.ExecuteReader();
                    while (rd.Read())
                    {
                        datos[0] = rd.GetString(0);
                        datos[1] = rd.GetString(1);
                        datos[2] = rd.GetString(2);
                        datos[3] = rd.GetString(3);
                        datos[4] = rd.GetString(4);
                        datos[5] = rd.GetString(5);
                        datos[6] = rd.GetString(6);
                        datos[7] = rd.GetString(7);

                    }
                    return datos;
                }
                else
                {
                    return null;
                }

            }
            catch (SqlException)
            {
                CommonMethods.HandleError("EC_502");
                return null;

            }
            catch (Exception)
            {
                CommonMethods.HandleError("EC_502");
                return null;

            }
            finally
            {
                getConnection().Close();
            }

        }

        public void RollBack()
        {
            //Eliminar el usuario ingresado
            string query = "DELETE FROM [Pacientes].[tbPacientes] WHERE idPaciente = @param1";
            SqlCommand cmddel = new SqlCommand(query, command.Connection);
            cmddel.Parameters.AddWithValue("param1", IdPatient);
            int retorno = cmddel.ExecuteNonQuery();
        }

        public void RollBackVisit()
        {
            string query = "DELETE FROM [Visitas].[tbVisitas] WHERE idVisita = @param1";
            SqlCommand cmddel = new SqlCommand(query, command.Connection);
            cmddel.Parameters.AddWithValue("param1", IdVisit);
            int retorno = cmddel.ExecuteNonQuery();
        }

        public int GetCodeIdPatient()
        {
            command.Connection = getConnection();
            string query = "SELECT idPaciente FROM [Pacientes].[tbPacientes] WHERE codigo = @param1";
            SqlCommand cmdIdPatient = new SqlCommand(query, command.Connection);
            cmdIdPatient.Parameters.AddWithValue("param1", Code);
            SqlDataReader consulta = cmdIdPatient.ExecuteReader();

            while (consulta.Read())
            {
                IdPatient = consulta.GetInt32(0); // Suponiendo que IdGrado_Seccion está en el índice 0
            }
            consulta.Close();

            return IdPatient;
        }

        public int InsertVisit()
        {
            try
            {
                GetCodeIdPatient();
                AddVisit();
                if (returnedValue == 1)
                {
                    NewInventory();
                    UpdateInventory();
                    if (updateReturn == 1)
                    {

                        return 1;
                    }
                    else
                    {
                        GetIdVisit();
                        RollBackVisit();
                        return 0;

                    }
                }
                else if (returnedValue == 0)
                {
                    return 0;
                }
                else
                {
                    return -1;
                }
            }
            catch (Exception)
            {
                CommonMethods.HandleError("EC_110");
                throw;
            }
            finally
            {
                command.Connection.Close();
            }



        }
        public int NewInventory()
        {
            GetQuantityInventary();
            if (QuantityPackage > 0)
            {
                NewQuantity = QuantityPackage - 1;
                return NewQuantity;
            }
            else if (QuantityPackage < 0)
            {
                Package1 = Package1 - 1;
                return Package1;
            }
            else { return 0; }

        }
        public DataSet GetRole()
        {
            try
            {

                //Se crea una conexion para garantizar que haya conexion con la base
                command.Connection = getConnection();
                string query = "SELECT * FROM [Pacientes].[tbTipoPersona]";
                SqlCommand cmdRole = new SqlCommand(query, command.Connection);
                cmdRole.ExecuteNonQuery();
                SqlDataAdapter adpCategory = new SqlDataAdapter(cmdRole);
                DataSet ds = new DataSet();
                adpCategory.Fill(ds, "tbTipoPersona");
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
        public int RegisterRole()
        {
            try
            {
                command.Connection = getConnection();
                string query = "INSERT INTO [Pacientes].[tbTipoPersona] VALUES (@param1)";
                SqlCommand cmd = new SqlCommand(query, command.Connection);
                cmd.Parameters.AddWithValue("param1", AddRole);
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
        public int UpdateRole()
        {
            try
            {
                command.Connection = getConnection();
                string query = "UPDATE [Pacientes].[tbTipoPersona] SET [tipoPersona] = (@param1) WHERE [idTipoPersona]\t = @param2 ";
                SqlCommand cmd = new SqlCommand(query, command.Connection);
                cmd.Parameters.AddWithValue("param1", AddRole);
                cmd.Parameters.AddWithValue("param2", Role);
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

        public bool VerifyCredentials()
        {
            try
            {
                command.Connection = getConnection();
                string query = "SELECT * FROM [Vistas].[viewInformacionLogin] WHERE [usuario] = @username AND [contraseña] = @password AND [estadoUsuario] = @userStatus AND [idRol] = @roleID";
                SqlCommand cmd = new SqlCommand(query, command.Connection);
                cmd.Parameters.AddWithValue("username", Username);
                cmd.Parameters.AddWithValue("password", Password);
                cmd.Parameters.AddWithValue("userStatus", true);
                cmd.Parameters.AddWithValue("roleID", 1);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    CurrentUserData.Username = dr.GetString(0);
                    CurrentUserData.Password = dr.GetString(1);
                    CurrentUserData.Token = dr.GetString(2);
                    CurrentUserData.Status = dr.GetBoolean(3);
                    CurrentUserData.RoleId = dr.GetInt32(4);
                    CurrentUserData.FullName = dr.GetString(6);
                    CurrentUserData.TemporaryPassword = dr.GetBoolean(7);
                    CurrentUserData.Email = dr.GetString(8);
                }
                Delete = true;
                return dr.HasRows;
            }
            catch (SqlException)
            {
                CommonMethods.HandleError("EC_203");
                return false;
            }
            catch (Exception)
            {
                CommonMethods.HandleError("EC_203");
                return false;
            }
            finally
            {
                command.Connection.Close();
            }
        }
    }
}