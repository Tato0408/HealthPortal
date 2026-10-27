using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HealthPortal.Controller.PatientAdministration;

namespace HealthPortal.View.PatientAdministration
{
    public partial class FrmPasswordPatientDelete : Form
    {
        public FrmPasswordPatientDelete(int idPaciente)
        {
            InitializeComponent();
            ControllerPAsswordPatientDelete control = new ControllerPAsswordPatientDelete(this, idPaciente);
        }
    }
}
