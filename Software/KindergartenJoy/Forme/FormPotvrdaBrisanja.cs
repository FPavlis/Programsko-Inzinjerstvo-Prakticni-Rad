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
    public partial class FormPotvrdaBrisanja : Form
    {
        public korisnik KorisnikZaBrisanje { get; set; }
        public FormPotvrdaBrisanja(korisnik odabraniKorisnik)
        {
            KorisnikZaBrisanje = odabraniKorisnik;
            InitializeComponent();
        }

        private void btnNe_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnDa_Click(object sender, EventArgs e)
        {
            FormGlavna.Reset = true;

            using (var context = new Entities())
            {
                context.korisnik.Attach(KorisnikZaBrisanje);
                context.korisnik.Remove(KorisnikZaBrisanje);
                context.SaveChanges();
            }

            Close();
        }
    }
}
