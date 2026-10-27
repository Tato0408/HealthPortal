using CustomControls;
using HealthPortal.Controller.Dashboard;
using HealthPortal.Helper;
using HealthPortal.Model.DAO;
using HealthPortal.Properties;
using HealthPortal.View.InventoryAdministration;
using HealthPortal.View.MainPage;
using HealthPortal.View.PasswordManagement;
using HealthPortal.View.Reports.User;
using HealthPortal.View.UserAdministration;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HealthPortal.Controller.UserAdministration
{
    internal class ControllerUserAdministration
    {
        FrmUserAdministration frmUserAdministration;
        private Dictionary<string, Tuple<Bitmap, Bitmap>> imageMapping;
        public ControllerUserAdministration(FrmUserAdministration view)
        {
            frmUserAdministration = view;
            frmUserAdministration.Load += new EventHandler(LoadData);
            frmUserAdministration.Load += new EventHandler(VerifyAccessLevel);

            // frmUserAdministration.btnFilter.Click += new EventHandler(SortData);

            frmUserAdministration.btnSearchForUser.Click += new EventHandler(SearchDatabase);
            frmUserAdministration.btnAddNewUser.Click += new EventHandler(AddUser);
            frmUserAdministration.cmsUpdateUserInfo.Click += new EventHandler(UpdateUser);
            frmUserAdministration.cmsDeleteUser.Click += new EventHandler(DeleteUser);
            frmUserAdministration.cmsViewUserInfo.Click += new EventHandler(ViewUser);
            //frmUserAdministration.btnReport.Click += new EventHandler(openReport);

            frmUserAdministration.cmsReestablishPassword.Click += new EventHandler(ChangeUserPassword);

            frmUserAdministration.btnAddNewUser.MouseEnter += new EventHandler(MouseEnterTextButton);
            frmUserAdministration.btnSearchForUser.MouseEnter += new EventHandler(MouseEnterTextButton);

            frmUserAdministration.btnAddNewUser.MouseLeave += new EventHandler(MouseLeaveTextButton);
            frmUserAdministration.btnSearchForUser.MouseLeave += new EventHandler(MouseLeaveTextButton);

            frmUserAdministration.txtUserAdministrationSearch.KeyPress += new KeyPressEventHandler(CommonMethods.TextBoxKeyPress);

            imageMapping = new Dictionary<string, Tuple<Bitmap, Bitmap>>()
            {
                { "btnExit", Tuple.Create(Resources.quit, Resources.hoverQuit) },
                { "btnResize", Tuple.Create(Resources.resize, Resources.hoverResize) }
            };

            frmUserAdministration.btnExit.MouseEnter += new EventHandler(MouseEnterPictureButton);
            frmUserAdministration.btnResize.MouseEnter += new EventHandler(MouseEnterPictureButton);
            frmUserAdministration.btnExit.MouseLeave += new EventHandler(MouseLeavePictureButton);
            frmUserAdministration.btnResize.MouseLeave += new EventHandler(MouseLeavePictureButton);
            frmUserAdministration.btnExit.Click += new EventHandler(CloseForm);
            frmUserAdministration.btnResize.Click += new EventHandler(ControllerDashboard.ToggleFullScreen);
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
        private void LoadData(object sender, EventArgs e)
        {
            ReloadData();
        }
        private void ReloadData()
        {
            DAOUserAdministration dao = new DAOUserAdministration();
            DataSet ds = dao.GetUserInfo();
            frmUserAdministration.dgvUserDisplay.DataSource = ds.Tables["viewPersonas"];
            SetDataGridViewColumnSize();
        }
        private void VerifyAccessLevel(object sender, EventArgs e)
        {
            if (CurrentUserData.RoleId == 1)
            {
                frmUserAdministration.cmsReestablishPassword.Enabled = true;
            }
            else
            {
                frmUserAdministration.cmsReestablishPassword.Enabled = false;
            }
        }

        private void openReport(object sebder, EventArgs e)
        {
            FrmViewGeneralUsers open = new FrmViewGeneralUsers();
            open.ShowDialog();
        }
        private void SearchDatabase(object sender, EventArgs e)
        {
            DAOUserAdministration dao = new DAOUserAdministration();
            string search = frmUserAdministration.txtUserAdministrationSearch.Texts.Trim();
            DataSet ds = dao.SearchDesiredUserInfo(search);
            frmUserAdministration.dgvUserDisplay.DataSource = ds.Tables["viewPersonas"];
            SetDataGridViewColumnSize();
        }
        private void AddUser(object sender, EventArgs e)
        {
            FrmAddUpdateUser frmAddUpdateUser = new FrmAddUpdateUser(1);
            frmAddUpdateUser.ShowDialog();
            ReloadData();
        }
        private void UpdateUser(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Seguro que desea actualizar los datos del usuario?", "Actualización de Datos", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                int position = frmUserAdministration.dgvUserDisplay.CurrentRow.Index;
                int personID = int.Parse(frmUserAdministration.dgvUserDisplay[0, position].Value.ToString());
                string firstName = frmUserAdministration.dgvUserDisplay[1, position].Value.ToString();
                string lastName = frmUserAdministration.dgvUserDisplay[2, position].Value.ToString();
                string email = frmUserAdministration.dgvUserDisplay[3, position].Value.ToString();
                string phoneNumber = frmUserAdministration.dgvUserDisplay[4, position].Value.ToString();
                string username = frmUserAdministration.dgvUserDisplay[5, position].Value.ToString();
                string role = frmUserAdministration.dgvUserDisplay[6, position].Value.ToString();

                FrmAddUpdateUser frmAddUpdateUser = new FrmAddUpdateUser(2, personID, firstName, lastName, email, phoneNumber, username, role);
                frmAddUpdateUser.ShowDialog();
                ReloadData();
            }
        }
        private void ViewUser(object sender, EventArgs e)
        {
            int position = frmUserAdministration.dgvUserDisplay.CurrentRow.Index;
            int personID = int.Parse(frmUserAdministration.dgvUserDisplay[0, position].Value.ToString());
            string firstName = frmUserAdministration.dgvUserDisplay[1, position].Value.ToString();
            string lastName = frmUserAdministration.dgvUserDisplay[2, position].Value.ToString();
            string email = frmUserAdministration.dgvUserDisplay[3, position].Value.ToString();
            string phoneNumber = frmUserAdministration.dgvUserDisplay[4, position].Value.ToString();
            string username = frmUserAdministration.dgvUserDisplay[5, position].Value.ToString();
            string role = frmUserAdministration.dgvUserDisplay[6, position].Value.ToString();

            FrmAddUpdateUser frmAddUpdateUser = new FrmAddUpdateUser(3, personID, firstName, lastName, email, phoneNumber, username, role);
            frmAddUpdateUser.ShowDialog();
        }
        private void DeleteUser(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Seguro que desea eliminar los datos del usuario? Esta acción no se puede deshacer.", "Eliminación de Datos", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                int position = frmUserAdministration.dgvUserDisplay.CurrentRow.Index;
                DAOUserAdministration dao = new DAOUserAdministration();
                dao.Username = frmUserAdministration.dgvUserDisplay[5, position].Value.ToString();
                dao.PersonId = int.Parse(frmUserAdministration.dgvUserDisplay[0, position].Value.ToString());
                if (dao.Username != CurrentUserData.Username && dao.PersonId != CurrentUserData.PersonID)
                {
                    if (dao.DeleteUser() == 2)
                    {
                        MessageBox.Show("Usuario eliminado.", "Acción completada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ReloadData();
                    }
                    else
                    {
                        MessageBox.Show("El usuario no pudo ser eliminado, verifique que el registro no tenga datos asociados.", "Acción interrumpida", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("No se puede eliminar a este usuario. Tenga en cuenta que no puede borrar su propio registro.", "Acción interrumpida", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void ChangeUserPassword(object sender, EventArgs e)
        {
            DAOUserAdministration dao = new DAOUserAdministration();
            int position = frmUserAdministration.dgvUserDisplay.CurrentRow.Index;
            dao.Username = frmUserAdministration.dgvUserDisplay[5, position].Value.ToString();
            string email = frmUserAdministration.dgvUserDisplay[3, position].Value.ToString();
            string temporaryPassword = CommonMethods.GenerateRandomPassword(8);
            dao.Password = CommonMethods.ComputeSha256Hash(temporaryPassword);
            CommonMethods.SendRecoveryEmail(temporaryPassword, email);
            dao.ReestablishUserPassword();
        }
        private void SetDataGridViewColumnSize()
        {
            frmUserAdministration.dgvUserDisplay.Columns[0].Width = 64;
        }
    }
}
