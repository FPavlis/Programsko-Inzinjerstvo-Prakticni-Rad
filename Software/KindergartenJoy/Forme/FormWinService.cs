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
using System.Diagnostics;

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
            Process process = new Process();
            process.StartInfo.UseShellExecute = true;
            process.StartInfo.Verb = "runas";
            process.StartInfo.WorkingDirectory = @"C:\Users\kowas\Documents\pi21-skovacic2-fpavlis-iparac\Software\ObavijestiService\bin\Debug";
            process.StartInfo.FileName = "cmd.exe";
            process.StartInfo.RedirectStandardInput = true;
            process.StartInfo.RedirectStandardOutput = true;
            process.StartInfo.UseShellExecute = false;
            process.Start();
            process.StandardInput.WriteLine("ObavijestiService install");
            process.StandardInput.Flush();
            process.StandardInput.Close();
            process.WaitForExit();
            label1.Text = "Servisi instalirani, da bi ih pokrenuli kliknite start!";
            btnDeinstaliraj.Enabled = true;
            btnInstaliraj.Enabled = false;
            btnStart.Enabled = true;
            btnStop.Enabled = false;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            Process process = new Process();
            process.StartInfo.UseShellExecute = true;
            process.StartInfo.Verb = "runas";
            process.StartInfo.WorkingDirectory = @"C:\Users\kowas\Documents\pi21-skovacic2-fpavlis-iparac\Software\ObavijestiService\bin\Debug";
            process.StartInfo.FileName = "cmd.exe";
            process.StartInfo.RedirectStandardInput = true;
            process.StartInfo.RedirectStandardOutput = true;
            process.StartInfo.UseShellExecute = false;
            process.Start();
            process.StandardInput.WriteLine("ObavijestiService start");
            process.StandardInput.Flush();
            process.StandardInput.Close();
            process.WaitForExit();
            label1.Text = "Servisi pokrenuti, možete izaći iz aplikacije!";
            btnDeinstaliraj.Enabled = false;
            btnInstaliraj.Enabled = false;
            btnStart.Enabled = false;
            btnStop.Enabled = true;
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            Process process = new Process();
            process.StartInfo.UseShellExecute = true;
            process.StartInfo.Verb = "runas";
            process.StartInfo.WorkingDirectory = @"C:\Users\kowas\Documents\pi21-skovacic2-fpavlis-iparac\Software\ObavijestiService\bin\Debug";
            process.StartInfo.FileName = "cmd.exe";
            process.StartInfo.RedirectStandardInput = true;
            process.StartInfo.RedirectStandardOutput = true;
            process.StartInfo.UseShellExecute = false;
            process.Start();
            process.StandardInput.WriteLine("ObavijestiService stop");
            process.StandardInput.Flush();
            process.StandardInput.Close();
            process.WaitForExit();
            label1.Text = "Servisi stopirani, možete ih deinstalirati ili opet pokrenuti!";
            btnDeinstaliraj.Enabled = true;
            btnInstaliraj.Enabled = false;
            btnStart.Enabled = true;
            btnStop.Enabled = false;
        }

        private void btnDeinstaliraj_Click(object sender, EventArgs e)
        {
            Process process = new Process();
            process.StartInfo.UseShellExecute = true;
            process.StartInfo.Verb = "runas";
            process.StartInfo.WorkingDirectory = @"C:\Users\kowas\Documents\pi21-skovacic2-fpavlis-iparac\Software\ObavijestiService\bin\Debug";
            process.StartInfo.FileName = "cmd.exe";
            process.StartInfo.RedirectStandardInput = true;
            process.StartInfo.RedirectStandardOutput = true;
            process.StartInfo.UseShellExecute = false;
            process.Start();
            process.StandardInput.WriteLine("ObavijestiService uninstall");
            process.StandardInput.Flush();
            process.StandardInput.Close();
            process.WaitForExit();
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
