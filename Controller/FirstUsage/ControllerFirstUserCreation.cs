using HealthPortal.Properties;
using HealthPortal.View.FirstUsage;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CustomControls;
using HealthPortal.Model.DAO;
using HealthPortal.Helper;
using HealthPortal.Model.DTO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Security.Principal;

namespace HealthPortal.Controller.FirstUsage
{
    internal class ControllerFirstUserCreation
    {
        FrmFirstUserCreation frmFirstUserCreation;
        private Dictionary<string, Tuple<Bitmap, Bitmap>> imageMapping;
        public ControllerFirstUserCreation(FrmFirstUserCreation view)
        {
            frmFirstUserCreation = view;

            // El diccionario "imageMapping" declarado previamente se inicializa con los valores correspondientes para posteriormente ser utilizado en los eventos .Enter y .Leave de los botones
            imageMapping = new Dictionary<string, Tuple<Bitmap, Bitmap>>()
            {
                { "btnShowPassword", Tuple.Create(Resources.show, Resources.hoverShow) },
                { "btnHidePassword", Tuple.Create(Resources.hide, Resources.hoverHide) },
                { "btnExit", Tuple.Create(Resources.quit, Resources.hoverQuit) }
            };

            // Evento de carga del formulario, se oculta automáticamente la contraseña
            frmFirstUserCreation.Load += new EventHandler(ShowPassword);

            // Extra
            CommonMethods.EnableFormDrag(frmFirstUserCreation, frmFirstUserCreation);

            // Eventos de validación
            frmFirstUserCreation.txtName.KeyPress += new KeyPressEventHandler(CommonMethods.TextBoxKeyPress);
            frmFirstUserCreation.txtLastName.KeyPress += new KeyPressEventHandler(CommonMethods.TextBoxKeyPress);
            frmFirstUserCreation.txtEmail.KeyPress += new KeyPressEventHandler(CommonMethods.TextBoxKeyPress);
            frmFirstUserCreation.txtPhoneNumber.KeyPress += new KeyPressEventHandler(CommonMethods.TextBoxKeyPress);
            frmFirstUserCreation.txtPhoneNumber.TextChangedEvent += new EventHandler(TextBoxTextChanged);
            frmFirstUserCreation.txtUsername.KeyPress += new KeyPressEventHandler(CommonMethods.TextBoxKeyPress);
            frmFirstUserCreation.txtPassword.KeyPress += new KeyPressEventHandler(CommonMethods.TextBoxKeyPress);
            frmFirstUserCreation.txtConfirmPassword.KeyPress += new KeyPressEventHandler(CommonMethods.TextBoxKeyPress);

            // Eventos .Enter de los textbox; se verifica si la propiedad .Texts de los textbox corresponde a lo que viene siendo el texto "placeholder", y si sí lo es, se vacían
            frmFirstUserCreation.txtName.Enter += new EventHandler(EnterTextBox);
            frmFirstUserCreation.txtLastName.Enter += new EventHandler(EnterTextBox);
            frmFirstUserCreation.txtEmail.Enter += new EventHandler(EnterTextBox);
            frmFirstUserCreation.txtPhoneNumber.Enter += new EventHandler(EnterTextBox);
            frmFirstUserCreation.txtUsername.Enter += new EventHandler(EnterTextBox);
            frmFirstUserCreation.txtPassword.Enter += new EventHandler(EnterTextBox);
            frmFirstUserCreation.txtConfirmPassword.Enter += new EventHandler(EnterTextBox);

            // Eventos .Leave de los textbox; se verifica si al salir del textbox la propiedad .Texts contiene un string vacío "", y si sí es un string vacío, se le coloca el texto "placeholder"
            frmFirstUserCreation.txtName.Leave += new EventHandler(LeaveTextBox);
            frmFirstUserCreation.txtLastName.Leave += new EventHandler(LeaveTextBox);
            frmFirstUserCreation.txtEmail.Leave += new EventHandler(LeaveTextBox);
            frmFirstUserCreation.txtPhoneNumber.Leave += new EventHandler(LeaveTextBox);
            frmFirstUserCreation.txtUsername.Leave += new EventHandler(LeaveTextBox);
            frmFirstUserCreation.txtPassword.Leave += new EventHandler(LeaveTextBox);
            frmFirstUserCreation.txtConfirmPassword.Leave += new EventHandler(LeaveTextBox);

            // Eventos .Click para ocultar / mostrar la contraseña
            frmFirstUserCreation.btnHidePassword.Click += new EventHandler(ShowPassword);
            frmFirstUserCreation.btnShowPassword.Click += new EventHandler(HidePassword);

            // Eventos .Enter de los botones, haciéndose la distinción entre los botones que son únicamente imágenes y los que son únicamente texto (MouseEnterPictureButton y MouseEnterTextButton, respectivamente)
            frmFirstUserCreation.btnExit.MouseEnter += new EventHandler(MouseEnterPictureButton);
            frmFirstUserCreation.btnHidePassword.MouseEnter += new EventHandler(MouseEnterPictureButton);
            frmFirstUserCreation.btnShowPassword.MouseEnter += new EventHandler(MouseEnterPictureButton);
            frmFirstUserCreation.btnRegisterFirstUser.MouseEnter += new EventHandler(MouseEnterTextButton);

            // Eventos .Leave de los botones, haciéndose la distinción entre los botones que son únicamente imágenes y los que son únicamente texto (MouseLeavePictureButton y MouseLeaveTextButton, respectivamente)
            frmFirstUserCreation.btnExit.MouseLeave += new EventHandler(MouseLeavePictureButton);
            frmFirstUserCreation.btnHidePassword.MouseLeave += new EventHandler(MouseLeavePictureButton);
            frmFirstUserCreation.btnShowPassword.MouseLeave += new EventHandler(MouseLeavePictureButton);
            frmFirstUserCreation.btnRegisterFirstUser.MouseLeave += new EventHandler(MouseLeaveTextButton);

            // Eventos que inician el proceso de registro del primer usuario
            frmFirstUserCreation.btnRegisterFirstUser.Click += new EventHandler(FirstUserRegistration);

            // Evento .Click que lo único que hace es cerrar el programa xd
            frmFirstUserCreation.btnExit.Click += new EventHandler(ExitApplication);
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
            if (frmFirstUserCreation.txtPhoneNumber.Texts.Length == 4 && !frmFirstUserCreation.txtPhoneNumber.Texts.Contains("-"))
            {
                frmFirstUserCreation.txtPhoneNumber.Texts += "-";
                frmFirstUserCreation.txtPhoneNumber.SelectionStart = frmFirstUserCreation.txtPhoneNumber.Texts.Length;
            }
        }

