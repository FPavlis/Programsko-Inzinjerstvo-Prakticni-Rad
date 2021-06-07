using KindergartenJoy.Forme;
using KindergartenJoy.Klase;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KindergartenJoy
{
    public partial class FormPrijava : Form
    {
        public FormPrijava()
        {
            InitializeComponent();
        }

        private void lblKreiraj_Click(object sender, EventArgs e)
        {
            FormRegistracija form = new FormRegistracija();
            form.ShowDialog();
        }

        private void FormPrijava_Load(object sender, EventArgs e)
        {
            lblKreiraj.MouseHover += LblKreiraj_MouseHover;
            lblKreiraj.MouseLeave += LblKreiraj_MouseLeave;
            lblKreiraj.Click += lblKreiraj_Click;
        }


        private void LblKreiraj_MouseLeave(object sender, EventArgs e)
        {
            lblKreiraj.ForeColor = System.Drawing.Color.RoyalBlue;
        }

        private void LblKreiraj_MouseHover(object sender, EventArgs e)
        {
            lblKreiraj.ForeColor = System.Drawing.Color.Black;
        }

        private void btnPrijava_Click(object sender, EventArgs e)
        {
            PokreniPrijavu();
        }

        private void PokreniPrijavu()
        {
            string email = txtEmail.Text;
            string lozinka = txtLozinka.Text;
            lblNetocno.Visible = false;

            List<korisnik> listaKorisnika = korisnik.DohvatiListuKorisnika();

            korisnik odabraniKorisnik = korisnik.DohvatiKorisnika(listaKorisnika, email, lozinka);

            bool pronadjen = ValidacijaRegistracija.ProvjeraKorisnickogRacuna(email, lozinka);

            if(pronadjen == true)
            {
                FormGlavna form = new FormGlavna(odabraniKorisnik);
                form.ShowDialog();
            }
            else
            {
                lblNetocno.Visible = true;
            }

        }
    }
}
