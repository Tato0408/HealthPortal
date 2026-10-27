using HealthPortal.View.Login;
using HealthPortal.View.PasswordManagement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;
using HealthPortal.Model.DAO;
using HealthPortal.Model;
using HealthPortal.Helper;
using HealthPortal.View.Dashboard;
using System.Windows.Forms;
using System.Drawing;
using HealthPortal.Properties;
using CustomControls;

namespace HealthPortal.Controller.Login
{
    internal class ControllerLogin
    {
        FrmLogin frmLogin;
        bool acceptAutomaticLogin = true;
        private Dictionary<string, Tuple<Bitmap, Bitmap>> imageMapping;
        public ControllerLogin(FrmLogin view)
        {
            frmLogin = view;

            imageMapping = new Dictionary<string, Tuple<Bitmap, Bitmap>>()
            {
                { "btnShowPassword", Tuple.Create(Resources.show, Resources.hoverShow) },
                { "btnHidePassword", Tuple.Create(Resources.hide, Resources.hoverHide) },
                { "btnExit", Tuple.Create(Resources.quit, Resources.hoverQuit) },
                { "btnTestConnection", Tuple.Create(Resources.wifi, Resources.hoverWifi) }
            };

            CommonMethods.EnableFormDrag(frmLogin, frmLogin);

            frmLogin.Load += new EventHandler(ShowPassword);

            frmLogin.txtUsername.Enter += new EventHandler(ExistingToken);

            frmLogin.txtPassword.Enter += new EventHandler(EnterTextBox);
            frmLogin.txtUsername.Enter += new EventHandler(EnterTextBox);

            frmLogin.txtUsername.Leave += new EventHandler(LeaveTextBox);
            frmLogin.txtPassword.Leave += new EventHandler(LeaveTextBox);

            frmLogin.txtUsername.KeyPress += new KeyPressEventHandler(CommonMethods.TextBoxKeyPress);
            frmLogin.txtPassword.KeyPress += new KeyPressEventHandler(CommonMethods.TextBoxKeyPress);

            frmLogin.txtUsername.KeyDown += new KeyEventHandler(CommonMethods.TextBoxKeyDown);
            frmLogin.txtPassword.KeyDown += new KeyEventHandler(CommonMethods.TextBoxKeyDown);

            frmLogin.btnTestConnection.Click += new EventHandler(TestConnection);

            frmLogin.btnExit.Click += new EventHandler(ExitApplication);

            frmLogin.btnLogin.Click += new EventHandler(AttemptLogin);

            frmLogin.btnHidePassword.Click += new EventHandler(ShowPassword);
            frmLogin.btnShowPassword.Click += new EventHandler(HidePassword);

            frmLogin.llbForgotPassword.Click += new EventHandler(OpenPasswordRecoveryForm);

            frmLogin.btnExit.MouseEnter += new EventHandler(MouseEnterPictureButton);
            frmLogin.btnHidePassword.MouseEnter += new EventHandler(MouseEnterPictureButton);
            frmLogin.btnShowPassword.MouseEnter += new EventHandler(MouseEnterPictureButton);
            frmLogin.btnTestConnection.MouseEnter += new EventHandler(MouseEnterPictureButton);

            frmLogin.btnExit.MouseLeave += new EventHandler(MouseLeavePictureButton);
            frmLogin.btnHidePassword.MouseLeave += new EventHandler(MouseLeavePictureButton);
            frmLogin.btnShowPassword.MouseLeave += new EventHandler(MouseLeavePictureButton);
            frmLogin.btnTestConnection.MouseLeave += new EventHandler(MouseLeavePictureButton);

            frmLogin.btnLogin.MouseEnter += new EventHandler(MouseEnterTextButton);
            frmLogin.btnLogin.MouseLeave += new EventHandler(MouseLeaveTextButton);
        }
        private async void ExistingToken(object sender, EventArgs e)
        {
            await Task.Delay(250);
            DAOLogin dao = new DAOLogin();
            dao.Token = GetStoredToken();
            if (!string.IsNullOrEmpty(dao.Token))
            {
                dao.Username = dao.ValidateToken();
                if (dao.Username != null && acceptAutomaticLogin)
                {
                    if (MessageBox.Show($"Se encontró información de inicio de sesión en esta computadora. ¿Desea iniciar sesión como '{dao.Username}'?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        dao.TokenLogin();
                        frmLogin.Hide();
                        if (CurrentUserData.TemporaryPassword)
                        {
                            FrmPasswordChange frmPasswordChange = new FrmPasswordChange(1);
                            frmPasswordChange.Show();
                        }
                        else
                        {
                            if (frmLogin.rdoRememberMe.Checked == true) SaveTokenLocally();
                            FrmDashboard frmDashboard = new FrmDashboard();
                            frmDashboard.Show();
                        }
                    }
                    else
                    {
                        acceptAutomaticLogin = false;
                    }
                }
            }
        }
        private string GetStoredToken()
        {
            return Properties.Settings.Default.RememberMeToken;
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
        private void TestConnection(object sender, EventArgs e)
        {
            if (dbContext.getConnection() == null)
            {
                MessageBox.Show("No fue posible realizar la conexión al servidor y/o la base de datos.", "Conexión fallida", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("La conexión al servidor y la base de datos se ha ejecutado correctamente.", "Conexión exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void ExitApplication(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void AttemptLogin(object sender, EventArgs e)
        {
            DAOLogin dao = new DAOLogin();
            dao.Username = frmLogin.txtUsername.Texts.Trim();
            dao.Password = CommonMethods.ComputeSha256Hash(frmLogin.txtPassword.Texts.Trim());
            if (dao.EvaluateLogin() == true && CurrentUserData.Username.Equals(dao.Username))
            {
                frmLogin.Hide();
                if (CurrentUserData.TemporaryPassword)
                {
                    FrmPasswordChange frmPasswordChange = new FrmPasswordChange(1);
                    frmPasswordChange.Show();
                }
                else
                {
                    if (frmLogin.rdoRememberMe.Checked == true) SaveTokenLocally();
                    FrmDashboard frmDashboard = new FrmDashboard();
                    frmDashboard.Show();
                }
            }
            else
            {
                MessageBox.Show("Datos incorrectos", "Error al iniciar sesión", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void ShowPassword(object sender, EventArgs e)
        {
            frmLogin.txtPassword.PasswordChar = false;
            frmLogin.btnHidePassword.Visible = false;
            frmLogin.btnShowPassword.Visible = true;
        }
        private void HidePassword(object sender, EventArgs e)
        {
            if (!frmLogin.txtPassword.Texts.Trim().Equals("Contraseña"))
            {
                frmLogin.txtPassword.PasswordChar = true;
                frmLogin.btnShowPassword.Visible = false;
                frmLogin.btnHidePassword.Visible = true;
            }
        }
        private void OpenPasswordRecoveryForm(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(frmLogin.txtUsername.Texts.Trim()))
            {
                DAOLogin dao = new DAOLogin();
                dao.Username = frmLogin.txtUsername.Texts.Trim();
                if (dao.ConfirmUser())
                {
                    FrmRecoveryMethods frmRecoveryMethods = new FrmRecoveryMethods(frmLogin.txtUsername.Texts.Trim());
                    frmLogin.Hide();
                    frmRecoveryMethods.Show();
                }
                else
                {
                    MessageBox.Show("El usuario ingresado no existe. Verifique la información proporcionada e intente de nuevo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Para poder utilizar los métodos de recuperación disponibles, por favor ingrese su usuario.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private string GetPlaceholderText(CustomTextBox txt)
        {
            if (txt == frmLogin.txtUsername) return "Usuario";
            if (txt == frmLogin.txtPassword) return "Contraseña";
            return string.Empty;
        }
        private void SaveTokenLocally()
        {
            Properties.Settings.Default.RememberMeToken = CurrentUserData.Token;
            Properties.Settings.Default.Save();
        }
    }
}