using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HealthPortal.View.Reports.Patient
{
    public partial class FrmViewGeneralPatient : Form
    {
        public FrmViewGeneralPatient()
        {
            InitializeComponent();
        }

        private void FrmViewGeneralPatient_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dataSetInfoInstitution.tbInstitution' Puede moverla o quitarla según sea necesario.
            this.tbInstitutionTableAdapter.FillInfoInstitution(this.dataSetInfoInstitution.tbInstitution);
            // TODO: esta línea de código carga datos en la tabla 'dataSetInfoPatient.tbPatient' Puede moverla o quitarla según sea necesario.
            this.tbPatientTableAdapter.FillInfoPatient(this.dataSetInfoPatient.tbPatient);

            this.reportViewer1.RefreshReport();
        }
    }
}
