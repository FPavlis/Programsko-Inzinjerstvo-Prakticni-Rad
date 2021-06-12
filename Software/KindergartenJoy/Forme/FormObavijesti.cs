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
    public partial class FormObavijesti : Form
    {
        private korisnik odabraniKorisnik;
        public FormObavijesti(korisnik odabrani)
        {
            InitializeComponent();
            odabraniKorisnik = odabrani;
        }

        private void btnSpremi_Click(object sender, EventArgs e)
        {
            obavijest novaObavijest = new obavijest()
            {
                naslov = txtNazivObavijesti.Text,
                datum_vrijeme = dtpKreiranjaObavijesti.Value,
                opis = txtOpisObavijesti.Text,
                korisnik_id = odabraniKorisnik.korisnik_id
            };

            using (var context = new Entities())
            {
                context.obavijest.Add(novaObavijest);
                context.SaveChanges();
            }
        }
    }
}
