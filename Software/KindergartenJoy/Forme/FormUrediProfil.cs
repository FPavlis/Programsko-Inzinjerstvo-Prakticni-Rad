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

        private void btnSpremi_Click(object sender, EventArgs e)
        {
            lbPogreska.Visible = false;

            if(txtEmail.Text == "" || txtTelefon.Text == "")
            {
                lbPogreska.Visible = true;
            }
            else
            {
                SpremiSvePromijene();
                Close();
            }
        }

        private void SpremiSvePromijene()
        {
            string email = txtEmail.Text;
            string telefon = txtTelefon.Text;
            string pretplata = "";

            if(rbDa.Checked == true)
            {
                pretplata = "D";
            }
            if(rbNe.Checked == true)
            {
                pretplata = "N";
            }

            korisnik.PromijeniPodatke(KorisnikProfil, email, telefon, pretplata);

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
