using HealthPortal.Controller.Settings;
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

namespace HealthPortal.View.Settings
{
    public partial class FrmServerSettings : Form
    {
        public FrmServerSettings()
        {
            InitializeComponent();
            ControllerServerSettings control = new ControllerServerSettings(this);
        }
    }
}