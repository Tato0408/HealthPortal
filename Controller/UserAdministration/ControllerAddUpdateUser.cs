using HealthPortal.View.UserAdministration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HealthPortal.Controller;
using HealthPortal.Model.DAO;
using System.Data;
using System.Windows.Forms;
using System.Net.Mail;
using HealthPortal.Helper;
using HealthPortal.Model.DTO;
using HealthPortal.View.FirstUsage;
using CustomControls;
using System.Drawing;
using HealthPortal.Properties;

namespace HealthPortal.Controller.UserAdministration
{
    internal class ControllerAddUpdateUser
    {
        FrmAddUpdateUser frmAddUpdateUser;
        private Dictionary<string, Tuple<Bitmap, Bitmap>> imageMapping;
        private int procedure;
        private string role;
        private string personID;
        public ControllerAddUpdateUser(FrmAddUpdateUser view, int procedure)
        {
            frmAddUpdateUser = view;
            imageMapping = new Dictionary<string, Tuple<Bitmap, Bitmap>>()
            {
                { "btnExit", Tuple.Create(Resources.quit, Resources.hoverQuit) }
            };
            this.procedure = procedure;
            VerifyProcedure();
            frmAddUpdateUser.Load += new EventHandler(LoadComboBox);
            frmAddUpdateUser.btnAddNewUser.Click += new EventHandler(NewUser);

            // Extra
            CommonMethods.EnableFormDrag(frmAddUpdateUser, frmAddUpdateUser);

            frmAddUpdateUser.btnExit.MouseEnter += new EventHandler(MouseEnterPictureButton);
            frmAddUpdateUser.btnExit.MouseLeave += new EventHandler(MouseLeavePictureButton);
            frmAddUpdateUser.btnExit.Click += new EventHandler(CloseForm);

            frmAddUpdateUser.txtUserAdministrationEmail.KeyPress += new KeyPressEventHandler(CommonMethods.TextBoxKeyPress);
            frmAddUpdateUser.txtUserAdministrationId.KeyPress += new KeyPressEventHandler(CommonMethods.TextBoxKeyPress);
            frmAddUpdateUser.txtUserAdministrationLastName.KeyPress += new KeyPressEventHandler(CommonMethods.TextBoxKeyPress);
            frmAddUpdateUser.txtUserAdministrationName.KeyPress += new KeyPressEventHandler(CommonMethods.TextBoxKeyPress);
            frmAddUpdateUser.txtUserAdministrationPhoneNumber.KeyPress += new KeyPressEventHandler(CommonMethods.TextBoxKeyPress);
            frmAddUpdateUser.txtUserAdministrationUsername.KeyPress += new KeyPressEventHandler(CommonMethods.TextBoxKeyPress);

            frmAddUpdateUser.txtUserAdministrationUsername.Enter += new EventHandler(EnterTextBox);
            frmAddUpdateUser.txtUserAdministrationEmail.Enter += new EventHandler(EnterTextBox);
            frmAddUpdateUser.txtUserAdministrationLastName.Enter += new EventHandler(EnterTextBox);
            frmAddUpdateUser.txtUserAdministrationName.Enter += new EventHandler(EnterTextBox);
            frmAddUpdateUser.txtUserAdministrationPhoneNumber.Enter += new EventHandler(EnterTextBox);

            frmAddUpdateUser.txtUserAdministrationUsername.Leave += new EventHandler(LeaveTextBox);
            frmAddUpdateUser.txtUserAdministrationEmail.Leave += new EventHandler(LeaveTextBox);
            frmAddUpdateUser.txtUserAdministrationLastName.Leave += new EventHandler(LeaveTextBox);
            frmAddUpdateUser.txtUserAdministrationName.Leave += new EventHandler(LeaveTextBox);
            frmAddUpdateUser.txtUserAdministrationPhoneNumber.Leave += new EventHandler(LeaveTextBox);

            frmAddUpdateUser.txtUserAdministrationPhoneNumber.TextChangedEvent += new EventHandler(TextBoxTextChanged);
        }
        public ControllerAddUpdateUser(FrmAddUpdateUser view, int procedure, int personID, string firstName, string lastName, string email, string phoneNumber, string username, string role)
        {
            frmAddUpdateUser = view;
            imageMapping = new Dictionary<string, Tuple<Bitmap, Bitmap>>()
            {
                { "btnExit", Tuple.Create(Resources.quit, Resources.hoverQuit) }
            };
            this.procedure = procedure;
            this.role = role;
            this.personID = personID.ToString();
            VerifyProcedure();
            frmAddUpdateUser.Load += new EventHandler(LoadComboBox);
            LoadValues(personID, firstName, lastName, email, phoneNumber, username);
            frmAddUpdateUser.btnUpdateUser.Click += new EventHandler(UpdateUserInfo);
            frmAddUpdateUser.txtUserAdministrationPhoneNumber.TextChangedEvent += new EventHandler(TextBoxTextChanged);

            // Extra
            CommonMethods.EnableFormDrag(frmAddUpdateUser, frmAddUpdateUser);

            frmAddUpdateUser.btnExit.MouseEnter += new EventHandler(MouseEnterPictureButton);
            frmAddUpdateUser.btnExit.MouseLeave += new EventHandler(MouseLeavePictureButton);
            frmAddUpdateUser.btnExit.Click += new EventHandler(CloseForm);

            frmAddUpdateUser.txtUserAdministrationEmail.KeyPress += new KeyPressEventHandler(CommonMethods.TextBoxKeyPress);
            frmAddUpdateUser.txtUserAdministrationId.KeyPress += new KeyPressEventHandler(CommonMethods.TextBoxKeyPress);
            frmAddUpdateUser.txtUserAdministrationLastName.KeyPress += new KeyPressEventHandler(CommonMethods.TextBoxKeyPress);
            frmAddUpdateUser.txtUserAdministrationName.KeyPress += new KeyPressEventHandler(CommonMethods.TextBoxKeyPress);
            frmAddUpdateUser.txtUserAdministrationPhoneNumber.KeyPress += new KeyPressEventHandler(CommonMethods.TextBoxKeyPress);
            frmAddUpdateUser.txtUserAdministrationUsername.KeyPress += new KeyPressEventHandler(CommonMethods.TextBoxKeyPress);

            frmAddUpdateUser.txtUserAdministrationUsername.Enter += new EventHandler(EnterTextBox);
            frmAddUpdateUser.txtUserAdministrationEmail.Enter += new EventHandler(EnterTextBox);
            frmAddUpdateUser.txtUserAdministrationLastName.Enter += new EventHandler(EnterTextBox);
            frmAddUpdateUser.txtUserAdministrationName.Enter += new EventHandler(EnterTextBox);
            frmAddUpdateUser.txtUserAdministrationPhoneNumber.Enter += new EventHandler(EnterTextBox);

            frmAddUpdateUser.txtUserAdministrationUsername.Leave += new EventHandler(LeaveTextBox);
            frmAddUpdateUser.txtUserAdministrationEmail.Leave += new EventHandler(LeaveTextBox);
            frmAddUpdateUser.txtUserAdministrationLastName.Leave += new EventHandler(LeaveTextBox);
            frmAddUpdateUser.txtUserAdministrationName.Leave += new EventHandler(LeaveTextBox);
            frmAddUpdateUser.txtUserAdministrationPhoneNumber.Leave += new EventHandler(LeaveTextBox);

            frmAddUpdateUser.txtUserAdministrationPhoneNumber.TextChangedEvent += new EventHandler(TextBoxTextChanged);
        }

