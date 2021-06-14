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
    public partial class FormStatistika : Form
    {
        public FormStatistika()
        {
            InitializeComponent();
        }

        private void btnPrikaziDjecu_Click(object sender, EventArgs e)
        {
            int brojDjece = 0;
            using (var context = new Entities())
            {
                var query = from a in context.dijete
                            select a;
                dgvGlavni.DataSource = query.ToList();
                brojDjece = dgvGlavni.RowCount;
                dgvGlavni.Columns["biljeska"].Visible = false;
                dgvGlavni.Columns["upis"].Visible = false;
                dgvGlavni.Columns["se_nalazi"].Visible = false;
            }
            label3.Text = brojDjece.ToString();
        }

        private void btnPrikaziKorisnike_Click(object sender, EventArgs e)
        {
            int brojKorisnika = 0;
            using (var context = new Entities())
            {
                var query = from a in context.korisnik
                            select a;
                dgvGlavni.DataSource = query.ToList();
                brojKorisnika = dgvGlavni.RowCount;
                dgvGlavni.Columns["upis"].Visible = false;
                dgvGlavni.Columns["radi_u"].Visible = false;
                dgvGlavni.Columns["obavijest"].Visible = false;
                dgvGlavni.Columns["tip_korisnik"].Visible = false;
                dgvGlavni.Columns["dnevnik"].Visible = false;
                dgvGlavni.Columns["biljeska"].Visible = false;
                dgvGlavni.Columns["aktivnost1"].Visible = false;
                dgvGlavni.Columns["aktivnost"].Visible = false;
            }
            label4.Text = brojKorisnika.ToString();
        }

        private void btnPrikaziAktivnosti_Click(object sender, EventArgs e)
        {
            int brojAktivnosti = 0;
            using (var context = new Entities())
            {
                var query = from a in context.aktivnost
                            select a;
                dgvGlavni.DataSource = query.ToList();
                brojAktivnosti = dgvGlavni.RowCount;
                dgvGlavni.Columns["korisnik_id"].Visible = false;
                dgvGlavni.Columns["korisnik"].Visible = false;
                dgvGlavni.Columns["korisnik1"].Visible = false;
            }
            label6.Text = brojAktivnosti.ToString();
        }

        private void FormStatistika_Load(object sender, EventArgs e)
        {

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
