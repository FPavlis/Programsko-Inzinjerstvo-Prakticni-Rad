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
    public partial class FormUrediProfil : Form
    {
        public korisnik KorisnikProfil { get; set; }
        public FormUrediProfil(korisnik odabraniKorisnik)
        {
            KorisnikProfil = odabraniKorisnik;
            InitializeComponent();
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FormUrediProfil_Load(object sender, EventArgs e)
        {
            lbImePrezime.Text = KorisnikProfil.ime + " " + KorisnikProfil.prezime;
        }
    }
}
