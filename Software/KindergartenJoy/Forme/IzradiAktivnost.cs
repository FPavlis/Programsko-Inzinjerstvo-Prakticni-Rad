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
            MessageBox.Show("Aktivnost uspiješno spremljena u bazu!");
        }

        private void btnOdustani_Click_1(object sender, EventArgs e)
        {
            Close();
        }
    }
}
