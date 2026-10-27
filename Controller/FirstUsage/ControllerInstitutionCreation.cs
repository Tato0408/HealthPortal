using CustomControls;
using HealthPortal.Helper;
using HealthPortal.Model.DAO;
using HealthPortal.Properties;
using HealthPortal.View.FirstUsage;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;

namespace HealthPortal.Controller.FirstUsage
{
    internal class ControllerInstitutionCreation
    {
        FrmInstitutionCreation frmInstitutionCreation;
        private Dictionary<string, Tuple<Bitmap, Bitmap>> imageMapping;

        /// <summary>
        ///     Constructor de ControllerInstitutionCreation, donde:
        ///         1. Se le asigna la vista (enviada como parámetro) a frmInstitutionCreation
        ///         2. Se le asigna valor a imageMapping, teniendo en cuenta los botones con imágenes que hay
        ///         3. Están todos los posibles eventos de la interfaz
        /// </summary>
        /// <param name="view"></param>
        public ControllerInstitutionCreation(FrmInstitutionCreation view)
        {
            frmInstitutionCreation = view;
            imageMapping = new Dictionary<string, Tuple<Bitmap, Bitmap>>()
            {
                { "btnExit", Tuple.Create(Resources.quit, Resources.hoverQuit) }
            };

            CommonMethods.EnableFormDrag(frmInstitutionCreation, frmInstitutionCreation);

            // Eventos "por defecto"
            frmInstitutionCreation.Load += new EventHandler(LoadCombobox);
            frmInstitutionCreation.picLogo.Paint += new PaintEventHandler(GeneratePictureBoxBorder);

            // Eventos de validación
            frmInstitutionCreation.txtInstitutionName.KeyPress += new KeyPressEventHandler(CommonMethods.TextBoxKeyPress);
            frmInstitutionCreation.txtInstitutionAddress.KeyPress += new KeyPressEventHandler(CommonMethods.TextBoxKeyPress);
            frmInstitutionCreation.txtPhoneNumber.KeyPress += new KeyPressEventHandler(CommonMethods.TextBoxKeyPress);
            frmInstitutionCreation.txtPhoneNumber.TextChangedEvent += new EventHandler(TextBoxTextChanged);
            frmInstitutionCreation.txtEmail.KeyPress += new KeyPressEventHandler(CommonMethods.TextBoxKeyPress);

            // Eventos .Enter de los textbox; se verifica si la propiedad .Texts de los textbox corresponde a lo que viene siendo el texto "placeholder", y si sí lo es, se vacían
            frmInstitutionCreation.txtInstitutionName.Enter += new EventHandler(EnterTextBox);
            frmInstitutionCreation.txtInstitutionAddress.Enter += new EventHandler(EnterTextBox);
            frmInstitutionCreation.txtEmail.Enter += new EventHandler(EnterTextBox);
            frmInstitutionCreation.txtPhoneNumber.Enter += new EventHandler(EnterTextBox);

            // Eventos .Leave de los textbox; se verifica si al salir del textbox la propiedad .Texts contiene un string vacío "", y si sí es un string vacío, se le coloca el texto "placeholder"
            frmInstitutionCreation.txtInstitutionName.Leave += new EventHandler(LeaveTextBox);
            frmInstitutionCreation.txtInstitutionAddress.Leave += new EventHandler(LeaveTextBox);
            frmInstitutionCreation.txtEmail.Leave += new EventHandler(LeaveTextBox);
            frmInstitutionCreation.txtPhoneNumber.Leave += new EventHandler(LeaveTextBox);

            // Eventos .Enter de los botones, haciéndose la distinción entre los botones que son únicamente imágenes y los que son únicamente texto (MouseEnterControl y MouseEnterButton, respectivamente)
            frmInstitutionCreation.btnExit.MouseEnter += new EventHandler(MouseEnterPictureButton);
            frmInstitutionCreation.btnAddLogo.MouseEnter += new EventHandler(MouseEnterTextButton);
            frmInstitutionCreation.btnRegisterInstitution.MouseEnter += new EventHandler(MouseEnterTextButton);

            // Eventos .Leave de los botones, haciéndose la distinción entre los botones que son únicamente imágenes y los que son únicamente texto (MouseLeavePictureButton y MouseLeaveTextButton, respectivamente)
            frmInstitutionCreation.btnExit.MouseLeave += new EventHandler(MouseLeavePictureButton);
            frmInstitutionCreation.btnAddLogo.MouseLeave += new EventHandler(MouseLeaveTextButton);
            frmInstitutionCreation.btnRegisterInstitution.MouseLeave += new EventHandler(MouseLeaveTextButton);

            // Evento .Click para abrir un FileDialog
            frmInstitutionCreation.btnAddLogo.Click += new EventHandler(AddLogo);

            // Evento .Click para registrar la institución
            frmInstitutionCreation.btnRegisterInstitution.Click += new EventHandler(RegisterInstitution);

            // Evento .Click que lo único que hace es cerrar el programa xd
            frmInstitutionCreation.btnExit.Click += new EventHandler(ExitApplication);
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
            if (frmInstitutionCreation.txtPhoneNumber.Texts.Length == 4 && !frmInstitutionCreation.txtPhoneNumber.Texts.Contains("-"))
            {
                frmInstitutionCreation.txtPhoneNumber.Texts += "-";
                frmInstitutionCreation.txtPhoneNumber.SelectionStart = frmInstitutionCreation.txtPhoneNumber.Texts.Length;
            }
        }
        private void LoadCombobox(object sender, EventArgs e)
        {
            DAOFirstUsage dao = new DAOFirstUsage();
            DataSet ds = dao.FillCombobox();
            frmInstitutionCreation.cmbInstitutionType.DataSource = ds.Tables["tbCategoríaInstitución"];
            frmInstitutionCreation.cmbInstitutionType.ValueMember = "idCategoríaInstitución";
            frmInstitutionCreation.cmbInstitutionType.DisplayMember = "categoríaInstitución";
        }

