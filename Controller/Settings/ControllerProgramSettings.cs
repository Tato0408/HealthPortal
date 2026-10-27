using HealthPortal.Model.DAO;
using HealthPortal.View.SectionAdministration;
using HealthPortal.View.Settings;
using System;
using System.Data;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using CustomControls;
using System.Windows.Forms;

namespace HealthPortal.Controller.Settings
{
    internal class ControllerProgramSettings
    {
        FrmProgramSettings frmProgramSettings;

        /// <summary>
        ///     Método constructor de la clase, contiene los eventos y le asigna el valor del argumento al
        ///     objeto previamente creado de tipo FrmProgramSettings
        /// </summary>
        /// <param name="view"></param>
        public ControllerProgramSettings(FrmProgramSettings view)
        {
            frmProgramSettings = view;
            frmProgramSettings.Load += new EventHandler(InitialLoad);

            frmProgramSettings.btnAddSecurityQuestion.MouseEnter += new EventHandler(MouseEnterTextButton);
            frmProgramSettings.btnAddSecurityQuestion.MouseLeave += new EventHandler(MouseLeaveTextButton);
            frmProgramSettings.btnAddSecurityQuestion.Click += new EventHandler(AddSecurityQuestion);
            frmProgramSettings.cmsUpdate.Click += new EventHandler(UpdateSecurityQuestion);
            frmProgramSettings.cmsDelete.Click += new EventHandler(DeleteSecurityQuestion);
           
        }

       

        private void DeleteSecurityQuestion(object sender, EventArgs e)
        {
            int position = frmProgramSettings.dgvSecurityQuestions.CurrentRow.Index;
            DAOSettings dao = new DAOSettings();
            dao.QuestionID = (int)frmProgramSettings.dgvSecurityQuestions[0, position].Value;
            if (dao.DeleteSecurityQuestion())
            {
                MessageBox.Show("Pregunta eliminada exitosamente.", "Proceso completado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {

                MessageBox.Show("La pregunta no pudo ser eliminada. Verifique que ningún usuario esté utilizando esta pregunta e intente de nuevo.", "Proceso interrumpido", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            FillQuestionsDgv();
        }
        private void UpdateSecurityQuestion(object sender, EventArgs e)
        {
            int position = frmProgramSettings.dgvSecurityQuestions.CurrentRow.Index;
            FrmAddUpdateSecurityQuestion frmAddUpdateSecurityQuestion = new FrmAddUpdateSecurityQuestion(2, (int)frmProgramSettings.dgvSecurityQuestions[0, position].Value, (string)frmProgramSettings.dgvSecurityQuestions[1, position].Value);
            frmAddUpdateSecurityQuestion.ShowDialog();
            FillQuestionsDgv();
        }
        private void AddSecurityQuestion(object sender, EventArgs e)
        {
            FrmAddUpdateSecurityQuestion frmAddUpdateSecurityQuestion = new FrmAddUpdateSecurityQuestion(1);
            frmAddUpdateSecurityQuestion.ShowDialog();
            FillQuestionsDgv();
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
        private void InitialLoad(object sender, EventArgs e)
        {
            CheckSecurityQuestionsState();
            FillQuestionsDgv();
        }
        private void CheckSecurityQuestionsState()
        {
            DAOSettings dao = new DAOSettings();
            if (dao.CheckSecurityQuestions())
            {
                frmProgramSettings.lblInfo.Text = "Método disponible";
            }
            else
            {
                frmProgramSettings.lblInfo.Text = "No hay preguntas, método no disponible";
            }
        }
        private void FillQuestionsDgv()
        {
            DAOSettings dao = new DAOSettings();
            DataSet ds = dao.RetrieveSecurityQuestions();
            frmProgramSettings.dgvSecurityQuestions.DataSource = ds.Tables["viewPreguntasDeSeguridad"];
            CheckSecurityQuestionsState();
            SetDataGridViewColumnSize();
        }
        private void SetDataGridViewColumnSize()
        {
            frmProgramSettings.dgvSecurityQuestions.Columns[0].Width = 102;
        }
    }
}
