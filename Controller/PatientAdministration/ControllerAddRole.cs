using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HealthPortal.Helper;
using HealthPortal.Model.DAO;
using HealthPortal.View.InventoryAdministration;
using HealthPortal.View.PatientAdministration;

namespace HealthPortal.Controller.PatientAdministration
{
    internal class ControllerAddRole
    {
        FrmAddRole objRole;

        int action;

        public ControllerAddRole(FrmAddRole view, int action)
        {
            objRole = view;
            this.action = action;
            objRole.btnExitE.Click += new EventHandler(CloseForm);
            objRole.btnAddRole.Click += new EventHandler(AddRole);
        }
        public ControllerAddRole(FrmAddRole view, int action, int id, string role)
        {
            objRole = view;
            this.action = action;
            Checkaction();
            ChargeValues(id, role);
            objRole.btnUpdateRole.Click += new EventHandler(UpdateRole);
            objRole.btnExitE.Click += new EventHandler(CloseForm);

        }

        private void ChargeValues(int id, string role)
        {
            objRole.txtRole.Texts = role;
            objRole.txtID.Text = id.ToString();
        }

        private void UpdateRole(object sender, EventArgs e)
        {
            DAOPatientAdministration dao = new DAOPatientAdministration();
            dao.AddRole = objRole.txtRole.Texts.Trim();
            dao.Role = int.Parse(objRole.txtID.Text.Trim());
            if (string.IsNullOrEmpty(objRole.txtRole.Texts))
            {
                MessageBox.Show("Favor rellenar el campo vacio", "Error de inserción", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int returnedValue = dao.UpdateRole();
                if (returnedValue == 1)
                {
                    MessageBox.Show("Los datos se han ingresado correctamente", "Proceso exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    objRole.Close();
                }
                else
                {
                    MessageBox.Show("No se pudieron ingresar los datos", "Procedimiento interrumpido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public void Checkaction()
        {
            if (action == 1)
            {
                objRole.btnAddRole.Enabled = false;
                objRole.btnUpdateRole.Enabled = true;
            }
            else if (action == 2)
            {

                objRole.btnAddRole.Visible = false;
                objRole.btnUpdateRole.Visible = true;
                objRole.lblRole.Text = "Actualizar Rol";
            }
        }


        private void AddRole(object sender, EventArgs e)
        {
            DAOPatientAdministration dao = new DAOPatientAdministration();
            dao.AddRole = objRole.txtRole.Texts.Trim();
            if (string.IsNullOrEmpty(objRole.txtRole.Texts))
            {
                MessageBox.Show("Favor rellenar el campo vacio", "Error de inserción", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int returnedValue = dao.RegisterRole();
                if (returnedValue == 1)
                {
                    MessageBox.Show("Los datos se han ingresado correctamente", "Proceso exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (MessageBox.Show("Desea continuar con la inserción?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        objRole.txtRole.Clear();
                    }
                    else
                    {
                        objRole.Close();
                    }
                }
                else
                {
                    MessageBox.Show("No se pudieron ingresar los datos", "Procedimiento interrumpido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }
        private void CloseForm(object sender, EventArgs e)
        {
            objRole.Dispose();
        }
    }
}
