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
    public partial class FrmManuals : Form
    {
        public FrmManuals()
        {
            InitializeComponent();
            ControllerManuals control = new ControllerManuals(this);
        }
    }
}
