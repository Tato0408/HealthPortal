using HealthPortal.Helper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HealthPortal.Controller.Settings;

namespace HealthPortal.View.Settings
{
    public partial class FrmUserSettings : Form
    {
        public FrmUserSettings()
        {
            InitializeComponent();
            ControllerUserSettings control = new ControllerUserSettings(this);
        }
    }
}
