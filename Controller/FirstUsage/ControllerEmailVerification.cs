using CustomControls;
using HealthPortal.Helper;
using HealthPortal.Model.DAO;
using HealthPortal.Properties;
using HealthPortal.View.FirstUsage;
using HealthPortal.View.Login;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HealthPortal.Controller.FirstUsage
{
    internal class ControllerEmailVerification
    {
        FrmEmailVerification frmEmailVerification;
        string confirmationCode;
        int personID;
        string username;
        public ControllerEmailVerification(FrmEmailVerification view, string confirmationCode, int personID, string username)
        {
            frmEmailVerification = view;
            this.confirmationCode = confirmationCode;
            this.personID = personID;
            this.username = username;
            CommonMethods.EnableFormDrag(frmEmailVerification, frmEmailVerification);
            frmEmailVerification.txtConfirmationCode.Enter += new EventHandler(EnterTxtConfirmationCode);
            frmEmailVerification.txtConfirmationCode.Leave += new EventHandler(LeaveTxtConfirmationCode);
            frmEmailVerification.btnExit.MouseEnter += new EventHandler(MouseEnterControl);
            frmEmailVerification.btnExit.MouseLeave += new EventHandler(MouseLeaveControl);
            frmEmailVerification.btnConfirmEmail.MouseEnter += new EventHandler(MouseEnterButton);
            frmEmailVerification.btnConfirmEmail.MouseLeave += new EventHandler(MouseLeaveButton);
            frmEmailVerification.btnExit.Click += new EventHandler(ExitForm);
            frmEmailVerification.btnConfirmEmail.Click += new EventHandler(CompareConfirmationCode);
            frmEmailVerification.txtConfirmationCode.KeyPress += new KeyPressEventHandler(CommonMethods.TextBoxKeyPress);
        }
        private void EnterTxtConfirmationCode(object sender, EventArgs e)
        {
            if (frmEmailVerification.txtConfirmationCode.Texts.Trim().Equals("Código de Confirmación"))
            {
                frmEmailVerification.txtConfirmationCode.Clear();
                frmEmailVerification.txtConfirmationCode.ForeColor = Color.FromArgb(31, 43, 91);
            }
        }
        private void LeaveTxtConfirmationCode(object sender, EventArgs e)
        {
            if (frmEmailVerification.txtConfirmationCode.Texts.Trim().Equals(""))
            {
                frmEmailVerification.txtConfirmationCode.Texts = "Código de Confirmación";
                frmEmailVerification.txtConfirmationCode.ForeColor = Color.FromArgb(142, 202, 230);
            }
        }
        private void MouseEnterButton(object sender, EventArgs e)
        {
            RJButton btn = sender as RJButton;
            btn.BackColor = Color.FromArgb(31, 43, 91);
            btn.ForeColor = Color.White;
        }
        private void MouseLeaveButton(object sender, EventArgs e)
        {
            RJButton btn = sender as RJButton;
            btn.BackColor = Color.FromArgb(142, 202, 230);
            btn.ForeColor = Color.FromArgb(31, 43, 91);
        }
        private void MouseEnterControl(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            btn.Image = Resources.hoverQuit;
        }
        private void MouseLeaveControl(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            btn.Image = Resources.quit;
        }
        private void ExitForm(object sender, EventArgs e)
        {
            DAOFirstUsage dao = new DAOFirstUsage();
            DialogResult result = MessageBox.Show("¿Seguro que desea abandonar el proceso de creación del primer usuario?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                dao.PersonID = personID;
                dao.Username = username;
                dao.DeleteUser();
                MessageBox.Show("Entendido. Registro de primer usuario eliminado.", "Registro eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Application.Exit();
            }
        }
        private void CompareConfirmationCode(object sender, EventArgs e)
        {
            if (confirmationCode == frmEmailVerification.txtConfirmationCode.Texts.Trim())
            {
                MessageBox.Show("Correo confirmado de manera exitosa. Registro de primer usuario finalizado exitosamente. De nuevo, ¡bienvenid@ a HealthPortal!", "Correo confirmado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                frmEmailVerification.Hide();
                frmEmailVerification.Dispose();
                FrmLogin objLogin = new FrmLogin();
                objLogin.Show();
            }
            else
            {
                MessageBox.Show("El código de confirmación ingresado no coincide con el que ha sido enviado a su correo. Asegúrese de haberlo ingresado de manera correcta y vuelva a intentarlo.", "Código incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
