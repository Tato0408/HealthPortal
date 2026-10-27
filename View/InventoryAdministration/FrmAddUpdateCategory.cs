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

namespace HealthPortal.View.InventoryAdministration
{
    public partial class FrmAddUpdateCategory : Form
    {
        public FrmAddUpdateCategory(int action)
        {
            InitializeComponent();
            ControllerAddUpdateCategory control = new ControllerAddUpdateCategory(this, action);
        }

        public FrmAddUpdateCategory(int action, int id, string medicineCategory)
        {
            InitializeComponent();
            ControllerAddUpdateCategory control = new ControllerAddUpdateCategory(this, action, id, medicineCategory);
        }
    }
}