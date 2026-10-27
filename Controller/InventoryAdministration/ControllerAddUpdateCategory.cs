using HealthPortal.Helper;
using HealthPortal.Model.DAO;
using HealthPortal.View.InventoryAdministration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HealthPortal.Controller.InventoryAdministration
{
    internal class ControllerAddUpdateCategory
    {
        FrmAddUpdateCategory frmAddUpdateCategory;
        private int action;
        public ControllerAddUpdateCategory(FrmAddUpdateCategory view, int action)
        {
            frmAddUpdateCategory = view;
            this.action = action;
            Checkaction();
            frmAddUpdateCategory.btnAdd.Click += new EventHandler(AddNewCategory);
            frmAddUpdateCategory.btnExitAddUpdateCategory.Click += new EventHandler(CloseForm);
            frmAddUpdateCategory.txtMedicineCategory.KeyPress += new KeyPressEventHandler(CommonMethods.TextBoxKeyPress);
        }
        public ControllerAddUpdateCategory(FrmAddUpdateCategory view, int action, int id, string medicineCategory)
        {
            frmAddUpdateCategory = view;
            this.action = action;
            Checkaction();
            ChargeValues(id, medicineCategory);
            frmAddUpdateCategory.btnUpdate.Click += new EventHandler(UpdateCategory);
            frmAddUpdateCategory.btnExitAddUpdateCategory.Click += new EventHandler(CloseForm);
            frmAddUpdateCategory.txtMedicineCategory.KeyPress += new KeyPressEventHandler(CommonMethods.TextBoxKeyPress);
        }

        public void AddNewCategory(object sender, EventArgs e)
        {
            DAOInventoryAdministration dao = new DAOInventoryAdministration();
            dao.CategoriaMedicamento = frmAddUpdateCategory.txtMedicineCategory.Texts.Trim();
            if (string.IsNullOrEmpty(frmAddUpdateCategory.txtMedicineCategory.Texts))
            {
                MessageBox.Show("Favor rellenar el campo vacio", "Error de inserción", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int returnedValue = dao.RegisterCategory();
                if (returnedValue == 1)
                {
                    MessageBox.Show("Los datos se han ingresado correctamente", "Proceso exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (MessageBox.Show("Desea continuar con la inserción?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        frmAddUpdateCategory.Close();
                        FrmAddUpdateCategory openForm = new FrmAddUpdateCategory(1);
                        openForm.ShowDialog();

                    }
                    else
                    {
                        frmAddUpdateCategory.Close();
                    }
                }
                else
                {
                    MessageBox.Show("No se pudieron ingresar los datos", "Procedimiento interrumpido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void UpdateCategory(object sender, EventArgs e)
        {
            DAOInventoryAdministration dao = new DAOInventoryAdministration();
            dao.CategoriaMedicamento = frmAddUpdateCategory.txtMedicineCategory.Texts.Trim();
            dao.IdCategoria = int.Parse(frmAddUpdateCategory.txtID.Text.Trim());
            if (string.IsNullOrEmpty(frmAddUpdateCategory.txtMedicineCategory.Texts))
            {
                MessageBox.Show("Favor rellenar el campo vacio", "Error de inserción", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int returnedValue = dao.UpdateCategory();
                if (returnedValue == 1)
                {
                    MessageBox.Show("Los datos se han ingresado correctamente", "Proceso exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    frmAddUpdateCategory.Close();
                }
                else
                {
                    MessageBox.Show("No se pudieron ingresar los datos", "Procedimiento interrumpido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void CloseForm(object sender, EventArgs e)
        {
            frmAddUpdateCategory.Dispose();
        }

        private void ChargeValues(int id, string medicineCategory)
        {
            frmAddUpdateCategory.txtID.Text = id.ToString();
            frmAddUpdateCategory.txtMedicineCategory.Texts = medicineCategory;
        }

        public void Checkaction()
        {
            if (action == 1)
            {
                frmAddUpdateCategory.btnAdd.Visible = true;
                frmAddUpdateCategory.btnUpdate.Visible = false;
            }
            else if (action == 2)
            {

                frmAddUpdateCategory.btnAdd.Visible = false;
                frmAddUpdateCategory.btnUpdate.Visible = true;
                frmAddUpdateCategory.lblTitle.Text = "Actualizar Categoría";
            }
        }
    }
}
