using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using HealthPortal.Model.DAO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Net;
using System.Windows.Forms.DataVisualization.Charting;
using HealthPortal.View.PatientAdministration;
using HealthPortal.Helper;
using HealthPortal.View.SectionAdministration;
using CustomControls;
using System.Drawing;
using HealthPortal.Properties;
using HealthPortal.View.InventoryAdministration;
using HealthPortal.Controller.Dashboard;
using HealthPortal.View.MainPage;
using HealthPortal.View.Reports.Patient;

namespace HealthPortal.Controller.PatientAdministration
{
    internal class ControllerPatientAdministration
    {
        FrmPatientAdministration frmPatientAdministration;
        private Dictionary<string, Tuple<Bitmap, Bitmap>> imageMapping;
        public ControllerPatientAdministration(FrmPatientAdministration view)
        {
            frmPatientAdministration = view;
            frmPatientAdministration.Load += new EventHandler(InitialLoad);

            frmPatientAdministration.btnNew.Click += new EventHandler(NewStudentPatient);
            frmPatientAdministration.cmsInsertPatient.Click += new EventHandler(NewPatient);

            frmPatientAdministration.cmsUpdate.Click += new EventHandler(UpdatePatient);
            frmPatientAdministration.UpdatePatient.Click += new EventHandler(UpdatePatientInfo);

            frmPatientAdministration.cmsView.Click += new EventHandler(ViewPatientFile);
            frmPatientAdministration.ViewPatient.Click += new EventHandler(ViewPatientInfo);

            frmPatientAdministration.cmsDelete.Click += new EventHandler(DeleteVisit);

            frmPatientAdministration.btnSearch.Click += new EventHandler(SearchPatient);
           

            frmPatientAdministration.btnSearchPatientInfo.Click += new EventHandler(SearchPatientInfo);

            frmPatientAdministration.btnFilter.Click += new EventHandler(SearchPatientByDate);
            frmPatientAdministration.cmbSpecialty.SelectedIndexChanged += new EventHandler(SearchPatientBySpecialty);
            frmPatientAdministration.cmbGrade.SelectedIndexChanged += new EventHandler(SearchByGrade);
            frmPatientAdministration.cmbRole.SelectedIndexChanged += new EventHandler(SearchByRole);


            frmPatientAdministration.btnShowAll.Click += new EventHandler(LoadPatientData);
            frmPatientAdministration.btnRefreshPatient.Click += new EventHandler(LoadPatientInfoData);

            frmPatientAdministration.btnFilter.MouseEnter += new EventHandler(MouseEnterTextButton);
            frmPatientAdministration.btnNew.MouseEnter += new EventHandler(MouseEnterTextButton);
            frmPatientAdministration.btnSearch.MouseEnter += new EventHandler(MouseEnterTextButton);
            frmPatientAdministration.btnShowAll.MouseEnter += new EventHandler(MouseEnterTextButton);

            frmPatientAdministration.btnFilter.MouseLeave += new EventHandler(MouseLeaveTextButton);
            frmPatientAdministration.btnNew.MouseLeave += new EventHandler(MouseLeaveTextButton);
            frmPatientAdministration.btnSearch.MouseLeave += new EventHandler(MouseLeaveTextButton);
            frmPatientAdministration.btnShowAll.MouseLeave += new EventHandler(MouseLeaveTextButton);
            frmPatientAdministration.PatientDelete.Click += new EventHandler(confirmDelete);
            frmPatientAdministration.btnReport.Click += new EventHandler(openReport);
            frmPatientAdministration.btnVisitReport.Click += new EventHandler(openVisitReport);
            frmPatientAdministration.txtSearch.KeyPress += new KeyPressEventHandler(CommonMethods.TextBoxKeyPress);

            //frmPatientAdministration.btnPDF.Click += new EventHandler(VisitReport);
            frmPatientAdministration.dtpVisitDate.Value = DateTime.Now;

            imageMapping = new Dictionary<string, Tuple<Bitmap, Bitmap>>()
            {
                { "btnExit", Tuple.Create(Resources.quit, Resources.hoverQuit) },
                { "btnResize", Tuple.Create(Resources.resize, Resources.hoverResize) }
            };
            frmPatientAdministration.btnExit.MouseEnter += new EventHandler(MouseEnterPictureButton);
            frmPatientAdministration.btnResize.MouseEnter += new EventHandler(MouseEnterPictureButton);
            frmPatientAdministration.btnExit.MouseLeave += new EventHandler(MouseLeavePictureButton);
            frmPatientAdministration.btnResize.MouseLeave += new EventHandler(MouseLeavePictureButton);
            frmPatientAdministration.btnExit.Click += new EventHandler(CloseForm);
            frmPatientAdministration.btnResize.Click += new EventHandler(ControllerDashboard.ToggleFullScreen);

            frmPatientAdministration.llbPatientsTreated.Click += new EventHandler(OpenPatientsTreatedForm);
        }

