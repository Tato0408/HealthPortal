using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HealthPortal.Model.DAO;
using System.Windows.Forms.DataVisualization.Charting;
using HealthPortal.View.InventoryAdministration;
using System.Drawing;
using System.Windows.Forms;
using HealthPortal.Properties;
using HealthPortal.Helper;

namespace HealthPortal.Controller.InventoryAdministration
{
    internal class ControllerUsageIndex
    {
        FrmUsageIndex frmUsageIndex;
        private Dictionary<string, Tuple<Bitmap, Bitmap>> imageMapping;
        public ControllerUsageIndex(FrmUsageIndex view)
        {
            frmUsageIndex = view;

            imageMapping = new Dictionary<string, Tuple<Bitmap, Bitmap>>()
            {
                { "btnExit", Tuple.Create(Resources.quit, Resources.hoverQuit) }
            };

            frmUsageIndex.Load += new EventHandler(LoadData);
            frmUsageIndex.btnExit.MouseEnter += new EventHandler(MouseEnterPictureButton);
            frmUsageIndex.btnExit.MouseLeave += new EventHandler(MouseLeavePictureButton);
            frmUsageIndex.btnExit.Click += new EventHandler(CloseForm);
            frmUsageIndex.dtpStartingDate.Leave += new EventHandler(LeftDateTimePicker);
            frmUsageIndex.dtpEndDate.Leave += new EventHandler(LeftDateTimePicker);
            CommonMethods.EnableFormDrag(frmUsageIndex, frmUsageIndex);
        }
        private void CloseForm(object sender, EventArgs e)
        {
            frmUsageIndex.Dispose();
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
            frmUsageIndex.dtpStartingDate.Value = DateTime.Now.AddMonths(-1);
            frmUsageIndex.dtpEndDate.Value = DateTime.Now;
            frmUsageIndex.dtpStartingDate.MaxDate = DateTime.Now;
            frmUsageIndex.dtpEndDate.MaxDate = DateTime.Now;
            DateTime januaryFirst = new DateTime(DateTime.Now.Year, 1, 1);
            frmUsageIndex.dtpStartingDate.MinDate = januaryFirst;
            frmUsageIndex.dtpEndDate.MinDate = januaryFirst;
            BindChartData();
        }
        private void LeftDateTimePicker(object sender, EventArgs e)
        {
            BindChartData();
        }
        private void BindChartData()
        {
            DAOInventoryAdministration dao = new DAOInventoryAdministration();
            dao.FechaInicio = frmUsageIndex.dtpStartingDate.Value;
            dao.FechaFin = frmUsageIndex.dtpEndDate.Value;
            frmUsageIndex.chartUsageIndex.DataSource = dao.RetrieveChartData();
            frmUsageIndex.chartUsageIndex.Series.Clear();
            Series series = new Series
            {
                XValueMember = "nombreInventario",
                YValueMembers = "usos",
                ChartType = SeriesChartType.Column,
                Name = "Uso de ítems del inventario a lo largo del tiempo"
            };
            frmUsageIndex.chartUsageIndex.Series.Add(series);
            frmUsageIndex.chartUsageIndex.ChartAreas[0].AxisX.Title = "Ítem";
            frmUsageIndex.chartUsageIndex.ChartAreas[0].AxisY.Title = "Cantidad de usos";
            frmUsageIndex.chartUsageIndex.DataBind();
        }
    }
}
