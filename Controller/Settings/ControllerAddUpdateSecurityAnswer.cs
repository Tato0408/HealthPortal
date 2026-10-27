using CustomControls;
using HealthPortal.Helper;
using HealthPortal.Model.DAO;
using HealthPortal.Properties;
using HealthPortal.View.Settings;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HealthPortal.Controller.Settings
{
    internal class ControllerAddUpdateSecurityAnswer
    {
        FrmAddUpdateSecurityAnswer frmAddUpdateSecurityAnswer;
        int origin, answerID;
        string username;
        public ControllerAddUpdateSecurityAnswer(FrmAddUpdateSecurityAnswer view, int origin, string username)
        {
            frmAddUpdateSecurityAnswer = view;
            this.origin = origin;
            this.username = username;

            frmAddUpdateSecurityAnswer.Load += new EventHandler(InitialLoad);

            frmAddUpdateSecurityAnswer.txtAnswer.Enter += new EventHandler(EnterTxtAnswer);
            frmAddUpdateSecurityAnswer.txtAnswer.Leave += new EventHandler(LeaveTxtAnswer);

            frmAddUpdateSecurityAnswer.btnExit.MouseEnter += new EventHandler(MouseEnterControl);
            frmAddUpdateSecurityAnswer.btnExit.MouseLeave += new EventHandler(MouseLeaveControl);

            frmAddUpdateSecurityAnswer.btnAddAnswer.MouseEnter += new EventHandler(MouseEnterButton);
            frmAddUpdateSecurityAnswer.btnAddAnswer.MouseLeave += new EventHandler(MouseLeaveButton);
            frmAddUpdateSecurityAnswer.btnUpdateAnswer.MouseEnter += new EventHandler(MouseEnterButton);
            frmAddUpdateSecurityAnswer.btnUpdateAnswer.MouseLeave += new EventHandler(MouseLeaveButton);

            frmAddUpdateSecurityAnswer.btnAddAnswer.Click += new EventHandler(AddAnswer);

            frmAddUpdateSecurityAnswer.btnExit.Click += new EventHandler(CloseForm);
            frmAddUpdateSecurityAnswer.txtAnswer.KeyPress += new KeyPressEventHandler(CommonMethods.TextBoxKeyPress);

            VerifyOrigin();

            CommonMethods.EnableFormDrag(frmAddUpdateSecurityAnswer, frmAddUpdateSecurityAnswer);
        }
        public ControllerAddUpdateSecurityAnswer(FrmAddUpdateSecurityAnswer view, int origin, string username, int answerID)
        {
            frmAddUpdateSecurityAnswer = view;
            this.origin = origin;
            this.username = username;
            this.answerID = answerID;

            frmAddUpdateSecurityAnswer.Load += new EventHandler(InitialLoad);

            frmAddUpdateSecurityAnswer.txtAnswer.Enter += new EventHandler(EnterTxtAnswer);
            frmAddUpdateSecurityAnswer.txtAnswer.Leave += new EventHandler(LeaveTxtAnswer);

            frmAddUpdateSecurityAnswer.btnExit.MouseEnter += new EventHandler(MouseEnterControl);
            frmAddUpdateSecurityAnswer.btnExit.MouseLeave += new EventHandler(MouseLeaveControl);

            frmAddUpdateSecurityAnswer.btnAddAnswer.MouseEnter += new EventHandler(MouseEnterButton);
            frmAddUpdateSecurityAnswer.btnAddAnswer.MouseLeave += new EventHandler(MouseLeaveButton);
            frmAddUpdateSecurityAnswer.btnUpdateAnswer.MouseEnter += new EventHandler(MouseEnterButton);
            frmAddUpdateSecurityAnswer.btnUpdateAnswer.MouseLeave += new EventHandler(MouseLeaveButton);

            frmAddUpdateSecurityAnswer.btnUpdateAnswer.Click += new EventHandler(UpdateAnswer);

            frmAddUpdateSecurityAnswer.btnExit.Click += new EventHandler(CloseForm);
            frmAddUpdateSecurityAnswer.txtAnswer.KeyPress += new KeyPressEventHandler(CommonMethods.TextBoxKeyPress);

            VerifyOrigin();

            CommonMethods.EnableFormDrag(frmAddUpdateSecurityAnswer, frmAddUpdateSecurityAnswer);
        }
        private void UpdateAnswer(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(frmAddUpdateSecurityAnswer.txtAnswer.Texts.Trim()) || frmAddUpdateSecurityAnswer.txtAnswer.Texts.Trim() == "Respuesta")
            {
                DAOSettings dao = new DAOSettings();
                dao.AnswerID = answerID;
                dao.Answer = frmAddUpdateSecurityAnswer.txtAnswer.Texts.Trim();

                if (dao.UpdateAnswer())
                {
                    MessageBox.Show("Respuesta de seguridad actualizada exitosamente.", "Proceso finalizado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                frmAddUpdateSecurityAnswer.Hide();
                frmAddUpdateSecurityAnswer.Dispose();
            }
        }
        private void AddAnswer(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(frmAddUpdateSecurityAnswer.txtAnswer.Texts.Trim()) || frmAddUpdateSecurityAnswer.txtAnswer.Texts.Trim() == "Respuesta")
            {
                DAOSettings dao = new DAOSettings();
                dao.QuestionID = (int)frmAddUpdateSecurityAnswer.cmbQuestions.SelectedValue;
                dao.Answer = CommonMethods.ComputeSha256Hash(frmAddUpdateSecurityAnswer.txtAnswer.Texts.Trim());
                dao.Username = username;
                if (dao.RegisterAnswer())
                {
                    MessageBox.Show("Respuesta de seguridad registrada exitosamente.", "Proceso finalizado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                frmAddUpdateSecurityAnswer.Hide();
                frmAddUpdateSecurityAnswer.Dispose();
            }
        }
        private void MouseEnterButton(object sender, EventArgs e)
        {
            RJButton btn = sender as RJButton;
            btn.BackColor = Color.FromArgb(31, 43, 91);
            btn.ForeColor = Color.White;
        }
        private void MouseLeaveButton(object sender, EventArgs e)
        {
            RJButton btn = sender as RJButton;
            btn.BackColor = Color.FromArgb(142, 202, 230);
            btn.ForeColor = Color.FromArgb(31, 43, 91);
        }
        private void EnterTxtAnswer(object sender, EventArgs e)
        {
            if (frmAddUpdateSecurityAnswer.txtAnswer.Texts.Trim().Equals("Respuesta"))
            {
                frmAddUpdateSecurityAnswer.txtAnswer.Clear();
                frmAddUpdateSecurityAnswer.txtAnswer.ForeColor = Color.FromArgb(31, 43, 91);
            }
        }
        private void LeaveTxtAnswer(object sender, EventArgs e)
        {
            if (frmAddUpdateSecurityAnswer.txtAnswer.Texts.Trim().Equals(""))
            {
                frmAddUpdateSecurityAnswer.txtAnswer.Texts = "Respuesta";
                frmAddUpdateSecurityAnswer.txtAnswer.ForeColor = Color.FromArgb(142, 202, 230);
            }
        }
        private void CloseForm(object sender, EventArgs e)
        {
            frmAddUpdateSecurityAnswer.Dispose();
        }
        private void MouseEnterControl(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            btn.Image = Resources.hoverQuit;
        }
        private void MouseLeaveControl(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            btn.Image = Resources.quit;
        }
        private void InitialLoad(object sender, EventArgs e)
        {
            DAOSettings dao = new DAOSettings();
            DataSet ds = dao.RetrieveOnlySecurityQuestions();
            frmAddUpdateSecurityAnswer.cmbQuestions.DataSource = ds.Tables["tbPreguntas"];
            frmAddUpdateSecurityAnswer.cmbQuestions.ValueMember = "idPregunta";
            frmAddUpdateSecurityAnswer.cmbQuestions.DisplayMember = "pregunta";
        }
        private void VerifyOrigin()
        {
            if (origin == 1)
            {
                frmAddUpdateSecurityAnswer.lblTitle.Text = "Añadir Pregunta de Seguridad";
                frmAddUpdateSecurityAnswer.btnAddAnswer.Enabled = true;
                frmAddUpdateSecurityAnswer.btnUpdateAnswer.Enabled = false;
                frmAddUpdateSecurityAnswer.cmbQuestions.Enabled = true;
            }
            else
            {
                DAOSettings dao = new DAOSettings();
                dao.AnswerID = answerID;
                frmAddUpdateSecurityAnswer.lblTitle.Text = "Actualizar Pregunta de Seguridad";
                frmAddUpdateSecurityAnswer.btnAddAnswer.Enabled = false;
                frmAddUpdateSecurityAnswer.btnUpdateAnswer.Enabled = true;
                frmAddUpdateSecurityAnswer.cmbQuestions.Enabled = false;
            }
        }
    }
}