        //private void ReportVisit(object sender, EventArgs e)
        //{
        //    int pos = frmPatientAdministration.dgvVisitInfo.CurrentRow.Index;
        //    int IdPatient = int.Parse(frmPatientAdministration.dgvVisitInfo[0, pos].Value.ToString());
        //    FrmViewSpecificPatient specificPatient = new FrmViewSpecificPatient(IdPatient);
        //}

        private void OpenPatientsTreatedForm(object sender, EventArgs e)
        {
            FrmPatientsTreated frmPatientsTreated = new FrmPatientsTreated();
            frmPatientsTreated.ShowDialog();
        }

        private void LoadPatientInfoData(object sender, EventArgs e)
        {
            RefreshPatientInfoData();
            frmPatientAdministration.txtSearchPatientInfo.Clear();
        }

        private void SearchPatientInfo(object sender, EventArgs e)
        {
            RefreshPatientData();
            DAOPatientAdministration dao = new DAOPatientAdministration();
            string search = frmPatientAdministration.txtSearchPatientInfo.Texts;
            DataSet ds = dao.SearchPatientInfo(search);
            frmPatientAdministration.dgvPacientInfo.DataSource = ds.Tables["viewInfoPacientes"];
        }

        private void CloseForm(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea cerrar el programa directamente? Considere que se cerrará la sesión de manera automática", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                CommonMethods.DisposeOfCurrentUserData();
                Environment.Exit(0);
            }
        }
        private void MouseEnterPictureButton(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn != null && imageMapping.ContainsKey(btn.Name))
            {
                btn.Image = imageMapping[btn.Name].Item2;
                btn.ForeColor = Color.FromArgb(31, 43, 91);
            }
        }
        private void MouseLeavePictureButton(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn != null && imageMapping.ContainsKey(btn.Name))
            {
                btn.Image = imageMapping[btn.Name].Item1;
                btn.ForeColor = Color.FromArgb(142, 202, 230);
            }
        }
        private void MouseEnterTextButton(object sender, EventArgs e)
        {
            RJButton btn = sender as RJButton;
            btn.BackColor = Color.FromArgb(31, 43, 91);
            btn.ForeColor = Color.White;
        }
        private void MouseLeaveTextButton(object sender, EventArgs e)
        {
            RJButton btn = sender as RJButton;
            btn.BackColor = Color.FromArgb(255, 183, 3);
            btn.ForeColor = Color.FromArgb(31, 43, 91);
        }

        //private void VisitReport(object sender, EventArgs e)
        //{
        //    FrmReportGeneralPatient frmAddUpdatePatient = new FrmReportGeneralPatient();
        //    frmAddUpdatePatient.ShowDialog();
        //}

        private void CheckUserAccessLevel()
        {
            if (CurrentUserData.RoleId == 4 && CurrentUserData.RoleId == 5)
            {
                frmPatientAdministration.cmsDelete.Enabled = false;
                frmPatientAdministration.cmsUpdate.Enabled = false;
            }
        }
        
        private void openVisitReport(object sender, EventArgs e)
        {
            FrmViewGeneralVisit open = new FrmViewGeneralVisit();
            open.ShowDialog();
        }

        private void openReport(object sender, EventArgs e)
        {
            FrmViewGeneralPatient open = new FrmViewGeneralPatient();
            open.ShowDialog();
        }
        private void SearchByGrade(object sender, EventArgs e)
        {
            DAOPatientAdministration dao = new DAOPatientAdministration();
            string search = frmPatientAdministration.cmbGrade.Text;
            DataSet ds = dao.SearchPatientGrade(search);
            frmPatientAdministration.dgvVisitInfo.DataSource = ds.Tables["viewAdminPacientes"];
        }
        private void SearchByRole(object sender, EventArgs e)
        {
            DAOPatientAdministration dao = new DAOPatientAdministration();
            string search = frmPatientAdministration.cmbRole.Text;
            DataSet ds = dao.SearchPatientRole(search);
            frmPatientAdministration.dgvVisitInfo.DataSource = ds.Tables["viewAdminPacientes"];
        }
        private void SearchPatientBySpecialty(object sender, EventArgs e)
        {
            DAOPatientAdministration dao = new DAOPatientAdministration();
            string search = frmPatientAdministration.cmbSpecialty.Text;
            DataSet ds = dao.SearchPatientSpecialty(search);
            frmPatientAdministration.dgvVisitInfo.DataSource = ds.Tables["viewAdminPacientes"];
        }
        private void SearchPatientByDate(object sender, EventArgs e)
        {
            DAOPatientAdministration dao = new DAOPatientAdministration();
            DateTime searchDate = frmPatientAdministration.dtpVisitDate.Value.Date;
            DataSet ds = dao.SearchPatientDate(searchDate);
            frmPatientAdministration.dgvVisitInfo.DataSource = ds.Tables["viewAdminPacientes"];
        }
        private void SearchPatient(object sender, EventArgs e)
        {
            RefreshPatientData();
            DAOPatientAdministration dao = new DAOPatientAdministration();
            string search = frmPatientAdministration.txtSearch.Texts;
            DataSet ds = dao.SearchPatient(search);
            frmPatientAdministration.dgvVisitInfo.DataSource = ds.Tables["viewAdminPacientes"];
        }
        private void ViewPatientFile(object sender, EventArgs e)
        {
            int pos = frmPatientAdministration.dgvVisitInfo.CurrentRow.Index;
            int IdPatient;
            string PatientName, PatientLastName, TypePerson, Code, technicalGroup, Grade, sectionAcademic, Specialty, housVisit, nameMedication, Observations;
            DateTime DateVisit;

            IdPatient = int.Parse(frmPatientAdministration.dgvVisitInfo[0, pos].Value.ToString());
            PatientName = frmPatientAdministration.dgvVisitInfo[1, pos].Value.ToString();
            PatientLastName = frmPatientAdministration.dgvVisitInfo[2, pos].Value.ToString();
            TypePerson = frmPatientAdministration.dgvVisitInfo[3, pos].Value.ToString();
            Code = frmPatientAdministration.dgvVisitInfo[4, pos].Value.ToString();
            technicalGroup = frmPatientAdministration.dgvVisitInfo[5, pos].Value.ToString();
            Grade = frmPatientAdministration.dgvVisitInfo[6, pos].Value.ToString();
            sectionAcademic = frmPatientAdministration.dgvVisitInfo[7, pos].Value.ToString();
            Specialty = frmPatientAdministration.dgvVisitInfo[8, pos].Value.ToString();
            DateVisit = DateTime.Parse(frmPatientAdministration.dgvVisitInfo[9, pos].Value.ToString());
            housVisit = frmPatientAdministration.dgvVisitInfo[10, pos].Value.ToString();
            nameMedication = frmPatientAdministration.dgvVisitInfo[11, pos].Value.ToString();
            Observations = frmPatientAdministration.dgvVisitInfo[12, pos].Value.ToString();

            FrmAddUpdatePatient frmAddUpdatePatient = new FrmAddUpdatePatient(3, IdPatient, PatientName, PatientLastName, TypePerson, Code, technicalGroup, Grade, sectionAcademic, Specialty, DateVisit, housVisit, nameMedication, Observations);
            frmAddUpdatePatient.ShowDialog();
            RefreshPatientData();
        }
        private void InitialLoad(object sender, EventArgs e)
        {
            CheckUserAccessLevel();
            DAOPatientAdministration dao = new DAOPatientAdministration();

            DataSet ds = dao.FillCombo("tbEspecialidades", "Secciones");
            frmPatientAdministration.cmbSpecialty.DataSource = ds.Tables["tbEspecialidades"];
            frmPatientAdministration.cmbSpecialty.ValueMember = "idEspecialidad";
            frmPatientAdministration.cmbSpecialty.DisplayMember = "especialidad";

            DataSet dsGradosRegistros = dao.FillCombo("tbGrados", "Secciones");
            frmPatientAdministration.cmbGrade.DataSource = dsGradosRegistros.Tables["tbGrados"];
            frmPatientAdministration.cmbGrade.ValueMember = "idGrado";
            frmPatientAdministration.cmbGrade.DisplayMember = "grado";

            DataSet dsRol = dao.FillCombo("tbTipoPersona", "Pacientes");
            frmPatientAdministration.cmbRole.DataSource = dsRol.Tables["tbTipoPersona"];
            frmPatientAdministration.cmbRole.ValueMember = "idTipoPersona";
            frmPatientAdministration.cmbRole.DisplayMember = "tipoPersona";



            RefreshPatientData();
            RefreshPatientInfoData();
        }
        public void RefreshPatientInfoData()
        {
            DAOPatientAdministration dao = new DAOPatientAdministration();
            DataSet ds = dao.RetrieveDgvInfoPatient();
            frmPatientAdministration.dgvPacientInfo.DataSource = ds.Tables["viewInfoPacientes"];
            frmPatientAdministration.dgvPacientInfo.Columns[0].HeaderText = "ID";
          
            frmPatientAdministration.dgvPacientInfo.Columns[1].HeaderText = "Nombre";
            frmPatientAdministration.dgvPacientInfo.Columns[2].HeaderText = "Apellidos";
            frmPatientAdministration.dgvPacientInfo.Columns[3].HeaderText = "Tipo Persona";
            frmPatientAdministration.dgvPacientInfo.Columns[4].HeaderText = "Código";
            frmPatientAdministration.dgvPacientInfo.Columns[5].HeaderText = "Grupo Tecnico";
            frmPatientAdministration.dgvPacientInfo.Columns[6].HeaderText = "Grado";
            frmPatientAdministration.dgvPacientInfo.Columns[7].HeaderText = "Sección";
            frmPatientAdministration.dgvPacientInfo.Columns[8].HeaderText = "Especialidad";

        }

        public void NewStudentPatient(object sender, EventArgs e)
        {
            FrmAddUpdatePatient frmAddUpdatePatient = new FrmAddUpdatePatient(1);
            frmAddUpdatePatient.ShowDialog();
            RefreshPatientData();
        }

        public void NewPatient(object sender, EventArgs e)
        {
            FrmViewPatientInfo frmAddUpdatePatient = new FrmViewPatientInfo(1);
            frmAddUpdatePatient.ShowDialog();
            RefreshPatientInfoData();
        }

        public void RefreshPatientData()
        {
            DAOPatientAdministration dao = new DAOPatientAdministration();
            DataSet ds = dao.RetrieveDgvInfo();
            frmPatientAdministration.dgvVisitInfo.DataSource = ds.Tables["viewAdminPacientes"];
            frmPatientAdministration.dgvVisitInfo.Columns[0].HeaderText = "ID";
            frmPatientAdministration.dgvVisitInfo.Columns[0].Width = 32;
            frmPatientAdministration.dgvVisitInfo.Columns[1].HeaderText = "Nombre";
            frmPatientAdministration.dgvVisitInfo.Columns[2].HeaderText = "Apellidos";
            frmPatientAdministration.dgvVisitInfo.Columns[3].Visible = false;
            frmPatientAdministration.dgvVisitInfo.Columns[4].HeaderText = "Código";
            frmPatientAdministration.dgvVisitInfo.Columns[5].Visible = false;
            frmPatientAdministration.dgvVisitInfo.Columns[6].HeaderText = "Grado";
            frmPatientAdministration.dgvVisitInfo.Columns[7].Visible = false;
            frmPatientAdministration.dgvVisitInfo.Columns[8].HeaderText = "Especialidad";
            frmPatientAdministration.dgvVisitInfo.Columns[9].HeaderText = "Fecha de visita";
            frmPatientAdministration.dgvVisitInfo.Columns[10].HeaderText = "Hora de visita";
            frmPatientAdministration.dgvVisitInfo.Columns[11].Visible = false;
            frmPatientAdministration.dgvVisitInfo.Columns[12].Visible = false;
            frmPatientAdministration.dgvVisitInfo.Columns[13].Visible = false;
        }
        private void LoadPatientData(object sender, EventArgs e)
        {
            RefreshPatientData();
            frmPatientAdministration.txtSearch.Clear();
        }
        private void UpdatePatient(object sender, EventArgs e)
        {

            int pos = frmPatientAdministration.dgvVisitInfo.CurrentRow.Index;
            int IdVisit;
            string nombrePaciente, apellidoPaciente, TipoPersona, codigo, grupoTecnico, grado, seccionAcademica, Especialidad, horaVisita, nombreMedicamento, Observaciones;
            DateTime FechaVisita;

            IdVisit = int.Parse(frmPatientAdministration.dgvVisitInfo[0, pos].Value.ToString());
            nombrePaciente = frmPatientAdministration.dgvVisitInfo[1, pos].Value.ToString();
            apellidoPaciente = frmPatientAdministration.dgvVisitInfo[2, pos].Value.ToString();
            TipoPersona = frmPatientAdministration.dgvVisitInfo[3, pos].Value.ToString();
            codigo = frmPatientAdministration.dgvVisitInfo[4, pos].Value.ToString();
            grupoTecnico = frmPatientAdministration.dgvVisitInfo[5, pos].Value.ToString();
            grado = frmPatientAdministration.dgvVisitInfo[6, pos].Value.ToString();
            seccionAcademica = frmPatientAdministration.dgvVisitInfo[7, pos].Value.ToString();
            Especialidad = frmPatientAdministration.dgvVisitInfo[8, pos].Value.ToString();
            FechaVisita = DateTime.Parse(frmPatientAdministration.dgvVisitInfo[9, pos].Value.ToString());
            horaVisita = frmPatientAdministration.dgvVisitInfo[10, pos].Value.ToString();
            nombreMedicamento = frmPatientAdministration.dgvVisitInfo[11, pos].Value.ToString();
            Observaciones = frmPatientAdministration.dgvVisitInfo[12, pos].Value.ToString();

            FrmAddUpdatePatient openFrom = new FrmAddUpdatePatient(2, IdVisit, nombrePaciente, apellidoPaciente, TipoPersona, codigo, grupoTecnico, grado, seccionAcademica, Especialidad, FechaVisita, horaVisita, nombreMedicamento, Observaciones);
            openFrom.ShowDialog();
            RefreshPatientData();


        }

        //Mandar información del data grid para empezar el proceso de llenar el formulario del maestro

        //DELETE

        //Eliminar paciente que sean estudiantes
        private void DeleteVisit(object sender, EventArgs e)
        {
            int pos = frmPatientAdministration.dgvVisitInfo.CurrentRow.Index;
            if (MessageBox.Show($"¿Esta seguro que desea elimar a:\n {frmPatientAdministration.dgvVisitInfo[1, pos].Value.ToString()} {frmPatientAdministration.dgvVisitInfo[2, pos].Value.ToString()}.\nConsidere que dicha acción no se podrá revertir.", "Confirmar acción", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                DAOPatientAdministration dao = new DAOPatientAdministration();
                dao.IdVisit = int.Parse(frmPatientAdministration.dgvVisitInfo[0, pos].Value.ToString());
                int ValorRetornado = dao.DeleteVisit();
                if (ValorRetornado == 1)
                {
                    MessageBox.Show("Registro eliminado", "Acción completada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RefreshPatientData();
                }
                else
                {
                    MessageBox.Show("Registro no pudo ser eliminado, verifique que el registro no tenga datos asociados.", "Acción interrumpida", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void confirmDelete(object sender, EventArgs e) 
        {
            int idPaciente = DeletePatient();
            if (idPaciente != 0)
            {
                FrmPasswordPatientDelete openForm = new FrmPasswordPatientDelete(idPaciente);
                openForm.ShowDialog();
                RefreshPatientData();
                RefreshPatientInfoData();
            }
            
            
            

        }

        private int DeletePatient()
        {
            int pos = frmPatientAdministration.dgvPacientInfo.CurrentRow.Index;
            if (MessageBox.Show($"¿Esta seguro que desea elimar a:\n {frmPatientAdministration.dgvPacientInfo[1, pos].Value.ToString()} {frmPatientAdministration.dgvPacientInfo[2, pos].Value.ToString()}.\nConsidere que para dicha acción se tienen que eliminar las visitas relacionadas con el paciente por lo tanto se perderan datos de visita, esta acción no es reversible", "Confirmar acción", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                DAOPatientAdministration dao = new DAOPatientAdministration();
                dao.IdPatient = int.Parse(frmPatientAdministration.dgvPacientInfo[0, pos].Value.ToString());
                return dao.IdPatient;
            }
            else
            {
                return 0;
            }
        }

        private void UpdatePatientInfo(object sender, EventArgs e)
        {

            int pos = frmPatientAdministration.dgvPacientInfo.CurrentRow.Index;
            int IdPaciente;
            string nombrePaciente, apellidoPaciente, TipoPersona, codigo, grupoTecnico, grado, seccionAcademica, Especialidad;

            IdPaciente = int.Parse(frmPatientAdministration.dgvPacientInfo[0, pos].Value.ToString());
            nombrePaciente = frmPatientAdministration.dgvPacientInfo[1, pos].Value.ToString();
            apellidoPaciente = frmPatientAdministration.dgvPacientInfo[2, pos].Value.ToString();
            TipoPersona = frmPatientAdministration.dgvPacientInfo[3, pos].Value.ToString();
            codigo = frmPatientAdministration.dgvPacientInfo[4, pos].Value.ToString();
            grupoTecnico = frmPatientAdministration.dgvPacientInfo[5, pos].Value.ToString();
            grado = frmPatientAdministration.dgvPacientInfo[6, pos].Value.ToString();
            seccionAcademica = frmPatientAdministration.dgvPacientInfo[7, pos].Value.ToString();
            Especialidad = frmPatientAdministration.dgvPacientInfo[8, pos].Value.ToString();


            FrmViewPatientInfo openFrom = new FrmViewPatientInfo(2, IdPaciente, nombrePaciente, apellidoPaciente, TipoPersona, codigo, grupoTecnico, grado, seccionAcademica, Especialidad);
            openFrom.ShowDialog();
            RefreshPatientInfoData();


        }

        private void ViewPatientInfo(object sender, EventArgs e)
        {

            int pos = frmPatientAdministration.dgvPacientInfo.CurrentRow.Index;
            int IdPaciente;
            string nombrePaciente, apellidoPaciente, TipoPersona, codigo, grupoTecnico, grado, seccionAcademica, Especialidad;

            IdPaciente = int.Parse(frmPatientAdministration.dgvPacientInfo[0, pos].Value.ToString());
            nombrePaciente = frmPatientAdministration.dgvPacientInfo[1, pos].Value.ToString();
            apellidoPaciente = frmPatientAdministration.dgvPacientInfo[2, pos].Value.ToString();
            TipoPersona = frmPatientAdministration.dgvPacientInfo[3, pos].Value.ToString();
            codigo = frmPatientAdministration.dgvPacientInfo[4, pos].Value.ToString();
            grupoTecnico = frmPatientAdministration.dgvPacientInfo[5, pos].Value.ToString();
            grado = frmPatientAdministration.dgvPacientInfo[6, pos].Value.ToString();
            seccionAcademica = frmPatientAdministration.dgvPacientInfo[7, pos].Value.ToString();
            Especialidad = frmPatientAdministration.dgvPacientInfo[8, pos].Value.ToString();


            FrmViewPatientInfo openFrom = new FrmViewPatientInfo(3, IdPaciente, nombrePaciente, apellidoPaciente, TipoPersona, codigo, grupoTecnico, grado, seccionAcademica, Especialidad);
            openFrom.ShowDialog();
            RefreshPatientInfoData();


        }

        
    }
}