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
            using (var context = new Entities())
            {
                var query = from a in context.dijete
                            select a;
                dgvGlavni.DataSource = query.ToList();
                dgvGlavni.Columns["biljeska"].Visible = false;
                dgvGlavni.Columns["upis"].Visible = false;
                dgvGlavni.Columns["se_nalazi"].Visible = false;
            }
        }

        private void btnPrikaziKorisnike_Click(object sender, EventArgs e)
        {
            using (var context = new Entities())
            {
                var query = from a in context.korisnik
                            select a;
                dgvGlavni.DataSource = query.ToList();
                dgvGlavni.Columns["upis"].Visible = false;
                dgvGlavni.Columns["radi_u"].Visible = false;
                dgvGlavni.Columns["obavijest"].Visible = false;
                dgvGlavni.Columns["tip_korisnik"].Visible = false;
                dgvGlavni.Columns["dnevnik"].Visible = false;
                dgvGlavni.Columns["biljeska"].Visible = false;
                dgvGlavni.Columns["aktivnost1"].Visible = false;
                dgvGlavni.Columns["aktivnost"].Visible = false;
            }
        }
    }
}
