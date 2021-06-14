using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
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
            LoadCijeliDGV();
        }

        private void LoadCijeliDGV()
        {
            using (var context = new Entities())
            {
                var query = from o in context.obavijest
                            select o;
                dgvObavijesti.DataSource = query.ToList();
                dgvObavijesti.Columns["korisnik"].Visible = false;
                dgvObavijesti.Columns["obavijest_id"].Visible = false;
                dgvObavijesti.Columns["korisnik_id"].Visible = false;
            }

        }

        private void DgvObavijesti_SelectionChanged(object sender, EventArgs e)
        {

            obavijest obv = dgvObavijesti.CurrentRow.DataBoundItem as obavijest;

            if(obv != null)
            {
                txtNazivObavijesti.Text = obv.naslov;
                lblOpis.Text = obv.opis;
                lblDatum.Text = obv.datum_vrijeme.ToShortDateString();
            }
        }

        private void FormObavijestiRoditelj_Load(object sender, EventArgs e)
        {
            rbDa.Checked = true;
            lblPretplata.Visible = false;

            dgvObavijesti.SelectionChanged += DgvObavijesti_SelectionChanged;
        }       

        private void PosaljiNaMail()
        {
            PdfPTable pTable = new PdfPTable(dgvObavijesti.Columns.Count);
            pTable.DefaultCell.Padding = 2;
            pTable.WidthPercentage = 100;
            pTable.HorizontalAlignment = Element.ALIGN_LEFT;
            foreach (DataGridViewColumn col in dgvObavijesti.Columns)
            {
                PdfPCell pCell = new PdfPCell(new Phrase(col.HeaderText));
                pTable.AddCell(pCell);
            }
            foreach (DataGridViewRow viewRow in dgvObavijesti.Rows)
            {
                foreach (DataGridViewCell dcell in viewRow.Cells)
                {
                    pTable.AddCell(Convert.ToString(dcell.Value));
                }
            }
            var doc = new Document();
            MemoryStream memoryStream = new MemoryStream();
            PdfWriter writer = PdfWriter.GetInstance(doc, memoryStream);

            doc.Open();
            doc.Add(pTable);

            writer.CloseStream = false;
            doc.Close();
            memoryStream.Position = 0;

            MailMessage mm = new MailMessage("pi21.tim12@gmail.com", roditelj.email)
            {
                Subject = "Obavijesti",
                IsBodyHtml = true,
                Body = "Lijepi pozdrav! KindergartenJoy Vam šalje vaše obavijesti! \n Nalaze se u PDF obliku unutar priloga ovog mail-a.\n" +
                " Ovo je automatski generirana e-pošta - nemojte na nju odgovarati. " +
                "Ako imate pitanja u vezi s ovim mailom, pošaljite mail na pi21.tim12@gmail.com"
            };

            mm.Attachments.Add(new Attachment(memoryStream, $"Obavijesti-{roditelj.ime}-{roditelj.prezime}.pdf"));
            SmtpClient smtp = new SmtpClient
            {
                Host = "smtp.gmail.com",
                Port = 587,
                EnableSsl = true,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential("pi21.tim12", "ivanfilipsilvio")

            };

            smtp.Send(mm);
            MessageBox.Show("Mail uspješno poslan!", "Uspijeh!", MessageBoxButtons.OK);
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

        private void LoadajDGV()
        {
            using (var context = new Entities())
            {
                var query = from a in context.obavijest
                            select new
                            {
                                a.naslov,
                                a.datum_vrijeme,
                                a.opis
                            };
                dgvObavijesti.DataSource = query.ToList();
            }
        }

        private void btnPosaljiNaMail_Click(object sender, EventArgs e)
        {
            LoadajDGV();
            PosaljiNaMail();
            LoadCijeliDGV();
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
