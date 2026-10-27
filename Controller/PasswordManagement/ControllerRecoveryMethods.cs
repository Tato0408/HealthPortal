using HealthPortal.Helper;
using HealthPortal.Model.DAO;
using HealthPortal.Properties;
using HealthPortal.View.Login;
using HealthPortal.View.PasswordManagement;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HealthPortal.Controller.PasswordManagement
{
    internal class ControllerRecoveryMethods
    {
        FrmRecoveryMethods frmRecoveryMethods;
        private Dictionary<string, Tuple<Bitmap, Bitmap>> imageMapping;
        string username;
        public ControllerRecoveryMethods(FrmRecoveryMethods view, string username)
        {
            frmRecoveryMethods = view;
            this.username = username;
            imageMapping = new Dictionary<string, Tuple<Bitmap, Bitmap>>()
            {
                { "btnEmailRecoveryMethod", Tuple.Create(Resources.emailRecovery, Resources.hoverEmailRecovery) },
                { "btnSecurityQuestions", Tuple.Create(Resources.securityQuestions, Resources.hoverSecurityQuestions) },
                { "btnAdminIntervention", Tuple.Create(Resources.adminIntervention, Resources.hoverAdminIntervention) },
                { "btnExit", Tuple.Create(Resources.quit, Resources.hoverQuit) }
            };

            CommonMethods.EnableFormDrag(frmRecoveryMethods, frmRecoveryMethods);
            CheckSecurityQuestions();

            frmRecoveryMethods.btnExit.Click += new EventHandler(GoBackToLogin);

            frmRecoveryMethods.btnEmailRecoveryMethod.MouseEnter += new EventHandler(MouseEnterPictureButton);
            frmRecoveryMethods.btnSecurityQuestions.MouseEnter += new EventHandler(MouseEnterPictureButton);
            frmRecoveryMethods.btnAdminIntervention.MouseEnter += new EventHandler(MouseEnterPictureButton);
            frmRecoveryMethods.btnExit.MouseEnter += new EventHandler(MouseEnterPictureButton);

            frmRecoveryMethods.btnEmailRecoveryMethod.MouseLeave += new EventHandler(MouseLeavePictureButton);
            frmRecoveryMethods.btnSecurityQuestions.MouseLeave += new EventHandler(MouseLeavePictureButton);
            frmRecoveryMethods.btnAdminIntervention.MouseLeave += new EventHandler(MouseLeavePictureButton);
            frmRecoveryMethods.btnExit.MouseLeave += new EventHandler(MouseLeavePictureButton);

            frmRecoveryMethods.btnEmailRecoveryMethod.Click += new EventHandler(EmailPasswordRecovery);
            frmRecoveryMethods.btnAdminIntervention.Click += new EventHandler(AdminInterventionRecovery);
            frmRecoveryMethods.btnSecurityQuestions.Click += new EventHandler(SecurityQuestionsRecovery);
        }
        private void CheckSecurityQuestions()
        {
            DAOPasswordManagement dao = new DAOPasswordManagement();
            if (dao.AmountOfSecurityQuestions() >= 1)
            {
                frmRecoveryMethods.btnSecurityQuestions.Enabled = true;
            }
            else
            {
                frmRecoveryMethods.btnSecurityQuestions.Enabled = false;
            }
        }
        private void GoBackToLogin(object sender, EventArgs e)
        {
            FrmLogin frmLogin = new FrmLogin();
            frmRecoveryMethods.Hide();
            frmLogin.Show();
            frmRecoveryMethods.Dispose();
        }
        private void MouseEnterPictureButton(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn != null && imageMapping.ContainsKey(btn.Name))
            {
                btn.Image = imageMapping[btn.Name].Item2;
                if (btn != frmRecoveryMethods.btnExit) btn.BackColor = Color.FromArgb(31, 43, 91);
            }
        }
        private void MouseLeavePictureButton(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn != null && imageMapping.ContainsKey(btn.Name))
            {
                btn.Image = imageMapping[btn.Name].Item1;
                if (btn != frmRecoveryMethods.btnExit) btn.BackColor = Color.FromArgb(142, 202, 230);
            }
        }
        private void EmailPasswordRecovery(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Seguro que desea utilizar la recuperación por correo electrónico? Le será enviado un correo conteniendo una contraseña temporal que deberá usar para iniciar sesión la próxima vez.", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                DAOPasswordManagement dao = new DAOPasswordManagement();
                string temporaryPassword = CommonMethods.GenerateRandomPassword(8);
                dao.Password = CommonMethods.ComputeSha256Hash(temporaryPassword);
                dao.Username = username;
                dao.TemporaryPasswordAssignation();
                CommonMethods.SendRecoveryEmail(temporaryPassword, dao.VerifyEmail());
            }
        }
        private void AdminInterventionRecovery(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Seguro que desea utilizar la recuperación por intervención de administrador? Necesitará que un administrador ingrese sus credenciales para confirmar el cambio de contraseña.", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                FrmAdminIntervention frmAdminIntervention = new FrmAdminIntervention(username);
                frmAdminIntervention.ShowDialog();
            }
        }
        private void SecurityQuestionsRecovery(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Seguro que desea utilizar la recuperación por preguntas de seguridad?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                FrmSecurityQuestions frmSecurityQuestions = new FrmSecurityQuestions(username);
                frmSecurityQuestions.ShowDialog();
            }
        }
    }
}