        /// <summary>
        ///     La propiedad .PasswordChar de los textbox Password y ConfirmPassword pasa a ser FALSE,
        ///     esto quiere decir que el texto será visible.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ShowPassword(object sender, EventArgs e)
        {
            frmFirstUserCreation.txtPassword.PasswordChar = false;
            frmFirstUserCreation.txtConfirmPassword.PasswordChar = false;
            frmFirstUserCreation.btnHidePassword.Visible = false;
            frmFirstUserCreation.btnShowPassword.Visible = true;
        }
        /// <summary>
        ///     La propiedad .PasswordChar de los textbox Password y ConfirmPassword pasa a ser TRUE,
        ///     esto quiere decir que el texto estará oculto.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void HidePassword(object sender, EventArgs e)
        {
            if (!frmFirstUserCreation.txtPassword.Texts.Trim().Equals("Contraseña"))
            {
                frmFirstUserCreation.txtPassword.PasswordChar = true;
                frmFirstUserCreation.btnShowPassword.Visible = false;
                frmFirstUserCreation.btnHidePassword.Visible = true;
                if (!frmFirstUserCreation.txtConfirmPassword.Texts.Trim().Equals("Confirmar contraseña"))
                {
                    frmFirstUserCreation.txtConfirmPassword.PasswordChar = true;
                }
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
        private void ExitApplication(object sender, EventArgs e)
        {
            Application.Exit();
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
            System.Windows.Forms.Button btn = sender as System.Windows.Forms.Button;
            if (btn != null && imageMapping.ContainsKey(btn.Name))
            {
                btn.Image = imageMapping[btn.Name].Item2;
            }
        }
        private void MouseLeavePictureButton(object sender, EventArgs e)
        {
            System.Windows.Forms.Button btn = sender as System.Windows.Forms.Button;
            if (btn != null && imageMapping.ContainsKey(btn.Name))
            {
                btn.Image = imageMapping[btn.Name].Item1;
            }
        }

        /// <summary>
        ///     Proceso para registrar al primer usuario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FirstUserRegistration(object sender, EventArgs e)
        {
            // Se verifica que ninguno de los textbox esté vacío
            if (!(frmFirstUserCreation.txtLastName.Texts.Trim() == "" || frmFirstUserCreation.txtLastName.Texts.Trim() == "" || frmFirstUserCreation.txtEmail.Texts.Trim() == "" || frmFirstUserCreation.txtPhoneNumber.Texts.Trim() == "" || frmFirstUserCreation.txtUsername.Texts.Trim() == "" || frmFirstUserCreation.txtPassword.Texts.Trim() == "" || frmFirstUserCreation.txtConfirmPassword.Texts.Trim() == "" || frmFirstUserCreation.txtName.Texts.Trim() == "Nombres" || frmFirstUserCreation.txtLastName.Texts.Trim() == "Apellidos" || frmFirstUserCreation.txtEmail.Texts.Trim() == "Correo Electrónico" || frmFirstUserCreation.txtPhoneNumber.Texts.Trim() == "Número de Teléfono" || frmFirstUserCreation.txtUsername.Texts.Trim() == "Usuario" || frmFirstUserCreation.txtPassword.Texts.Trim() == "Contraseña" || frmFirstUserCreation.txtConfirmPassword.Texts.Trim() == "Confirmar contraseña"))
            {
                // Se verifica que estos dos métodos retornen TRUE
                if (VerifyPasswordSimilarity() == true && ValidateEmail() == true)
                {
                    DAOFirstUsage dao = new DAOFirstUsage();
                    // A los atributos del DTO, por medio del DAO, se les asignan los contenidos de los textbox
                    dao.Name = frmFirstUserCreation.txtName.Texts.Trim();
                    dao.LastName = frmFirstUserCreation.txtLastName.Texts.Trim();
                    dao.Email = frmFirstUserCreation.txtEmail.Texts.Trim();
                    dao.Phone = frmFirstUserCreation.txtPhoneNumber.Texts.Trim();
                    dao.Username = frmFirstUserCreation.txtUsername.Texts.Trim();

                    // Excepto a la contraseña, esa tiene el paso extra de la encriptación con SHA256
                    dao.Password = CommonMethods.ComputeSha256Hash(frmFirstUserCreation.txtPassword.Texts.Trim());

                    // Y también exceptuando estos dos últimos que son casos especiales
                    dao.Token = CommonMethods.GenerateRandomPassword(69);

                    // Se evalúa que se haya logrado la inserción a la tabla tbUsuarios y tbPersonas
                    if (dao.RegisterFirstUser() == 2)
                    {
                        // Se genera una contraseña aleatoria, aunque en este caso      particular cumplirá la función de código de confirmación      del correo ingresado
                        string confirmationCode = CommonMethods.GenerateRandomPassword(8);
                        MessageBox.Show("Los datos han sido guardados de manera exitosa.", "Proceso finalizado", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Se evalua si el correo logró ser enviado
                        if (CommonMethods.SendVerificationEmail(dao.Email, confirmationCode) == false)
                        {
                            // Si no se envió, se recupera el ID de este primer usuario y posteriormente se elimina el registro, pues es de suma importancia que el correo síexista
                            dao.PersonID = dao.GetMaxID();
                            dao.DeleteUser();
                        }
                        else
                        {
                            // Si el correo se envió de manera exitosa, se oculta el formulario actual y se muestra el formulario en el que se tendrá que ingresar el código de confirmación recién generado
                            int personID = dao.GetMaxID();
                            FrmEmailVerification frmEmailVerification = new FrmEmailVerification(confirmationCode, personID, frmFirstUserCreation.txtUsername.Texts.Trim());
                            frmFirstUserCreation.Hide();
                            frmEmailVerification.ShowDialog();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Los datos no han podido ser registrados.", "Proceso interrumpido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Asegúrese de haber ingresado datos correctos y de no haber dejado ningún campo vacío.", "Proceso interrumpido", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /// <summary>
        ///     Se verifica que el texto que contiene txtPassword y txtConfirmPassword sean lo mismo
        /// </summary>
        /// <returns></returns>
        private bool VerifyPasswordSimilarity()
        {
            if (frmFirstUserCreation.txtPassword.Texts.Trim() == frmFirstUserCreation.txtConfirmPassword.Texts.Trim())
            {
                if (CommonMethods.IsPasswordValid(frmFirstUserCreation.txtPassword.Texts.Trim()))
                {
                    return true;
                }
                else
                {
                    MessageBox.Show("¡Ups! Parece que la contraseña no cuenta con el formato adecuado. Asegúrese de que la contraseña cuente con, como mínimo: Una letra mayúscula, una letra minúscula, un carácter especial (@$#_), un número (1234567890), y 8 caracteres de largo", "Contraseña inválida", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            else
            {
                MessageBox.Show("Verifique que ambas contraseñas ingresadas coincidan e intente de nuevo.", "Contraseñas no coinciden", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        /// <summary>
        ///     
        /// </summary>
        /// <returns></returns>
        bool ValidateEmail()
        {
            string email = frmFirstUserCreation.txtEmail.Texts.Trim();

            // Se verifica que el correo ingresado contenga el carácter '@'
            if (!(email.Contains("@")))
            {
                MessageBox.Show("Formato de correo invalido; por favor verifique que el correo que ha ingresado contenga @.", "Formato incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                // Se retorna FALSE porque obviamente no es un correo válido
                return false;
            }
            DAOFirstUsage dao = new DAOFirstUsage();
            // Se inicializa un array con los dominios permitidos
            string[] allowedDomains = { "gmail.com", $"{dao.InstitutionDomain()}" };

            // Se extrae el dominio del correo ingresado, creando un Substring que le sigue al carácter '@'. El +1 es para que el Substring comience en el siguiente carácter, entonces el Substring es, por ejemplo, "gmail.com" en lugar de "@gmail.com"
            string extention = email.Substring(email.LastIndexOf('@') + 1);

            // Se evalua si el array de dominios permitidos contiene el dominio ingresado por el usuario
            if (!allowedDomains.Contains(extention))
            {
                // Si no lo contiene pues se envía un mensaje de error y se retorna FALSE
                MessageBox.Show("Dominio del correo es invalido, el sistema unicamente admite dominios 'gmail.com' y 'ricaldone.edu.sv'.", "Formato incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            // Si la condición no se cumple quiere decir que el array si contiene la extensión, por lo que el correo es, en su totalidad, válido. Se retorna TRUE
            return true;
        }
        string GetPlaceholderText(CustomTextBox txt)
        {
            if (txt == frmFirstUserCreation.txtName) return "Nombres";
            if (txt == frmFirstUserCreation.txtLastName) return "Apellidos";
            if (txt == frmFirstUserCreation.txtEmail) return "Correo Electrónico";
            if (txt == frmFirstUserCreation.txtPhoneNumber) return "Número de Teléfono";
            if (txt == frmFirstUserCreation.txtUsername) return "Usuario";
            if (txt == frmFirstUserCreation.txtPassword) return "Contraseña";
            if (txt == frmFirstUserCreation.txtConfirmPassword) return "Confirmar contraseña";
            return string.Empty;
        }
    }
}
