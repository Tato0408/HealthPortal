using HealthPortal.Controller.Settings;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HealthPortal.View.Settings
{
    public partial class FrmProgramSettings : Form
    {
        public FrmProgramSettings()
        {
            InitializeComponent();
            ControllerProgramSettings control = new ControllerProgramSettings(this);
        }
    }
}
