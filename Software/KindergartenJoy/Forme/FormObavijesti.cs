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
    public partial class FormObavijesti : Form
    {
        private korisnik odabraniKorisnik;
        public FormObavijesti(korisnik odabrani)
        {
            InitializeComponent();
            odabraniKorisnik = odabrani;
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            Close();
        }

        private string DohvatiMailingListu()
        {
            string mailingLista = "";
            using (var context = new Entities())
            {
                var query = from a in context.korisnik
                            where a.pretplata == "D"
                            select a.email;
                List<string> pomocna = query.ToList();
                mailingLista = string.Join(",", pomocna);
            }
            return mailingLista;
        }

        private void PosaljiNaMail()
        {
            var doc = new Document();
            MemoryStream memoryStream = new MemoryStream();
            PdfWriter writer = PdfWriter.GetInstance(doc, memoryStream);

            doc.Open();
            doc.Add(new Paragraph("Novo kreirana obavijest iz Vašeg KindergartenJoy vrtica!"));
            doc.Add(new Paragraph("------------------------OBAVIJEST-----------------------"));
            doc.Add(new Paragraph($"Naslov obavijesti: {txtNazivObavijesti.Text}"));
            doc.Add(new Paragraph($"Opis obavijesti: {txtOpisObavijesti.Text}"));
            doc.Add(new Paragraph($"Datum i vrijeme kreiranja obavijesti: {dtpDogađaja.Value}"));

            writer.CloseStream = false;
            doc.Close();
            memoryStream.Position = 0;

            MailMessage mm = new MailMessage("pi21.tim12@gmail.com", DohvatiMailingListu())
            {
                Subject = "Obavijesti",
                IsBodyHtml = true,
                Body = "Lijepi pozdrav! KindergartenJoy Vam šalje vaše nove obavijesti! \n Nalaze se u PDF obliku unutar priloga ovog mail-a.\n" +
                " Ovo je automatski generirana e-pošta - nemojte na nju odgovarati. " +
                "Ako imate pitanja u vezi s ovim mailom, pošaljite mail na pi21.tim12@gmail.com"
            };

            mm.Attachments.Add(new Attachment(memoryStream, $"Obavijesti-{odabraniKorisnik.ime}-{odabraniKorisnik.prezime}.pdf"));
            SmtpClient smtp = new SmtpClient
            {
                Host = "smtp.gmail.com",
                Port = 587,
                EnableSsl = true,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential("pi21.tim12", "ivanfilipsilvio")

            };

            smtp.Send(mm);
        }

        private void btnSpremi_Click_1(object sender, EventArgs e)
        {
            obavijest novaObavijest = new obavijest()
            {
                naslov = txtNazivObavijesti.Text,
                datum_vrijeme = DateTime.Now,
                opis = txtOpisObavijesti.Text,
                korisnik_id = odabraniKorisnik.korisnik_id,
                datum_dogadaja = dtpDogađaja.Value,
            };

            using (var context = new Entities())
            {
                context.obavijest.Add(novaObavijest);
                context.SaveChanges();
            }

            PosaljiNaMail();

            FormObavijestDodana form = new FormObavijestDodana();
            form.ShowDialog();
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

        private void button1_Click(object sender, EventArgs e)
        {
            FormWinService formWinService = new FormWinService();
            formWinService.ShowDialog();
        }
    }
}
