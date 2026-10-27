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
using HealthPortal.Controller.Dashboard;
using HealthPortal.Helper;
using HealthPortal.Model.DAO;
using HealthPortal.Properties;
using HealthPortal.View.MainPage;
using HealthPortal.View.SectionAdministration;
using HealthPortal.View.UserAdministration;

namespace HealthPortal.Controller.SectionAdministration
{
    internal class ControllerSectionAdministration
    {
        FrmSectionAdministration frmSectionAdministration;
        private Dictionary<string, Tuple<Bitmap, Bitmap>> imageMapping;
        public ControllerSectionAdministration(FrmSectionAdministration view)
        {
            frmSectionAdministration = view;
            frmSectionAdministration.Load += new EventHandler(InitialLoad);

            frmSectionAdministration.cmsAddSection.Click += new EventHandler(AddSection);
            frmSectionAdministration.cmsAddGrade.Click += new EventHandler(AddGrade);
            frmSectionAdministration.cmsAddSpecialty.Click += new EventHandler(AddSpecialty);
            frmSectionAdministration.cmsAddASection.Click += new EventHandler(AddAcademicSection);

            frmSectionAdministration.cmsUpdateSection.Click += new EventHandler(UpdateSection);
            frmSectionAdministration.cmsUpdateGrade.Click += new EventHandler(UpdateGrade);
            frmSectionAdministration.cmsUpdateSpecialty.Click += new EventHandler(UpdateSpecialty);
            frmSectionAdministration.cmsUpdateASection.Click += new EventHandler(UpdateAcademicSection);

            frmSectionAdministration.cmsDeleteASection.Click += new EventHandler(DeleteAcademicSection);
            frmSectionAdministration.cmsDeleteGrade.Click += new EventHandler(DeleteGrade);
            frmSectionAdministration.cmsDeleteSpecialty.Click += new EventHandler(DeleteSpecialty);
            frmSectionAdministration.cmsDeleteSection.Click += new EventHandler(DeleteSection);

            frmSectionAdministration.tabAcademicLevel.SelectedIndexChanged += new EventHandler(TabControlSelectedIndexChanged);

            imageMapping = new Dictionary<string, Tuple<Bitmap, Bitmap>>()
            {
                { "btnExit", Tuple.Create(Resources.quit, Resources.hoverQuit) },
                { "btnResize", Tuple.Create(Resources.resize, Resources.hoverResize) }
            };
            frmSectionAdministration.btnExit.MouseEnter += new EventHandler(MouseEnterPictureButton);
            frmSectionAdministration.btnResize.MouseEnter += new EventHandler(MouseEnterPictureButton);
            frmSectionAdministration.btnExit.MouseLeave += new EventHandler(MouseLeavePictureButton);
            frmSectionAdministration.btnResize.MouseLeave += new EventHandler(MouseLeavePictureButton);
            frmSectionAdministration.btnExit.Click += new EventHandler(CloseForm);
            frmSectionAdministration.btnResize.Click += new EventHandler(ControllerDashboard.ToggleFullScreen);
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
        private void TabControlSelectedIndexChanged(object sender, EventArgs e)
        {
            switch (frmSectionAdministration.tabAcademicLevel.SelectedIndex)
            {
                case 0:
                    frmSectionAdministration.dgvAcademicLevelDisplay.ContextMenuStrip = frmSectionAdministration.cmsSection;
                    RefreshSectionDataGridView();
                    break;
                case 1:
                    frmSectionAdministration.dgvAcademicLevelDisplay.ContextMenuStrip = frmSectionAdministration.cmsSpecialty;
                    RefreshSpecialtyDataGridView();
                    break;
                case 2:
                    frmSectionAdministration.dgvAcademicLevelDisplay.ContextMenuStrip = frmSectionAdministration.cmsAcademicSection;
                    RefreshAcademicSectionDataGridView();
                    break;
                case 3:
                    frmSectionAdministration.dgvAcademicLevelDisplay.ContextMenuStrip = frmSectionAdministration.cmsGrade;
                    RefreshGradeDataGridView();
                    break;
                default:
                    break;
            }
        }
        private void InitialLoad(object sender, EventArgs e)
        {
            RefreshSectionDataGridView();
            frmSectionAdministration.dgvAcademicLevelDisplay.ContextMenuStrip = frmSectionAdministration.cmsSection;
        }
        private void AddSection(object sender, EventArgs e)
        {
            FrmAddUpdateSection frmAddUpdateSection = new FrmAddUpdateSection(1, 0);
            frmAddUpdateSection.ShowDialog();
            RefreshSectionDataGridView();
        }
        private void AddSpecialty(object sender, EventArgs e)
        {
            FrmAddUpdateSection frmAddUpdateSection = new FrmAddUpdateSection(1, 1);
            frmAddUpdateSection.ShowDialog();
            RefreshSpecialtyDataGridView();
        }
        private void AddAcademicSection(object sender, EventArgs e)
        {
            FrmAddUpdateSection frmAddUpdateSection = new FrmAddUpdateSection(1, 2);
            frmAddUpdateSection.ShowDialog();
            RefreshAcademicSectionDataGridView();
        }
        private void AddGrade(object sender, EventArgs e)
        {
            FrmAddUpdateSection frmAddUpdateSection = new FrmAddUpdateSection(1, 3);
            frmAddUpdateSection.ShowDialog();
            RefreshGradeDataGridView();
        }
        private void UpdateSpecialty(object sender, EventArgs e)
        {
            if (frmSectionAdministration.dgvAcademicLevelDisplay.CurrentRow != null && !frmSectionAdministration.dgvAcademicLevelDisplay.CurrentRow.IsNewRow)
            {
                int pos = frmSectionAdministration.dgvAcademicLevelDisplay.CurrentRow.Index;
                int specialtyID = int.Parse(frmSectionAdministration.dgvAcademicLevelDisplay[0, pos].Value.ToString());
                string specialty = frmSectionAdministration.dgvAcademicLevelDisplay[1, pos].Value.ToString();
                FrmAddUpdateSection frmAddUpdateSection = new FrmAddUpdateSection(2, specialtyID, specialty, 1);
                frmAddUpdateSection.ShowDialog();

                RefreshSpecialtyDataGridView();
            }
            else
            {
                MessageBox.Show("Por favor, seleccione una celda válida.", "Proceso interrumpido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        private void UpdateSection(object sender, EventArgs e)
        {
            if (frmSectionAdministration.dgvAcademicLevelDisplay.CurrentRow != null && !frmSectionAdministration.dgvAcademicLevelDisplay.CurrentRow.IsNewRow)
            {
                int pos = frmSectionAdministration.dgvAcademicLevelDisplay.CurrentRow.Index;
                int sectionID = int.Parse(frmSectionAdministration.dgvAcademicLevelDisplay[0, pos].Value.ToString());
                string technicalGroup = frmSectionAdministration.dgvAcademicLevelDisplay[1, pos].Value.ToString();
                string grade = frmSectionAdministration.dgvAcademicLevelDisplay[2, pos].Value.ToString();
                string academicSection = frmSectionAdministration.dgvAcademicLevelDisplay[3, pos].Value.ToString();
                string specialty = frmSectionAdministration.dgvAcademicLevelDisplay[4, pos].Value.ToString();
                FrmAddUpdateSection frmAddUpdateSection = new FrmAddUpdateSection(2, sectionID, technicalGroup, specialty, grade, academicSection);
                frmAddUpdateSection.ShowDialog();
                RefreshSectionDataGridView();
            }
            else
            {
                MessageBox.Show("Por favor, seleccione una celda válida.", "Proceso interrumpido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        private void UpdateAcademicSection(object sender, EventArgs e)
        {
            if (frmSectionAdministration.dgvAcademicLevelDisplay.CurrentRow != null && !frmSectionAdministration.dgvAcademicLevelDisplay.CurrentRow.IsNewRow)
            {
                int pos = frmSectionAdministration.dgvAcademicLevelDisplay.CurrentRow.Index;
                int academicSectionID = int.Parse(frmSectionAdministration.dgvAcademicLevelDisplay[0, pos].Value.ToString());
                string academicSection = frmSectionAdministration.dgvAcademicLevelDisplay[1, pos].Value.ToString();
                FrmAddUpdateSection frmAddUpdateSection = new FrmAddUpdateSection(2, academicSectionID, academicSection, 2);
                frmAddUpdateSection.ShowDialog();
                RefreshAcademicSectionDataGridView();
            }
            else
            {
                MessageBox.Show("Por favor, seleccione una celda válida.", "Proceso interrumpido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        private void UpdateGrade(object sender, EventArgs e)
        {
            if (frmSectionAdministration.dgvAcademicLevelDisplay.CurrentRow != null && !frmSectionAdministration.dgvAcademicLevelDisplay.CurrentRow.IsNewRow)
            {
                int pos = frmSectionAdministration.dgvAcademicLevelDisplay.CurrentRow.Index;
                int gradeID = int.Parse(frmSectionAdministration.dgvAcademicLevelDisplay[0, pos].Value.ToString());
                string academicSection = frmSectionAdministration.dgvAcademicLevelDisplay[1, pos].Value.ToString();
                FrmAddUpdateSection frmAddUpdateSection = new FrmAddUpdateSection(2, gradeID, academicSection, 3);
                frmAddUpdateSection.ShowDialog();
                RefreshGradeDataGridView();
            }
            else
            {
                MessageBox.Show("Por favor, seleccione una celda válida.", "Proceso interrumpido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        private void DeleteAcademicSection(object sender, EventArgs e)
        {
            if (frmSectionAdministration.dgvAcademicLevelDisplay.CurrentRow != null && !frmSectionAdministration.dgvAcademicLevelDisplay.CurrentRow.IsNewRow)
            {
                int pos = frmSectionAdministration.dgvAcademicLevelDisplay.CurrentRow.Index;
                if (MessageBox.Show($"¿Está seguro que desea eliminar a la sección académica:{frmSectionAdministration.dgvAcademicLevelDisplay[1, pos].Value.ToString()}.\nConsidere que dicha acción no se podrá revertir.", "Confirmar acción", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    DAOSectionAdministration dao = new DAOSectionAdministration();
                    dao.AcademicSectionID = int.Parse(frmSectionAdministration.dgvAcademicLevelDisplay[0, pos].Value.ToString());
                    if (dao.DeleteAcademicSection() == 1)
                    {
                        MessageBox.Show("Registro eliminado.", "Acción completada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        RefreshAcademicSectionDataGridView();
                    }
                    else
                    {
                        MessageBox.Show("Registro no pudo ser eliminado, verifique que el registro no tenga datos asociados.", "Acción interrumpida", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione una celda válida.", "Proceso interrumpido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        private void DeleteSpecialty(object sender, EventArgs e)
        {
            if (frmSectionAdministration.dgvAcademicLevelDisplay.CurrentRow != null && !frmSectionAdministration.dgvAcademicLevelDisplay.CurrentRow.IsNewRow)
            {
                int pos = frmSectionAdministration.dgvAcademicLevelDisplay.CurrentRow.Index;
                if (MessageBox.Show($"¿Está seguro que desea eliminar a la especialidad:{frmSectionAdministration.dgvAcademicLevelDisplay[1, pos].Value.ToString()}.\nConsidere que dicha acción no se podrá revertir.", "Confirmar acción", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    DAOSectionAdministration dao = new DAOSectionAdministration();
                    dao.SpecialtyID = int.Parse(frmSectionAdministration.dgvAcademicLevelDisplay[0, pos].Value.ToString());
                    if (dao.DeleteSpecialty() == 1)
                    {
                        MessageBox.Show("Registro eliminado.", "Acción completada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        RefreshSpecialtyDataGridView();
                    }
                    else
                    {
                        MessageBox.Show("Registro no pudo ser eliminado, verifique que el registro no tenga datos asociados.", "Acción interrumpida", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione una celda válida.", "Proceso interrumpido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        private void DeleteSection(object sender, EventArgs e)
        {
            if (frmSectionAdministration.dgvAcademicLevelDisplay.CurrentRow != null && !frmSectionAdministration.dgvAcademicLevelDisplay.CurrentRow.IsNewRow)
            {
                int pos = frmSectionAdministration.dgvAcademicLevelDisplay.CurrentRow.Index;
                if (MessageBox.Show($"¿Está seguro que desea eliminar a la sección:{frmSectionAdministration.dgvAcademicLevelDisplay[1, pos].Value.ToString()}.\nConsidere que dicha acción no se podrá revertir.", "Confirmar acción", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    DAOSectionAdministration dao = new DAOSectionAdministration();
                    dao.SectionID = int.Parse(frmSectionAdministration.dgvAcademicLevelDisplay[0, pos].Value.ToString());
                    if (dao.DeleteSection() == 1)
                    {
                        MessageBox.Show("Registro eliminado.", "Acción completada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        RefreshSectionDataGridView();
                    }
                    else
                    {
                        MessageBox.Show("Registro no pudo ser eliminado, verifique que el registro no tenga datos asociados.", "Acción interrumpida", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione una celda válida.", "Proceso interrumpido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        private void DeleteGrade(object sender, EventArgs e)
        {
            if (frmSectionAdministration.dgvAcademicLevelDisplay.CurrentRow != null && !frmSectionAdministration.dgvAcademicLevelDisplay.CurrentRow.IsNewRow)
            {
                int pos = frmSectionAdministration.dgvAcademicLevelDisplay.CurrentRow.Index;
                if (MessageBox.Show($"¿Está seguro que desea eliminar al grado:{frmSectionAdministration.dgvAcademicLevelDisplay[1, pos].Value.ToString()}.\nConsidere que dicha acción no se podrá revertir.", "Confirmar acción", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    DAOSectionAdministration dao = new DAOSectionAdministration();
                    dao.GradeID = int.Parse(frmSectionAdministration.dgvAcademicLevelDisplay[0, pos].Value.ToString());
                    if (dao.DeleteGrade() == 1)
                    {
                        MessageBox.Show("Registro eliminado.", "Acción completada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        RefreshGradeDataGridView();
                    }
                    else
                    {
                        MessageBox.Show("Registro no pudo ser eliminado, verifique que el registro no tenga datos asociados.", "Acción interrumpida", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione una celda válida.", "Proceso interrumpido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        private void RefreshSectionDataGridView()
        {
            DAOSectionAdministration dao = new DAOSectionAdministration();
            DataSet ds = dao.RetrieveSectionData();
            // Llenar DataGridView
            frmSectionAdministration.dgvAcademicLevelDisplay.DataSource = ds.Tables["viewGradoSeccion"];
            SetDataGridViewColumnSize();
        }
        private void RefreshSpecialtyDataGridView()
        {
            DAOSectionAdministration dao = new DAOSectionAdministration();
            DataSet ds = dao.RetrieveSpecialtyData();
            // Llenar DataGridView
            frmSectionAdministration.dgvAcademicLevelDisplay.DataSource = ds.Tables["viewEspecialidades"];
            SetDataGridViewColumnSize();
        }
        private void RefreshAcademicSectionDataGridView()
        {
            DAOSectionAdministration dao = new DAOSectionAdministration();
            DataSet ds = dao.RetrieveAcademicSectionData();
            //Llenar DataGridView
            frmSectionAdministration.dgvAcademicLevelDisplay.DataSource = ds.Tables["viewSeccionesAcademicas"];
            SetDataGridViewColumnSize();

        }
        private void RefreshGradeDataGridView()
        {
            DAOSectionAdministration dao = new DAOSectionAdministration();
            DataSet ds = dao.RetrieveGradeData();
            frmSectionAdministration.dgvAcademicLevelDisplay.DataSource = ds.Tables["viewGrados"];
            SetDataGridViewColumnSize();
        }
        private void SetDataGridViewColumnSize()
        {
            frmSectionAdministration.dgvAcademicLevelDisplay.Columns[0].Width = 64;
        }
    }
}