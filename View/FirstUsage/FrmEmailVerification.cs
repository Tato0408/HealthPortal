using HealthPortal.Controller.FirstUsage;
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

namespace HealthPortal.View.FirstUsage
{
    public partial class FrmEmailVerification : Form
    {
        public FrmEmailVerification(string confirmationCode, int personID, string username)
        {
            InitializeComponent();
            Region = Region.FromHrgn(CommonMethods.CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            ControllerEmailVerification control = new ControllerEmailVerification(this, confirmationCode, personID, username);
        }
    }
}
