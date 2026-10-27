using HealthPortal.View.Settings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace HealthPortal.Controller.Settings
{
    internal class ControllerManuals
    {
        FrmManuals frmManual;

        public ControllerManuals(FrmManuals view)
        {
            frmManual = view;
            frmManual.btnDowland2.Click += new EventHandler(Manuals);
        }
        private void Manuals(object sender, EventArgs e)
        {
            string url = "https://healthportal2024.netlify.app/";
            Process.Start(new ProcessStartInfo(url));
        }
    }
}
