using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CustomControls;
using HealthPortal.Controller.Dashboard;
using HealthPortal.Helper;
using HealthPortal.Model.DAO;
using HealthPortal.Model.DTO;
using HealthPortal.Properties;
using HealthPortal.View.InventoryAdministration;
using HealthPortal.View.Reports.Inventory;
using HealthPortal.View.Reports.Inventory.DataSetInfoInventoryTableAdapters;
using HealthPortal.View.Reports.Inventory.DataSetInfoInstitutionTableAdapters;
using HealthPortal.View.MainPage;
using HealthPortal.View.PatientAdministration;
using HealthPortal.View.SectionAdministration;
using HealthPortal.View.PasswordManagement;
using System.Windows.Forms.DataVisualization.Charting;

namespace HealthPortal.Controller.InventoryAdministration
{
    internal class ControllerInventoryAdministration
    {
        FrmInventoryAdministration frmInventoryAdministration;
        private Dictionary<string, Tuple<Bitmap, Bitmap>> imageMapping;

        public ControllerInventoryAdministration(FrmInventoryAdministration vista)
        {
            frmInventoryAdministration = vista;
            frmInventoryAdministration.Load += new EventHandler(LoadDataGridView);
            //Evento click del boton
            frmInventoryAdministration.btnNew.Click += new EventHandler(NewMedicineInventory);
            frmInventoryAdministration.cmsUpdate.Click += new EventHandler(UpdateMedicineInventory);
            frmInventoryAdministration.cmsDelete.Click += new EventHandler(DeleteMedicineInventory);
            frmInventoryAdministration.cmsView.Click += new EventHandler(ViewMedicineInventory);
            frmInventoryAdministration.btnSearch.Click += new EventHandler(SearchMedicineInventory);
            frmInventoryAdministration.btnOpenCategoryAdministration.Click += new EventHandler(openCategoryAdministration);
            frmInventoryAdministration.btnPrintGeneralReport.Click += new EventHandler(OpenReport);
            //frmInventoryAdministration.btnPrintReport.Click += new EventHandler(ReportInventary);

            imageMapping = new Dictionary<string, Tuple<Bitmap, Bitmap>>()
            {
                { "btnExit", Tuple.Create(Resources.quit, Resources.hoverQuit) },
                { "btnResize", Tuple.Create(Resources.resize, Resources.hoverResize) }
            };

            frmInventoryAdministration.llbUsageIndex.Click += new EventHandler(OpenUsageIndexForm);
            frmInventoryAdministration.btnExit.MouseEnter += new EventHandler(MouseEnterPictureButton);
            frmInventoryAdministration.btnResize.MouseEnter += new EventHandler(MouseEnterPictureButton);
            frmInventoryAdministration.btnExit.MouseLeave += new EventHandler(MouseLeavePictureButton);
            frmInventoryAdministration.btnResize.MouseLeave += new EventHandler(MouseLeavePictureButton);
            frmInventoryAdministration.btnExit.Click += new EventHandler(CloseForm);
            frmInventoryAdministration.btnResize.Click += new EventHandler(ControllerDashboard.ToggleFullScreen);

            frmInventoryAdministration.btnFilter.MouseEnter += new EventHandler(MouseEnterTextButton);
            frmInventoryAdministration.btnNew.MouseEnter += new EventHandler(MouseEnterTextButton);
            frmInventoryAdministration.btnSearch.MouseEnter += new EventHandler(MouseEnterTextButton);

            frmInventoryAdministration.btnFilter.MouseLeave += new EventHandler(MouseLeaveTextButton);
            frmInventoryAdministration.btnNew.MouseLeave += new EventHandler(MouseLeaveTextButton);
            frmInventoryAdministration.btnSearch.MouseLeave += new EventHandler(MouseLeaveTextButton);

            frmInventoryAdministration.txtSearch.KeyPress += new KeyPressEventHandler(CommonMethods.TextBoxKeyPress);
        }
        private void OpenUsageIndexForm(object sender, EventArgs e)
        {
            FrmUsageIndex frmUsageIndex = new FrmUsageIndex();
            frmUsageIndex.ShowDialog();
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
        private void CloseForm(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea cerrar el programa directamente? Considere que se cerrará la sesión de manera automática", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                CommonMethods.DisposeOfCurrentUserData();
                Environment.Exit(0);
            }
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
        private void LoadDataGridView(object sender, EventArgs e)
        {
            LoadData();
        }
        private void LoadData()
        {
            DAOInventoryAdministration dao = new DAOInventoryAdministration();

            //Declarando nuevo DataSet para que obtenga los datos del metodo LlenarCombosInventario
            DataSet ds = dao.FillCombo();
            //Llenar comboBox de la tabla tbCategoriaMedicamento
            frmInventoryAdministration.cmbCategory.DataSource = ds.Tables["tbCategoriaMedicamento"];
            frmInventoryAdministration.cmbCategory.ValueMember = "idCategoriaMedicamento";
            frmInventoryAdministration.cmbCategory.DisplayMember = "categoriaMedicamento";
            RefreshData();
        }
        private void ChargeValuesFromDataGrid()
        {
            if (frmInventoryAdministration.dgvInventory.Rows.Count > 0)
            {
                frmInventoryAdministration.cmsDataGrid.Enabled = true;
            }
            else
            {
                frmInventoryAdministration.cmsDataGrid.Enabled = false;
            }
            
        }
        private void RefreshData()
        {
            //Objeto de la clase DAOAdminInventory
            DAOInventoryAdministration dao = new DAOInventoryAdministration();
            //Declarando DataSet para que obtenga los datos del metodo GetInventory
            DataSet ds = dao.GetInventory();
            //Llenar DataGridView
            frmInventoryAdministration.dgvInventory.DataSource = ds.Tables["viewInventario"];
            frmInventoryAdministration.dgvInventory.Columns[0].Width = 80;
            frmInventoryAdministration.dgvInventory.Columns[1].Width = 80;
            frmInventoryAdministration.dgvInventory.Columns[2].Width = 80;
            frmInventoryAdministration.dgvInventory.Columns[3].Width = 80;
            frmInventoryAdministration.dgvInventory.Columns[4].Width = 80;
            frmInventoryAdministration.dgvInventory.Columns[5].Width = 80;
            frmInventoryAdministration.dgvInventory.Columns[6].Width = 80;
            frmInventoryAdministration.dgvInventory.Columns[7].Width = 80;
            frmInventoryAdministration.dgvInventory.Columns[8].Width = 80;
            frmInventoryAdministration.dgvInventory.Columns[9].Visible = false;
            ChargeValuesFromDataGrid();
        }
        private void NewMedicineInventory(object sender, EventArgs e)
        {
            FrmAddUpdateMedicine openForm = new FrmAddUpdateMedicine(1);
            openForm.ShowDialog();
            LoadData();
            RefreshData();
        }

        private void UpdateMedicineInventory(object sender, EventArgs e)
        {
            if (frmInventoryAdministration.dgvInventory.Rows.Count == 0)
            {
                MessageBox.Show("No existe ninun dato el cual actualizar", "Error de actualización", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int pos = frmInventoryAdministration.dgvInventory.CurrentRow.Index;
                int id, idEntry;
                string nameMedicine, categoryMedicine, stock, stockPack, description;
                DateTime expirationDate, income, exit;
                id = int.Parse(frmInventoryAdministration.dgvInventory[0, pos].Value.ToString());
                nameMedicine = frmInventoryAdministration.dgvInventory[1, pos].Value.ToString();
                description = frmInventoryAdministration.dgvInventory[2, pos].Value.ToString();
                categoryMedicine = frmInventoryAdministration.dgvInventory[3, pos].Value.ToString();
                expirationDate = DateTime.Parse(frmInventoryAdministration.dgvInventory[4, pos].Value.ToString());
                income = DateTime.Parse(frmInventoryAdministration.dgvInventory[5, pos].Value.ToString());
                exit = DateTime.Parse(frmInventoryAdministration.dgvInventory[6, pos].Value.ToString());
                stock = frmInventoryAdministration.dgvInventory[7, pos].Value.ToString();
                stockPack = frmInventoryAdministration.dgvInventory[8, pos].Value.ToString();
                idEntry = int.Parse(frmInventoryAdministration.dgvInventory[9, pos].Value.ToString());


                FrmAddUpdateMedicine openForm = new FrmAddUpdateMedicine(2, id, nameMedicine, categoryMedicine, expirationDate, stock, stockPack, income, exit, description);
                openForm.ShowDialog();
                RefreshData();
            }
        }
        private void DeleteMedicineInventory(object sender, EventArgs e)
        {
            if (frmInventoryAdministration.dgvInventory.Rows.Count == 0)
            {
                MessageBox.Show("No existe ninun dato el cual eliminar", "Error de eliminación", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int pos = frmInventoryAdministration.dgvInventory.CurrentRow.Index;
                if ((MessageBox.Show($"¿Está seguro que desea eliminar al medicamento {frmInventoryAdministration.dgvInventory[1, pos].Value.ToString()}? Considere que dicha acción no se podrá revertir.", "Confirmar acción", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
                {
                    DAOInventoryAdministration dao = new DAOInventoryAdministration();
                    dao.IdMedicamento = int.Parse(frmInventoryAdministration.dgvInventory[0, pos].Value.ToString());
                    dao.IdEntradaSalida = int.Parse(frmInventoryAdministration.dgvInventory[9, pos].Value.ToString());
                    int returnedValue = dao.DeleteInventory();
                    if (returnedValue > 0)
                    {
                        MessageBox.Show("Registro eliminado", "Acción completada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Registro no pudo ser eliminado, verifique que el registro no tenga datos asociados.", "Acción interrumpida", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    RefreshData();
                }
            }
        }
        private void SearchMedicineInventory(object sender, EventArgs e)
        {
            DAOInventoryAdministration dao = new DAOInventoryAdministration();
            string search = frmInventoryAdministration.txtSearch.Texts.Trim();
            DataSet ds = dao.SearchMedicineInventory(search);
            frmInventoryAdministration.dgvInventory.DataSource = ds.Tables["viewInventario"];
        }
        private void ViewMedicineInventory(object sender, EventArgs e)
        {
            if (frmInventoryAdministration.dgvInventory.Rows.Count == 0)
            {
                MessageBox.Show("No existe ninguna ficha la cula pueda visualizarse", "Error de visualización", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int pos = frmInventoryAdministration.dgvInventory.CurrentRow.Index;
                int id;
                string nameMedicine, categoryMedicine, stock, stockPack, description;
                DateTime expirationDate, income, exit;
                id = int.Parse(frmInventoryAdministration.dgvInventory[0, pos].Value.ToString());
                nameMedicine = frmInventoryAdministration.dgvInventory[1, pos].Value.ToString();
                description = frmInventoryAdministration.dgvInventory[2, pos].Value.ToString();
                categoryMedicine = frmInventoryAdministration.dgvInventory[3, pos].Value.ToString();
                expirationDate = DateTime.Parse(frmInventoryAdministration.dgvInventory[4, pos].Value.ToString());
                income = DateTime.Parse(frmInventoryAdministration.dgvInventory[5, pos].Value.ToString());
                exit = DateTime.Parse(frmInventoryAdministration.dgvInventory[6, pos].Value.ToString());
                stock = frmInventoryAdministration.dgvInventory[7, pos].Value.ToString();
                stockPack = frmInventoryAdministration.dgvInventory[8, pos].Value.ToString();


                FrmAddUpdateMedicine openForm = new FrmAddUpdateMedicine(3, id, nameMedicine, categoryMedicine, expirationDate, stock, stockPack, income, exit, description);
                openForm.ShowDialog();
                RefreshData();
            }
        }
        private void openCategoryAdministration(object sender, EventArgs e)
        {
            FrmCategoryAdministration open = new FrmCategoryAdministration();
            open.ShowDialog();
            LoadData();
        }
        private void OpenReport(object sender, EventArgs e)
        {
            FrmViewGeneralInventory open = new FrmViewGeneralInventory();
            open.ShowDialog();
            LoadData();
        }
    }
}