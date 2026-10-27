using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HealthPortal.Model.DAO;
using HealthPortal.Model.DTO;
using HealthPortal.View.FirstUsage;
using HealthPortal.View.Login;
using System.Drawing;
using System.IO;
using CustomControls;
using System.Xml;
using HealthPortal.View.Settings;
using System.Runtime.CompilerServices;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using HealthPortal.View.Dashboard;

namespace HealthPortal.Helper
{
    internal class CommonMethods
    {
        const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        public static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // width of ellipse
            int nHeightEllipse // height of ellipse
        );

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        public static void ReadXMLConnectionFile()
        {
            string path = Path.Combine(Directory.GetCurrentDirectory().ToString(), "config_server.xml");
            if (File.Exists(path))
            {
                CurrentUserData.ServerSettingsOrigin = 2;
                XmlDocument doc = new XmlDocument();
                doc.Load(path);

                XmlNode root = doc.DocumentElement;
                XmlNode serverNode = root.SelectSingleNode("server/text()");
                XmlNode databaseNode = root.SelectSingleNode("database/text()");
                XmlNode sqlAuthNode = root.SelectSingleNode("sqlAuth/text()");
                XmlNode sqlPassNode = root.SelectSingleNode("sqlPassword/text()");

                string codedServer = serverNode.Value;
                string codedDatabase = databaseNode.Value;
                string codedSqlAuth = sqlAuthNode.Value;
                string codedSqlPass = sqlPassNode.Value;

                DTOdbContext.Server = DecodeString(codedServer);
                DTOdbContext.Database = DecodeString(codedDatabase);

                if (codedSqlAuth.Equals("null") && codedSqlPass.Equals("null"))
                {
                    sqlAuthNode.Value = string.Empty;
                    sqlPassNode.Value = string.Empty;
                }

                if (!string.IsNullOrEmpty(sqlAuthNode.Value) && !string.IsNullOrEmpty(sqlPassNode.Value))
                {
                    string codedUser = sqlAuthNode.Value;
                    string codedPassword = sqlPassNode.Value;

                    DTOdbContext.User = DecodeString(codedUser);
                    DTOdbContext.Password = DecodeString(codedPassword);
                }
                else
                {
                    DTOdbContext.User = DecodeString(string.Empty);
                    DTOdbContext.Password = DecodeString(string.Empty);
                }
            }
            else
            {
                CurrentUserData.ServerSettingsOrigin = 1;
                FrmServerSettings frmServerSettings = new FrmServerSettings();
                frmServerSettings.ShowDialog();
            }
        }
        public static string CodeString(string stringToCode)
        {
            try
            {
                byte[] bytes = Encoding.UTF8.GetBytes(stringToCode);
                string base64String = Convert.ToBase64String(bytes);
                return base64String;
            }
            catch (Exception)
            {
                return string.Empty;
            }
        }
        private static string DecodeString(string codedString)
        {
            try
            {
                byte[] decodedBytes = Convert.FromBase64String(codedString);
                string decodedString = Encoding.UTF8.GetString(decodedBytes);
                return decodedString.ToString();
            }
            catch (Exception)
            {
                return null;
            }
        }
        public static void TextBoxKeyDown(object sender, KeyEventArgs e)
        {
            CustomTextBox txt = sender as CustomTextBox;
            if (txt.Tag.ToString() != "sql")
            {
                if ((e.Control && e.KeyCode == Keys.C) || (e.Control && e.KeyCode == Keys.V))
                {
                    e.SuppressKeyPress = true;
                }
            }
        }
        public static void TextBoxKeyPress(object sender, KeyPressEventArgs e)
        {
            CustomTextBox txt = sender as CustomTextBox;
            if (txt == null || txt.Tag == null)
            {
                return;
            }
            string tag = txt.Tag.ToString();
            switch (tag)
            {
                case "name":
                    ValidateNameTextBox(e);
                    break;
                case "email":
                    ValidateEmailTextBox(e);
                    break;
                case "username":
                    ValidateUsernameTextBox(e);
                    break;
                case "password":
                    ValidatePasswordTextBox(e);
                    break;
                case "phoneNumber":
                    ValidatePhoneNumberTextBox(txt, e);
                    break;
                case "confirmationCode":
                    ValidateConfirmationCodeTextBox(e);
                    break;
                case "securityAnswer":
                    ValidateSecurityAnswerTextBox(e);
                    break;
                case "address":
                    ValidateAddressTextBox(e);
                    break;
                case "sql":
                    // Nada xd
                    break;
                default:
                    // Igual, nada xd
                    break;
            }
        }
        private static void ValidateNameTextBox(KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && e.KeyChar != (char)Keys.Back && e.KeyChar != (char)Keys.Tab)
            {
                e.Handled = true;
            }
        }
        private static void ValidatePhoneNumberTextBox(CustomTextBox txt, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back && e.KeyChar != (char)Keys.Tab)
            {
                e.Handled = true;
            }
        }
        private static void ValidateEmailTextBox(KeyPressEventArgs e)
        {
            if (!char.IsLower(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '@' && e.KeyChar != '.' && e.KeyChar != (char)Keys.Back && e.KeyChar != (char)Keys.Tab)
            {
                e.Handled = true;
            }
        }
        private static void ValidateUsernameTextBox(KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back && e.KeyChar != (char)Keys.Tab)
            {
                e.Handled = true;
            }
        }
        private static void ValidatePasswordTextBox(KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && !@"@$#_".Contains(e.KeyChar) && e.KeyChar != (char)Keys.Back && e.KeyChar != (char)Keys.Tab)
            {
                e.Handled = true;
            }
        }
        private static void ValidateConfirmationCodeTextBox(KeyPressEventArgs e)
        {
            if (Control.ModifierKeys == Keys.Control && (e.KeyChar == 3 || e.KeyChar == 22 || e.KeyChar == 24))
            {
                // El 3 es Ctrl + C, el 22 es Ctrl + V, y el 24 es Ctrl + X
                return;
            }
            if (!char.IsLetterOrDigit(e.KeyChar) && !@"@$#_".Contains(e.KeyChar) && e.KeyChar != (char)Keys.Back && e.KeyChar != (char)Keys.Tab)
            {
                e.Handled = true;
            }
        }
        private static void ValidateSecurityAnswerTextBox(KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back && e.KeyChar != (char)Keys.Tab && e.KeyChar != ' ')
            {
                e.Handled = true;
            }
        }
        private static void ValidateAddressTextBox(KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back && e.KeyChar != (char)Keys.Tab && e.KeyChar != ' ' && e.KeyChar != '-' && e.KeyChar != '.' && e.KeyChar != ',')
            {
                e.Handled = true;
            }
        }
        public static void DetermineInitialForm()
        {
            DAOLogin daoLogin = new DAOLogin();
            ReadXMLConnectionFile();
            Form initialForm = null;
            if (daoLogin.GetAmountOfUsers() == 0)
            {
                if (daoLogin.GetInstitutionInfo() == 0)
                {
                    initialForm = new FrmInstitutionCreation();
                }
                else
                {
                    initialForm = new FrmFirstUserCreation();
                }
            }
            else
            {
                initialForm = new FrmLogin();
            }

            if (initialForm != null)
            {
                initialForm.WindowState = FormWindowState.Normal;
                initialForm.TopMost = true;
                initialForm.Activate();
                Application.Run(initialForm);
            }
        }
        public static string ComputeSha256Hash(string rawData)
        {
            // Crear una instancia de SHA256
            using (SHA256 sha256Hash = SHA256.Create())
            {
                // Computar el hash - devuelve un arreglo de bytes
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(rawData));

                // Convertir byte array a string
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }
        public static string GenerateRandomPassword(int length)
        {
            const string validCharacters = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890@$#_";
            StringBuilder password = new StringBuilder();
            RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider();
            byte[] data = new byte[length];
            rng.GetBytes(data);
            foreach (byte a in data)
            {
                password.Append(validCharacters[a % validCharacters.Length]);
            }
            return password.ToString();
        }
        public static bool IsPasswordValid(string password)
        {
            const string validCharacters = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890@$#_";
            foreach (char a in password)
            {
                if (!validCharacters.Contains(a))
                {
                    return false;
                }
            }
            return AtLeast8Characters(password) &&
                   AtLeast1Number(password) &&
                   AtLeast1Uppercase(password) &&
                   AtLeast1Lowercase(password) &&
                   AtLeast1SpecialCharacter(password);
        }
        public static bool SendVerificationEmail(string email, string confirmationCode)
        {
            try
            {
                SmtpClient client = new SmtpClient("smtp.gmail.com", 587)
                {
                    Credentials = new NetworkCredential($"healthportal.noreply@gmail.com", "vtgf qixd xvgf kdpo"),
                    EnableSsl = true
                };
                MailMessage mailMessage = new MailMessage
                {
                    From = new MailAddress("healthportal.noreply@gmail.com"),
                    Subject = "Confirmación de Correo",
                    Body = $"¡Ha sido registrado como usuario en HealthPortal! El código de confirmación que deberá utilizar para confirmar su contraseña es: '{confirmationCode}'.",
                    IsBodyHtml = true
                };
                mailMessage.To.Add(email);
                client.Send(mailMessage);
                MessageBox.Show($"Correo de confirmación de cuenta enviado exitosamente.", "Correo enviado exitosamente", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            catch (Exception)
            {
                MessageBox.Show($"Hubo un error al enviar el correo. Revise el correo ingresado y vuelva a intentar.", "Error al enviar el correo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
        }
        public static bool SendEmail(string temporaryPassword, string email)
        {
            try
            {
                SmtpClient client = new SmtpClient("smtp.gmail.com", 587)
                {
                    Credentials = new NetworkCredential($"healthportal.noreply@gmail.com", "vtgf qixd xvgf kdpo"),
                    EnableSsl = true
                };
                MailMessage mailMessage = new MailMessage
                {
                    From = new MailAddress("healthportal.noreply@gmail.com"),
                    Subject = "Contraseña Temporal",
                    Body = $"¡Ha sido registrado como usuario en HealthPortal! La contraseña que deberá utilizar para inciar sesión es: '{temporaryPassword}'. Claro está que, por motivos de seguridad, es indispensable que, al iniciar sesión por primera vez, se asegure de cambiar la contraseña.",
                    IsBodyHtml = true
                };
                mailMessage.To.Add(email);
                client.Send(mailMessage);
                MessageBox.Show($"Contraseña temporal enviada al usuario a través de su correo electrónico de manera exitosa.", "Correo enviado exitosamente", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            catch (Exception)
            {
                MessageBox.Show($"Hubo un error al enviar el correo. Revise el correo ingresado y vuelva a intentar.", "Error al enviar el correo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
        }
        public static bool SendRecoveryEmail(string temporaryPassword, string email)
        {
            try
            {
                SmtpClient client = new SmtpClient("smtp.gmail.com", 587)
                {
                    Credentials = new NetworkCredential($"healthportal.noreply@gmail.com", "vtgf qixd xvgf kdpo"),
                    EnableSsl = true
                };
                MailMessage mailMessage = new MailMessage
                {
                    From = new MailAddress("healthportal.noreply@gmail.com"),
                    Subject = "Contraseña Temporal",
                    Body = $"Al parecer ha olvidado su contraseña para iniciar sesión en HealthPortal. La contraseña que deberá utilizar para inciar sesión es: '{temporaryPassword}'. Claro está que, por motivos de seguridad, es indispensable que, al iniciar sesión con esta nueva contraseña, se asegure de cambiar la contraseña a una de su elección. Además, ¡asegúrese de recordarla esta vez!",
                    IsBodyHtml = true
                };
                mailMessage.To.Add(email);
                client.Send(mailMessage);
                MessageBox.Show($"Contraseña temporal enviada al usuario a través de su correo electrónico de manera exitosa.", "Correo enviado exitosamente", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            catch (Exception)
            {
                MessageBox.Show($"Hubo un error al enviar el correo. Revise el correo ingresado y vuelva a intentar.", "Error al enviar el correo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
        }
        public static void DisposeOfCurrentUserData()
        {
            CurrentUserData.Username = string.Empty;
            CurrentUserData.Status = false;
            CurrentUserData.FullName = string.Empty;
            CurrentUserData.Password = string.Empty;
            CurrentUserData.RoleId = 0;
            CurrentUserData.TemporaryPassword = false;
            CurrentUserData.Email = string.Empty;
            CurrentUserData.FullScreen = false;
        }
        public static void EnableFormDrag(Form frm, Control control)
        {
            control.MouseDown += (sender, e) =>
            {
                if (e.Button == MouseButtons.Left)
                {
                    control.Cursor = Cursors.Hand;
                    ReleaseCapture();
                    SendMessage(frm.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
                    control.Cursor = Cursors.Default;
                }
            };
        }
        public static byte[] ImageToByteArray(Image img)
        {
            if (img != null)
            {
                MemoryStream memoryStream = new MemoryStream();
                img.Save(memoryStream, System.Drawing.Imaging.ImageFormat.Png);
                return memoryStream.ToArray();
            }
            return null;
        }
        public static Image ByteArrayToImage(byte[] byteArray)
        {
            if (byteArray != null)
            {
                MemoryStream memoryStream = new MemoryStream(byteArray);
                return Image.FromStream(memoryStream);
            }
            return null;
        }
        private static bool AtLeast8Characters(string password)
        {
            return password.Length >= 8;
        }
        private static bool AtLeast1Number(string password)
        {
            return password.Any(char.IsDigit);
        }
        private static bool AtLeast1Uppercase(string password)
        {
            return password.Any(char.IsUpper);
        }
        private static bool AtLeast1Lowercase(string password)
        {
            return password.Any(char.IsLower);
        }
        private static bool AtLeast1SpecialCharacter(string password)
        {
            string specialCharacters = "@$#_";
            return password.Any(specialCharacter => specialCharacters.Contains(specialCharacter));
        }
        public static void HandleError(string errorCode)
        {
            MessageBox.Show($"Un error ha ocurrido. Por favor, consulte el código {errorCode} en el manual técnico.", "Error crítico", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}