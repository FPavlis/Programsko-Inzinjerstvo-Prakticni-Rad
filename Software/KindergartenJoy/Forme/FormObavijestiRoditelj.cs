using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.Net;
using System.Net.Mail;
using System.IO;

namespace KindergartenJoy.Forme
{
    public partial class FormObavijestiRoditelj : Form
    {
        public FormObavijestiRoditelj()
        {
            InitializeComponent();
        }

        private void FormObavijestiRoditelj_Load(object sender, EventArgs e)
        {
            txtOpisObavijesti.Enabled = false;
            txtNazivObavijesti.Enabled = false;
            dtpKreiranjaObavijesti.Enabled = false;
            using (var context = new Entities())
            {
                var query = from o in context.obavijest
                            select o;
                dgvObavijesti.DataSource = query.ToList();
                dgvObavijesti.Columns["korisnik"].Visible = false;
            }

            dgvObavijesti.SelectionChanged += DgvObavijesti_SelectionChanged;
        }

        private void DgvObavijesti_SelectionChanged(object sender, EventArgs e)
        {
            
            obavijest obv = dgvObavijesti.CurrentRow.DataBoundItem as obavijest;
            txtNazivObavijesti.Text = obv.naslov;
            txtOpisObavijesti.Text = obv.opis;
            dtpKreiranjaObavijesti.Value = obv.datum_vrijeme;
        }
    }
}
