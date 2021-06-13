using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;

namespace KindergartenJoy.Forme
{
    public partial class PregledajAktivnosti : Form
    {
        private korisnik korisnik;
        public PregledajAktivnosti(korisnik odabraniKorisnik)
        {
            InitializeComponent();
            korisnik = odabraniKorisnik;
        }

        private void PregledajAktivnosti_Load(object sender, EventArgs e)
        {
            LoadajDGV();
            if(korisnik.tip_korisnik_id != 2)
            {
                btnDodajAktivnost.Enabled = false;
                btnExport.Enabled = false;
                btnObrisiAktivnost.Enabled = false;
                btnPošaljiNaMail.Enabled = false;
            }
        }

        private void LoadajCijeliDGV()
        {
            using (var context = new Entities())
            {
                var query = from a in context.aktivnost
                            select a;
                dgvAktivnosti.DataSource = query.ToList();
                dgvAktivnosti.Columns["korisnik_id"].Visible = false;
                dgvAktivnosti.Columns["korisnik"].Visible = false;
                dgvAktivnosti.Columns["korisnik1"].Visible = false;
                
            }
        }

        private void LoadajDGV()
        {
            using (var context = new Entities())
            {
                var query = from a in context.aktivnost
                            select new
                            {
                                a.naziv,
                                a.opis,
                                a.vrijeme
                            };
                dgvAktivnosti.DataSource = query.ToList();
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
                LoadajCijeliDGV();
                aktivnost aktivnostZaBrisanje = dgvAktivnosti.CurrentRow.DataBoundItem as aktivnost;
                context.aktivnost.Attach(aktivnostZaBrisanje);
                context.aktivnost.Remove(aktivnostZaBrisanje);
                context.SaveChanges();
                LoadajDGV();
            }
        }


        private string DodajAttachmentMailu()
        {
            string putanja = "";
            OpenFileDialog dialog = new OpenFileDialog();
            if(dialog.ShowDialog() == DialogResult.OK)
            {
                 putanja = dialog.FileName.ToString();
            }
            return putanja;
        }

        private string DohvatiMailingListu()
        {
            string mailingLista = "";
            using (var context = new Entities())
            {
                var query = from a in context.korisnik
                            select a.email;
                List<string> pomocna = query.ToList();
                mailingLista = string.Join(",", pomocna);
            }
            return mailingLista;
        }

        private void PošaljiPoruku()
        {
            string fromMail = "pi21.tim12@gmail.com";
            string toMail = DohvatiMailingListu();
            string subjectOfMail = "Tjedne aktivnosti - KindergartenJoy";
            string messageOfMail = "Poštovani, u privitku Vam šaljemo tjedne aktivnosti. Vaš KindergartenJoy!";
            string smtpValue = "smtp.gmail.com";
            string username = "pi21.tim12";
            string password = "ivanfilipsilvio";
            MailMessage mail = new MailMessage(fromMail,toMail,subjectOfMail,messageOfMail);
            mail.Attachments.Add(new Attachment(DodajAttachmentMailu()));
            SmtpClient client = new SmtpClient(smtpValue);
            client.Port = 587;
            client.Credentials = new System.Net.NetworkCredential(username, password);
            client.EnableSsl = true;
            client.Send(mail);
            MessageBox.Show("Poruka uspješno poslana!", "Uspijeh!", MessageBoxButtons.OK);
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            if (dgvAktivnosti.Rows.Count > 0)
            {
                SaveFileDialog save = new SaveFileDialog();
                save.Filter = "PDF (*.pdf)|*.pdf";
                save.FileName = "Aktivnosti.pdf";
                bool ErrorMessage = false;

                if (save.ShowDialog() == DialogResult.OK)
                {
                    if (File.Exists(save.FileName))
                    {
                        try
                        {
                            File.Delete(save.FileName);
                        }
                        catch (Exception ex)
                        {
                            ErrorMessage = true;
                            MessageBox.Show("Nemoguće pisati na disk" + ex.Message);
                        }
                    }
                    if (!ErrorMessage)
                    {
                        try
                        {
                            PdfPTable pTable = new PdfPTable(dgvAktivnosti.Columns.Count);
                            pTable.DefaultCell.Padding = 2;
                            pTable.WidthPercentage = 100;
                            pTable.HorizontalAlignment = Element.ALIGN_LEFT;
                            foreach (DataGridViewColumn col in dgvAktivnosti.Columns)
                            {                               
                                PdfPCell pCell = new PdfPCell(new Phrase(col.HeaderText));
                                pTable.AddCell(pCell);
                            }
                            foreach (DataGridViewRow viewRow in dgvAktivnosti.Rows)
                            {
                                foreach (DataGridViewCell dcell in viewRow.Cells)
                                {
                                    pTable.AddCell(Convert.ToString(dcell.Value));
                                }
                            }
                            using (FileStream fileStream = new FileStream(save.FileName, FileMode.Create))
                            {
                                Document document = new Document(PageSize.A4, 8f, 16f, 16f, 8f);
                                PdfWriter.GetInstance(document, fileStream);
                                document.Open();
                                document.Add(pTable);
                                document.Close();
                                fileStream.Close();
                            }
                            MessageBox.Show("Aktivnosti uspješno exportane", "Uspijeh!");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Greška pri exportu podataka" + ex.Message);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Ne postoje rekordi u DataGridView-u", "Info");

            }

        }

        private void btnPošaljiNaMail_Click(object sender, EventArgs e)
        {
            PošaljiPoruku();
        }

        private void btnNaslovnica_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
