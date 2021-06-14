using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KindergartenJoy.Forme
{
    public partial class IzradiAktivnost : Form
    {
        public IzradiAktivnost()
        {
            InitializeComponent();
        }
        private void btnSpremiAktivnost_Click_1(object sender, EventArgs e)
        {
            string nazivAktivnosti = txtNazivAktivnosti.Text;
            string opis = txtOpisAktivnosti.Text;
            DateTime dateTime = dtpDatumIVrijemeAktivnosti.Value;
            aktivnost aktivnost1 = new aktivnost();
            aktivnost1.DodajAktivnost(nazivAktivnosti, opis, dateTime);

            FormAktivnostDodana form = new FormAktivnostDodana();
            form.ShowDialog();

            Close();
        }

        private void btnOdustani_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private const string sHTMLHelpFileName = "User manual KindergartenJoy.chm";
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.F1)
            {
                System.Windows.Forms.Help.ShowHelp(this, Application.StartupPath + @"\" + sHTMLHelpFileName);
                return true;
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }
    }
}
