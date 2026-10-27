using HealthPortal.Controller.UserAdministration;
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

namespace HealthPortal.View.UserAdministration
{
    public partial class FrmAddUpdateUser : Form
    {
        public FrmAddUpdateUser(int procedure)
        {
            InitializeComponent();
            Region = Region.FromHrgn(CommonMethods.CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            ControllerAddUpdateUser control = new ControllerAddUpdateUser(this, procedure);
        }
        public FrmAddUpdateUser(int procedure, int personID, string firstName, string lastName, string email, string phoneNumber, string username, string role)
        {
            InitializeComponent();
            Region = Region.FromHrgn(CommonMethods.CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            ControllerAddUpdateUser control = new ControllerAddUpdateUser(this, procedure, personID, firstName, lastName, email, phoneNumber, username, role);
        }
    }
}
