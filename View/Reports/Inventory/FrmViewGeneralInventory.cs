using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HealthPortal.View.Reports.Inventory
{
    public partial class FrmViewGeneralInventory : Form
    {
        public FrmViewGeneralInventory()
        {
            InitializeComponent();
        }

        private void FrmViewGeneralInventory_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dataSetInfoInventory1.tbInventory' Puede moverla o quitarla según sea necesario.
            this.tbInventoryTableAdapter.FillInfoInventory(this.dataSetInfoInventory1.tbInventory);
            // TODO: esta línea de código carga datos en la tabla 'dataSetInfoInventory1.tbInventory' Puede moverla o quitarla según sea necesario.
            this.tbInventoryTableAdapter.FillInfoInventory(this.dataSetInfoInventory1.tbInventory);
            // TODO: esta línea de código carga datos en la tabla 'dataSetInfoInstitution.tbInstitution' Puede moverla o quitarla según sea necesario.
            this.tbInstitutionTableAdapter.FillInfoInstitution(this.dataSetInfoInstitution.tbInstitution);
            // TODO: esta línea de código carga datos en la tabla 'dataSetInfoInventory.tbInventory' Puede moverla o quitarla según sea necesario.
            this.tbInventoryTableAdapter.FillInfoInventory(this.dataSetInfoInventory.tbInventory);

            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }
    }
}
