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
            lblEmail.Text = OdabraniKorisnik.email;
        }
    }
}
