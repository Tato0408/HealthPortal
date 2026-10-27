using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HealthPortal.Helper;
using HealthPortal.Controller.Login;
using System.Drawing.Text;

namespace HealthPortal.View.Login
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
            Region = Region.FromHrgn(CommonMethods.CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            btnShowPassword.Visible = false;
            ControllerLogin control = new ControllerLogin(this);
        }
    }
}
