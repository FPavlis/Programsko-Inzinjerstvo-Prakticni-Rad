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
            string spolDijeteta = "";

            if (rbMusko.Checked == true)
            {
                spolDijeteta = rbMusko.Text;
            }

            if (rbZensko.Checked == true)
            {
                spolDijeteta = rbZensko.Text;
            }

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

            FormUpisObavljen form = new FormUpisObavljen();
            this.Hide();
            form.ShowDialog();
            this.Close();
        }

        private void FormUpisDjece_Load(object sender, EventArgs e)
        {
            rbMusko.Checked = true;
            pbDecko.Visible = true;
            rbMusko.CheckedChanged += RbMusko_CheckedChanged;
            rbZensko.CheckedChanged += RbZensko_CheckedChanged;
            lblRoditelj.Text = Roditelj.ime + " " + Roditelj.prezime;
            lblVrijeme.Text = DateTime.Now.Date.ToShortDateString();
        }

        private void RbZensko_CheckedChanged(object sender, EventArgs e)
        {
            pbGirl.Visible = true;
            pbDecko.Visible = false;
        }

        private void RbMusko_CheckedChanged(object sender, EventArgs e)
        {
            pbDecko.Visible = true;
            pbGirl.Visible = false;
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            Close();
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
