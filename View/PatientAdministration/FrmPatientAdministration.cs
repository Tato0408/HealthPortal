using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HealthPortal.Controller.PatientAdministration;

namespace HealthPortal.View.PatientAdministration
{
    public partial class FrmPatientAdministration : Form
    {
        public FrmPatientAdministration()
        {
            InitializeComponent();
            ControllerPatientAdministration control = new ControllerPatientAdministration(this);
        }
    }
}