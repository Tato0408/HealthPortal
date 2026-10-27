using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HealthPortal.Model.DAO;
using HealthPortal.View.InventoryAdministration;
using HealthPortal.View.PatientAdministration;

namespace HealthPortal.Controller.PatientAdministration
{
    internal class ControllerAdminRol
    {
        FrmAdminRol frmAdminRol;



        public ControllerAdminRol(FrmAdminRol view)
        {
            frmAdminRol = view;
            frmAdminRol.Load += new EventHandler(LoadData);
            frmAdminRol.btnAddRol.Click += new EventHandler(AddRole);
            frmAdminRol.btnExitRoleAdministration.Click += new EventHandler(CloseForm);
            frmAdminRol.cmsRole.Click += new EventHandler(UpdateRole);
        }

        private void LoadData(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void RefreshData()
        {
            DAOPatientAdministration daoRole = new DAOPatientAdministration();
            DataSet ds = daoRole.GetRole();
            frmAdminRol.dgvRol.DataSource = ds.Tables["tbTipoPersona"];
        }

        private void AddRole(object sender, EventArgs e)
        {
            FrmAddRole openform = new FrmAddRole(1);
            openform.ShowDialog();
            RefreshData();
        }
        private void UpdateRole(object sender, EventArgs e)
        {
            if (frmAdminRol.dgvRol.Rows.Count == 0)
            {
                MessageBox.Show("No existe ninun dato el cual actualizar", "Error de actualización", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int pos = frmAdminRol.dgvRol.CurrentRow.Index;
                int id;
                string Role;
                id = int.Parse(frmAdminRol.dgvRol[0, pos].Value.ToString());
                Role = frmAdminRol.dgvRol[1, pos].Value.ToString();
                FrmAddRole openForm = new FrmAddRole(2, id, Role);
                openForm.ShowDialog();
                RefreshData();
            }
        }
        private void CloseForm(object sender, EventArgs e)
        {
            frmAdminRol.Dispose();
        }
    }
}
