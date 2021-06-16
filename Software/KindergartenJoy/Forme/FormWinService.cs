using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ServiceProcess;

namespace KindergartenJoy.Forme
{
    public partial class FormWinService : Form
    {       
        public FormWinService()
        {
            InitializeComponent();
            ProvjeraStatusaServisa();
            
        }

        private void btnInstaliraj_Click(object sender, EventArgs e)
        {           
            string fileName = "install.bat";
            string path = Path.GetFullPath(fileName);
            System.Diagnostics.Process.Start(path);
            label1.Text = "Servisi instalirani, da bi ih pokrenuli kliknite start!";
            btnDeinstaliraj.Enabled = true;
            btnInstaliraj.Enabled = false;
            btnStart.Enabled = true;
            btnStop.Enabled = false;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            string fileName = "start.bat";
            string path = Path.GetFullPath(fileName);
            System.Diagnostics.Process.Start(path);
            label1.Text = "Servisi pokrenuti, možete izaći iz aplikacije!";
            btnDeinstaliraj.Enabled = false;
            btnInstaliraj.Enabled = false;
            btnStart.Enabled = false;
            btnStop.Enabled = true;
        }

        private void btnStop_Click(object sender, EventArgs e)
        {        
            string fileName = "stop.bat";
            string path = Path.GetFullPath(fileName);
            System.Diagnostics.Process.Start(path);
            label1.Text = "Servisi stopirani, možete ih deinstalirati ili opet pokrenuti!";
            btnDeinstaliraj.Enabled = true;
            btnInstaliraj.Enabled = false;
            btnStart.Enabled = true;
            btnStop.Enabled = false;
        }

        private void btnDeinstaliraj_Click(object sender, EventArgs e)
        {           
            string fileName = "uninstall.bat";
            string path = Path.GetFullPath(fileName);
            System.Diagnostics.Process.Start(path);
            label1.Text = "Servisi deinstalirani, možete ih opet instalirati po potrebi!";
            btnDeinstaliraj.Enabled = false;
            btnInstaliraj.Enabled = true;
            btnStart.Enabled = false;
            btnStop.Enabled = false;
        }

        public void ProvjeraStatusaServisa()
        {
            ServiceController ctl = ServiceController.GetServices().FirstOrDefault(s => s.ServiceName == "ObavijestService");
            if (ctl == null)
            {
                btnDeinstaliraj.Enabled = false;
                btnStart.Enabled = false;
                btnStop.Enabled = false;
                btnInstaliraj.Enabled = true;
            }

            if (ctl != null)
            {
                if (ctl != null && ctl.Status != ServiceControllerStatus.Running)
                {
                    btnDeinstaliraj.Enabled = true;
                    btnStart.Enabled = true;
                    btnStop.Enabled = false;
                    btnInstaliraj.Enabled = false;
                }

                if (ctl.Status == ServiceControllerStatus.Running)
                {
                    btnDeinstaliraj.Enabled = false;
                    btnStart.Enabled = false;
                    btnStop.Enabled = true;
                    btnInstaliraj.Enabled = false;
                }

                if (ctl.Status == ServiceControllerStatus.Stopped)
                {
                    btnDeinstaliraj.Enabled = true;
                    btnStart.Enabled = true;
                    btnStop.Enabled = false;
                    btnInstaliraj.Enabled = false;
                }
            }
        }
    }
}
