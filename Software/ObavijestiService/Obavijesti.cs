using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using KindergartenJoy.Forme;
using KindergartenJoy.Klase;
using KindergartenJoy;
using System.Net.Mail;
using System.Net;
using iTextSharp.text.pdf;
using iTextSharp.text;

namespace ObavijestiService
{
    public class Obavijesti
    {
        private readonly Timer _timer;

        public Obavijesti()
        {
            _timer = new Timer(86400000) { AutoReset = true };
            _timer.Elapsed += TimerElapsed;
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

        private List<obavijest> DohvatiSveObavijesti()
        {
            List<obavijest> lista;
            using (var context = new Entities())
            {
                var query = from a in context.obavijest
                            select a;
                lista = query.ToList();
            }
            return lista;
        }

        private List<obavijest> DohvatiTrazeneObavijesti(List<obavijest> lista)
        {
            List<obavijest> trazene = new List<obavijest>();
            foreach (var obavijest in lista)
            {
                if(obavijest.datum_dogadaja.Day == DateTime.Today.Day+1)
                {
                    trazene.Add(obavijest);
                }
            }
            return trazene;
        }

        private void PosaljiNaMail()
        {
            List<obavijest> obavijesti = DohvatiTrazeneObavijesti(DohvatiSveObavijesti());
            var doc = new Document();
            MemoryStream memoryStream = new MemoryStream();
            PdfWriter writer = PdfWriter.GetInstance(doc, memoryStream);

            doc.Open();
            doc.Add(new Paragraph("Podsjetnik za obavijesti koje će se dogoditi sutra!"));
            foreach (var item in obavijesti)
            {
                doc.Add(new Paragraph("------------------------OBAVIJEST-----------------------"));
                doc.Add(new Paragraph($"Naslov obavijesti: {item.naslov}"));
                doc.Add(new Paragraph($"Opis obavijesti: {item.opis}"));
                doc.Add(new Paragraph($"Datum i vrijeme kreiranja obavijesti: {item.datum_vrijeme}"));
                doc.Add(new Paragraph("--------------------------------------------------------"));
            }
            

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

            mm.Attachments.Add(new Attachment(memoryStream, $"Obavijesti.pdf"));
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

        private void TimerElapsed(object sender, ElapsedEventArgs e)
        {
            List<obavijest> obavijesti = DohvatiTrazeneObavijesti(DohvatiSveObavijesti());
            if (obavijesti.Count != 0)
            {
                PosaljiNaMail();
            }

        }

        public void Start()
        {
            _timer.Start();
        }

        public void Stop()
        {
            _timer.Stop();
        }
    }
}
