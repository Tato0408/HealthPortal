using HealthPortal.View.InventoryAdministration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HealthPortal.Model.DAO;
using System.Windows.Forms;

namespace HealthPortal.Controller.InventoryAdministration
{
    internal class ControllerCategoryAdministration
    {
        FrmCategoryAdministration frmCategoryAdministration;
        public ControllerCategoryAdministration(FrmCategoryAdministration view)
        {
            frmCategoryAdministration = view;
            frmCategoryAdministration.Load += new EventHandler(LoadData);
            frmCategoryAdministration.btnAddCategory.Click += new EventHandler(AddNewCategory);
            frmCategoryAdministration.cmsUpdateCategory.Click += new EventHandler(UpdateCategory);
            frmCategoryAdministration.btnExitCategoryAdministration.Click += new EventHandler(CloseForm);
        }
        private void AddNewCategory(object sender, EventArgs e)
        {
            FrmAddUpdateCategory openForm = new FrmAddUpdateCategory(1);
            openForm.ShowDialog();
            RefreshData();
        }

        private void UpdateCategory(object sender, EventArgs e)
        {
            if (frmCategoryAdministration.dgvCategory.Rows.Count == 0)
            {
                MessageBox.Show("No existe ninun dato el cual actualizar", "Error de actualización", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int pos = frmCategoryAdministration.dgvCategory.CurrentRow.Index;
                int id;
                string medicineCategory;
                id = int.Parse(frmCategoryAdministration.dgvCategory[0, pos].Value.ToString());
                medicineCategory = frmCategoryAdministration.dgvCategory[1, pos].Value.ToString();
                FrmAddUpdateCategory openForm = new FrmAddUpdateCategory(2, id, medicineCategory);
                openForm.ShowDialog();
                RefreshData();
            }
        }
        private void CloseForm(object sender, EventArgs e)
        {
            frmCategoryAdministration.Dispose();
        }

        private void LoadData(object sender, EventArgs e)
        {
            RefreshData();
        }
        private void RefreshData()
        {
            DAOInventoryAdministration daoCategory = new DAOInventoryAdministration();
            DataSet ds = daoCategory.GetCategory();
            frmCategoryAdministration.dgvCategory.DataSource = ds.Tables["tbCategoriaMedicamento"];
        }
    }
}
