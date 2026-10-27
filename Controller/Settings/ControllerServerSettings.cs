using CustomControls;
using HealthPortal.Helper;
using HealthPortal.Model;
using HealthPortal.Model.DTO;
using HealthPortal.Properties;
using HealthPortal.View.Login;
using HealthPortal.View.Settings;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace HealthPortal.Controller.Settings
{
    internal class ControllerServerSettings
    {
        FrmServerSettings frmServerSettings;
        private Dictionary<string, Tuple<Bitmap, Bitmap>> imageMapping;
        public ControllerServerSettings(FrmServerSettings view)
        {
            frmServerSettings = view;

            imageMapping = new Dictionary<string, Tuple<Bitmap, Bitmap>>()
            {
                { "btnExit", Tuple.Create(new Bitmap(Resources.gquit, 32, 32), new Bitmap(Resources.hoverQuit, 32, 32)) }
            };

            frmServerSettings.Resize += new EventHandler(ApplyRoundedCorners);

            frmServerSettings.txtServerURL.Enter += new EventHandler(EnterTextBox);
            frmServerSettings.txtDataBase.Enter += new EventHandler(EnterTextBox);
            frmServerSettings.txtSQLAuth.Enter += new EventHandler(EnterTextBox);
            frmServerSettings.txtPassword.Enter += new EventHandler(EnterTextBox);

            frmServerSettings.txtServerURL.Leave += new EventHandler(LeaveTextBox);
            frmServerSettings.txtDataBase.Leave += new EventHandler(LeaveTextBox);
            frmServerSettings.txtSQLAuth.Leave += new EventHandler(LeaveTextBox);
            frmServerSettings.txtPassword.Leave += new EventHandler(LeaveTextBox);

            frmServerSettings.rdoTrue.CheckedChanged += new EventHandler(rdTrueMarked);
            frmServerSettings.rdoFalse.CheckedChanged += new EventHandler(rdFalseMarked);
            frmServerSettings.Load += new EventHandler(rdFalseMarked);

            frmServerSettings.btnSaveConfig.Click += new EventHandler(SaveDataBaseConfiguration);

            frmServerSettings.btnSaveConfig.MouseEnter += new EventHandler(MouseEnterTextButton);
            frmServerSettings.btnSaveConfig.MouseLeave += new EventHandler(MouseLeaveTextButton);

            frmServerSettings.btnExit.Click += new EventHandler(CloseProgram);
            frmServerSettings.btnExit.MouseEnter += new EventHandler(MouseEnterPictureButton);
            frmServerSettings.btnExit.MouseLeave += new EventHandler(MouseLeavePictureButton);

            VerifyOrigin();
        }
        private void VerifyOrigin()
        {
            if (CurrentUserData.ServerSettingsOrigin == 1)
            {
                frmServerSettings.btnExit.Visible = true;
                frmServerSettings.btnExit.Image = new Bitmap(Resources.gquit, 32, 32);
                CommonMethods.EnableFormDrag(frmServerSettings, frmServerSettings);
                CommonMethods.EnableFormDrag(frmServerSettings, frmServerSettings.pnlTitle);
            }
            else
            {
                frmServerSettings.btnExit.Visible = false;
                frmServerSettings.txtServerURL.Texts = DTOdbContext.Server;
                frmServerSettings.txtDataBase.Texts = DTOdbContext.Database;
                frmServerSettings.txtSQLAuth.Texts = DTOdbContext.User;
                frmServerSettings.txtPassword.Texts = DTOdbContext.Password;
                if (string.IsNullOrEmpty(DTOdbContext.User) && string.IsNullOrEmpty(DTOdbContext.Password)) frmServerSettings.rdoFalse.Checked = true;
            }
        }
        private void ApplyRoundedCorners(object sender, EventArgs e)
        {
            if (CurrentUserData.ServerSettingsOrigin == 1)
            {
                frmServerSettings.Region = Region.FromHrgn(CommonMethods.CreateRoundRectRgn(0, 0, frmServerSettings.Width, frmServerSettings.Height, 20, 20));
            }
        }
        private void CloseProgram(object sender, EventArgs e)
        {
            Environment.Exit(0);
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
        private void MouseEnterTextButton(object sender, EventArgs e)
        {
            RJButton btn = sender as RJButton;
            btn.BackColor = Color.FromArgb(31, 43, 91);
            btn.ForeColor = Color.White;
        }
        private void MouseLeaveTextButton(object sender, EventArgs e)
        {
            RJButton btn = sender as RJButton;
            btn.BackColor = Color.FromArgb(255, 183, 3);
            btn.ForeColor = Color.FromArgb(31, 43, 91);
        }
        private void rdTrueMarked(object sender, EventArgs e)
        {
            if (frmServerSettings.rdoFalse.Checked == true)
            {
                frmServerSettings.tlpSQLAuth.Enabled = true;
                frmServerSettings.txtSQLAuth.Texts = GetPlaceholderText(frmServerSettings.txtSQLAuth);
                frmServerSettings.txtPassword.Texts = GetPlaceholderText(frmServerSettings.txtPassword);
            }
        }

        private void rdFalseMarked(object sender, EventArgs e)
        {
            if (frmServerSettings.rdoTrue.Checked == true)
            {
                frmServerSettings.tlpSQLAuth.Enabled = false;
                frmServerSettings.txtSQLAuth.Clear();
                frmServerSettings.txtPassword.Clear();
            }
        }
        private void SaveDataBaseConfiguration(object sender, EventArgs e)
        {
            try
            {
                XmlDocument doc = new XmlDocument();
                XmlDeclaration decl = doc.CreateXmlDeclaration("1.0", "UTF-8", null);
                doc.AppendChild(decl);
                XmlElement root = doc.CreateElement("connection");
                doc.AppendChild(root);
                
                XmlElement server = doc.CreateElement("server");
                string codedServer = CommonMethods.CodeString(frmServerSettings.txtServerURL.Texts.Trim());
                server.InnerText = codedServer;
                root.AppendChild(server);

                XmlElement Database = doc.CreateElement("database");
                string codedDatabase = CommonMethods.CodeString(frmServerSettings.txtDataBase.Texts.Trim());
                Database.InnerText = codedDatabase;
                root.AppendChild(Database);

                XmlElement SqlAuth = doc.CreateElement("sqlAuth");
                XmlElement SqlPassword = doc.CreateElement("sqlPassword");

                string codedSqlAuth;
                string codedSqlPassword;

                if (frmServerSettings.rdoTrue.Checked == true)
                {
                    codedSqlAuth = "null";
                    SqlAuth.InnerText = codedSqlAuth;
                    root.AppendChild(SqlAuth);

                    
                    codedSqlPassword = "null";
                    SqlPassword.InnerText = codedSqlPassword;
                    root.AppendChild(SqlPassword);
                }
                else
                {
                    
                    codedSqlAuth = CommonMethods.CodeString(frmServerSettings.txtSQLAuth.Texts.Trim());
                    SqlAuth.InnerText = codedSqlAuth;
                    root.AppendChild(SqlAuth);

                    codedSqlPassword = CommonMethods.CodeString(frmServerSettings.txtPassword.Texts.Trim());
                    SqlPassword.InnerText = codedSqlPassword;
                    root.AppendChild(SqlPassword);

                }

                SqlConnection connection = dbContext.testConnection(frmServerSettings.txtServerURL.Texts.Trim(), frmServerSettings.txtDataBase.Texts.Trim(), frmServerSettings.txtSQLAuth.Texts.Trim(), frmServerSettings.txtPassword.Texts.Trim());

                if (connection != null)
                {
                    doc.Save("config_server.xml");
                    DTOdbContext.Server = frmServerSettings.txtServerURL.Texts.Trim();
                    DTOdbContext.Database = frmServerSettings.txtDataBase.Texts.Trim();
                    DTOdbContext.User = frmServerSettings.txtSQLAuth.Texts.Trim();
                    DTOdbContext.Password = frmServerSettings.txtPassword.Texts.Trim();
                    MessageBox.Show($"El archivo fue creado exitosamente.", "Archivo de configuración", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MessageBox.Show("El programa se cerrará. Deberá volver a abrirlo e iniciar sesión con las credenciales correspondientes.", "Proceso compeltado exitosamente", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CommonMethods.DisposeOfCurrentUserData();
                    Environment.Exit(0);
                }
            }
            catch (XmlException)
            {
                MessageBox.Show("No se pudo crear el archivo de configuración.", "Consulte el manual técnico", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        private string GetPlaceholderText(CustomTextBox txt)
        {
            if (txt == frmServerSettings.txtServerURL) return "URL del servidor";
            if (txt == frmServerSettings.txtDataBase) return "Nombre de la base de datos";
            if (txt == frmServerSettings.txtSQLAuth) return "Autenticación de SQL";
            if (txt == frmServerSettings.txtPassword) return "Contraseña de SQL";
            return string.Empty;
        }
    }
}