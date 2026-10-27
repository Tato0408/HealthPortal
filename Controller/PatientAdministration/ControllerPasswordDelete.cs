using CustomControls;
using HealthPortal.Controller.PatientAdministration;
using HealthPortal.Helper;
using HealthPortal.Model.DAO;
using HealthPortal.Properties;
using HealthPortal.View.FirstUsage;
using HealthPortal.View.Login;
using HealthPortal.View.PasswordManagement;
using HealthPortal.View.PatientAdministration;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HealthPortal.Controller.PatientAdministration
{
    internal class ControllerPasswordDelete
    {
        FrmPasswordDelete frmPasswordDelete;
        string userUsername;
        public bool Delete = false;
        private Dictionary<string, Tuple<Bitmap, Bitmap>> imageMapping;

        public ControllerPasswordDelete() 
        {
            frmPasswordDelete.Load += new EventHandler(ShowPassword);
            frmPasswordDelete.btnConfirmPasswordChange.Click += new EventHandler(AttemptPasswordChangeConfirmation);
            frmPasswordDelete.txtUsername.Enter += new EventHandler(EnterTextBox);
            frmPasswordDelete.txtPassword.Enter += new EventHandler(EnterTextBox);
            frmPasswordDelete.txtUsername.Leave += new EventHandler(LeaveTextBox);
            frmPasswordDelete.txtPassword.Leave += new EventHandler(LeaveTextBox);
            frmPasswordDelete.btnShowPassword.MouseEnter += new EventHandler(MouseEnterPictureButton);
            frmPasswordDelete.btnHidePassword.MouseEnter += new EventHandler(MouseEnterPictureButton);
            frmPasswordDelete.btnExit.MouseEnter += new EventHandler(MouseEnterPictureButton);
            frmPasswordDelete.btnShowPassword.MouseLeave += new EventHandler(MouseLeavePictureButton);
            frmPasswordDelete.btnHidePassword.MouseLeave += new EventHandler(MouseLeavePictureButton);
            frmPasswordDelete.btnExit.MouseLeave += new EventHandler(MouseLeavePictureButton);
            frmPasswordDelete.btnConfirmPasswordChange.MouseEnter += new EventHandler(MouseEnterTextButton);
            frmPasswordDelete.btnConfirmPasswordChange.MouseLeave += new EventHandler(MouseLeaveTextButton);
            frmPasswordDelete.btnExit.Click += new EventHandler(CloseForm);
            frmPasswordDelete.btnHidePassword.Click += new EventHandler(ShowPassword);
            frmPasswordDelete.btnShowPassword.Click += new EventHandler(HidePassword);
            frmPasswordDelete.txtUsername.KeyPress += new KeyPressEventHandler(CommonMethods.TextBoxKeyPress);
            frmPasswordDelete.txtPassword.KeyPress += new KeyPressEventHandler(CommonMethods.TextBoxKeyPress);
            CommonMethods.EnableFormDrag(frmPasswordDelete, frmPasswordDelete);
        }
        public ControllerPasswordDelete(FrmPasswordDelete view, string username)
        {
            frmPasswordDelete= view;
            imageMapping = new Dictionary<string, Tuple<Bitmap, Bitmap>>()
            {
                { "btnShowPassword", Tuple.Create(Resources.show, Resources.hoverShow) },
                { "btnHidePassword", Tuple.Create(Resources.hide, Resources.hoverHide) },
                { "btnExit", Tuple.Create(Resources.quit, Resources.hoverQuit) }
            };
            userUsername = username;
            frmPasswordDelete.Load += new EventHandler(ShowPassword);
            frmPasswordDelete.btnConfirmPasswordChange.Click += new EventHandler(AttemptPasswordChangeConfirmation);
            frmPasswordDelete.txtUsername.Enter += new EventHandler(EnterTextBox);
            frmPasswordDelete.txtPassword.Enter += new EventHandler(EnterTextBox);
            frmPasswordDelete.txtUsername.Leave += new EventHandler(LeaveTextBox);
            frmPasswordDelete.txtPassword.Leave += new EventHandler(LeaveTextBox);
            frmPasswordDelete.btnShowPassword.MouseEnter += new EventHandler(MouseEnterPictureButton);
            frmPasswordDelete.btnHidePassword.MouseEnter += new EventHandler(MouseEnterPictureButton);
            frmPasswordDelete.btnExit.MouseEnter += new EventHandler(MouseEnterPictureButton);
            frmPasswordDelete.btnShowPassword.MouseLeave += new EventHandler(MouseLeavePictureButton);
            frmPasswordDelete.btnHidePassword.MouseLeave += new EventHandler(MouseLeavePictureButton);
            frmPasswordDelete.btnExit.MouseLeave += new EventHandler(MouseLeavePictureButton);
            frmPasswordDelete.btnConfirmPasswordChange.MouseEnter += new EventHandler(MouseEnterTextButton);
            frmPasswordDelete.btnConfirmPasswordChange.MouseLeave += new EventHandler(MouseLeaveTextButton);
            frmPasswordDelete.btnExit.Click += new EventHandler(CloseForm);
            frmPasswordDelete.btnHidePassword.Click += new EventHandler(ShowPassword);
            frmPasswordDelete.btnShowPassword.Click += new EventHandler(HidePassword);
            frmPasswordDelete.txtUsername.KeyPress += new KeyPressEventHandler(CommonMethods.TextBoxKeyPress);
            frmPasswordDelete.txtPassword.KeyPress += new KeyPressEventHandler(CommonMethods.TextBoxKeyPress);
            CommonMethods.EnableFormDrag(frmPasswordDelete, frmPasswordDelete);
        }
        private void CloseForm(object sender, EventArgs e)
        {
            frmPasswordDelete.Hide();
            frmPasswordDelete.Dispose();
        }
        private void ShowPassword(object sender, EventArgs e)
        {
            frmPasswordDelete.txtPassword.PasswordChar = false;
            frmPasswordDelete.btnHidePassword.Visible = false;
            frmPasswordDelete.btnShowPassword.Visible = true;
        }
        private void HidePassword(object sender, EventArgs e)
        {
            if (!frmPasswordDelete.txtPassword.Texts.Trim().Equals("Contraseña"))
            {
                frmPasswordDelete.txtPassword.PasswordChar = true;
                frmPasswordDelete.btnShowPassword.Visible = false;
                frmPasswordDelete.btnHidePassword.Visible = true;
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

        public void DeleteConfirmation() 
        {
            if (!string.IsNullOrEmpty(frmPasswordDelete.txtUsername.Texts.Trim()) || !string.IsNullOrEmpty(frmPasswordDelete.txtPassword.Texts.Trim()) || frmPasswordDelete.txtUsername.Texts.Trim() == "Usuario" || frmPasswordDelete.txtPassword.Texts.Trim() == "Contraseña")
            {
                DAOPasswordManagement dao = new DAOPasswordManagement();
                dao.Username = frmPasswordDelete.txtUsername.Texts.Trim();
                dao.Password = CommonMethods.ComputeSha256Hash(frmPasswordDelete.txtPassword.Texts.Trim());
                if (dao.VerifyCredentials())
                {
                    MessageBox.Show("Los datos ingresados son correctos.", "Proceso finalizado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    frmPasswordDelete.Dispose();
                    Delete = true;

                }
                else
                {
                    MessageBox.Show("Los datos ingresados no son correctos.", "Proceso finalizado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Delete = false;
                }
            }
        }

        public void AttemptPasswordChangeConfirmation(object sender, EventArgs e)
        {
           DeleteConfirmation();
        }
        private string GetPlaceholderText(CustomTextBox txt)
        {
            if (txt == frmPasswordDelete.txtUsername) return "Usuario";
            if (txt == frmPasswordDelete.txtPassword) return "Contraseña";
            return string.Empty;
        }
    }
}