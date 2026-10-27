using HealthPortal.Model.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Runtime.CompilerServices;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using HealthPortal.View.PatientAdministration;
using HealthPortal.Helper;
using HealthPortal.Model.DTO;
using System.Text.RegularExpressions;
using HealthPortal.View.InventoryAdministration;

namespace HealthPortal.Controller.PatientAdministration
{
    class ControllerAddUpdatePatient
    {
        FrmAddUpdatePatient objAddUpdatePatient;

        int action, respuesta;
        private string typeperson, Grade, specialty, AcademicSection, namemedication;

        public ControllerAddUpdatePatient(FrmAddUpdatePatient view, int action)
        {
            objAddUpdatePatient = view;
            this.action = action;
            //Verificar action
            VerifyAction();
            objAddUpdatePatient.Load += new EventHandler(InitialLoad);
            //agregar un nuevo paciente
            objAddUpdatePatient.btnAddPatient.Click += new EventHandler(VerifyInsert);
            //Opcion del comboBox en este se puede cambiar si es uin estudiante o un alumno para mostrar los datos que se tienen que llenar
            objAddUpdatePatient.dtpRegisterDate.Value = DateTime.Now;
            objAddUpdatePatient.dtpRegisterTime.Value = DateTime.Now;
            objAddUpdatePatient.txtPatientCode.Leave += new EventHandler(Code);
            objAddUpdatePatient.btnExitE.Click += new EventHandler(CloseForm);
            
        }

        private void CloseForm(object sender, EventArgs e)
        {
            objAddUpdatePatient.Dispose();
        }

        public ControllerAddUpdatePatient(FrmAddUpdatePatient View, int Action, int IdPatient, string PatientName, string PatientLastName, string TypePerson, string codigo, string grupoTecnico, string grade, string seccionAcademica, string Especialidad, DateTime VisitDate, string TimeVisit, string nombreMedicamento, string Observaciones)
        {
            objAddUpdatePatient = View;
            this.action = Action;
            this.typeperson = TypePerson;
            this.Grade = grade;
            this.AcademicSection = seccionAcademica;
            this.specialty = Especialidad;
            this.namemedication = nombreMedicamento;
            objAddUpdatePatient.Load += new EventHandler(InitialLoad);
            VerifyAction();
            ChargeValues(IdPatient, PatientName, PatientLastName, codigo, grupoTecnico, VisitDate, TimeVisit, Observaciones);
            objAddUpdatePatient.btnUpdate.Click += new EventHandler(UpdateVisit);
            objAddUpdatePatient.btnExitE.Click += new EventHandler(CloseForm);

        }


        public void VerifyInsert(object sender, EventArgs e)
        {
            if (respuesta == 1)
            {
                NewVisit();
            }
            else if (respuesta == 0)
            {
                NewPatience();
            }
        }

