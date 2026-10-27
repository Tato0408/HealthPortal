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
using HealthPortal.Model;
using HealthPortal.View.PatientAdministration;

namespace HealthPortal.View.PatientAdministration
{
    public partial class FrmViewPatientInfo : Form
    {
        public FrmViewPatientInfo(int accion)
        {
            InitializeComponent();
            ControllerViewPatientInfo contro = new ControllerViewPatientInfo(this, accion);
        }

        public FrmViewPatientInfo(int accion, int IdPaciente, string nombrePaciente, string apellidoPaciente, string TipoPersona, string codigo, string grupoTecnico, string grado, string seccionAcademica, string Especialidad)
        {
            InitializeComponent();
            ControllerViewPatientInfo contro = new ControllerViewPatientInfo(this, accion, IdPaciente, nombrePaciente, apellidoPaciente, TipoPersona, codigo, grupoTecnico, grado, seccionAcademica, Especialidad);
        }


    }
}