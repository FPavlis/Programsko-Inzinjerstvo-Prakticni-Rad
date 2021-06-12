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
        public static bool Reset { get; set; }
        public korisnik OdabraniKorisnik { get; set; }
        public FormGlavna(korisnik odabraniKorisnik)
        {
            OdabraniKorisnik = odabraniKorisnik;
            InitializeComponent();
        }
        public FormGlavna()
        {

        }

        private void FormGlavna_Load(object sender, EventArgs e)
        {
            string vrijeme = DateTime.Now.ToShortDateString();
            lblVrijeme.Text = vrijeme;
            lblIme.Text = OdabraniKorisnik.ime + " " + OdabraniKorisnik.prezime;

            pbProfil.MouseHover += PbProfil_MouseHover;
            pbProfil.MouseLeave += PbProfil_MouseLeave;
            lblIme.MouseHover += LblIme_MouseHover;
            lblIme.MouseLeave += LblIme_MouseLeave;
            
        }

        private void LblIme_MouseLeave(object sender, EventArgs e)
        {
            lblIme.ForeColor = System.Drawing.Color.Black;
        }

        private void LblIme_MouseHover(object sender, EventArgs e)
        {
            lblIme.ForeColor = System.Drawing.Color.Red;
        }

        private void PbProfil_MouseLeave(object sender, EventArgs e)
        {
            lblIme.ForeColor = System.Drawing.Color.Black;
        }

        private void PbProfil_MouseHover(object sender, EventArgs e)
        {
            lblIme.ForeColor = System.Drawing.Color.Red;
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

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            FormProfilKorisnika form = new FormProfilKorisnika(OdabraniKorisnik);
            form.ShowDialog();

            if (Reset == true)
            {
                Reset = false;
                Hide();
                FormPrijava prijava = new FormPrijava();
                prijava.ShowDialog();
                Close();              
            }
        }

        private void lblIme_Click(object sender, EventArgs e)
        {
            FormProfilKorisnika form = new FormProfilKorisnika(OdabraniKorisnik);
            form.ShowDialog();

            if (Reset == true)
            {
                Reset = false;
                Hide();
                FormPrijava prijava = new FormPrijava();
                prijava.ShowDialog();
                Close();
            }
        }

        private void btnObavijesti_Click(object sender, EventArgs e)
        {
            if (OdabraniKorisnik.tip_korisnik_id == 2)
            {
                FormObavijesti forma = new FormObavijesti(OdabraniKorisnik);
                forma.ShowDialog();
            }
            else
            {
                FormObavijestiRoditelj forma = new FormObavijestiRoditelj(OdabraniKorisnik);
                forma.ShowDialog();
            }
        }
    }
}
