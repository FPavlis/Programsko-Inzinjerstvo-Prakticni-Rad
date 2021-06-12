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
    public partial class FormObavijestiRoditelj : Form
    {
        private korisnik roditelj;
        public FormObavijestiRoditelj(korisnik odabraniKorisnik)
        {
            roditelj = odabraniKorisnik;
            InitializeComponent();
        }

        private void DgvObavijesti_SelectionChanged(object sender, EventArgs e)
        {

            obavijest obv = dgvObavijesti.CurrentRow.DataBoundItem as obavijest;
            txtNazivObavijesti.Text = obv.naslov;
            lblOpis.Text = obv.opis;
            lblDatum.Text = obv.datum_vrijeme.ToShortDateString();
        }

        private void FormObavijestiRoditelj_Load(object sender, EventArgs e)
        {
            rbDa.Checked = true;
            lblPretplata.Visible = false;

            using (var context = new Entities())
            {
                var query = from o in context.obavijest
                            select o;
                dgvObavijesti.DataSource = query.ToList();
                dgvObavijesti.Columns["korisnik"].Visible = false;
                dgvObavijesti.Columns["obavijest_id"].Visible = false;
                dgvObavijesti.Columns["korisnik_id"].Visible = false;
            }

            dgvObavijesti.SelectionChanged += DgvObavijesti_SelectionChanged;
        }

        private void btnPrijava_Click(object sender, EventArgs e)
        {
            string pretplata = "";

            if (rbDa.Checked == true)
            {
                pretplata = "D";
            }
            if (rbNe.Checked == true)
            {
                pretplata = "N";
            }

            korisnik.Pretplata(roditelj, pretplata);

            if(rbDa.Checked == true)
            {
                lblPretplata.Text = "Uspješna pretplata!";
                lblPretplata.Visible = true;
            }
            if(rbNe.Checked == true)
            {
                lblPretplata.Text = "Otkazana pretplata!";
                lblPretplata.Visible = true;
            }
        }

        private void btnNaslovnica_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
