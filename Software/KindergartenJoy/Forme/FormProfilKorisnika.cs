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
            RefreshUI();
        }

        private void RefreshUI()
        {
            lbImePrezime.Text = Korisnik.ime + " " + Korisnik.prezime;
            lbEmail.Text = Korisnik.email;
            lbTelefon.Text = Korisnik.telefon;

            if (Korisnik.pretplata == null)
            {
                lbPretplata.Text = "NE";
            }

            if (Korisnik.pretplata == "N")
            {
                lbPretplata.Text = "NE";
            }

            if (Korisnik.pretplata == "D")
            {
                lbPretplata.Text = "DA";
            }
        }

        private void btnUredi_Click(object sender, EventArgs e)
        {
            FormUrediProfil form = new FormUrediProfil(Korisnik);
            form.ShowDialog();
            RefreshUI();
        }

        private void btnNaslovnica_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnIzbrisi_Click(object sender, EventArgs e)
        {
            FormPotvrdaBrisanja form = new FormPotvrdaBrisanja(Korisnik);
            form.ShowDialog();
            
            if(FormGlavna.Reset == true)
            {
                Close();
            }
            
        }

        private void btnDjeca_Click(object sender, EventArgs e)
        {
            FormMojaDjeca form = new FormMojaDjeca(Korisnik);

            form.ShowDialog();
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
