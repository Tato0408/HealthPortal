using CustomControls;
using HealthPortal.Helper;
using HealthPortal.Model.DAO;
using HealthPortal.Properties;
using HealthPortal.View.FirstUsage;
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
    internal class ControllerAdminIntervention
    {
        FrmAdminIntervention frmAdminIntervention;
        string userUsername;
        private Dictionary<string, Tuple<Bitmap, Bitmap>> imageMapping;
        public ControllerAdminIntervention(FrmAdminIntervention view, string username)
        {
            frmAdminIntervention = view;
            imageMapping = new Dictionary<string, Tuple<Bitmap, Bitmap>>()
            {
                { "btnShowPassword", Tuple.Create(Resources.show, Resources.hoverShow) },
                { "btnHidePassword", Tuple.Create(Resources.hide, Resources.hoverHide) },
                { "btnExit", Tuple.Create(Resources.quit, Resources.hoverQuit) }
            };
            userUsername = username;
            frmAdminIntervention.Load += new EventHandler(ShowPassword);
            frmAdminIntervention.btnConfirmPasswordChange.Click += new EventHandler(AttemptPasswordChangeConfirmation);
            frmAdminIntervention.txtUsername.Enter += new EventHandler(EnterTextBox);
            frmAdminIntervention.txtPassword.Enter += new EventHandler(EnterTextBox);
            frmAdminIntervention.txtUsername.Leave += new EventHandler(LeaveTextBox);
            frmAdminIntervention.txtPassword.Leave += new EventHandler(LeaveTextBox);
            frmAdminIntervention.btnShowPassword.MouseEnter += new EventHandler(MouseEnterPictureButton);
            frmAdminIntervention.btnHidePassword.MouseEnter += new EventHandler(MouseEnterPictureButton);
            frmAdminIntervention.btnExit.MouseEnter += new EventHandler(MouseEnterPictureButton);
            frmAdminIntervention.btnShowPassword.MouseLeave += new EventHandler(MouseLeavePictureButton);
            frmAdminIntervention.btnHidePassword.MouseLeave += new EventHandler(MouseLeavePictureButton);
            frmAdminIntervention.btnExit.MouseLeave += new EventHandler(MouseLeavePictureButton);
            frmAdminIntervention.btnConfirmPasswordChange.MouseEnter += new EventHandler(MouseEnterTextButton);
            frmAdminIntervention.btnConfirmPasswordChange.MouseLeave += new EventHandler(MouseLeaveTextButton);
            frmAdminIntervention.btnExit.Click += new EventHandler(CloseForm);
            frmAdminIntervention.btnHidePassword.Click += new EventHandler(ShowPassword);
            frmAdminIntervention.btnShowPassword.Click += new EventHandler(HidePassword);
            frmAdminIntervention.txtUsername.KeyPress += new KeyPressEventHandler(CommonMethods.TextBoxKeyPress);
            frmAdminIntervention.txtPassword.KeyPress += new KeyPressEventHandler(CommonMethods.TextBoxKeyPress);
            CommonMethods.EnableFormDrag(frmAdminIntervention, frmAdminIntervention);
        }
        private void CloseForm(object sender, EventArgs e)
        {
            frmAdminIntervention.Hide();
            frmAdminIntervention.Dispose();
        }
        private void ShowPassword(object sender, EventArgs e)
        {
            frmAdminIntervention.txtPassword.PasswordChar = false;
            frmAdminIntervention.btnHidePassword.Visible = false;
            frmAdminIntervention.btnShowPassword.Visible = true;
        }
        private void HidePassword(object sender, EventArgs e)
        {
            if (!frmAdminIntervention.txtPassword.Texts.Trim().Equals("Contraseña"))
            {
                frmAdminIntervention.txtPassword.PasswordChar = true;
                frmAdminIntervention.btnShowPassword.Visible = false;
                frmAdminIntervention.btnHidePassword.Visible = true;
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
        private void AttemptPasswordChangeConfirmation(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(frmAdminIntervention.txtUsername.Texts.Trim()) || !string.IsNullOrEmpty(frmAdminIntervention.txtPassword.Texts.Trim()) || frmAdminIntervention.txtUsername.Texts.Trim() == "Usuario" || frmAdminIntervention.txtPassword.Texts.Trim() == "Contraseña")
            {
                DAOPasswordManagement dao = new DAOPasswordManagement();
                dao.Username = frmAdminIntervention.txtUsername.Texts.Trim();
                dao.Password = CommonMethods.ComputeSha256Hash(frmAdminIntervention.txtPassword.Texts.Trim());
                if (dao.VerifyCredentials())
                {
                    string temporaryPassword = CommonMethods.GenerateRandomPassword(8);
                    dao.Username = CurrentUserData.Username;
                    CommonMethods.SendRecoveryEmail(temporaryPassword, dao.VerifyEmail());
                    dao.Username = userUsername;
                    dao.Password = CommonMethods.ComputeSha256Hash(temporaryPassword);
                    if (dao.TemporaryPasswordAssignation())
                    {
                        MessageBox.Show("Contraseña cambiada con éxito.", "Proceso finalizado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        frmAdminIntervention.Dispose();
                    }
                }
                else
                {
                    MessageBox.Show("Los datos ingresados no son correctos.", "Proceso finalizado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private string GetPlaceholderText(CustomTextBox txt)
        {
            if (txt == frmAdminIntervention.txtUsername) return "Usuario";
            if (txt == frmAdminIntervention.txtPassword) return "Contraseña";
            return string.Empty;
        }
    }
}