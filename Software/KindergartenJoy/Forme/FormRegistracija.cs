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

namespace KindergartenJoy.Forme
{
    public partial class FormRegistracija : Form
    {
        public FormRegistracija()
        {
            InitializeComponent();
        }

        private void FormRegistracija_Load(object sender, EventArgs e)
        {

        }

        private void btnRegistracija_Click(object sender, EventArgs e)
        {
            string korisnickoIme = txtKorIme.Text;
            string lozinka = txtLozinkaReg.Text;
            string ime = txtIme.Text;
            string prezime = txtPrezime.Text;
            string email = txtEmailReg.Text;
            string telefon = txtTelefon.Text;
            lblPogreske.Visible = false;

            string poruka = ValidacijaRegistracija.ValidacijaRegistracije(korisnickoIme, lozinka, ime, prezime, email, telefon);

            if(poruka != "")
            {
                lblPogreske.Text = poruka;
                lblPogreske.Visible = true;               
            }

            if(poruka == "")
            {
                korisnik.DodajNovogKorisnika(korisnickoIme, lozinka, ime, prezime, email, telefon);
                MessageBox.Show("Korisnik dodan!");
                Close();
            }
         
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