        public void Code(object sender, EventArgs e)
        {
            LeaveCode();
        }
        //Este metodo captura el evento cuando el txtCodigo pierde el focus para poder inicar la busqueda por medio de la coindidencia del Code
        public int LeaveCode()
        {
            DAOPatientAdministration daoPatientAdministration = new DAOPatientAdministration();
            daoPatientAdministration.Code = objAddUpdatePatient.txtPatientCode.Texts;
            string[] datos = new string[8];
           
            datos = daoPatientAdministration.SearchCode();
            if (datos != null)
            {
                action = 4;
                VerifyAction();
                objAddUpdatePatient.txtPatientName.Texts = datos[0];
                objAddUpdatePatient.txtPatientLastName.Texts = datos[1];
                objAddUpdatePatient.txtPatientCode.Texts = datos[2];
                objAddUpdatePatient.txtGrupo.Texts = datos[3];
                objAddUpdatePatient.CmBGradoRegistro.Text = datos[4];
                objAddUpdatePatient.cmbRegisterSpecialty.Text = datos[5];
                objAddUpdatePatient.cmbSection.Text = datos[6];
                objAddUpdatePatient.cmbRole.Text = datos[7];
               
                return respuesta = 1;

            }
            else if (datos == null)
            {
                objAddUpdatePatient.txtPatientName.Texts = objAddUpdatePatient.txtPatientName.Texts;
                objAddUpdatePatient.txtPatientLastName.Texts = objAddUpdatePatient.txtPatientLastName.Texts;
                objAddUpdatePatient.txtPatientCode.Texts = objAddUpdatePatient.txtPatientCode.Texts;
                objAddUpdatePatient.txtGrupo.Texts = objAddUpdatePatient.txtGrupo.Texts;   
                objAddUpdatePatient.CmBGradoRegistro.Text = objAddUpdatePatient.CmBGradoRegistro.Text;
                objAddUpdatePatient.cmbRegisterSpecialty.Text = objAddUpdatePatient.cmbRegisterSpecialty.Text;
                objAddUpdatePatient.cmbSection.Text = objAddUpdatePatient.cmbSection.Text;
                objAddUpdatePatient.cmbRole.Text = objAddUpdatePatient.cmbRole.Text;
                
                MessageBox.Show("El paciente no tiene un registro de visitas existentes, ingresar los datos", "Registro paciente", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 2;

            }
            else { return 0; }

        }

        //Metodo para actuzlaizar paciente
        public void UpdateVisit(object sender, EventArgs e)
        {
            DAOPatientAdministration daoPatientAdministration = new DAOPatientAdministration();
            daoPatientAdministration.IdVisit= int.Parse(objAddUpdatePatient.txtIdPerson.Text.Trim());
            
            daoPatientAdministration.Observation = objAddUpdatePatient.txtObservations.Texts.Trim();



            int valorRetornado = daoPatientAdministration.UpdateVisit();

            if (valorRetornado >= 0)
            {
                MessageBox.Show("Los datos han sido actualizado exitosamente",
                                "Proceso completado",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
            }

            else
            {
                MessageBox.Show("Los datos no pudieron ser actualizados debido a un error inesperado",
                                "Proceso interrumpido",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
            
        }

        //Verifica que acción se va a realizar
        public void VerifyAction()
        {
            if (action == 1)
            {
                objAddUpdatePatient.btnAddPatient.Enabled = true;
                objAddUpdatePatient.btnUpdate.Enabled = false;
                objAddUpdatePatient.btnUpdate.BackColor = Color.Silver;
                
            }
            else if (action == 2)
            {
                objAddUpdatePatient.label1.Text = "Actualizar Visita";
                objAddUpdatePatient.btnAddPatient.Enabled = false;
                objAddUpdatePatient.btnUpdate.Enabled = true;
              
                objAddUpdatePatient.btnAddPatient.BackColor = Color.Silver;
               
                objAddUpdatePatient.txtPatientName.Enabled = false;
                objAddUpdatePatient.txtPatientName.BackColor = Color.WhiteSmoke;
                objAddUpdatePatient.txtPatientLastName.Enabled = false;
                objAddUpdatePatient.txtPatientLastName.BackColor = Color.WhiteSmoke;
                objAddUpdatePatient.cmbRole.Enabled = false;
                objAddUpdatePatient.txtPatientCode.Enabled = false;
                objAddUpdatePatient.txtPatientCode.BackColor = Color.WhiteSmoke;
                objAddUpdatePatient.cmbRegisterSpecialty.Enabled = false;
                objAddUpdatePatient.txtGrupo.Enabled = false;
                objAddUpdatePatient.txtGrupo.BackColor = Color.WhiteSmoke;
                objAddUpdatePatient.CmBGradoRegistro.Enabled = false;
                objAddUpdatePatient.dtpRegisterTime.Enabled = false;
                objAddUpdatePatient.dtpRegisterDate.Enabled = false;
                objAddUpdatePatient.cmbMedicamentoRegistro.Enabled = false;

            }
            else if (action == 3)
            {
                objAddUpdatePatient.label1.Text = "Ficha de Visita";
                objAddUpdatePatient.btnAddPatient.Enabled = false;
                objAddUpdatePatient.btnAddPatient.BackColor = Color.Silver;
                objAddUpdatePatient.btnUpdate.Enabled = false;
                objAddUpdatePatient.btnUpdate.BackColor = Color.Silver;
               
                objAddUpdatePatient.txtPatientName.Enabled = false;
                objAddUpdatePatient.txtPatientName.BackColor = Color.WhiteSmoke;
                objAddUpdatePatient.txtPatientLastName.Enabled = false;
                objAddUpdatePatient.txtPatientLastName.BackColor = Color.WhiteSmoke;
                objAddUpdatePatient.cmbRole.Enabled = false;
                objAddUpdatePatient.txtPatientCode.Enabled = false;
                objAddUpdatePatient.txtPatientCode.BackColor = Color.WhiteSmoke;
                objAddUpdatePatient.cmbRegisterSpecialty.Enabled = false;
                objAddUpdatePatient.txtGrupo.Enabled = false;
                objAddUpdatePatient.txtGrupo.BackColor = Color.WhiteSmoke;
                objAddUpdatePatient.CmBGradoRegistro.Enabled = false;
                objAddUpdatePatient.cmbMedicamentoRegistro.Enabled = false;
                objAddUpdatePatient.txtObservations.Enabled = false;
                objAddUpdatePatient.txtObservations.BackColor = Color.WhiteSmoke;
                objAddUpdatePatient.dtpRegisterDate.Enabled = false;
                objAddUpdatePatient.dtpRegisterTime.Enabled = false;
                objAddUpdatePatient.cmbSection.Enabled = false;
                objAddUpdatePatient.dtpRegisterTime.Enabled = false;
                objAddUpdatePatient.dtpRegisterDate.Enabled = false;
                objAddUpdatePatient.cmbMedicamentoRegistro.Enabled = false;
            }
            else if (action == 4) 
            {
                objAddUpdatePatient.txtPatientName.BackColor = Color.WhiteSmoke;
                objAddUpdatePatient.txtPatientLastName.BackColor = Color.WhiteSmoke;
                objAddUpdatePatient.txtPatientCode.BackColor = Color.WhiteSmoke;
                objAddUpdatePatient.txtGrupo.BackColor = Color.WhiteSmoke;
                objAddUpdatePatient.cmbRole.Enabled = false;
                objAddUpdatePatient.txtPatientName.Enabled = false;
                objAddUpdatePatient.txtPatientLastName.Enabled = false;
                objAddUpdatePatient.cmbSection.Enabled = false;
                objAddUpdatePatient.cmbRegisterSpecialty.Enabled = false;
                objAddUpdatePatient.CmBGradoRegistro.Enabled = false;
                objAddUpdatePatient.txtGrupo.Enabled = false;
                objAddUpdatePatient.txtPatientCode.Enabled = false;
                objAddUpdatePatient.dtpRegisterTime.Enabled = false;
                objAddUpdatePatient.dtpRegisterDate.Enabled = false;
            }
        }

        private void NewVisit()
        {
            bool TxtEmpty = ValueTxtBox();
            if (TxtEmpty == true)
            {

                bool validation = ValidationPatient();
                if (validation == true)
                {

                    //Enviar los datos de los componentes del DTO
                    DAOPatientAdministration daoPatientAdministration = new DAOPatientAdministration();
                    daoPatientAdministration.Username = CurrentUserData.Username;
                    //Inserccion de datos de la tabla paciente
                    daoPatientAdministration.Name = objAddUpdatePatient.txtPatientName.Texts;
                    daoPatientAdministration.LastName = objAddUpdatePatient.txtPatientLastName.Texts;
                    daoPatientAdministration.Role = (int)objAddUpdatePatient.cmbRole.SelectedValue;

                    //Insercion datos tabla grade seccion
                    daoPatientAdministration.Specialty = (int)objAddUpdatePatient.cmbRegisterSpecialty.SelectedValue;
                    daoPatientAdministration.TechnicalGroup = objAddUpdatePatient.txtGrupo.Texts;
                    daoPatientAdministration.Grade = (int)objAddUpdatePatient.CmBGradoRegistro.SelectedValue;
                    daoPatientAdministration.AcademicSection = (int)objAddUpdatePatient.cmbSection.SelectedValue;

                    //Insercion de datos tbEstudiantes
                    daoPatientAdministration.Code = objAddUpdatePatient.txtPatientCode.Texts;

                    //Insercion de datos tbVisitas
                    daoPatientAdministration.Date = objAddUpdatePatient.dtpRegisterDate.Value.Date;
                    daoPatientAdministration.Time = objAddUpdatePatient.dtpRegisterTime.Value.ToString("HH:mm");
                    daoPatientAdministration.Medicine = (int)objAddUpdatePatient.cmbMedicamentoRegistro.SelectedValue;
                    daoPatientAdministration.Observation = objAddUpdatePatient.txtObservations.Texts;



                    int retorno = daoPatientAdministration.InsertVisit();
                    if (retorno == 1)
                    {
                        MessageBox.Show("Datos ingresados correctamente", "Proceso completado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        if (MessageBox.Show("Desea ingresar una nueva visita?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                                                                                                                            == DialogResult.Yes)
                        {
                            Clear();
                        }
                        else
                        {
                            objAddUpdatePatient.Close();
                        }
                    }
                    else
                    {
                        MessageBox.Show("No se pudieron ingresar los datos", "Proceso interrumpido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

            }
            else if (TxtEmpty == false)
            {
                MessageBox.Show("Algunos campos se encuentran vacios, Asegurar de compleatar la información", "Campos Vacios", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        public void Clear()
        {
            objAddUpdatePatient.txtPatientName.Clear();
            objAddUpdatePatient.txtPatientLastName.Clear();
            objAddUpdatePatient.txtPatientCode.Clear();
            objAddUpdatePatient.txtObservations.Clear();
            objAddUpdatePatient.txtGrupo.Clear();
        }
        //Ingreso de nuevo paciente
        private void NewPatience()
        {
            bool TxtEmpty = ValueTxtBox();
            if (TxtEmpty == true)
            {

                bool validation = ValidationPatient();
                if (validation == true)
                {

                    //Enviar los datos de los componentes del DTO
                    DAOPatientAdministration daoPatientAdministration = new DAOPatientAdministration();
                    daoPatientAdministration.Username = CurrentUserData.Username;
                    //Inserccion de datos de la tabla paciente
                    daoPatientAdministration.Name = objAddUpdatePatient.txtPatientName.Texts;
                    daoPatientAdministration.LastName = objAddUpdatePatient.txtPatientLastName.Texts;
                    daoPatientAdministration.Role = (int)objAddUpdatePatient.cmbRole.SelectedValue;

                    //Insercion datos tabla grade seccion
                    daoPatientAdministration.Specialty = (int)objAddUpdatePatient.cmbRegisterSpecialty.SelectedValue;
                    daoPatientAdministration.TechnicalGroup = objAddUpdatePatient.txtGrupo.Texts;
                    daoPatientAdministration.Grade = (int)objAddUpdatePatient.CmBGradoRegistro.SelectedValue;
                    daoPatientAdministration.AcademicSection = (int)objAddUpdatePatient.cmbSection.SelectedValue;

                    //Insercion de datos tbEstudiantes
                    daoPatientAdministration.Code = objAddUpdatePatient.txtPatientCode.Texts;

                    //Insercion de datos tbVisitas
                    daoPatientAdministration.Date = objAddUpdatePatient.dtpRegisterDate.Value.Date;
                    daoPatientAdministration.Time = objAddUpdatePatient.dtpRegisterTime.Value.ToString("HH:mm");
                    daoPatientAdministration.Medicine = (int)objAddUpdatePatient.cmbMedicamentoRegistro.SelectedValue;
                    daoPatientAdministration.Observation = objAddUpdatePatient.txtObservations.Texts;



                    int retorno = daoPatientAdministration.PatientRegistration();
                    if (retorno == 1)
                    {
                        MessageBox.Show("Datos ingresados correctamente", "Proceso completado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("No se pudieron ingresar los datos", "Proceso interrumpido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

            }
            else if (TxtEmpty == false)
            {
                MessageBox.Show("Algunos campos se encuentran vacios, Asegurar de compleatar la información", "Campos Vacios", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        //Carga Inicial
        public void InitialLoad(object sender, EventArgs e)
        {
            //Objeto de la clase DAOAdminUsuarios
            DAOPatientAdministration daoPatientAdministration = new DAOPatientAdministration();
            //Declarando nuevo DataSet para que obtenga los datos del metodo LlenarCombo
            DataSet dsRol = daoPatientAdministration.FillCombo("tbTipoPersona", "Pacientes");
            //Llenar combobox tbRole
            objAddUpdatePatient.cmbRole.DataSource = dsRol.Tables["tbTipoPersona"];
            objAddUpdatePatient.cmbRole.ValueMember = "idTipoPersona";
            objAddUpdatePatient.cmbRole.DisplayMember = "tipoPersona";


            DataSet dsEspRegistro = daoPatientAdministration.FillCombo("tbEspecialidades", "Secciones");
            //Llenar combobox tbEspecialidades
            objAddUpdatePatient.cmbRegisterSpecialty.DataSource = dsEspRegistro.Tables["tbEspecialidades"];
            objAddUpdatePatient.cmbRegisterSpecialty.ValueMember = "idEspecialidad";
            objAddUpdatePatient.cmbRegisterSpecialty.DisplayMember = "especialidad";

            DataSet dsGradosRegistros = daoPatientAdministration.FillCombo("tbGrados", "Secciones");
            //Llenar combobox tbGrados
            objAddUpdatePatient.CmBGradoRegistro.DataSource = dsGradosRegistros.Tables["tbGrados"];
            objAddUpdatePatient.CmBGradoRegistro.ValueMember = "idGrado";
            objAddUpdatePatient.CmBGradoRegistro.DisplayMember = "grado";

            DataSet dsSeccionesRegistros = daoPatientAdministration.FillCombo("tbSeccionAcademica", "Secciones");
            //Llenar combobox tbSeccion
            objAddUpdatePatient.cmbSection.DataSource = dsSeccionesRegistros.Tables["tbSeccionAcademica"];
            objAddUpdatePatient.cmbSection.ValueMember = "idSeccionAcademica";
            objAddUpdatePatient.cmbSection.DisplayMember = "seccionAcademica";

            //Llenar combox tbMedicamento
            DataSet dsMedicamentoRegistros = daoPatientAdministration.FillCombo("tbInventario", "Inventario");
            objAddUpdatePatient.cmbMedicamentoRegistro.DataSource = dsMedicamentoRegistros.Tables["tbInventario"];
            objAddUpdatePatient.cmbMedicamentoRegistro.ValueMember = "idInventario";
            objAddUpdatePatient.cmbMedicamentoRegistro.DisplayMember = "nombreInventario";

            objAddUpdatePatient.txtPersona.Texts = CurrentUserData.FullName;


            //La condición sirve para que al actualizar un registro, el valor del registro aparezca seleccionado.
            if (action == 2 || action == 3)
            {
                objAddUpdatePatient.cmbRole.Text = typeperson;
                objAddUpdatePatient.CmBGradoRegistro.Text = Grade;
                objAddUpdatePatient.cmbSection.Text = AcademicSection;
                objAddUpdatePatient.cmbRegisterSpecialty.Text = specialty;
                objAddUpdatePatient.cmbMedicamentoRegistro.Text = namemedication;
            }
        }

        //Cargar Los datos del formulario de Estudiantes
        public void ChargeValues(int IdPatient, string PatientName, string PatientLastName, string Code, string grupoTecnico, DateTime DateVisit, string TimeVisit, string Observaciones)
        {
            objAddUpdatePatient.txtIdPerson.Text = IdPatient.ToString();
            objAddUpdatePatient.txtPatientName.Texts = PatientName;
            objAddUpdatePatient.txtPatientLastName.Texts = PatientLastName;
            objAddUpdatePatient.txtPatientCode.Texts = Code;
            objAddUpdatePatient.dtpRegisterDate.Value = DateVisit;
            objAddUpdatePatient.dtpRegisterTime.Text = TimeVisit;
            objAddUpdatePatient.txtGrupo.Texts = grupoTecnico;
            objAddUpdatePatient.txtObservations.Texts = Observaciones;
        }

        private bool ValueTxtBox()
        {
            bool todosLlenos = true;

            // Recorrer todos los controles del formulario
            if (objAddUpdatePatient.txtPatientName.Texts != "")
            {
                if (objAddUpdatePatient.txtPatientLastName.Texts != "")
                {
                    if (objAddUpdatePatient.txtPatientCode.Texts != "")
                    {
                        if (objAddUpdatePatient.txtGrupo.Texts == "")
                        {
                            todosLlenos = false;

                        }

                    }
                    else
                    {
                        todosLlenos = false;
                    }

                }
                else
                {
                    todosLlenos = false;
                }
            }
            else
            {
                todosLlenos = false;
            }

            return todosLlenos;
        }

        public bool ValidationPatient()
        {
            DAOPatientAdministration DaoPatient = new DAOPatientAdministration();

            if (objAddUpdatePatient.txtPatientName.Texts.Length <= 60)
            {
                if (objAddUpdatePatient.txtPatientName.Texts != "")
                {
                    if (objAddUpdatePatient.txtPatientLastName.Texts.Length <= 60)
                    {
                        if (objAddUpdatePatient.txtPatientLastName.Texts != "")
                        {
                            if (objAddUpdatePatient.txtPatientCode.Texts.Length <= 10)
                            {
                                if (Regex.IsMatch(objAddUpdatePatient.txtPatientCode.Texts, @"^-?\d+(\.\d+)?$") == true)
                                {
                                    if (objAddUpdatePatient.txtPatientCode.Texts != "")
                                    {
                                        if (objAddUpdatePatient.dtpRegisterDate.Value.Date == DateTime.Now.Date)
                                        {
                                            return true;
                                        }
                                        else
                                        {
                                            MessageBox.Show($"La fecha tiene que ser la actual {DateTime.Now} ");
                                            return false;
                                        }
                                    }
                                    else
                                    {
                                        MessageBox.Show("El codigo del paciente no puede estar vacio");
                                        return false;
                                    }
                                }
                                else
                                {
                                    MessageBox.Show($"El código del paciente no es valido{objAddUpdatePatient.txtPatientCode.Texts} Verifique que solo contenga números", "Validación de codigo del paciente", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    return false;
                                }
                            }
                            else
                            {
                                MessageBox.Show("El código del paciente ha excedido el maximo de criterios");
                                return false;
                            }
                        }
                        else
                        {
                            MessageBox.Show("El apellido del paciente no puede ir vacio");
                            return false;
                        }
                    }
                    else
                    {
                        MessageBox.Show("El apellido del paciente ha excedido el maximo de criterios");
                        return false;
                    }
                }
                else
                {
                    MessageBox.Show("El nombre no puede ir vacio");
                    return false;
                }
            }
            else
            {
                MessageBox.Show("El nombre ha excedido el maximo de criterios");
                return false;
            }
        }
    }

}