        /// <summary>
        ///     Esta función hace un rectángulo alrededor del pictureBox, simulando un borde. Esto
        ///     porque quería que el borde fuera del color "AppWorkspace" pero no tenía ninguna propiedad
        ///     para cambiar el color del borde, por lo que tocó recurrir a esto
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GeneratePictureBoxBorder(object sender, PaintEventArgs e)
        {
            PictureBox pic = sender as PictureBox;
            Color borderColor = SystemColors.AppWorkspace;
            int borderWidth = 1;
            int offset = borderWidth / 2;
            Graphics graph = e.Graphics;
            Pen pen = new Pen(borderColor, borderWidth);
            graph.DrawRectangle(pen, offset, offset, pic.Width - borderWidth, pic.Height - borderWidth);
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
        private void AddLogo(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Archivos de imagen (*.jpg;*.jpeg;*.png)|*.jpg;*.jpeg;*.png| Todos los archivos(*.*)| *.* ";
            ofd.Title = "Seleccionar imagen para guardar como logo de la institución";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string imageURL = ofd.FileName;
                frmInstitutionCreation.picLogo.Image = Image.FromFile(imageURL);
            }
        }
        private void RegisterInstitution(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(frmInstitutionCreation.txtInstitutionName.Texts.Trim()) || string.IsNullOrEmpty(frmInstitutionCreation.txtInstitutionAddress.Texts.Trim()) || string.IsNullOrEmpty(frmInstitutionCreation.txtEmail.Texts.Trim()) || string.IsNullOrEmpty(frmInstitutionCreation.txtPhoneNumber.Texts.Trim()))
            {
                MessageBox.Show("Existen campos vacíos. Por favor, asegúrese de llenar todos los campos y vuelva a intentar.", "Información incompleta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DAOFirstUsage dao = new DAOFirstUsage();
                dao.InstitutionName = frmInstitutionCreation.txtInstitutionName.Texts.Trim();
                dao.InstitutionAddress = frmInstitutionCreation.txtInstitutionAddress.Texts.Trim();
                dao.InstitutionLogo = CommonMethods.ImageToByteArray(frmInstitutionCreation.picLogo.Image);
                dao.InstitutionPhone = frmInstitutionCreation.txtPhoneNumber.Texts.Trim();
                dao.InstitutionEmail = frmInstitutionCreation.txtEmail.Texts.Trim();
                dao.InstitutionCategoryID = (int)frmInstitutionCreation.cmbInstitutionType.SelectedValue;
                if (dao.RegisterInstitution() == 1 && ValidateEmail())
                {
                    MessageBox.Show("La información de la institución ha sido registrada exitosamente.", "Proceso finalizado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    FrmFirstUserCreation objFirstUserCreation = new FrmFirstUserCreation();
                    frmInstitutionCreation.Hide();
                    objFirstUserCreation.Show();
                }
                else
                {
                    MessageBox.Show("Los datos no han podido ser registrados.", "Proceso interrumpido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void ExitApplication(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private string GetPlaceholderText(CustomTextBox txt)
        {
            if (txt == frmInstitutionCreation.txtInstitutionName) return "Nombre de la Institución";
            if (txt == frmInstitutionCreation.txtInstitutionAddress) return "Dirección de la Institución";
            if (txt == frmInstitutionCreation.txtEmail) return "Correo de la Institución";
            if (txt == frmInstitutionCreation.txtPhoneNumber) return "Teléfono de la Institución";
            return string.Empty;
        }
        bool ValidateEmail()
        {
            string email = frmInstitutionCreation.txtEmail.Texts.Trim();

            // Se verifica que el correo ingresado contenga el carácter '@'
            if (!(email.Contains("@")))
            {
                MessageBox.Show("Formato de correo invalido; por favor verifique que el correo que ha ingresado contenga @.", "Formato incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                // Se retorna FALSE porque obviamente no es un correo válido
                return false;
            }
            return true;
        }
    }
}
