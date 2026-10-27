using HealthPortal.View.SectionAdministration;
using HealthPortal.View.Settings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using HealthPortal.Model.DAO;
using System.Data;
using HealthPortal.Helper;
using CustomControls;

namespace HealthPortal.Controller.Settings
{
    internal class ControllerUserSettings
    {
        FrmUserSettings frmUserSettings;
        public ControllerUserSettings(FrmUserSettings view)
        {
            frmUserSettings = view;
            frmUserSettings.Load += new EventHandler(InitialLoad);
            frmUserSettings.btnAddSecurityQuestion.MouseEnter += new EventHandler(MouseEnterTextButton);
            frmUserSettings.btnAddSecurityQuestion.MouseLeave += new EventHandler(MouseLeaveTextButton);
            frmUserSettings.btnAddSecurityQuestion.Click += new EventHandler(NewAnswer);
            frmUserSettings.cmsUpdate.Click += new EventHandler(UpdateAnswer);
            frmUserSettings.cmsDelete.Click += new EventHandler(DeleteAnswer);
           frmUserSettings.btManuals.Click += new EventHandler(Dowland);
        }
        private void Dowland(object sender, EventArgs e)
        {
            FrmManuals frmManuals = new FrmManuals();
            frmManuals.ShowDialog();

        }
        private void NewAnswer(object sender, EventArgs e)
        {
            FrmAddUpdateSecurityAnswer frmAddUpdateSecurityAnswer = new FrmAddUpdateSecurityAnswer(1, CurrentUserData.Username);
            frmAddUpdateSecurityAnswer.ShowDialog();
            FillQuestionsDgv();
        }
        private void UpdateAnswer(object sender, EventArgs e)
        {
            if (frmUserSettings.dgvSecurityQuestions.CurrentRow != null && !frmUserSettings.dgvSecurityQuestions.CurrentRow.IsNewRow)
            {
                int position = frmUserSettings.dgvSecurityQuestions.CurrentRow.Index;
                int answerID = (int)frmUserSettings.dgvSecurityQuestions[0, position].Value;
                FrmAddUpdateSecurityAnswer frmAddUpdateSecurityAnswer = new FrmAddUpdateSecurityAnswer(2, CurrentUserData.Username, answerID);
                frmAddUpdateSecurityAnswer.ShowDialog();
                FillQuestionsDgv();
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un registro válido.");
            }
        }
        private void DeleteAnswer(object sender, EventArgs e)
        {
            if (frmUserSettings.dgvSecurityQuestions.CurrentRow != null && !frmUserSettings.dgvSecurityQuestions.CurrentRow.IsNewRow)
            {
                int position = frmUserSettings.dgvSecurityQuestions.CurrentRow.Index;
                DAOSettings dao = new DAOSettings();
                dao.AnswerID = (int)frmUserSettings.dgvSecurityQuestions[0, position].Value;
                if (dao.DeleteSecurityAnswer())
                {
                    MessageBox.Show("Respuesta eliminada exitosamente.", "Proceso completado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {

                    MessageBox.Show("La respuesta no pudo ser eliminada. Verifique que ningún usuario esté utilizando esta pregunta e intente de nuevo.", "Proceso interrumpido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                FillQuestionsDgv();
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un registro válido.", "Proceso interrumpido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
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
                frmUserSettings.lblInfo.Text = "Método disponible";
                frmUserSettings.grpSecurityQuestions.Enabled = true;
            }
            else
            {
                frmUserSettings.lblInfo.Text = "No hay preguntas, método no disponible";
                frmUserSettings.grpSecurityQuestions.Enabled = false;
            }
        }
        private void FillQuestionsDgv()
        {
            DAOSettings dao = new DAOSettings();
            dao.Username = CurrentUserData.Username;
            DataSet ds = dao.RetrieveSecurityAnswers();
            frmUserSettings.dgvSecurityQuestions.DataSource = ds.Tables["viewRespuestasDeSeguridad"];
            CheckSecurityQuestionsState();
            SetDataGridViewColumnSize();
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
        private void SetDataGridViewColumnSize()
        {
            frmUserSettings.dgvSecurityQuestions.Columns[0].Width = 102;
        }
    }
}