        /// <summary>
        ///     Se llama al método "AutoInsertDash", que cumple la función
        ///     de colocar automáticamente un '-' cuando el usuario ha ingresado 4 dígitos, y,
        ///     posteriormente, mover el cursor para que el usuario pueda seguir escribiendo sin problema
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TextBoxTextChanged(object sender, EventArgs e)
        {
            AutoInsertDash();
        }
        private void AutoInsertDash()
        {
            if (frmAddUpdateUser.txtUserAdministrationPhoneNumber.Texts.Length == 4 && !frmAddUpdateUser.txtUserAdministrationPhoneNumber.Texts.Contains("-"))
            {
                frmAddUpdateUser.txtUserAdministrationPhoneNumber.Texts += "-";
                frmAddUpdateUser.txtUserAdministrationPhoneNumber.SelectionStart = frmAddUpdateUser.txtUserAdministrationPhoneNumber.Texts.Length;
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
        string GetPlaceholderText(CustomTextBox txt)
        {
            if (txt == frmAddUpdateUser.txtUserAdministrationName) return "Nombres";
            if (txt == frmAddUpdateUser.txtUserAdministrationLastName) return "Apellidos";
            if (txt == frmAddUpdateUser.txtUserAdministrationEmail) return "Correo Electrónico";
            if (txt == frmAddUpdateUser.txtUserAdministrationPhoneNumber) return "Número de Teléfono";
            if (txt == frmAddUpdateUser.txtUserAdministrationUsername) return "Usuario";
            return string.Empty;
        }
        private void CloseForm(object sender, EventArgs e)
        {
            frmAddUpdateUser.Dispose();
        }
        private void MouseEnterPictureButton(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn != null && imageMapping.ContainsKey(btn.Name))
            {
                btn.Image = imageMapping[btn.Name].Item2;
            }
        }
        private void MouseLeavePictureButton(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn != null && imageMapping.ContainsKey(btn.Name))
            {
                btn.Image = imageMapping[btn.Name].Item1;
            }
        }
        private void VerifyProcedure()
        {
            if (procedure == 1)
            {
                frmAddUpdateUser.btnAddNewUser.Enabled = true;
                frmAddUpdateUser.btnUpdateUser.Enabled = false;
            }
            else if (procedure == 2)
            {
                frmAddUpdateUser.btnAddNewUser.Enabled = false;
                frmAddUpdateUser.btnUpdateUser.Enabled = true;
                frmAddUpdateUser.txtUserAdministrationUsername.Enabled = false;
            }
            else
            {
                frmAddUpdateUser.btnAddNewUser.Enabled = false;
                frmAddUpdateUser.btnUpdateUser.Enabled = false;
                frmAddUpdateUser.txtUserAdministrationName.Enabled = false;
                frmAddUpdateUser.txtUserAdministrationLastName.Enabled = false;
                frmAddUpdateUser.txtUserAdministrationEmail.Enabled = false;
                frmAddUpdateUser.txtUserAdministrationPhoneNumber.Enabled = false;
                frmAddUpdateUser.txtUserAdministrationUsername.Enabled = false;
                frmAddUpdateUser.cmbUserAdministrationRole.Enabled = false;
            }
        }
        private void LoadComboBox(object sender, EventArgs e)
        {
            DAOUserAdministration dao = new DAOUserAdministration();
            DataSet ds = dao.GetRoles();
            frmAddUpdateUser.cmbUserAdministrationRole.DataSource = ds.Tables["tbRoles"];
            frmAddUpdateUser.cmbUserAdministrationRole.ValueMember = "idRol";
            frmAddUpdateUser.cmbUserAdministrationRole.DisplayMember = "nombreRol";
            if (procedure == 2)
            {
                frmAddUpdateUser.cmbUserAdministrationRole.Text = role;
                frmAddUpdateUser.txtUserAdministrationId.Texts = personID;
            }
        }
        private void NewUser(object sender, EventArgs e)
        {
            DAOUserAdministration dao = new DAOUserAdministration();
            string temporaryPassword;
            string email;

            // Persona
            dao.PersonName = frmAddUpdateUser.txtUserAdministrationName.Texts.Trim();
            dao.PersonLastName = frmAddUpdateUser.txtUserAdministrationLastName.Texts.Trim();
            email = frmAddUpdateUser.txtUserAdministrationEmail.Texts.Trim();
            dao.Email = frmAddUpdateUser.txtUserAdministrationEmail.Texts.Trim();
            dao.PhoneNumber = frmAddUpdateUser.txtUserAdministrationPhoneNumber.Texts.Trim();

            // Usuario
            dao.Username = frmAddUpdateUser.txtUserAdministrationUsername.Texts.Trim();
            temporaryPassword = CommonMethods.GenerateRandomPassword(8);
            dao.Password = CommonMethods.ComputeSha256Hash(temporaryPassword);
            dao.Token = CommonMethods.GenerateRandomPassword(69);
            dao.UserStatus = true;
            dao.UserAttempts = 0;
            dao.TemporaryPassword = true;
            dao.RoleId = int.Parse(frmAddUpdateUser.cmbUserAdministrationRole.SelectedValue.ToString());
            if (dao.RegisterUser() == 2)
            {
                MessageBox.Show("Los datos han sido guardados de manera exitosa.", "Proceso finalizado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (CommonMethods.SendEmail(temporaryPassword, email) == false)
                {
                    dao.PersonId = dao.GetMaxID();
                    dao.DeleteUser();
                }
                else
                {
                    MessageBox.Show("Los datos han sido registrados en la base de datos de manera exitosa.", "Proceso finalizado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Los datos no han podido ser registrados.", "Proceso interrumpido", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void UpdateUserInfo(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(frmAddUpdateUser.txtUserAdministrationName.Texts.Trim()) || string.IsNullOrEmpty(frmAddUpdateUser.txtUserAdministrationLastName.Texts.Trim()) || string.IsNullOrEmpty(frmAddUpdateUser.txtUserAdministrationEmail.Texts.Trim()) || string.IsNullOrEmpty(frmAddUpdateUser.txtUserAdministrationPhoneNumber.Texts.Trim()))
            {
                DAOUserAdministration dao = new DAOUserAdministration();
                dao.PersonId = int.Parse(frmAddUpdateUser.txtUserAdministrationId.Texts.Trim());
                dao.PersonName = frmAddUpdateUser.txtUserAdministrationName.Texts.Trim();
                dao.PersonLastName = frmAddUpdateUser.txtUserAdministrationLastName.Texts.Trim();
                dao.Email = frmAddUpdateUser.txtUserAdministrationEmail.Texts.Trim();
                dao.PhoneNumber = frmAddUpdateUser.txtUserAdministrationPhoneNumber.Texts.Trim();
                dao.Username = frmAddUpdateUser.txtUserAdministrationUsername.Texts.Trim();
                dao.RoleId = (int)frmAddUpdateUser.cmbUserAdministrationRole.SelectedValue;

                int returnedValue = dao.UpdateUserInfo();
                if (returnedValue == 2)
                {
                    MessageBox.Show("Los datos han sido actualizado exitosamente", "Proceso completado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (returnedValue == 1)
                {
                    MessageBox.Show("Los datos no pudieron ser actualizados completamente", "Proceso interrumpido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("Los datos no pudieron ser actualizados debido a un error inesperado", "Proceso interrumpido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Existen campos vacíos, complete cada uno de los apartados.", "Proceso interrumpido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void LoadValues(int personId, string firstName, string lastName, string email, string phoneNumber, string username)
        {
            frmAddUpdateUser.txtUserAdministrationId.Texts = personId.ToString();
            frmAddUpdateUser.txtUserAdministrationName.Texts = firstName;
            frmAddUpdateUser.txtUserAdministrationLastName.Texts = lastName;
            frmAddUpdateUser.txtUserAdministrationEmail.Texts = email;
            frmAddUpdateUser.txtUserAdministrationPhoneNumber.Texts = phoneNumber;
            frmAddUpdateUser.txtUserAdministrationUsername.Texts = username;
        }
    }
}
