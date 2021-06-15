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

namespace KindergartenJoy.Forme
{
    public partial class FormWinService : Form
    {
        public FormWinService()
        {
            InitializeComponent();
        }

        private void btnInstaliraj_Click(object sender, EventArgs e)
        {
            string fileName = "install.bat";
            string path = Path.GetFullPath(fileName);
            System.Diagnostics.Process.Start(path);
            label1.Text = "Servisi instalirani, da bi ih pokrenuli kliknite start!";
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            string fileName = "start.bat";
            string path = Path.GetFullPath(fileName);
            System.Diagnostics.Process.Start(path);
            label1.Text = "Servisi pokrenuti, možete izaći iz aplikacije!";
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            string fileName = "stop.bat";
            string path = Path.GetFullPath(fileName);
            System.Diagnostics.Process.Start(path);
            label1.Text = "Servisi stopirani, možete ih deinstalirati ili opet pokrenuti!";
        }

        private void btnDeinstaliraj_Click(object sender, EventArgs e)
        {
            string fileName = "uninstall.bat";
            string path = Path.GetFullPath(fileName);
            System.Diagnostics.Process.Start(path);
            label1.Text = "Servisi deinstalirani, možete ih opet instalirati po potrebi!";
        }
    }
}
