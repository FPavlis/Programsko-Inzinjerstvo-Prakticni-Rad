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
    public partial class FormProfilKorisnika : Form
    {
        public korisnik Korisnik { get; set; }
        public FormProfilKorisnika(korisnik odabraniKorisnik)
        {
            Korisnik = odabraniKorisnik;
            InitializeComponent();
        }

        private void FormProfilKorisnika_Load(object sender, EventArgs e)
        {
            lbImePrezime.Text = Korisnik.ime + " " + Korisnik.prezime;
            lbEmail.Text = Korisnik.email;
            lbTelefon.Text = Korisnik.telefon;
            lbPretplata.Text = "DA";
        }

        private void btnUredi_Click(object sender, EventArgs e)
        {
            FormUrediProfil form = new FormUrediProfil(Korisnik);
            form.ShowDialog();
        }
    }
}
