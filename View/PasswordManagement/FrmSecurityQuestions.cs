using HealthPortal.Controller.PasswordManagement;
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

namespace HealthPortal.View.PasswordManagement
{
    public partial class FrmSecurityQuestions : Form
    {
        public FrmSecurityQuestions(string username)
        {
            InitializeComponent();
            Region = Region.FromHrgn(CommonMethods.CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            ControllerSecurityQuestions control = new ControllerSecurityQuestions(this, username);
        }
    }
}
