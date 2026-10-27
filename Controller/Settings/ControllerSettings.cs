using HealthPortal.Controller.Dashboard;
using HealthPortal.Helper;
using HealthPortal.Properties;
using HealthPortal.View.Dashboard;
using HealthPortal.View.InventoryAdministration;
using HealthPortal.View.MainPage;
using HealthPortal.View.Settings;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace HealthPortal.Controller.Settings
{
    internal class ControllerSettings
    {
        FrmSettings frmSettings;
        Form currentForm;
        Button currentButton;
        bool initialLoadInProgress = true;
        private Dictionary<string, Tuple<Bitmap, Bitmap>> imageMapping;
        public ControllerSettings(FrmSettings view)
        {
            frmSettings = view;
            frmSettings.Load += new EventHandler(InitialLoad);
            frmSettings.Resize += new EventHandler(ResizeSidePanel);
            imageMapping = new Dictionary<string, Tuple<Bitmap, Bitmap>>()
            {
                { "btnUserSettings", Tuple.Create(Resources.users, Resources.hoverUsers)},
                { "btnInstitutionSettings", Tuple.Create(Resources.school, Resources.hoverSchool) },
                { "btnServerSettings", Tuple.Create(Resources.server, Resources.hoverServer) },
                { "btnProgramSettings", Tuple.Create(Resources.healthPortal, Resources.hoverHealthPortal) },
                { "btnExit", Tuple.Create(Resources.quit, Resources.hoverQuit) },
                { "btnResize", Tuple.Create(Resources.resize, Resources.hoverResize) }
            };

            frmSettings.Load += new EventHandler(OpenUserSettingsForm);
            frmSettings.btnUserSettings.Click += new EventHandler(OpenUserSettingsForm);
            frmSettings.btnInstitutionSettings.Click += new EventHandler(OpenInstitutionSettingsForm);
            frmSettings.btnServerSettings.Click += new EventHandler(OpenServerSettingsForm);
            frmSettings.btnProgramSettings.Click += new EventHandler(OpenProgramSettingsForm);

            frmSettings.btnUserSettings.MouseEnter += new EventHandler(MouseEnterControl);
            frmSettings.btnInstitutionSettings.MouseEnter += new EventHandler(MouseEnterControl);
            frmSettings.btnServerSettings.MouseEnter += new EventHandler(MouseEnterControl);
            frmSettings.btnProgramSettings.MouseEnter += new EventHandler(MouseEnterControl);

            frmSettings.btnUserSettings.MouseLeave += new EventHandler(MouseLeaveControl);
            frmSettings.btnInstitutionSettings.MouseLeave += new EventHandler(MouseLeaveControl);
            frmSettings.btnServerSettings.MouseLeave += new EventHandler(MouseLeaveControl);
            frmSettings.btnProgramSettings.MouseLeave += new EventHandler(MouseLeaveControl);

            frmSettings.btnExit.MouseEnter += new EventHandler(MouseEnterControl);
            frmSettings.btnResize.MouseEnter += new EventHandler(MouseEnterControl);
            frmSettings.btnExit.MouseLeave += new EventHandler(MouseLeaveControl);
            frmSettings.btnResize.MouseLeave += new EventHandler(MouseLeaveControl);

            frmSettings.btnExit.Click += new EventHandler(CloseForm);
            frmSettings.btnResize.Click += new EventHandler(ControllerDashboard.ToggleFullScreen);
        }
        private void CloseForm(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea cerrar el programa directamente? Considere que se cerrará la sesión de manera automática", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                CommonMethods.DisposeOfCurrentUserData();
                Environment.Exit(0);
            }
        }
        private void ResizeSidePanel(object sender, EventArgs e)
        {
            if (!initialLoadInProgress)
            {
                frmSettings.tlpSettings.ColumnStyles[0].SizeType = SizeType.Percent;
                frmSettings.tlpSettings.ColumnStyles[0].Width = CurrentUserData.IsSideBarExpanded ? 79.93f : 77.42f;
                frmSettings.tlpSettings.ColumnStyles[1].SizeType = SizeType.Percent;
                frmSettings.tlpSettings.ColumnStyles[1].Width = CurrentUserData.IsSideBarExpanded ? 20.07f : 22.58f;
            }
            initialLoadInProgress = false;
        }
        private void MouseEnterControl(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn != null && imageMapping.ContainsKey(btn.Name))
            {
                btn.Image = imageMapping[btn.Name].Item2;
                btn.ForeColor = Color.FromArgb(31, 43, 91);
            }
        }
        private void MouseLeaveControl(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn != null && imageMapping.ContainsKey(btn.Name))
            {
                if (btn != currentButton)
                {
                    btn.Image = imageMapping[btn.Name].Item1;
                    btn.ForeColor = Color.FromArgb(142, 202, 230);
                }
            }
        }
        private void OpenUserSettingsForm(object sender, EventArgs e)
        {
            frmSettings.btnUserSettings.Image = Resources.hoverUsers;
            frmSettings.btnInstitutionSettings.Image = Resources.school;
            frmSettings.btnServerSettings.Image = Resources.server;
            frmSettings.btnProgramSettings.Image = Resources.healthPortal;

            frmSettings.btnUserSettings.ForeColor = Color.FromArgb(31, 43, 91);
            frmSettings.btnInstitutionSettings.ForeColor = Color.FromArgb(142, 202, 230);
            frmSettings.btnServerSettings.ForeColor = Color.FromArgb(142, 202, 230);
            frmSettings.btnProgramSettings.ForeColor = Color.FromArgb(142, 202, 230);

            frmSettings.pnlUserSettings.BackColor = Color.FromArgb(142, 202, 230);
            frmSettings.pnlInstitutionSettings.BackColor = Color.White;
            frmSettings.pnlServerSettings.BackColor = Color.White;
            frmSettings.pnlProgramSettings.BackColor = Color.White;

            frmSettings.btnUserSettings.FlatAppearance.BorderColor = Color.FromArgb(142, 202, 230);
            frmSettings.btnInstitutionSettings.FlatAppearance.BorderColor = Color.White;
            frmSettings.btnServerSettings.FlatAppearance.BorderColor = Color.White;
            frmSettings.btnProgramSettings.FlatAppearance.BorderColor = Color.White;

            OpenForm<FrmUserSettings>(frmSettings.btnUserSettings);
        }
        private void OpenInstitutionSettingsForm(object sender, EventArgs e)
        {
            frmSettings.btnUserSettings.Image = Resources.users;
            frmSettings.btnInstitutionSettings.Image = Resources.hoverSchool;
            frmSettings.btnServerSettings.Image = Resources.server;
            frmSettings.btnProgramSettings.Image = Resources.healthPortal;

            frmSettings.btnUserSettings.ForeColor = Color.FromArgb(142, 202, 230);
            frmSettings.btnInstitutionSettings.ForeColor = Color.FromArgb(31, 43, 91);
            frmSettings.btnServerSettings.ForeColor = Color.FromArgb(142, 202, 230);
            frmSettings.btnProgramSettings.ForeColor = Color.FromArgb(142, 202, 230);

            frmSettings.pnlUserSettings.BackColor = Color.White;
            frmSettings.pnlInstitutionSettings.BackColor = Color.FromArgb(142, 202, 230);
            frmSettings.pnlServerSettings.BackColor = Color.White;
            frmSettings.pnlProgramSettings.BackColor = Color.White;

            frmSettings.btnUserSettings.FlatAppearance.BorderColor = Color.White;
            frmSettings.btnInstitutionSettings.FlatAppearance.BorderColor = Color.FromArgb(142, 202, 230);
            frmSettings.btnServerSettings.FlatAppearance.BorderColor = Color.White;
            frmSettings.btnProgramSettings.FlatAppearance.BorderColor = Color.White;

            OpenForm<FrmInstitutionSettings>(frmSettings.btnInstitutionSettings);
        }
        private void OpenServerSettingsForm(object sender, EventArgs e)
        {
            frmSettings.btnUserSettings.Image = Resources.users;
            frmSettings.btnInstitutionSettings.Image = Resources.school;
            frmSettings.btnServerSettings.Image = Resources.hoverServer;
            frmSettings.btnProgramSettings.Image = Resources.healthPortal;

            frmSettings.btnUserSettings.ForeColor = Color.FromArgb(142, 202, 230);
            frmSettings.btnInstitutionSettings.ForeColor = Color.FromArgb(142, 202, 230);
            frmSettings.btnServerSettings.ForeColor = Color.FromArgb(31, 43, 91);
            frmSettings.btnProgramSettings.ForeColor = Color.FromArgb(142, 202, 230);

            frmSettings.pnlUserSettings.BackColor = Color.White;
            frmSettings.pnlInstitutionSettings.BackColor = Color.White;
            frmSettings.pnlServerSettings.BackColor = Color.FromArgb(142, 202, 230);
            frmSettings.pnlProgramSettings.BackColor = Color.White;

            frmSettings.btnUserSettings.FlatAppearance.BorderColor = Color.White;
            frmSettings.btnInstitutionSettings.FlatAppearance.BorderColor = Color.White;
            frmSettings.btnServerSettings.FlatAppearance.BorderColor = Color.FromArgb(142, 202, 230);
            frmSettings.btnProgramSettings.FlatAppearance.BorderColor = Color.White;

            OpenForm<FrmServerSettings>(frmSettings.btnServerSettings);
        }
        private void OpenProgramSettingsForm(object sender, EventArgs e)
        {
            frmSettings.btnUserSettings.Image = Resources.users;
            frmSettings.btnInstitutionSettings.Image = Resources.school;
            frmSettings.btnServerSettings.Image = Resources.server;
            frmSettings.btnProgramSettings.Image = Resources.hoverHealthPortal;

            frmSettings.btnUserSettings.ForeColor = Color.FromArgb(142, 202, 230);
            frmSettings.btnInstitutionSettings.ForeColor = Color.FromArgb(142, 202, 230);
            frmSettings.btnServerSettings.ForeColor = Color.FromArgb(142, 202, 230);
            frmSettings.btnProgramSettings.ForeColor = Color.FromArgb(31, 43, 91);

            frmSettings.pnlUserSettings.BackColor = Color.White;
            frmSettings.pnlInstitutionSettings.BackColor = Color.White;
            frmSettings.pnlServerSettings.BackColor = Color.White;
            frmSettings.pnlProgramSettings.BackColor = Color.FromArgb(142, 202, 230);

            frmSettings.btnUserSettings.FlatAppearance.BorderColor = Color.White;
            frmSettings.btnInstitutionSettings.FlatAppearance.BorderColor = Color.White;
            frmSettings.btnServerSettings.FlatAppearance.BorderColor = Color.White;
            frmSettings.btnProgramSettings.FlatAppearance.BorderColor = Color.FromArgb(142, 202, 230);

            OpenForm<FrmProgramSettings>(frmSettings.btnProgramSettings);
        }
        private void OpenForm<NewForm>(Button associatedBtn) where NewForm : Form, new()
        {
            Form form;
            form = frmSettings.pnlContainer.Controls.OfType<NewForm>().FirstOrDefault();
            if (form == null)
            {
                form = new NewForm();
                form.TopLevel = false;
                form.FormBorderStyle = FormBorderStyle.None;
                form.Dock = DockStyle.Fill;
                //form.Opacity = 0.75;
                if (currentForm != null)
                {
                    currentForm.Close();
                    frmSettings.pnlContainer.Controls.Remove(currentForm);
                }
                currentForm = form;
                frmSettings.pnlContainer.Controls.Add(form);
                frmSettings.pnlContainer.Tag = form;
                form.Show();
                form.BringToFront();
            }
            else
            {
                form.BringToFront();
            }
            currentButton = associatedBtn;
        }
        private void InitialLoad(object sender, EventArgs e)
        {
            initialLoadInProgress = true;
            CheckUserAccessRole();
            frmSettings.tlpSettings.ColumnStyles[0].SizeType = SizeType.Percent;
            frmSettings.tlpSettings.ColumnStyles[0].Width = !CurrentUserData.IsSideBarExpanded ? 79.93f : 77.42f;
            frmSettings.tlpSettings.ColumnStyles[1].SizeType = SizeType.Percent;
            frmSettings.tlpSettings.ColumnStyles[1].Width = !CurrentUserData.IsSideBarExpanded ? 20.07f : 22.58f;
        }
        private void CheckUserAccessRole()
        {
            if (CurrentUserData.RoleId != 1)
            {
                frmSettings.btnInstitutionSettings.Visible = false;
                frmSettings.btnServerSettings.Visible = false;
            }
        }
    }
}
