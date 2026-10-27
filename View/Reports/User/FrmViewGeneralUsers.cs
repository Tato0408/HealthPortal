using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HealthPortal.View.Reports.User
{
    public partial class FrmViewGeneralUsers : Form
    {
        public FrmViewGeneralUsers()
        {
            InitializeComponent();
        }

        private void FrmViewGeneralUsers_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dataSetInfoInstitution.tbInstitution' Puede moverla o quitarla según sea necesario.
            this.tbInstitutionTableAdapter.FillInfoInstitution(this.dataSetInfoInstitution.tbInstitution);
            // TODO: esta línea de código carga datos en la tabla 'dataSetInfoUsers.tbUsers' Puede moverla o quitarla según sea necesario.
            this.tbUsersTableAdapter.FillInfoUsers(this.dataSetInfoUsers.tbUsers);


            this.reportViewer1.RefreshReport();
        }

    }
}
