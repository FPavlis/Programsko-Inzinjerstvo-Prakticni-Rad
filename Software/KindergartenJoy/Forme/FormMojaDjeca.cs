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
    public partial class FormMojaDjeca : Form
    {
        private const string sHTMLHelpFileName = "User manual KindergartenJoy.chm";
        public korisnik Roditelj { get; set; }
        public FormMojaDjeca(korisnik odabraniKorisnik)
        {
            Roditelj = odabraniKorisnik;
            InitializeComponent();
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FormMojaDjeca_Load(object sender, EventArgs e)
        {
            RefreshGUI();
        }

        private void RefreshGUI()
        {
            List<dijete> svaDjeca = dijete.DohvatiListuDjece();
            List<upis> sviUpisi = upis.DohvatiSveUpise();
            List<upis> upisiRoditelja = new List<upis>();
            List<dijete> djecaRoditelja = new List<dijete>();

            foreach (var item in sviUpisi)
            {
                if(item.korisnik_id == Roditelj.korisnik_id)
                {
                    upisiRoditelja.Add(item);
                }
            }

            foreach (var dijete in svaDjeca)
            {
                foreach (var roditelj in upisiRoditelja)
                {
                    if(dijete.dijete_id == roditelj.dijete_id)
                    {
                        djecaRoditelja.Add(dijete);
                    }
                }
            }

            dgvDjeca.DataSource = djecaRoditelja;
            dgvDjeca.Columns["biljeska"].Visible = false;
            dgvDjeca.Columns["se_nalazi"].Visible = false;
            dgvDjeca.Columns["upis"].Visible = false;
        }

        private dijete DohvatiIzabranoDijete()
        {
            return dgvDjeca.CurrentRow.DataBoundItem as dijete;
        }

        private void btnIspis_Click(object sender, EventArgs e)
        {
            dijete odabranoDijete = DohvatiIzabranoDijete();

            if(odabranoDijete != null)
            {
                using (var context = new Entities())
                {
                    context.dijete.Attach(odabranoDijete);
                    context.dijete.Remove(odabranoDijete);
                    context.SaveChanges();
                }
            }

            RefreshGUI();
        }

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
