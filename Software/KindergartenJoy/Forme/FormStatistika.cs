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
        private int brojClickova = 0;
        private List<int> yValues = new List<int>();
        private List<string> xValues = new List<string>(){"DA", "NE" };
        public FormStatistika()
        {
            InitializeComponent();
        }

        private void btnPrikaziDjecu_Click(object sender, EventArgs e)
        {
            chartPretplatnici.Visible = false;
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
            chartPretplatnici.Visible = false;
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
            chartPretplatnici.Visible = false;
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
            chartPretplatnici.Visible = false;
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

        private void btnStatistikaPretplatnika_Click(object sender, EventArgs e)
        {
            brojClickova++;

            chartPretplatnici.Visible = true;
            if (brojClickova == 1) 
            {
                int brojDa, brojNe;
                using (var context = new Entities())
                {
                    var query = from a in context.korisnik
                                where a.pretplata == "D"
                                select a;
                    List<korisnik> listKorisnika = query.ToList();
                    brojDa = listKorisnika.Count();
                }
                using (var context = new Entities())
                {
                    var query = from a in context.korisnik
                                where a.pretplata == "N"
                                select a;
                    List<korisnik> listKorisnika = query.ToList();
                    brojNe = listKorisnika.Count();
                }
                yValues.Add(brojDa);
                yValues.Add(brojNe);

                chartPretplatnici.Series["Broj pretplatnika"].Points.DataBindXY(xValues, yValues);
            }
            
        }
    }
}
