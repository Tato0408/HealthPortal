using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HealthPortal.Model.DAO;
using System.Windows.Forms.DataVisualization.Charting;
using HealthPortal.View.PatientAdministration;
using System.Drawing;
using System.Windows.Forms;
using HealthPortal.Properties;
using HealthPortal.Helper;

namespace HealthPortal.Controller.PatientAdministration
{
    internal class ControllerPatientsTreated
    {
        FrmPatientsTreated frmPatientsTreated;
        private Dictionary<string, Tuple<Bitmap, Bitmap>> imageMapping;
        public ControllerPatientsTreated(FrmPatientsTreated view)
        {
            frmPatientsTreated = view;

            imageMapping = new Dictionary<string, Tuple<Bitmap, Bitmap>>()
            {
                { "btnExit", Tuple.Create(Resources.quit, Resources.hoverQuit) }
            };

            frmPatientsTreated.Load += new EventHandler(LoadData);
            frmPatientsTreated.btnExit.MouseEnter += new EventHandler(MouseEnterPictureButton);
            frmPatientsTreated.btnExit.MouseLeave += new EventHandler(MouseLeavePictureButton);
            frmPatientsTreated.btnExit.Click += new EventHandler(CloseForm);
            CommonMethods.EnableFormDrag(frmPatientsTreated, frmPatientsTreated);
        }
        private void CloseForm(object sender, EventArgs e)
        {
            frmPatientsTreated.Dispose();
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
        private void LoadData(object sender, EventArgs e)
        {
            BindChartData();
        }
        private void LeftDateTimePicker(object sender, EventArgs e)
        {
            BindChartData();
        }
        private void BindChartData()
        {
            DAOPatientAdministration dao = new DAOPatientAdministration();
            frmPatientsTreated.chartPatientsTreated.DataSource = dao.RetrieveChartData();
            frmPatientsTreated.chartPatientsTreated.Series.Clear();
            Series series = new Series
            {
                XValueMember = "idGradoSeccion",
                YValueMembers = "PorcentajeDelTotal",
                ChartType = SeriesChartType.Pie,
                Name = "Total de pacientes atendidos"
            };
            frmPatientsTreated.chartPatientsTreated.Series.Add(series);
            frmPatientsTreated.chartPatientsTreated.ChartAreas[0].AxisX.Title = "ID del grado y sección";
            frmPatientsTreated.chartPatientsTreated.ChartAreas[0].AxisY.Title = "Porcentaje de estudiantes";
            frmPatientsTreated.chartPatientsTreated.DataBind();
        }
    }
}
