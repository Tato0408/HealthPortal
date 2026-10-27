using CustomControls;
using HealthPortal.Helper;
using HealthPortal.Model.DAO;
using HealthPortal.Properties;
using HealthPortal.View.Login;
using HealthPortal.View.Settings;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HealthPortal.Controller.Settings
{
    internal class ControllerAddUpdateSecurityQuestion
    {
        FrmAddUpdateSecurityQuestion frmAddUpdateSecurityQuestion;
        int origin;
        int securityQuestionID;
        string question;
        public ControllerAddUpdateSecurityQuestion(FrmAddUpdateSecurityQuestion view, int origin)
        {
            frmAddUpdateSecurityQuestion = view;
            this.origin = origin;

            VerifyOrigin();
            CommonMethods.EnableFormDrag(frmAddUpdateSecurityQuestion, frmAddUpdateSecurityQuestion);

            frmAddUpdateSecurityQuestion.txtQuestion.Enter += new EventHandler(EnterTxtQuestion);
            frmAddUpdateSecurityQuestion.txtQuestion.Leave += new EventHandler(LeaveTxtQuestion);

            frmAddUpdateSecurityQuestion.btnExit.MouseEnter += new EventHandler(MouseEnterControl);
            frmAddUpdateSecurityQuestion.btnExit.MouseLeave += new EventHandler(MouseLeaveControl);

            frmAddUpdateSecurityQuestion.btnAddQuestion.MouseEnter += new EventHandler(MouseEnterButton);
            frmAddUpdateSecurityQuestion.btnAddQuestion.MouseLeave += new EventHandler(MouseLeaveButton);
            frmAddUpdateSecurityQuestion.btnUpdateQuestion.MouseEnter += new EventHandler(MouseEnterButton);
            frmAddUpdateSecurityQuestion.btnUpdateQuestion.MouseLeave += new EventHandler(MouseLeaveButton);

            frmAddUpdateSecurityQuestion.btnExit.Click += new EventHandler(ExitForm);
            frmAddUpdateSecurityQuestion.btnAddQuestion.Click += new EventHandler(RegisterQuestion);

            frmAddUpdateSecurityQuestion.txtQuestion.KeyPress += new KeyPressEventHandler(CommonMethods.TextBoxKeyPress);
        }
        public ControllerAddUpdateSecurityQuestion(FrmAddUpdateSecurityQuestion view, int origin, int securityQuestionID, string question)
        {
            frmAddUpdateSecurityQuestion = view;
            this.origin = origin;
            this.securityQuestionID = securityQuestionID;
            this.question = question;

            VerifyOrigin();
            CommonMethods.EnableFormDrag(frmAddUpdateSecurityQuestion, frmAddUpdateSecurityQuestion);

            frmAddUpdateSecurityQuestion.txtQuestion.Enter += new EventHandler(EnterTxtQuestion);
            frmAddUpdateSecurityQuestion.txtQuestion.Leave += new EventHandler(LeaveTxtQuestion);

            frmAddUpdateSecurityQuestion.btnExit.MouseEnter += new EventHandler(MouseEnterControl);
            frmAddUpdateSecurityQuestion.btnExit.MouseLeave += new EventHandler(MouseLeaveControl);

            frmAddUpdateSecurityQuestion.btnAddQuestion.MouseEnter += new EventHandler(MouseEnterButton);
            frmAddUpdateSecurityQuestion.btnAddQuestion.MouseLeave += new EventHandler(MouseLeaveButton);
            frmAddUpdateSecurityQuestion.btnUpdateQuestion.MouseEnter += new EventHandler(MouseEnterButton);
            frmAddUpdateSecurityQuestion.btnUpdateQuestion.MouseLeave += new EventHandler(MouseLeaveButton);

            frmAddUpdateSecurityQuestion.btnExit.Click += new EventHandler(ExitForm);
            frmAddUpdateSecurityQuestion.btnUpdateQuestion.Click += new EventHandler(UpdateQuestion);

            frmAddUpdateSecurityQuestion.txtQuestion.KeyPress += new KeyPressEventHandler(CommonMethods.TextBoxKeyPress);
        }
        private void VerifyOrigin()
        {
            if (origin == 1)
            {
                frmAddUpdateSecurityQuestion.lblTitle.Text = "Añadir Pregunta de Seguridad";
                frmAddUpdateSecurityQuestion.btnAddQuestion.Enabled = true;
                frmAddUpdateSecurityQuestion.btnUpdateQuestion.Enabled = false;
            }
            else
            {
                DAOSettings dao = new DAOSettings();
                dao.QuestionID = securityQuestionID;
                frmAddUpdateSecurityQuestion.lblTitle.Text = "Actualizar Pregunta de Seguridad";
                frmAddUpdateSecurityQuestion.txtQuestion.Texts = dao.GetSecurityQuestion();
                frmAddUpdateSecurityQuestion.btnAddQuestion.Enabled = false;
                frmAddUpdateSecurityQuestion.btnUpdateQuestion.Enabled = true;
            }
        }
        private void UpdateQuestion(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(frmAddUpdateSecurityQuestion.txtQuestion.Texts.Trim()) || frmAddUpdateSecurityQuestion.txtQuestion.Texts.Trim() == "Pregunta")
            {
                DAOSettings dao = new DAOSettings();
                dao.QuestionID = securityQuestionID;
                dao.Question = EnsureQuestionFormat(frmAddUpdateSecurityQuestion.txtQuestion.Texts.Trim());

                if (dao.UpdateQuestion())
                {
                    MessageBox.Show("Pregunta de seguridad actualizada exitosamente.", "Proceso finalizado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                frmAddUpdateSecurityQuestion.Hide();
                frmAddUpdateSecurityQuestion.Dispose();
            }
        }
        private void RegisterQuestion(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(frmAddUpdateSecurityQuestion.txtQuestion.Texts.Trim()) || frmAddUpdateSecurityQuestion.txtQuestion.Texts.Trim() == "Pregunta")
            {
                DAOSettings dao = new DAOSettings();
                dao.Question = EnsureQuestionFormat(frmAddUpdateSecurityQuestion.txtQuestion.Texts.Trim());

                if (dao.RegisterQuestion())
                {
                    MessageBox.Show("Pregunta de seguridad registrada exitosamente.", "Proceso finalizado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                frmAddUpdateSecurityQuestion.Hide();
                frmAddUpdateSecurityQuestion.Dispose();
            }
        }
        private string EnsureQuestionFormat(string question)
        {
            if (!question.StartsWith("¿"))
            {
                question = "¿" + question;
            }
            if (!question.EndsWith("?"))
            {
                question = question + "?";
            }
            return question;
        }
        private void EnterTxtQuestion(object sender, EventArgs e)
        {
            if (frmAddUpdateSecurityQuestion.txtQuestion.Texts.Trim().Equals("Pregunta"))
            {
                frmAddUpdateSecurityQuestion.txtQuestion.Clear();
                frmAddUpdateSecurityQuestion.txtQuestion.ForeColor = Color.FromArgb(31, 43, 91);
            }
        }
        private void LeaveTxtQuestion(object sender, EventArgs e)
        {
            if (frmAddUpdateSecurityQuestion.txtQuestion.Texts.Trim().Equals(""))
            {
                frmAddUpdateSecurityQuestion.txtQuestion.Texts = "Pregunta";
                frmAddUpdateSecurityQuestion.txtQuestion.ForeColor = Color.FromArgb(142, 202, 230);
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
        private void ExitForm(object sender, EventArgs e)
        {
            frmAddUpdateSecurityQuestion.Close();
            frmAddUpdateSecurityQuestion.Dispose();
        }
    }
}
