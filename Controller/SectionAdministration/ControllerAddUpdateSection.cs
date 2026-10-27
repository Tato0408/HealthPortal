using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using CustomControls;
using HealthPortal.Helper;
using HealthPortal.Model.DAO;
using HealthPortal.Properties;
using HealthPortal.View.Login;
using HealthPortal.View.SectionAdministration;
using static System.Collections.Specialized.BitVector32;

namespace HealthPortal.Controller.SectionAdministration
{
    public class ControllerAddUpdateSection
    {
        FrmAddUpdateSection frmAddUpdateSection;
        int action, id, option;
        private string specialty, academicSection, grade;
        private Dictionary<string, Tuple<Bitmap, Bitmap>> imageMapping;
        public ControllerAddUpdateSection(FrmAddUpdateSection view, int action, int option)
        {
            this.action = action;
            this.option = option;
            frmAddUpdateSection = view;
            imageMapping = new Dictionary<string, Tuple<Bitmap, Bitmap>>()
            {
                { "btnExitS", Tuple.Create(Resources.quit, Resources.hoverQuit) },
                { "btnExitE", Tuple.Create(Resources.quit, Resources.hoverQuit) },
                { "btnExitSA", Tuple.Create(Resources.quit, Resources.hoverQuit) },
                { "btnExitG", Tuple.Create(Resources.quit, Resources.hoverQuit) }
            };
            VerifyTab();
            VerifyAction();
            frmAddUpdateSection.Load += new EventHandler(InitialLoad);
            frmAddUpdateSection.btnAddSpecialty.Click += new EventHandler(NewSpecialty);
            frmAddUpdateSection.btnAddSection.Click += new EventHandler(NewSection);
            frmAddUpdateSection.btnAddAcademicSection.Click += new EventHandler(NewAcademicSection);
            frmAddUpdateSection.btnAddGrade.Click += new EventHandler(NewGrade);

            CommonMethods.EnableFormDrag(frmAddUpdateSection, frmAddUpdateSection);

            frmAddUpdateSection.btnExitS.Click += new EventHandler(CloseForm);
            frmAddUpdateSection.btnExitE.Click += new EventHandler(CloseForm);
            frmAddUpdateSection.btnExitSA.Click += new EventHandler(CloseForm);
            frmAddUpdateSection.btnExitG.Click += new EventHandler(CloseForm);

            frmAddUpdateSection.btnAddAcademicSection.MouseEnter += new EventHandler(MouseEnterTextButton);
            frmAddUpdateSection.btnAddSection.MouseEnter += new EventHandler(MouseEnterTextButton);
            frmAddUpdateSection.btnAddSpecialty.MouseEnter += new EventHandler(MouseEnterTextButton);
            frmAddUpdateSection.btnAddGrade.MouseEnter += new EventHandler(MouseEnterTextButton);
            frmAddUpdateSection.btnUpdateAcademicSection.MouseEnter += new EventHandler(MouseEnterTextButton);
            frmAddUpdateSection.btnUpdateSection.MouseEnter += new EventHandler(MouseEnterTextButton);
            frmAddUpdateSection.btnUpdateSpecialty.MouseEnter += new EventHandler(MouseEnterTextButton);
            frmAddUpdateSection.btnUpdateGrade.MouseEnter += new EventHandler(MouseEnterTextButton);

            frmAddUpdateSection.btnAddAcademicSection.MouseLeave += new EventHandler(MouseLeaveTextButton);
            frmAddUpdateSection.btnAddSection.MouseLeave += new EventHandler(MouseLeaveTextButton);
            frmAddUpdateSection.btnAddSpecialty.MouseLeave += new EventHandler(MouseLeaveTextButton);
            frmAddUpdateSection.btnAddGrade.MouseLeave += new EventHandler(MouseLeaveTextButton);
            frmAddUpdateSection.btnUpdateAcademicSection.MouseLeave += new EventHandler(MouseLeaveTextButton);
            frmAddUpdateSection.btnUpdateSection.MouseLeave += new EventHandler(MouseLeaveTextButton);
            frmAddUpdateSection.btnUpdateSpecialty.MouseLeave += new EventHandler(MouseLeaveTextButton);
            frmAddUpdateSection.btnUpdateGrade.MouseLeave += new EventHandler(MouseLeaveTextButton);

            frmAddUpdateSection.btnExitS.MouseEnter += new EventHandler(MouseEnterPictureButton);
            frmAddUpdateSection.btnExitSA.MouseEnter += new EventHandler(MouseEnterPictureButton);
            frmAddUpdateSection.btnExitE.MouseEnter += new EventHandler(MouseEnterPictureButton);
            frmAddUpdateSection.btnExitG.MouseEnter += new EventHandler(MouseEnterPictureButton);

            frmAddUpdateSection.btnExitS.MouseLeave += new EventHandler(MouseLeavePictureButton);
            frmAddUpdateSection.btnExitSA.MouseLeave += new EventHandler(MouseLeavePictureButton);
            frmAddUpdateSection.btnExitE.MouseLeave += new EventHandler(MouseLeavePictureButton);
            frmAddUpdateSection.btnExitG.MouseLeave += new EventHandler(MouseLeavePictureButton);

            frmAddUpdateSection.txtGrade.Enter += new EventHandler(EnterTextBox);
            frmAddUpdateSection.txtSpecialty.Enter += new EventHandler(EnterTextBox);
            frmAddUpdateSection.txtAcademicSection.Enter += new EventHandler(EnterTextBox);
            frmAddUpdateSection.txtTechnicalGroup.Enter += new EventHandler(EnterTextBox);

            frmAddUpdateSection.txtGrade.Leave += new EventHandler(LeaveTextBox);
            frmAddUpdateSection.txtSpecialty.Leave += new EventHandler(LeaveTextBox);
            frmAddUpdateSection.txtAcademicSection.Leave += new EventHandler(LeaveTextBox);
            frmAddUpdateSection.txtTechnicalGroup.Leave += new EventHandler(LeaveTextBox);
        }
        public ControllerAddUpdateSection(FrmAddUpdateSection view, int action, int sectionID, string technicalGroup, string specialty, string grade, string academicSection)
        {
            id = sectionID;
            this.action = action;
            frmAddUpdateSection = view;
            imageMapping = new Dictionary<string, Tuple<Bitmap, Bitmap>>()
            {
                { "btnExitS", Tuple.Create(Resources.quit, Resources.hoverQuit) },
                { "btnExitE", Tuple.Create(Resources.quit, Resources.hoverQuit) },
                { "btnExitSA", Tuple.Create(Resources.quit, Resources.hoverQuit) },
                { "btnExitG", Tuple.Create(Resources.quit, Resources.hoverQuit) }
            };
            this.grade = grade;
            this.academicSection = academicSection;
            this.specialty = specialty;
            frmAddUpdateSection.Load += new EventHandler(InitialLoad);
            VerifyTab();
            VerifyAction();
            LoadSectionTab(technicalGroup);
            frmAddUpdateSection.btnUpdateSection.Click += new EventHandler(UpdateSection);

            CommonMethods.EnableFormDrag(frmAddUpdateSection, frmAddUpdateSection);

            frmAddUpdateSection.btnExitS.Click += new EventHandler(CloseForm);
            frmAddUpdateSection.btnExitE.Click += new EventHandler(CloseForm);
            frmAddUpdateSection.btnExitSA.Click += new EventHandler(CloseForm);
            frmAddUpdateSection.btnExitG.Click += new EventHandler(CloseForm);

            frmAddUpdateSection.btnAddAcademicSection.MouseEnter += new EventHandler(MouseEnterTextButton);
            frmAddUpdateSection.btnAddSection.MouseEnter += new EventHandler(MouseEnterTextButton);
            frmAddUpdateSection.btnAddSpecialty.MouseEnter += new EventHandler(MouseEnterTextButton);
            frmAddUpdateSection.btnAddGrade.MouseEnter += new EventHandler(MouseEnterTextButton);
            frmAddUpdateSection.btnUpdateAcademicSection.MouseEnter += new EventHandler(MouseEnterTextButton);
            frmAddUpdateSection.btnUpdateSection.MouseEnter += new EventHandler(MouseEnterTextButton);
            frmAddUpdateSection.btnUpdateSpecialty.MouseEnter += new EventHandler(MouseEnterTextButton);
            frmAddUpdateSection.btnUpdateGrade.MouseEnter += new EventHandler(MouseEnterTextButton);

            frmAddUpdateSection.btnAddAcademicSection.MouseLeave += new EventHandler(MouseLeaveTextButton);
            frmAddUpdateSection.btnAddSection.MouseLeave += new EventHandler(MouseLeaveTextButton);
            frmAddUpdateSection.btnAddSpecialty.MouseLeave += new EventHandler(MouseLeaveTextButton);
            frmAddUpdateSection.btnAddGrade.MouseLeave += new EventHandler(MouseLeaveTextButton);
            frmAddUpdateSection.btnUpdateAcademicSection.MouseLeave += new EventHandler(MouseLeaveTextButton);
            frmAddUpdateSection.btnUpdateSection.MouseLeave += new EventHandler(MouseLeaveTextButton);
            frmAddUpdateSection.btnUpdateSpecialty.MouseLeave += new EventHandler(MouseLeaveTextButton);
            frmAddUpdateSection.btnUpdateGrade.MouseLeave += new EventHandler(MouseLeaveTextButton);

            frmAddUpdateSection.btnExitS.MouseEnter += new EventHandler(MouseEnterPictureButton);
            frmAddUpdateSection.btnExitSA.MouseEnter += new EventHandler(MouseEnterPictureButton);
            frmAddUpdateSection.btnExitE.MouseEnter += new EventHandler(MouseEnterPictureButton);
            frmAddUpdateSection.btnExitG.MouseEnter += new EventHandler(MouseEnterPictureButton);

            frmAddUpdateSection.btnExitS.MouseLeave += new EventHandler(MouseLeavePictureButton);
            frmAddUpdateSection.btnExitSA.MouseLeave += new EventHandler(MouseLeavePictureButton);
            frmAddUpdateSection.btnExitE.MouseLeave += new EventHandler(MouseLeavePictureButton);
            frmAddUpdateSection.btnExitG.MouseLeave += new EventHandler(MouseLeavePictureButton);

            frmAddUpdateSection.txtGrade.Enter += new EventHandler(EnterTextBox);
            frmAddUpdateSection.txtSpecialty.Enter += new EventHandler(EnterTextBox);
            frmAddUpdateSection.txtAcademicSection.Enter += new EventHandler(EnterTextBox);
            frmAddUpdateSection.txtTechnicalGroup.Enter += new EventHandler(EnterTextBox);

            frmAddUpdateSection.txtGrade.Leave += new EventHandler(LeaveTextBox);
            frmAddUpdateSection.txtSpecialty.Leave += new EventHandler(LeaveTextBox);
            frmAddUpdateSection.txtAcademicSection.Leave += new EventHandler(LeaveTextBox);
            frmAddUpdateSection.txtTechnicalGroup.Leave += new EventHandler(LeaveTextBox);
        }
        public ControllerAddUpdateSection(FrmAddUpdateSection view, int action, int id, string argument, int option)
        {
            this.action = action;
            this.id = id;
            this.option = option;
            frmAddUpdateSection = view;
            VerifyTab();
            VerifyAction();
            imageMapping = new Dictionary<string, Tuple<Bitmap, Bitmap>>()
            {
                { "btnExitS", Tuple.Create(Resources.quit, Resources.hoverQuit) },
                { "btnExitE", Tuple.Create(Resources.quit, Resources.hoverQuit) },
                { "btnExitSA", Tuple.Create(Resources.quit, Resources.hoverQuit) },
                { "btnExitG", Tuple.Create(Resources.quit, Resources.hoverQuit) }
            };

            CommonMethods.EnableFormDrag(frmAddUpdateSection, frmAddUpdateSection);

            frmAddUpdateSection.btnExitS.Click += new EventHandler(CloseForm);
            frmAddUpdateSection.btnExitE.Click += new EventHandler(CloseForm);
            frmAddUpdateSection.btnExitSA.Click += new EventHandler(CloseForm);
            frmAddUpdateSection.btnExitG.Click += new EventHandler(CloseForm);

            frmAddUpdateSection.btnAddAcademicSection.MouseEnter += new EventHandler(MouseEnterTextButton);
            frmAddUpdateSection.btnAddSection.MouseEnter += new EventHandler(MouseEnterTextButton);
            frmAddUpdateSection.btnAddSpecialty.MouseEnter += new EventHandler(MouseEnterTextButton);
            frmAddUpdateSection.btnAddGrade.MouseEnter += new EventHandler(MouseEnterTextButton);
            frmAddUpdateSection.btnUpdateAcademicSection.MouseEnter += new EventHandler(MouseEnterTextButton);
            frmAddUpdateSection.btnUpdateSection.MouseEnter += new EventHandler(MouseEnterTextButton);
            frmAddUpdateSection.btnUpdateSpecialty.MouseEnter += new EventHandler(MouseEnterTextButton);
            frmAddUpdateSection.btnUpdateGrade.MouseEnter += new EventHandler(MouseEnterTextButton);

            frmAddUpdateSection.btnAddAcademicSection.MouseLeave += new EventHandler(MouseLeaveTextButton);
            frmAddUpdateSection.btnAddSection.MouseLeave += new EventHandler(MouseLeaveTextButton);
            frmAddUpdateSection.btnAddSpecialty.MouseLeave += new EventHandler(MouseLeaveTextButton);
            frmAddUpdateSection.btnAddGrade.MouseLeave += new EventHandler(MouseLeaveTextButton);
            frmAddUpdateSection.btnUpdateAcademicSection.MouseLeave += new EventHandler(MouseLeaveTextButton);
            frmAddUpdateSection.btnUpdateSection.MouseLeave += new EventHandler(MouseLeaveTextButton);
            frmAddUpdateSection.btnUpdateSpecialty.MouseLeave += new EventHandler(MouseLeaveTextButton);
            frmAddUpdateSection.btnUpdateGrade.MouseLeave += new EventHandler(MouseLeaveTextButton);

            frmAddUpdateSection.btnExitS.MouseEnter += new EventHandler(MouseEnterPictureButton);
            frmAddUpdateSection.btnExitSA.MouseEnter += new EventHandler(MouseEnterPictureButton);
            frmAddUpdateSection.btnExitE.MouseEnter += new EventHandler(MouseEnterPictureButton);
            frmAddUpdateSection.btnExitG.MouseEnter += new EventHandler(MouseEnterPictureButton);

            frmAddUpdateSection.btnExitS.MouseLeave += new EventHandler(MouseLeavePictureButton);
            frmAddUpdateSection.btnExitSA.MouseLeave += new EventHandler(MouseLeavePictureButton);
            frmAddUpdateSection.btnExitE.MouseLeave += new EventHandler(MouseLeavePictureButton);
            frmAddUpdateSection.btnExitG.MouseLeave += new EventHandler(MouseLeavePictureButton);

            frmAddUpdateSection.txtGrade.Enter += new EventHandler(EnterTextBox);
            frmAddUpdateSection.txtSpecialty.Enter += new EventHandler(EnterTextBox);
            frmAddUpdateSection.txtAcademicSection.Enter += new EventHandler(EnterTextBox);
            frmAddUpdateSection.txtTechnicalGroup.Enter += new EventHandler(EnterTextBox);

            frmAddUpdateSection.txtGrade.Leave += new EventHandler(LeaveTextBox);
            frmAddUpdateSection.txtSpecialty.Leave += new EventHandler(LeaveTextBox);
            frmAddUpdateSection.txtAcademicSection.Leave += new EventHandler(LeaveTextBox);
            frmAddUpdateSection.txtTechnicalGroup.Leave += new EventHandler(LeaveTextBox);

            if (option == 1)
            {
                specialty = argument;
                frmAddUpdateSection.Load += new EventHandler(InitialLoad);
                frmAddUpdateSection.tabAcademicLevel.SelectedIndex = 1;
                LoadSpecialtyTab();
                frmAddUpdateSection.btnUpdateSpecialty.Click += new EventHandler(UpdateSpecialty);
            }
            else if (option == 2)
            {
                academicSection = argument;
                frmAddUpdateSection.Load += new EventHandler(InitialLoad);
                frmAddUpdateSection.tabAcademicLevel.SelectedIndex = 2;
                LoadAcademicSectionTab();
                frmAddUpdateSection.btnUpdateAcademicSection.Click += new EventHandler(UpdateAcademicSection);
            }
            else
            {
                grade = argument;
                frmAddUpdateSection.Load += new EventHandler(InitialLoad);
                frmAddUpdateSection.tabAcademicLevel.SelectedIndex = 3;
                LoadGradeTab();
                frmAddUpdateSection.btnUpdateGrade.Click += new EventHandler(UpdateGrade);
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
            btn.BackColor = Color.FromArgb(142, 202, 230);
            btn.ForeColor = Color.FromArgb(31, 43, 91);
        }
        private void EnterTextBox(object sender, EventArgs e)
        {
            CustomTextBox txt = sender as CustomTextBox;
            if (txt != null)
            {
                if (txt.Texts.Trim() == GetPlaceholderText(txt))
                {
                    txt.Clear();
                    txt.ForeColor = Color.FromArgb(31, 43, 91);
                }
            }
        }
        private void LeaveTextBox(object sender, EventArgs e)
        {
            CustomTextBox txt = sender as CustomTextBox;
            if (txt != null)
            {
                if (string.IsNullOrEmpty(txt.Texts))
                {
                    txt.Texts = GetPlaceholderText(txt);
                    txt.ForeColor = Color.FromArgb(142, 202, 230);
                }
            }
        }
        private string GetPlaceholderText(CustomTextBox txt)
        {
            if (txt == frmAddUpdateSection.txtGrade) return "Grado";
            if (txt == frmAddUpdateSection.txtSpecialty) return "Especialidad";
            if (txt == frmAddUpdateSection.txtTechnicalGroup) return "Grupo técnico";
            if (txt == frmAddUpdateSection.txtAcademicSection) return "Sección Académica";
            return string.Empty;
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
        private void CloseForm(object sender, EventArgs e)
        {
            frmAddUpdateSection.Hide();
            frmAddUpdateSection.Dispose();
        }
        private void VerifyTab()
        {
            if (option == 0)
            {
                frmAddUpdateSection.tabAcademicLevel.TabPages.Remove(frmAddUpdateSection.tabPageSpecialty);
                frmAddUpdateSection.tabAcademicLevel.TabPages.Remove(frmAddUpdateSection.tabPageAcademicSection);
                frmAddUpdateSection.tabAcademicLevel.TabPages.Remove(frmAddUpdateSection.tabPageGrade);
                frmAddUpdateSection.tabAcademicLevel.SelectedIndex = 0;
            }
            else if (option == 1)
            {
                frmAddUpdateSection.tabAcademicLevel.TabPages.Remove(frmAddUpdateSection.tabPageSection);
                frmAddUpdateSection.tabAcademicLevel.TabPages.Remove(frmAddUpdateSection.tabPageAcademicSection);
                frmAddUpdateSection.tabAcademicLevel.TabPages.Remove(frmAddUpdateSection.tabPageGrade);
                frmAddUpdateSection.tabAcademicLevel.SelectedIndex = 1;
            }
            else if (option == 2)
            {
                frmAddUpdateSection.tabAcademicLevel.TabPages.Remove(frmAddUpdateSection.tabPageSection);
                frmAddUpdateSection.tabAcademicLevel.TabPages.Remove(frmAddUpdateSection.tabPageSpecialty);
                frmAddUpdateSection.tabAcademicLevel.TabPages.Remove(frmAddUpdateSection.tabPageGrade);
                frmAddUpdateSection.tabAcademicLevel.SelectedIndex = 2;
            }
            else if (option == 3)
            {
                frmAddUpdateSection.tabAcademicLevel.TabPages.Remove(frmAddUpdateSection.tabPageSection);
                frmAddUpdateSection.tabAcademicLevel.TabPages.Remove(frmAddUpdateSection.tabPageSpecialty);
                frmAddUpdateSection.tabAcademicLevel.TabPages.Remove(frmAddUpdateSection.tabPageAcademicSection);
                frmAddUpdateSection.tabAcademicLevel.SelectedIndex = 3;
            }
        }
        private void LoadSectionTab(string technicalGroup)
        {
            frmAddUpdateSection.txtTechnicalGroup.Texts = technicalGroup.ToString();
            frmAddUpdateSection.tabAcademicLevel.TabPages.Remove(frmAddUpdateSection.tabPageSpecialty);
            frmAddUpdateSection.tabAcademicLevel.TabPages.Remove(frmAddUpdateSection.tabPageAcademicSection);
            frmAddUpdateSection.tabAcademicLevel.TabPages.Remove(frmAddUpdateSection.tabPageGrade);
        }
        private void LoadSpecialtyTab()
        {
            frmAddUpdateSection.tabAcademicLevel.TabPages.Remove(frmAddUpdateSection.tabPageSection);
            frmAddUpdateSection.tabAcademicLevel.TabPages.Remove(frmAddUpdateSection.tabPageAcademicSection);
            frmAddUpdateSection.tabAcademicLevel.TabPages.Remove(frmAddUpdateSection.tabPageGrade);
        }
        private void LoadAcademicSectionTab()
        {
            // frmAddUpdateSection.txtId.Text = IdSeccion.ToString();
            frmAddUpdateSection.tabAcademicLevel.TabPages.Remove(frmAddUpdateSection.tabPageSection);
            frmAddUpdateSection.tabAcademicLevel.TabPages.Remove(frmAddUpdateSection.tabPageSpecialty);
            frmAddUpdateSection.tabAcademicLevel.TabPages.Remove(frmAddUpdateSection.tabPageGrade);
        }
        private void LoadGradeTab()
        {
            frmAddUpdateSection.tabAcademicLevel.TabPages.Remove(frmAddUpdateSection.tabPageSection);
            frmAddUpdateSection.tabAcademicLevel.TabPages.Remove(frmAddUpdateSection.tabPageSpecialty);
            frmAddUpdateSection.tabAcademicLevel.TabPages.Remove(frmAddUpdateSection.tabPageAcademicSection);
        }
        private void VerifyAction()
        {
            if (action == 1)
            {
                frmAddUpdateSection.lblSection.Text = "Agregar Sección";
                frmAddUpdateSection.btnAddSection.Enabled = true;
                frmAddUpdateSection.btnUpdateSection.Enabled = false;
                frmAddUpdateSection.lblSpecialty.Text = "Agregar Especialidad";
                frmAddUpdateSection.btnAddSpecialty.Enabled = true;
                frmAddUpdateSection.btnUpdateSpecialty.Enabled = false;
                frmAddUpdateSection.lblAcademicSection.Text = "Agregar Sección Académica";
                frmAddUpdateSection.btnAddAcademicSection.Enabled = true;
                frmAddUpdateSection.btnUpdateAcademicSection.Enabled = false;
                frmAddUpdateSection.lblGrade.Text = "Agregar Grado";
                frmAddUpdateSection.btnAddGrade.Enabled = true;
                frmAddUpdateSection.btnUpdateGrade.Enabled = false;
            }
            else if (action == 2 && frmAddUpdateSection.tabAcademicLevel.SelectedIndex == 0)
            {
                frmAddUpdateSection.lblSection.Text = "Actualizar Sección";
                frmAddUpdateSection.btnAddSection.Enabled = false;
                frmAddUpdateSection.btnUpdateSection.Enabled = true;
                frmAddUpdateSection.lblSpecialty.Text = "Actualizar Especialidad";
                frmAddUpdateSection.btnAddSpecialty.Enabled = false;
                frmAddUpdateSection.btnUpdateSpecialty.Enabled = true;
                frmAddUpdateSection.lblAcademicSection.Text = "Actualizar Sección Académica";
                frmAddUpdateSection.btnAddAcademicSection.Enabled = false;
                frmAddUpdateSection.btnUpdateAcademicSection.Enabled = true;
                frmAddUpdateSection.lblGrade.Text = "Actualizar Grado";
                frmAddUpdateSection.btnAddGrade.Enabled = false;
                frmAddUpdateSection.btnUpdateGrade.Enabled = true;
            }
            else if (action == 2 && frmAddUpdateSection.tabAcademicLevel.SelectedIndex == 1)
            {
                frmAddUpdateSection.lblSpecialty.Text = "Actualizar Especialidad";
                frmAddUpdateSection.btnAddSpecialty.Enabled = false;
                frmAddUpdateSection.btnUpdateSpecialty.Enabled = true;
            }
            else if (action == 2 && frmAddUpdateSection.tabAcademicLevel.SelectedIndex == 2)
            {
                frmAddUpdateSection.lblAcademicSection.Text = "Actualizar Sección Académica";
                frmAddUpdateSection.btnAddAcademicSection.Enabled = false;
                frmAddUpdateSection.btnUpdateAcademicSection.Enabled = true;
            }
            else if (action == 2 && frmAddUpdateSection.tabAcademicLevel.SelectedIndex == 3)
            {
                frmAddUpdateSection.lblGrade.Text = "Actualizar Grado";
                frmAddUpdateSection.btnAddGrade.Enabled = false;
                frmAddUpdateSection.btnUpdateGrade.Enabled = true;
            }
        }
        private void InitialLoad(object sender, EventArgs e)
        {
            DAOSectionAdministration dao = new DAOSectionAdministration();

            DataSet dsGrades = dao.FillCombo("tbGrados", "Secciones");
            frmAddUpdateSection.cmbGrade.DataSource = dsGrades.Tables["tbGrados"];
            frmAddUpdateSection.cmbGrade.ValueMember = "idGrado";
            frmAddUpdateSection.cmbGrade.DisplayMember = "grado";

            DataSet dsSpecialties = dao.FillCombo("tbEspecialidades", "Secciones");
            frmAddUpdateSection.cmbSpecialty.DataSource = dsSpecialties.Tables["tbEspecialidades"];
            frmAddUpdateSection.cmbSpecialty.ValueMember = "idEspecialidad";
            frmAddUpdateSection.cmbSpecialty.DisplayMember = "especialidad";

            DataSet dsAcademicSections = dao.FillCombo("tbSeccionAcademica", "Secciones");
            frmAddUpdateSection.cmbAcademicSection.DataSource = dsAcademicSections.Tables["tbSeccionAcademica"];
            frmAddUpdateSection.cmbAcademicSection.ValueMember = "idSeccionAcademica";
            frmAddUpdateSection.cmbAcademicSection.DisplayMember = "seccionAcademica";
        }
        private void NewAcademicSection(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(frmAddUpdateSection.txtAcademicSection.Texts.Trim()))
            {
                DAOSectionAdministration dao = new DAOSectionAdministration();
                dao.AcademicSection = frmAddUpdateSection.txtAcademicSection.Texts.Trim();
                if (dao.AddAcademicSection() == 1)
                {
                    MessageBox.Show("Datos ingresados correctamente.", "Proceso completado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CloseForm(sender, e);
                }
                else
                {
                    MessageBox.Show("No se pudieron ingresar los datos.", "Proceso interrumpido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void NewSpecialty(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(frmAddUpdateSection.txtSpecialty.Texts.Trim()))
            {
                DAOSectionAdministration dao = new DAOSectionAdministration();
                dao.Specialty = frmAddUpdateSection.txtSpecialty.Texts.Trim();
                if (dao.AddSpecialty() == 1)
                {
                    MessageBox.Show("Datos ingresados correctamente.", "Proceso completado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CloseForm(sender, e);
                }
                else
                {
                    MessageBox.Show("No se pudieron ingresar los datos.", "Proceso interrumpido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void NewSection(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(frmAddUpdateSection.txtTechnicalGroup.Texts.Trim()))
            {
                DAOSectionAdministration dao = new DAOSectionAdministration();
                dao.GradeID = (int)frmAddUpdateSection.cmbGrade.SelectedValue;
                dao.SpecialtyID = (int)frmAddUpdateSection.cmbSpecialty.SelectedValue;
                dao.AcademicSectionID = (int)frmAddUpdateSection.cmbAcademicSection.SelectedValue;
                dao.TechnicalGroup = frmAddUpdateSection.txtTechnicalGroup.Texts.Trim();
                if (dao.AddSection() == 1)
                {
                    MessageBox.Show("Datos ingresados correctamente.", "Proceso completado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CloseForm(sender, e);
                }
                else
                {
                    MessageBox.Show("No se pudieron ingresar los datos.", "Proceso interrumpido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void NewGrade(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(frmAddUpdateSection.txtGrade.Texts.Trim()))
            {
                DAOSectionAdministration dao = new DAOSectionAdministration();
                dao.Grade = frmAddUpdateSection.txtGrade.Texts.Trim();
                if (dao.AddGrade() == 1)
                {
                    MessageBox.Show("Datos ingresados correctamente", "Proceso completado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CloseForm(sender, e);
                }
                else
                {
                    MessageBox.Show("No se pudieron ingresar los datos", "Proceso interrumpido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void UpdateSpecialty(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(frmAddUpdateSection.txtSpecialty.Texts.Trim()))
            {
                DAOSectionAdministration dao = new DAOSectionAdministration();
                dao.SpecialtyID = id;
                dao.Specialty = frmAddUpdateSection.txtSpecialty.Texts.Trim();
                if (dao.UpdateSpecialty() == 1)
                {
                    MessageBox.Show("Los datos han sido actualizado exitosamente",
                               "Proceso completado",
                               MessageBoxButtons.OK,
                               MessageBoxIcon.Information);
                    CloseForm(sender, e);
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
        private void UpdateAcademicSection(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(frmAddUpdateSection.txtAcademicSection.Texts.Trim()))
            {
                DAOSectionAdministration dao = new DAOSectionAdministration();
                dao.AcademicSectionID = id;
                dao.AcademicSection = frmAddUpdateSection.txtAcademicSection.Texts.Trim();
                if (dao.UpdateAcademicSection() == 1)
                {
                    MessageBox.Show("Los datos han sido actualizado exitosamente",
                               "Proceso completado",
                               MessageBoxButtons.OK,
                               MessageBoxIcon.Information);
                    CloseForm(sender, e);
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
        private void UpdateGrade(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(frmAddUpdateSection.txtGrade.Texts.Trim()))
            {
                DAOSectionAdministration dao = new DAOSectionAdministration();
                dao.GradeID = id;
                dao.Grade = frmAddUpdateSection.txtGrade.Texts.Trim();
                if (dao.UpdateGrade() == 1)
                {
                    MessageBox.Show("Los datos han sido actualizado exitosamente",
                               "Proceso completado",
                               MessageBoxButtons.OK,
                               MessageBoxIcon.Information);
                    CloseForm(sender, e);
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
        private void UpdateSection(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(frmAddUpdateSection.txtTechnicalGroup.Texts.Trim()))
            {
                DAOSectionAdministration dao = new DAOSectionAdministration();
                dao.SectionID = id;
                dao.TechnicalGroup = frmAddUpdateSection.txtTechnicalGroup.Texts.Trim();
                dao.SpecialtyID = (int)frmAddUpdateSection.cmbSpecialty.SelectedValue;
                dao.GradeID = (int)frmAddUpdateSection.cmbGrade.SelectedValue;
                dao.AcademicSectionID = (int)frmAddUpdateSection.cmbAcademicSection.SelectedValue;
                if (dao.UpdateSection() == 1)
                {
                    MessageBox.Show("Los datos han sido actualizado exitosamente",
                               "Proceso completado",
                               MessageBoxButtons.OK,
                               MessageBoxIcon.Information);
                    CloseForm(sender, e);
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
}