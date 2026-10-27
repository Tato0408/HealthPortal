using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CustomControls;
using HealthPortal.Helper;
using HealthPortal.Model.DAO;
using HealthPortal.View.PasswordManagement;
using HealthPortal.View.PatientAdministration;

namespace HealthPortal.Controller.PatientAdministration
{
    internal class ControllerPAsswordPatientDelete
    {
        FrmPasswordPatientDelete frmPasswordPatientDelete;
        int idPaciente;

        public ControllerPAsswordPatientDelete(FrmPasswordPatientDelete view, int idPaciente)
        {
            frmPasswordPatientDelete = view;
            this.idPaciente = idPaciente;
            frmPasswordPatientDelete.Load += new EventHandler(ShowPassword);
            frmPasswordPatientDelete.btnConfirmDeletePatient.Click += new EventHandler(ConfirmDelete);
            frmPasswordPatientDelete.btnHidePassword.Click += new EventHandler(ShowPassword);
            frmPasswordPatientDelete.btnShowPassword.Click += new EventHandler(HidePassword);
            frmPasswordPatientDelete.btnExit.Click += new EventHandler(CloseForm);
        }

        private void ConfirmDelete(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(frmPasswordPatientDelete.txtUsername.Texts.Trim()) || !string.IsNullOrEmpty(frmPasswordPatientDelete.txtPassword.Texts.Trim()) || frmPasswordPatientDelete.txtUsername.Texts.Trim() == "Usuario" || frmPasswordPatientDelete.txtPassword.Texts.Trim() == "Contraseña")
            {
               DAOPatientAdministration dao = new DAOPatientAdministration();
                dao.Username = frmPasswordPatientDelete.txtUsername.Texts.Trim();
                dao.Password = CommonMethods.ComputeSha256Hash(frmPasswordPatientDelete.txtPassword.Texts.Trim());
                if (dao.VerifyCredentials())
                {
                    MessageBox.Show("Credenciales correctas.", "Permiso de administrador aprobado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DAOPatientAdministration objDelPaciente = new DAOPatientAdministration();
                    objDelPaciente.IdPatient = idPaciente;
                    if (objDelPaciente.DeletePatient() > 0)
                    {
                        MessageBox.Show("Paciente eliminado con exito", "Acción completada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        frmPasswordPatientDelete.Dispose();
                    }
                    else
                    {
                        MessageBox.Show("Paciente no pudo ser eliminado.", "Acción incompleta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Los datos ingresados no son correctos.", "Proceso finalizado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                   
                    
                }
                
            }
            else
            {
                MessageBox.Show("Los datos ingresados no son correctos.", "Proceso finalizado", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void ShowPassword(object sender, EventArgs e)
        {
           frmPasswordPatientDelete.txtPassword.PasswordChar = false;
           frmPasswordPatientDelete.btnHidePassword.Visible = false;
            frmPasswordPatientDelete.btnShowPassword.Visible = true;
        }
        private void HidePassword(object sender, EventArgs e)
        {
            if (!frmPasswordPatientDelete.txtPassword.Texts.Trim().Equals("Contraseña"))
            {
                frmPasswordPatientDelete.txtPassword.PasswordChar = true;
                frmPasswordPatientDelete.btnShowPassword.Visible = false;
                frmPasswordPatientDelete.btnHidePassword.Visible = true;
            }
        }

        private void CloseForm(object sender, EventArgs e)
        {
            frmPasswordPatientDelete.Hide();
            frmPasswordPatientDelete.Dispose();
        }

    }
}
