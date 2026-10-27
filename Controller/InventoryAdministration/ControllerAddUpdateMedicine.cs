using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using HealthPortal.Model.DAO;
using HealthPortal.View.InventoryAdministration;
using System.Collections.Specialized;
using System.Drawing;
using System.IO;
using System.Windows.Forms.DataVisualization.Charting;
using HealthPortal.Helper;
using HealthPortal.Properties;

namespace HealthPortal.Controller.InventoryAdministration
{
    internal class ControllerAddUpdateMedicine
    {
        FrmAddUpdateMedicine frmAddUpdateMedicine;
        private int action;
        private string medicineCategory;

        private Dictionary<string, Tuple<Bitmap, Bitmap>> imageMapping;

        /// <summary>
        /// Constructor para la inserción de medicamentos
        /// </summary>
        /// <param name="view"></param>
        /// <param name="accion"></param>
        public ControllerAddUpdateMedicine(FrmAddUpdateMedicine view, int action)
        {
            frmAddUpdateMedicine = view;

            imageMapping = new Dictionary<string, Tuple<Bitmap, Bitmap>>()
            {
                { "btnExit", Tuple.Create(Resources.quit, Resources.hoverQuit) }
            };

            this.action = action;
            frmAddUpdateMedicine.Load += new EventHandler(InitialLoad);

            //Metodos que se ejecutan cuando el programa esta cargando
            CheckAction();

            //Metodos que se ejecutan al ocurrir eventos
            frmAddUpdateMedicine.btnAddInventory.Click += new EventHandler(RegisterNewMedicine);
            frmAddUpdateMedicine.btnAddImage.Click += new EventHandler(AddImage);

            frmAddUpdateMedicine.txtMedicineName.KeyPress += new KeyPressEventHandler(CommonMethods.TextBoxKeyPress);
            frmAddUpdateMedicine.txtDescription.KeyPress += new KeyPressEventHandler(CommonMethods.TextBoxKeyPress);

            frmAddUpdateMedicine.btnExit.MouseEnter += new EventHandler(MouseEnterPictureButton);
            frmAddUpdateMedicine.btnExit.MouseLeave += new EventHandler(MouseLeavePictureButton);

            frmAddUpdateMedicine.btnExit.Click += new EventHandler(CloseForm);

            frmAddUpdateMedicine.btnAddCategory.Click += new EventHandler(AddCategory);

            frmAddUpdateMedicine.numStock.KeyPress += new KeyPressEventHandler(NumUpDownKeyPress);
            frmAddUpdateMedicine.numStockPack.KeyPress += new KeyPressEventHandler(NumUpDownKeyPress);
        }
        public ControllerAddUpdateMedicine(FrmAddUpdateMedicine view, int action, int id, string medicineName, string medicineCategory, DateTime expirationDate, string stock, string stockPack, DateTime entryDate, DateTime exit, string description)
        {
            //Acciones iniciales
            frmAddUpdateMedicine = view;

            imageMapping = new Dictionary<string, Tuple<Bitmap, Bitmap>>()
            {
                { "btnExit", Tuple.Create(Resources.quit, Resources.hoverQuit) }
            };

            this.action = action;
            this.medicineCategory = medicineCategory;
            //Metodos iniciales ejecutados cuando el formulario esta cargando
            frmAddUpdateMedicine.Load += new EventHandler(InitialLoad);
            CheckAction();
            ChargeValues(id, medicineName, medicineCategory, expirationDate, stock, stockPack, entryDate, exit, description);

            //Metodos que se ejecutan al ocurrir eventos
            frmAddUpdateMedicine.btnUpdateInventory.Click += new EventHandler(UpdateInventory);
            frmAddUpdateMedicine.btnAddImage.Click += new EventHandler(AddImage);

            frmAddUpdateMedicine.txtMedicineName.KeyPress += new KeyPressEventHandler(CommonMethods.TextBoxKeyPress);
            frmAddUpdateMedicine.txtDescription.KeyPress += new KeyPressEventHandler(CommonMethods.TextBoxKeyPress);

            frmAddUpdateMedicine.btnExit.MouseEnter += new EventHandler(MouseEnterPictureButton);
            frmAddUpdateMedicine.btnExit.MouseLeave += new EventHandler(MouseLeavePictureButton);

            frmAddUpdateMedicine.btnExit.Click += new EventHandler(CloseForm);

            frmAddUpdateMedicine.numStock.KeyPress += new KeyPressEventHandler(NumUpDownKeyPress);
            frmAddUpdateMedicine.numStockPack.KeyPress += new KeyPressEventHandler(NumUpDownKeyPress);
        }
        private void NumUpDownKeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
        private void CloseForm(object sender, EventArgs e)
        {
            frmAddUpdateMedicine.Dispose();
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
        private void AddImage(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "archivos de imagenes (*. png; *.jpg)| *.png ; *jpg";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                frmAddUpdateMedicine.picImage.Image = Image.FromFile(ofd.FileName);
                frmAddUpdateMedicine.picImage.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }
        public void InitialLoad(object sender, EventArgs e)
        {
            CommonMethods.EnableFormDrag(frmAddUpdateMedicine, frmAddUpdateMedicine);
            //Objeto de la clase DAOAdminInventory
            DAOInventoryAdministration dao = new DAOInventoryAdministration();

            //Declarando nuevo DataSet para que obtenga los datos del metodo LlenarCombosInventario
            DataSet ds = dao.FillCombo();
            //Llenar comboBox de la tabla tbCategoriaMedicamento
            DateTime januaryFirst = new DateTime(DateTime.Now.Year, 1, 1);
            frmAddUpdateMedicine.cmbCategory.DataSource = ds.Tables["tbCategoriaMedicamento"];
            frmAddUpdateMedicine.cmbCategory.ValueMember = "idCategoriaMedicamento";
            frmAddUpdateMedicine.cmbCategory.DisplayMember = "categoriaMedicamento";
            frmAddUpdateMedicine.cmbCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            frmAddUpdateMedicine.dtpEntryDate.MinDate = januaryFirst;
            frmAddUpdateMedicine.dtpEntryDate.MaxDate = DateTime.Now;
            frmAddUpdateMedicine.dtpExpirationDate.Value = DateTime.Now.AddDays(31);
            frmAddUpdateMedicine.dtpExpirationDate.MinDate = DateTime.Now.AddDays(31);
            frmAddUpdateMedicine.dtpExpirationDate.MaxDate = DateTime.Now.AddYears(1);
            frmAddUpdateMedicine.dtpEntryTime.Enabled = false;

        }
        public void RegisterNewMedicine(object sender, EventArgs e)
        {
            DateTime date = DateTime.Today;
            DateTime expiration = date.AddDays(31);
            DateTime expirationEntry = date.AddDays(-31);
            DAOInventoryAdministration dao = new DAOInventoryAdministration();
            //Datos para la creacion de un nuevo inventario
            dao.NombreMedicamento = frmAddUpdateMedicine.txtMedicineName.Texts.Trim();
            dao.Descripcion = frmAddUpdateMedicine.txtDescription.Texts.Trim();
            dao.IdCategoria = int.Parse(frmAddUpdateMedicine.cmbCategory.SelectedValue.ToString());
            dao.FechaVencimiento = frmAddUpdateMedicine.dtpExpirationDate.Value.Date;
            dao.Existencia = int.Parse(frmAddUpdateMedicine.numStock.Text.Trim());
            dao.Envases = int.Parse(frmAddUpdateMedicine.numStockPack.Text.Trim());
            dao.Envases = int.Parse(frmAddUpdateMedicine.numStockPack.Text.Trim());
            dao.Ingreso = frmAddUpdateMedicine.dtpEntryDate.Value.Date;
            dao.Salida = frmAddUpdateMedicine.dtpEntryTime.Value.ToString("HH:mm");
            MemoryStream memoryStream = new MemoryStream();
            Image img = frmAddUpdateMedicine.picImage.Image;
            if (string.IsNullOrEmpty(frmAddUpdateMedicine.txtMedicineName.Texts) || frmAddUpdateMedicine.dtpExpirationDate.Value.Date <= expiration || frmAddUpdateMedicine.dtpEntryDate.Value < expirationEntry || int.Parse(frmAddUpdateMedicine.numStock.Text) <= 0 || frmAddUpdateMedicine.picImage.Image == null || int.Parse(frmAddUpdateMedicine.numStock.Text) <= 0 || frmAddUpdateMedicine.dtpEntryDate.Value > DateTime.Now)
            {
                MessageBox.Show("La fecha de vencimiento debe de ser de 31 días después de la fecha actual, la cantidad de medicamentos ingresados no es válida o hay campos vacíos dentro del formulario, favor revisar de nuevo el ingreso de datos para continuar la inserción", "Error de inserción", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                img.Save(memoryStream, img.RawFormat);
                dao.Imagen = memoryStream.ToArray();
                int returnedValue = dao.RegisterMedicine();
                if (returnedValue == 2)
                {
                    MessageBox.Show("Los datos han sido registrados exitosamente", "Proceso completado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (MessageBox.Show("Desea ingresar un nuevo medicamento?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        frmAddUpdateMedicine.Close();
                        FrmAddUpdateMedicine openForm = new FrmAddUpdateMedicine(1);
                        openForm.ShowDialog();
                    }
                    else
                    {
                        frmAddUpdateMedicine.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Los datos no pudieron ser registrados", "Proceso Interrumpido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }
        public void AddCategory(object sender, EventArgs e)
        {
            FrmCategoryAdministration openForm = new FrmCategoryAdministration();
            openForm.ShowDialog();
            FillComboBox();
        }

        public void FillComboBox()
        {
            DAOInventoryAdministration dao = new DAOInventoryAdministration();
            DataSet ds = dao.FillCombo();
            //Llenar comboBox de la tabla tbCategoriaMedicamento
            frmAddUpdateMedicine.cmbCategory.DataSource = ds.Tables["tbCategoriaMedicamento"];
            frmAddUpdateMedicine.cmbCategory.ValueMember = "idCategoriaMedicamento";
            frmAddUpdateMedicine.cmbCategory.DisplayMember = "categoriaMedicamento";
            frmAddUpdateMedicine.cmbCategory.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        public void UpdateInventory(object sender, EventArgs e)
        {
            DateTime date = DateTime.Today;
            DateTime expiration = date.AddDays(31);
            DateTime expirationEntry = date.AddDays(-31);
            DAOInventoryAdministration dao = new DAOInventoryAdministration();
            dao.IdMedicamento = int.Parse(frmAddUpdateMedicine.txtID.Text.Trim());
            MessageBox.Show($"{frmAddUpdateMedicine.txtID.Text}");
            dao.NombreMedicamento = frmAddUpdateMedicine.txtMedicineName.Texts.Trim();
            dao.IdCategoria = int.Parse(frmAddUpdateMedicine.cmbCategory.SelectedValue.ToString());
            dao.FechaVencimiento = frmAddUpdateMedicine.dtpExpirationDate.Value.Date;
            dao.Existencia = int.Parse(frmAddUpdateMedicine.numStock.Text.Trim());
            dao.Envases = int.Parse(frmAddUpdateMedicine.numStockPack.Text.Trim());
            dao.Ingreso = frmAddUpdateMedicine.dtpEntryDate.Value.Date;
            dao.Salida = frmAddUpdateMedicine.dtpEntryTime.Value.ToString("HH:mm");
            dao.Descripcion = frmAddUpdateMedicine.txtDescription.Texts.Trim();
            MemoryStream memoryStream = new MemoryStream();
            Image img = frmAddUpdateMedicine.picImage.Image;


            if (string.IsNullOrEmpty(frmAddUpdateMedicine.txtMedicineName.Texts) || frmAddUpdateMedicine.dtpExpirationDate.Value.Date <= expiration || frmAddUpdateMedicine.dtpEntryDate.Value < expirationEntry || int.Parse(frmAddUpdateMedicine.numStock.Text) <= 0 || frmAddUpdateMedicine.picImage.Image == null || int.Parse(frmAddUpdateMedicine.numStock.Text) <= 0 || frmAddUpdateMedicine.dtpEntryDate.Value > DateTime.Now)
            {
                MessageBox.Show("La fecha de vencimiento debe de ser de 31 días despues de la fecha actual, la cantidad de medicamentos ingresados no es válida o hay campos vacíos dentro del formulario, favor revisar de nuevo el ingreso de datos para continuar la actualización", "Error de actualización", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                img.Save(memoryStream, img.RawFormat);
                dao.Imagen = memoryStream.ToArray();
                int returnedValue = dao.UpdateInventory();
                if (returnedValue == 2)
                {
                    MessageBox.Show("Los datos han sido actualizado exitosamente",
                                    "Proceso completado",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                }
                else if (returnedValue == 1)
                {

                    MessageBox.Show("Los datos no pudieron ser actualizados completamente",
                                    "Proceso interrumpido",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("Los datos no pudieron ser actualizados debido a un error inesperado",
                                    "Proceso interrumpido",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                }
            }

        }

        public void ChargeValues(int id, string medicineName, string medicineCategory, DateTime expirationDate, string stock, string stockPack, DateTime entryDate, DateTime exit, string description)
        {
            DAOInventoryAdministration dao = new DAOInventoryAdministration();
            dao.IdMedicamento = id;
            MemoryStream memoryStream = new MemoryStream(dao.GetImageBytes());
            frmAddUpdateMedicine.txtID.Text = id.ToString();
            frmAddUpdateMedicine.txtMedicineName.Texts = medicineName;
            frmAddUpdateMedicine.cmbCategory.Text = medicineCategory;
            frmAddUpdateMedicine.dtpExpirationDate.Value = expirationDate;
            frmAddUpdateMedicine.numStock.Text = stock;
            frmAddUpdateMedicine.numStockPack.Text = stockPack;
            frmAddUpdateMedicine.dtpEntryDate.Value = entryDate;
            frmAddUpdateMedicine.dtpEntryTime.Value = exit;
            frmAddUpdateMedicine.txtDescription.Texts = description;
            frmAddUpdateMedicine.picImage.Image = Image.FromStream(memoryStream);
        }

        public void CheckAction()
        {
            if (action == 1)
            {
                frmAddUpdateMedicine.btnAddInventory.Enabled = true;
                frmAddUpdateMedicine.btnUpdateInventory.Enabled = false;
                frmAddUpdateMedicine.txtMedicineName.Text = "Nombre del Medicamento";
            }
            else if (action == 2)
            {
                frmAddUpdateMedicine.lblTitle.Text = "Actualización de Inventario";
                frmAddUpdateMedicine.btnAddInventory.Enabled = false;
                frmAddUpdateMedicine.btnUpdateInventory.Enabled = true;
                frmAddUpdateMedicine.btnAddCategory.Visible = false;
                frmAddUpdateMedicine.cmbCategory.Width = 335;
                frmAddUpdateMedicine.btnAddImage.Text = "Actualizar";
                frmAddUpdateMedicine.cmbCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            }
            else if (action == 3)
            {
                frmAddUpdateMedicine.lblTitle.Text = "Ficha de Inventario";
                frmAddUpdateMedicine.btnAddInventory.Visible = false;
                frmAddUpdateMedicine.btnUpdateInventory.Visible = false;
                frmAddUpdateMedicine.btnAddCategory.Visible = false;
                frmAddUpdateMedicine.txtID.Visible = false;
                frmAddUpdateMedicine.txtMedicineName.Enabled = false;
                frmAddUpdateMedicine.txtMedicineName.BackColor = Color.White;
                frmAddUpdateMedicine.txtDescription.Enabled = false;
                frmAddUpdateMedicine.txtDescription.BackColor = Color.White;
                frmAddUpdateMedicine.dtpExpirationDate.Enabled = false;
                frmAddUpdateMedicine.dtpExpirationDate.CalendarTitleBackColor = Color.White;
                frmAddUpdateMedicine.dtpEntryTime.Enabled = false;
                frmAddUpdateMedicine.dtpEntryTime.CalendarTitleBackColor = Color.White;
                frmAddUpdateMedicine.dtpEntryDate.Enabled = false;
                frmAddUpdateMedicine.dtpEntryDate.CalendarTitleBackColor = Color.White;
                frmAddUpdateMedicine.numStock.Enabled = false;
                frmAddUpdateMedicine.numStock.BackColor = Color.White;
                frmAddUpdateMedicine.numStockPack.Enabled = false;
                frmAddUpdateMedicine.numStockPack.BackColor = Color.White;
                frmAddUpdateMedicine.btnAddImage.Visible = false;
                frmAddUpdateMedicine.cmbCategory.Enabled = false;
                frmAddUpdateMedicine.cmbCategory.BackColor = Color.White;
                frmAddUpdateMedicine.cmbCategory.Width = 335;
            }
        }
    }
}