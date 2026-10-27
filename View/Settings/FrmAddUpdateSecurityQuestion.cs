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
    public partial class FrmAddUpdateSecurityQuestion : Form
    {
        public FrmAddUpdateSecurityQuestion(int origin)
        {
            InitializeComponent();
            Region = Region.FromHrgn(CommonMethods.CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            ControllerAddUpdateSecurityQuestion control = new ControllerAddUpdateSecurityQuestion(this, origin);
        }
        public FrmAddUpdateSecurityQuestion(int origin, int securityQuestionID, string question)
        {
            InitializeComponent();
            Region = Region.FromHrgn(CommonMethods.CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            ControllerAddUpdateSecurityQuestion control = new ControllerAddUpdateSecurityQuestion(this, origin, securityQuestionID, question);
        }
    }
}
