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
    public partial class PregledajAktivnosti : Form
    {
        public PregledajAktivnosti()
        {
            InitializeComponent();
        }

        private void PregledajAktivnosti_Load(object sender, EventArgs e)
        {
            LoadajDGV();
        }

        private void LoadajDGV()
        {
            using (var context = new Entities())
            {
                var query = from a in context.aktivnost
                            select a;
                dgvAktivnosti.DataSource = query.ToList();
                dgvAktivnosti.Columns["korisnik_id"].Visible = false;
                dgvAktivnosti.Columns["aktivnost_id"].Visible = false;
                dgvAktivnosti.Columns["korisnik"].Visible = false;
                dgvAktivnosti.Columns["korisnik1"].Visible = false;
            }
        }

        private void btnDodajAktivnost_Click(object sender, EventArgs e)
        {
            IzradiAktivnost izradiAktivnost = new IzradiAktivnost();
            izradiAktivnost.ShowDialog();
            LoadajDGV();
        }

        private void btnObrisiAktivnost_Click(object sender, EventArgs e)
        {
            using (var context = new Entities())
            {
                aktivnost aktivnostZaBrisanje = dgvAktivnosti.CurrentRow.DataBoundItem as aktivnost;
                context.aktivnost.Attach(aktivnostZaBrisanje);
                context.aktivnost.Remove(aktivnostZaBrisanje);
                context.SaveChanges();
                LoadajDGV();
            }
        }
    }
}
