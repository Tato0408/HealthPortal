using HealthPortal.Helper;
using HealthPortal.Model.DAO;
using HealthPortal.Model.DTO;
using HealthPortal.View.PatientAdministration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HealthPortal.Controller.PatientAdministration
{
    class ControllerViewPatientInfo
    {
        FrmViewPatientInfo frmViewPatientInfo;
        int action;
        private string typeperson, grade, specialty, academicSection;
        public ControllerViewPatientInfo(FrmViewPatientInfo view, int action)
        {
            frmViewPatientInfo = view;
            this.action = action;
            //Verificar action
            VerifyAction();
            frmViewPatientInfo.Load += new EventHandler(InitialLoad);
            //agregar un nuevo paciente
            frmViewPatientInfo.btnAddPatient.Click += new EventHandler(NewPatient);
            frmViewPatientInfo.btnInsertRol.Click += new EventHandler(AddRole);
            frmViewPatientInfo.btnExitE.Click += new EventHandler(CloseFrom);
        }

        private void CloseFrom(object sender, EventArgs e)
        {
            frmViewPatientInfo.Dispose();
        }

        private void AddRole(object sender, EventArgs e)
        {
            FrmAdminRol openform = new FrmAdminRol();
            openform.ShowDialog();
        }

        private void NewPatient(object sender, EventArgs e)
        {
            DAOPatientAdministration daoPatientAdministration = new DAOPatientAdministration();
            //Inserccion de datos de la tabla paciente
            daoPatientAdministration.Name = frmViewPatientInfo.txtPatientName.Texts;
            daoPatientAdministration.LastName = frmViewPatientInfo.txtPatientLastName.Texts;
            daoPatientAdministration.Role = (int)frmViewPatientInfo.cmbRole.SelectedValue;

            //Insercion datos tabla grade seccion
            daoPatientAdministration.Specialty = (int)frmViewPatientInfo.cmbRegisterSpecialty.SelectedValue;
            daoPatientAdministration.TechnicalGroup = frmViewPatientInfo.txtGrupo.Texts;
            daoPatientAdministration.Grade = (int)frmViewPatientInfo.CmBGradoRegistro.SelectedValue;
            daoPatientAdministration.AcademicSection = (int)frmViewPatientInfo.cmbSection.SelectedValue;
            daoPatientAdministration.Code = frmViewPatientInfo.txtPatientCode.Texts;

            int retorno = daoPatientAdministration.PatientInsert();
            if (retorno == 1)
            {
                MessageBox.Show("Datos ingresados correctamente", "Proceso completado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No se pudieron ingresar los datos", "Proceso interrumpido", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public ControllerViewPatientInfo(FrmViewPatientInfo view, int Action, int IdPatient, string PatientName, string PatientLastName, string TypePerson, string codigo, string grupoTecnico, string grade, string seccionAcademica, string Especialidad)
        {
            frmViewPatientInfo = view;
            this.action = Action;
            this.typeperson = TypePerson;
            this.grade = grade;
            this.academicSection = seccionAcademica;
            this.specialty = Especialidad;
            frmViewPatientInfo.Load += new EventHandler(InitialLoad);
            VerifyAction();
            ChargeValues(IdPatient, PatientName, PatientLastName, codigo, grupoTecnico);
            frmViewPatientInfo.btnUpdate.Click += new EventHandler(UpdatePatient);
            frmViewPatientInfo.btnInsertRol.Click += new EventHandler(AddRole);
            frmViewPatientInfo.btnExitE.Click += new EventHandler(CloseFrom);
        }
        public void InitialLoad(object sender, EventArgs e)
        {
            //Objeto de la clase DAOAdminUsuarios
            DAOPatientAdministration daoPatientAdministration = new DAOPatientAdministration();
            //Declarando nuevo DataSet para que obtenga los datos del metodo LlenarCombo
            DataSet dsRol = daoPatientAdministration.FillCombo("tbTipoPersona", "Pacientes");
            //Llenar combobox tbRole
            frmViewPatientInfo.cmbRole.DataSource = dsRol.Tables["tbTipoPersona"];
            frmViewPatientInfo.cmbRole.ValueMember = "idTipoPersona";
            frmViewPatientInfo.cmbRole.DisplayMember = "tipoPersona";


            DataSet dsEspRegistro = daoPatientAdministration.FillCombo("tbEspecialidades", "Secciones");
            //Llenar combobox tbEspecialidades
            frmViewPatientInfo.cmbRegisterSpecialty.DataSource = dsEspRegistro.Tables["tbEspecialidades"];
            frmViewPatientInfo.cmbRegisterSpecialty.ValueMember = "idEspecialidad";
            frmViewPatientInfo.cmbRegisterSpecialty.DisplayMember = "especialidad";

            DataSet dsGradosRegistros = daoPatientAdministration.FillCombo("tbGrados", "Secciones");
            //Llenar combobox tbGrados
            frmViewPatientInfo.CmBGradoRegistro.DataSource = dsGradosRegistros.Tables["tbGrados"];
            frmViewPatientInfo.CmBGradoRegistro.ValueMember = "idGrado";
            frmViewPatientInfo.CmBGradoRegistro.DisplayMember = "grado";

            DataSet dsSeccionesRegistros = daoPatientAdministration.FillCombo("tbSeccionAcademica", "Secciones");
            //Llenar combobox tbSeccion
            frmViewPatientInfo.cmbSection.DataSource = dsSeccionesRegistros.Tables["tbSeccionAcademica"];
            frmViewPatientInfo.cmbSection.ValueMember = "idSeccionAcademica";
            frmViewPatientInfo.cmbSection.DisplayMember = "seccionAcademica";

            //La condición sirve para que al actualizar un registro, el valor del registro aparezca seleccionado.
            if (action == 2 || action == 3)
            {
                frmViewPatientInfo.cmbRole.Text = typeperson;
                frmViewPatientInfo.CmBGradoRegistro.Text = grade;
                frmViewPatientInfo.cmbSection.Text = academicSection;
                frmViewPatientInfo.cmbRegisterSpecialty.Text = specialty;

            }
        }
        public void ChargeValues(int IdPatient, string PatientName, string PatientLastName, string Code, string grupoTecnico)
        {
            frmViewPatientInfo.txtIdPerson.Text = IdPatient.ToString();
            frmViewPatientInfo.txtPatientName.Texts = PatientName;
            frmViewPatientInfo.txtPatientLastName.Texts = PatientLastName;
            frmViewPatientInfo.txtPatientCode.Texts = Code;
            frmViewPatientInfo.txtGrupo.Texts = grupoTecnico;

        }
        public void VerifyAction()
        {
            if (action == 1)
            {
                frmViewPatientInfo.label1.Text = "Agregar nuevo paciente";
                frmViewPatientInfo.btnAddPatient.Enabled = true;
                frmViewPatientInfo.btnUpdate.Enabled = false;
            }
            else if (action == 2)
            {
                frmViewPatientInfo.label1.Text = "Actualizar información del Paciente";
                frmViewPatientInfo.btnUpdate.Enabled = true;
                frmViewPatientInfo.btnAddPatient.Enabled = false;


            }
            else if (action == 3)
            {

                frmViewPatientInfo.btnUpdate.Enabled = false;
                frmViewPatientInfo.btnUpdate.BackColor = Color.Silver;
                
                frmViewPatientInfo.txtPatientName.Enabled = false;
                frmViewPatientInfo.txtPatientName.BackColor = Color.WhiteSmoke;
                frmViewPatientInfo.txtPatientLastName.Enabled = false;
                frmViewPatientInfo.txtPatientLastName.BackColor = Color.WhiteSmoke;
                frmViewPatientInfo.cmbRole.Enabled = false;
                frmViewPatientInfo.txtPatientCode.Enabled = false;
                frmViewPatientInfo.txtPatientCode.BackColor = Color.WhiteSmoke;
                frmViewPatientInfo.cmbRegisterSpecialty.Enabled = false;
                frmViewPatientInfo.txtGrupo.Enabled = false;
                frmViewPatientInfo.txtGrupo.BackColor = Color.WhiteSmoke;
                frmViewPatientInfo.CmBGradoRegistro.Enabled = false;
                frmViewPatientInfo.cmbSection.Enabled = false;
            }
        }

        public void UpdatePatient(object sender, EventArgs e)
        {
            DAOPatientAdministration daoPatientAdministration = new DAOPatientAdministration();
            daoPatientAdministration.IdPatient = int.Parse(frmViewPatientInfo.txtIdPerson.Text.Trim());
            daoPatientAdministration.Name = frmViewPatientInfo.txtPatientName.Texts.Trim();
            daoPatientAdministration.LastName = frmViewPatientInfo.txtPatientLastName.Texts.Trim();
            daoPatientAdministration.Role = (int)frmViewPatientInfo.cmbRole.SelectedValue;

            //Actuzalizar Tabla Grade
            daoPatientAdministration.Specialty = (int)frmViewPatientInfo.cmbRegisterSpecialty.SelectedValue;
            daoPatientAdministration.TechnicalGroup = frmViewPatientInfo.txtGrupo.Texts;
            daoPatientAdministration.Grade = (int)frmViewPatientInfo.CmBGradoRegistro.SelectedValue;
            daoPatientAdministration.AcademicSection = (int)frmViewPatientInfo.cmbSection.SelectedValue;

            //Insercion de datos tbEstudiantes
            daoPatientAdministration.Code = frmViewPatientInfo.txtPatientCode.Texts;


            int valorRetornado = daoPatientAdministration.UpdatePatient();

            if (valorRetornado == 1)
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
    }
}