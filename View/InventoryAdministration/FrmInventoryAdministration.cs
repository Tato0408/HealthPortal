using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HealthPortal.Controller;
using HealthPortal.Controller.InventoryAdministration;

namespace HealthPortal.View.InventoryAdministration
{
    public partial class FrmInventoryAdministration : Form
    {
        public FrmInventoryAdministration()
        {
            InitializeComponent();
            ControllerInventoryAdministration control = new ControllerInventoryAdministration(this);
        }

       
    }
}