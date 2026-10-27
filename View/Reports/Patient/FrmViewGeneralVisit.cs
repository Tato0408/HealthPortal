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
    public partial class FrmViewGeneralVisit : Form
    {
        public FrmViewGeneralVisit()
        {
            InitializeComponent();
        }

        private void FrmViewGeneralVisit_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dataSetInfoInstitution.tbInstitution' Puede moverla o quitarla según sea necesario.
            this.tbInstitutionTableAdapter.FillInfoInstitution(this.dataSetInfoInstitution.tbInstitution);
            // TODO: esta línea de código carga datos en la tabla 'dataSetInfoVisit.tbVisitas' Puede moverla o quitarla según sea necesario.
            this.tbVisitasTableAdapter.FillNewInfoVisit(this.dataSetInfoVisit.tbVisitas);
            // TODO: esta línea de código carga datos en la tabla 'dataSetInfoVisit.tbVisitas' Puede moverla o quitarla según sea necesario.
            this.tbVisitasTableAdapter.FillNewInfoVisit(this.dataSetInfoVisit.tbVisitas);
            this.reportViewer1.RefreshReport();
        }
        private void rjButton1_Click_1(object sender, EventArgs e)
        {
            this.tbVisitasTableAdapter.FillNewInfoVisit(this.dataSetInfoVisit.tbVisitas);
            // TODO: esta línea de código carga datos en la tabla 'dataSet1.viewAdminPacientes' Puede moverla o quitarla según sea 
            this.reportViewer1.RefreshReport();
        }

        private void btnFiltrar_Click_1(object sender, EventArgs e)
        {
            string param1, param2;
            this.tbVisitasTableAdapter.AdminPatientDate(this.dataSetInfoVisit.tbVisitas, param1 = dtpDesde.Value.ToString(), param2 = dtpHasta.Value.ToString());

            // TODO: esta línea de código carga datos en la tabla 'dataSet1.viewAdminPacientes' Puede moverla o quitarla según sea 
            this.reportViewer1.RefreshReport();
        }

        private void btnNew_Click_1(object sender, EventArgs e)
        {
            string Param1;
            this.tbVisitasTableAdapter.PatientSearch(this.dataSetInfoVisit.tbVisitas, Param1 = txtSearchPatient.Text);

            // TODO: esta línea de código carga datos en la tabla 'dataSet1.viewAdminPacientes' Puede moverla o quitarla según sea 
            this.reportViewer1.RefreshReport();
        }

    }
}
