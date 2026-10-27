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
using HealthPortal.Helper;

namespace HealthPortal.View.Settings
{
    public partial class FrmAddUpdateSecurityAnswer : Form
    {
        public FrmAddUpdateSecurityAnswer(int origin, string username)
        {
            InitializeComponent();
            Region = Region.FromHrgn(CommonMethods.CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            ControllerAddUpdateSecurityAnswer control = new ControllerAddUpdateSecurityAnswer(this, origin, username);
        }
        public FrmAddUpdateSecurityAnswer(int origin, string username, int answerID)
        {
            InitializeComponent();
            Region = Region.FromHrgn(CommonMethods.CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            ControllerAddUpdateSecurityAnswer control = new ControllerAddUpdateSecurityAnswer(this, origin, username, answerID);
        }
    }
}
