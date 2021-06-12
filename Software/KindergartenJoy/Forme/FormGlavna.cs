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
    public partial class FormGlavna : Form
    {
        public korisnik OdabraniKorisnik { get; set; }
        public FormGlavna(korisnik odabraniKorisnik)
        {
            OdabraniKorisnik = odabraniKorisnik;
            InitializeComponent();
        }

        private void FormGlavna_Load(object sender, EventArgs e)
        {
            string vrijeme = DateTime.Now.ToShortDateString();
            lblVrijeme.Text = vrijeme;
            lblIme.Text = OdabraniKorisnik.ime + " " + OdabraniKorisnik.prezime;
        }

        private void btnAktivnost_Click(object sender, EventArgs e)
        {
            PregledajAktivnosti pregledajAktivnosti = new PregledajAktivnosti(OdabraniKorisnik);
            pregledajAktivnosti.ShowDialog();
        }

        private void btnPrijava_Click(object sender, EventArgs e)
        {
            FormUpisDjece form = new FormUpisDjece(OdabraniKorisnik);
            form.ShowDialog();
        }

        private void btnStatistika_Click_1(object sender, EventArgs e)
        {
            FormStatistika form = new FormStatistika();
            form.ShowDialog();
        }

        private void btnObavijesti_Click(object sender, EventArgs e)
        {
            if(OdabraniKorisnik.tip_korisnik_id == 2)
            {
                FormObavijesti forma = new FormObavijesti(OdabraniKorisnik);
                forma.ShowDialog();
            }
            else
            {
                FormObavijestiRoditelj forma = new FormObavijestiRoditelj();
                forma.ShowDialog();
            }
        }
    }
}
