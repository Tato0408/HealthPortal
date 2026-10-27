using HealthPortal.View.MainPage;
using HealthPortal.Model.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HealthPortal.Helper;
using HealthPortal.Properties;
using HealthPortal.View.InventoryAdministration;
using System.Drawing;
using System.Windows.Forms;
using HealthPortal.Controller.Dashboard;

namespace HealthPortal.Controller.MainPage
{
    internal class ControllerMainPage
    {
        FrmMainPage frmMainPage;
        private Dictionary<string, Tuple<Bitmap, Bitmap>> imageMapping;
        public ControllerMainPage(FrmMainPage view)
        {
            frmMainPage = view;
            frmMainPage.Load += new EventHandler(LoadInstitutionName);
            frmMainPage.timerDateTime.Tick += new EventHandler(Tick);

            imageMapping = new Dictionary<string, Tuple<Bitmap, Bitmap>>()
            {
                { "btnExit", Tuple.Create(Resources.quit, Resources.hoverQuit) },
                { "btnResize", Tuple.Create(Resources.resize, Resources.hoverResize) }
            };
            frmMainPage.btnExit.MouseEnter += new EventHandler(MouseEnterPictureButton);
            frmMainPage.btnResize.MouseEnter += new EventHandler(MouseEnterPictureButton);
            frmMainPage.btnExit.MouseLeave += new EventHandler(MouseLeavePictureButton);
            frmMainPage.btnResize.MouseLeave += new EventHandler(MouseLeavePictureButton);
            frmMainPage.btnExit.Click += new EventHandler(CloseForm);
            frmMainPage.btnResize.Click += new EventHandler(ControllerDashboard.ToggleFullScreen);
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
        private void LoadInstitutionName(object sender, EventArgs e)
        {
            DAOMainPage dao = new DAOMainPage();
            frmMainPage.lblTitle.Text = $"Página Principal - {dao.GetInstitutionName()}";
        }
        private void Tick(object sender, EventArgs e)
        {
            frmMainPage.lblTime.Text = DateTime.Now.ToLongTimeString();
            frmMainPage.lblDate.Text = DateTime.Now.ToLongDateString();
        }
    }
}
