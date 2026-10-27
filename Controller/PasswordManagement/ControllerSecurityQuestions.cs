using CustomControls;
using HealthPortal.Helper;
using HealthPortal.Model.DAO;
using HealthPortal.Properties;
using HealthPortal.View.PasswordManagement;
using HealthPortal.View.Settings;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HealthPortal.Controller.PasswordManagement
{
    internal class ControllerSecurityQuestions
    {
        FrmSecurityQuestions frmSecurityQuestions;
        string username;
        public ControllerSecurityQuestions(FrmSecurityQuestions view, string username)
        {
            frmSecurityQuestions = view;
            this.username = username;
            frmSecurityQuestions.Load += new EventHandler(InitialLoad);

            frmSecurityQuestions.txtAnswer.Enter += new EventHandler(EnterTxtAnswer);
            frmSecurityQuestions.txtAnswer.Leave += new EventHandler(LeaveTxtAnswer);

            frmSecurityQuestions.btnExit.MouseEnter += new EventHandler(MouseEnterControl);
            frmSecurityQuestions.btnExit.MouseLeave += new EventHandler(MouseLeaveControl);

            frmSecurityQuestions.btnConfirmAnswer.MouseEnter += new EventHandler(MouseEnterButton);
            frmSecurityQuestions.btnConfirmAnswer.MouseLeave += new EventHandler(MouseLeaveButton);

            frmSecurityQuestions.btnConfirmAnswer.Click += new EventHandler(VerifyAnswer);

            frmSecurityQuestions.btnExit.Click += new EventHandler(CloseForm);
            frmSecurityQuestions.txtAnswer.KeyPress += new KeyPressEventHandler(CommonMethods.TextBoxKeyPress);

            CommonMethods.EnableFormDrag(frmSecurityQuestions, frmSecurityQuestions);
        }
        private void VerifyAnswer(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(frmSecurityQuestions.txtAnswer.Texts.Trim()))
            {
                DAOPasswordManagement dao = new DAOPasswordManagement();
                dao.Username = username;
                dao.QuestionID = (int)frmSecurityQuestions.cmbQuestions.SelectedValue;
                dao.Answer = CommonMethods.ComputeSha256Hash(frmSecurityQuestions.txtAnswer.Texts.Trim());
                if (dao.VerifyAnswer())
                {
                    string temporaryPassword = CommonMethods.GenerateRandomPassword(8);
                    CommonMethods.SendRecoveryEmail(temporaryPassword, dao.VerifyEmail());
                    dao.Username = username;
                    dao.Password = CommonMethods.ComputeSha256Hash(temporaryPassword);
                    if (dao.TemporaryPasswordAssignation())
                    {
                        MessageBox.Show("Contraseña cambiada con éxito.", "Proceso finalizado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        frmSecurityQuestions.Dispose();
                    }
                    else
                    {

                        MessageBox.Show("La contraseña no pudo ser actualizada.", "Proceso finalizado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                else
                {
                    MessageBox.Show("Respuesta incorrecta.", "Proceso finalizado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }
        private void InitialLoad(object sender, EventArgs e)
        {
            DAOPasswordManagement dao = new DAOPasswordManagement();
            dao.Username = username;
            DataSet ds = dao.RetrieveUserSecurityQuestions();
            frmSecurityQuestions.cmbQuestions.DataSource = ds.Tables["tbPreguntas"];
            frmSecurityQuestions.cmbQuestions.ValueMember = "idPregunta";
            frmSecurityQuestions.cmbQuestions.DisplayMember = "pregunta";
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
            if (frmSecurityQuestions.txtAnswer.Texts.Trim().Equals("Respuesta"))
            {
                frmSecurityQuestions.txtAnswer.Clear();
                frmSecurityQuestions.txtAnswer.ForeColor = Color.FromArgb(31, 43, 91);
            }
        }
        private void LeaveTxtAnswer(object sender, EventArgs e)
        {
            if (frmSecurityQuestions.txtAnswer.Texts.Trim().Equals(""))
            {
                frmSecurityQuestions.txtAnswer.Texts = "Respuesta";
                frmSecurityQuestions.txtAnswer.ForeColor = Color.FromArgb(142, 202, 230);
            }
        }
        private void CloseForm(object sender, EventArgs e)
        {
            frmSecurityQuestions.Dispose();
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
    }
}
