using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HealthPortal.Controller.InventoryAdministration;
using HealthPortal.Helper;

namespace HealthPortal.View.InventoryAdministration
{
    public partial class FrmUsageIndex : Form
    {
        public FrmUsageIndex()
        {
            InitializeComponent();
            Region = Region.FromHrgn(CommonMethods.CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            ControllerUsageIndex control = new ControllerUsageIndex(this);
        }
    }
}
