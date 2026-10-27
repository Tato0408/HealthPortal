using HealthPortal.Helper;
using HealthPortal.Model.DAO;
using HealthPortal.View.PasswordManagement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HealthPortal.View.Login;
using System.Drawing;
using HealthPortal.Properties;
using CustomControls;

namespace HealthPortal.Controller.PasswordManagement
{
    internal class ControllerPasswordChange
    {
        FrmPasswordChange frmPasswordChange;
        readonly int procedure;
        readonly string username;
        private Dictionary<string, Tuple<Bitmap, Bitmap>> imageMapping;
        public ControllerPasswordChange(FrmPasswordChange view, int procedure)
        {
            this.procedure = procedure;

            imageMapping = new Dictionary<string, Tuple<Bitmap, Bitmap>>()
            {
                { "btnExit", Tuple.Create(Resources.quit, Resources.hoverQuit) }
            };

            frmPasswordChange = view;
            frmPasswordChange.Load += new EventHandler(VerifyProcedure);
            frmPasswordChange.btnChangePassword.Click += new EventHandler(RespectiveAction);
            frmPasswordChange.btnExit.Click += new EventHandler(CloseForm);
            CommonMethods.EnableFormDrag(frmPasswordChange, frmPasswordChange);
            frmPasswordChange.txtNewPassword.KeyPress += new KeyPressEventHandler(CommonMethods.TextBoxKeyPress);
            frmPasswordChange.txtPreviousPassword.KeyPress += new KeyPressEventHandler(CommonMethods.TextBoxKeyPress);
            frmPasswordChange.txtNewPasswordConfirmation.KeyPress += new KeyPressEventHandler(CommonMethods.TextBoxKeyPress);

            frmPasswordChange.txtNewPassword.Enter += new EventHandler(EnterTextBox);
            frmPasswordChange.txtNewPasswordConfirmation.Enter += new EventHandler(EnterTextBox);
            frmPasswordChange.txtPreviousPassword.Enter += new EventHandler(EnterTextBox);
            frmPasswordChange.txtNewPassword.Leave += new EventHandler(LeaveTextBox);
            frmPasswordChange.txtNewPasswordConfirmation.Leave += new EventHandler(LeaveTextBox);
            frmPasswordChange.txtPreviousPassword.Leave += new EventHandler(LeaveTextBox);

            frmPasswordChange.btnExit.MouseEnter += new EventHandler(MouseEnterPictureButton);
            frmPasswordChange.btnChangePassword.MouseEnter += new EventHandler(MouseEnterTextButton);

            frmPasswordChange.btnExit.MouseLeave += new EventHandler(MouseLeavePictureButton);
            frmPasswordChange.btnChangePassword.MouseLeave += new EventHandler(MouseLeaveTextButton);
        }
        public ControllerPasswordChange(FrmPasswordChange view, int procedure, string username)
        {
            this.procedure = procedure;
            this.username = username;
            frmPasswordChange = view;
            frmPasswordChange.Load += new EventHandler(VerifyProcedure);
            frmPasswordChange.btnChangePassword.Click += new EventHandler(RespectiveAction);
            frmPasswordChange.btnExit.Click += new EventHandler(CloseForm);
            CommonMethods.EnableFormDrag(frmPasswordChange, frmPasswordChange);
            frmPasswordChange.txtNewPassword.KeyPress += new KeyPressEventHandler(CommonMethods.TextBoxKeyPress);
            frmPasswordChange.txtPreviousPassword.KeyPress += new KeyPressEventHandler(CommonMethods.TextBoxKeyPress);
            frmPasswordChange.txtNewPasswordConfirmation.KeyPress += new KeyPressEventHandler(CommonMethods.TextBoxKeyPress);

            frmPasswordChange.txtNewPassword.Enter += new EventHandler(EnterTextBox);
            frmPasswordChange.txtNewPasswordConfirmation.Enter += new EventHandler(EnterTextBox);
            frmPasswordChange.txtPreviousPassword.Enter += new EventHandler(EnterTextBox);
            frmPasswordChange.txtNewPassword.Leave += new EventHandler(LeaveTextBox);
            frmPasswordChange.txtNewPasswordConfirmation.Leave += new EventHandler(LeaveTextBox);
            frmPasswordChange.txtPreviousPassword.Leave += new EventHandler(LeaveTextBox);

            frmPasswordChange.btnExit.MouseEnter += new EventHandler(MouseEnterPictureButton);
            frmPasswordChange.btnChangePassword.MouseEnter += new EventHandler(MouseEnterTextButton);

            frmPasswordChange.btnExit.MouseLeave += new EventHandler(MouseLeavePictureButton);
            frmPasswordChange.btnChangePassword.MouseLeave += new EventHandler(MouseLeaveTextButton);
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
        private void VerifyProcedure(object sender, EventArgs e)
        {
            if (procedure == 2)
            {
                frmPasswordChange.txtPreviousPassword.Enabled = false;
            }
            else
            {
                frmPasswordChange.txtPreviousPassword.Enabled = true;
            }
        }
        private void RespectiveAction(object sender, EventArgs e)
        {
            if (procedure == 1)
            {
                AttemptPasswordChange();
            }
            else
            {
                ChangeUserPassword(username);
            }
        }
        private void ChangeUserPassword(string username)
        {
            DAOUserAdministration daoUserAdministration = new DAOUserAdministration();
            if (CheckNewPassword() == true)
            {
                daoUserAdministration.Password = CommonMethods.ComputeSha256Hash(frmPasswordChange.txtNewPassword.Texts.Trim());
                daoUserAdministration.Username = username;
                if (daoUserAdministration.ReestablishUserPassword() == true)
                {
                    MessageBox.Show("Contraseña cambiada con éxito. Ha de informar al usuario del más reciente cambio. Cuando el usuario inicie sesión, también deberá de crear una nueva contraseña.", "Cambio de contraseña exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("La contraseña no pudo ser actualizada.", "Cambio de contraseña fallido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Las nuevas contraseñas ingresadas no coinciden entre sí.", "Error al cambiar contraseña", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void AttemptPasswordChange()
        {
            DAOPasswordManagement dao = new DAOPasswordManagement();
            if (VerifyPassword() == true)
            {
                if (CheckNewPassword() == true)
                {
                    dao.Username = CurrentUserData.Username;
                    dao.Password = CommonMethods.ComputeSha256Hash(frmPasswordChange.txtNewPassword.Texts.Trim());
                    if (dao.UpdatePassword() == true)
                    {
                        MessageBox.Show("Contraseña cambiada con éxito. Vuelva a iniciar sesión con su nueva contraseña.", "Cambio de contraseña exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        BackToLogin();
                    }
                    else
                    {
                        MessageBox.Show("La contraseña no pudo ser actualizada.", "Cambio de contraseña fallido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Las nuevas contraseñas ingresadas no coinciden entre sí.", "Error al cambiar contraseña", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("La contraseña ingresada no coincide con el usuario.", "Error al cambiar contraseña", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private bool VerifyPassword()
        {
            DAOPasswordManagement dao = new DAOPasswordManagement();
            dao.Username = CurrentUserData.Username;
            dao.Password = CommonMethods.ComputeSha256Hash(frmPasswordChange.txtPreviousPassword.Texts.Trim());
            return dao.VerifyCurrentUserPassword();
        }
        private bool CheckNewPassword()
        {
            if (frmPasswordChange.txtNewPassword.Texts.Trim() == frmPasswordChange.txtNewPasswordConfirmation.Texts.Trim())
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private void BackToLogin()
        {
            CommonMethods.DisposeOfCurrentUserData();
            FrmLogin frmLogin = new FrmLogin();
            frmLogin.Show();
            frmPasswordChange.Dispose();
        }
        private void CloseForm(object sender, EventArgs e)
        {
            BackToLogin();
        }
        private string GetPlaceholderText(CustomTextBox txt)
        {
            if (txt == frmPasswordChange.txtNewPassword) return "Ingrese su contraseña nueva";
            if (txt == frmPasswordChange.txtNewPasswordConfirmation) return "Confirme su contraseña nueva";
            if (txt == frmPasswordChange.txtPreviousPassword) return "Ingrese su contraseña previa";
            return string.Empty;
        }
    }
}
