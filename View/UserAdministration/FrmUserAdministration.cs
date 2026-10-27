using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HealthPortal.Controller.UserAdministration;

namespace HealthPortal.View.UserAdministration
{
    public partial class FrmUserAdministration : Form
    {
        public FrmUserAdministration()
        {
            InitializeComponent();
            cmsReestablishPassword.Enabled = false;
            ControllerUserAdministration control = new ControllerUserAdministration(this);
        }
    }
}
