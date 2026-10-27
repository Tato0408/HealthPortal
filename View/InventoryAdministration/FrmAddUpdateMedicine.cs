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
    public partial class FrmAddUpdateMedicine : Form
    {
        public FrmAddUpdateMedicine(int action)
        {
            InitializeComponent();
            Region = Region.FromHrgn(CommonMethods.CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            ControllerAddUpdateMedicine control = new ControllerAddUpdateMedicine(this, action);
        }
        public FrmAddUpdateMedicine(int action, int id, string medicineName, string medicineCategory, DateTime expirationDate, string stock, string stockPack, DateTime entryDate, DateTime exit, string description)
        {
            InitializeComponent();
            Region = Region.FromHrgn(CommonMethods.CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            ControllerAddUpdateMedicine control = new ControllerAddUpdateMedicine(this, action, id, medicineName, medicineCategory, expirationDate, stock, stockPack, entryDate, exit, description);
        }
    }
}