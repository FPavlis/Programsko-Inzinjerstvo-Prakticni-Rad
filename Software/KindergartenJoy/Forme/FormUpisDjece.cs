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
    public partial class FormUpisDjece : Form
    {
        public korisnik Roditelj { get; set; }
        public FormUpisDjece(korisnik odabraniKorisnik)
        {
            Roditelj = odabraniKorisnik;
            InitializeComponent();
        }

        private void btnUpisiDijete_Click(object sender, EventArgs e)
        {
            string imeDijeteta = txtIme.Text;
            string prezimeDijeteta = txtPrezime.Text;
            string spolDijeteta = txtSpol.Text;
            int oibDijeteta = int.Parse(txtOib.Text);
            DateTime datumRođenjaDijeteta = dtpDatumRođenja.Value;
            upis noviUpis = new upis();
            noviUpis.korisnik_id = Roditelj.korisnik_id;
            dijete dijeteStvoreno = noviUpis.UpisiDijete(imeDijeteta,prezimeDijeteta,spolDijeteta,datumRođenjaDijeteta, oibDijeteta);
            noviUpis.dijete_id = dijeteStvoreno.dijete_id;
            DateTime datumUpisa = DateTime.Now;
            noviUpis.datum_upis = datumUpisa;

            using (var context = new Entities())
            {
                context.upis.Add(noviUpis);
                context.SaveChanges();
            }
        }
    }
}
