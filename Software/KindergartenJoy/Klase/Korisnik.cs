using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace KindergartenJoy
{
    public partial class korisnik
    {
        public int Aktivnost { get; set; }
        public int TipKorisnika { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string OIB { get; set; }
        public string KorisnickoIme { get; set; }
        public string Lozinka { get; set; }
        public string LozikaSHA256 { get; set; }
        public string Email { get; set; }
        public string Telefon { get; set; }
        public char Status { get; set; }
        public char Pretplata { get; set; }

        internal static List<korisnik> DohvatiListuKorisnika()
        {
            using(var context = new Entities())
            {
                List<korisnik> listaKorisnika = context.korisnik.ToList();
                return listaKorisnika;
            }
        }

        internal static void DodajNovogKorisnika(string korisnickoIme, string lozinka, string ime, string prezime, string email, string telefon)
        {
            korisnik noviKorisnik = new korisnik
            {
                korisnicko_ime = korisnickoIme,
                lozinka = lozinka,
                lozinka_sha256 = ComputeSha256Hash(lozinka),
                status = "0",
                ime = ime,
                prezime = prezime,
                email = email,
                telefon = telefon,
                tip_korisnik_id = 3,
                aktivnost_id = 3 // ovo je sjebano
            };

            using(var context = new Entities())
            {
                context.korisnik.Add(noviKorisnik);
                context.SaveChanges();
            }

        }

        static string ComputeSha256Hash(string rawData)
        {
            // Create a SHA256   
            using (SHA256 sha256Hash = SHA256.Create())
            {
                // ComputeHash - returns byte array  
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(rawData));

                // Convert byte array to a string   
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }

    }
}
