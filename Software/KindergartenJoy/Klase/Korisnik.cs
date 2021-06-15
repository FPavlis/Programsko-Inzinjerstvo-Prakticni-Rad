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
        internal static List<korisnik> DohvatiListuKorisnika()
        {
            using(var context = new Entities())
            {
                List<korisnik> listaKorisnika = context.korisnik.ToList();
                return listaKorisnika;
            }
        }

        internal static korisnik DohvatiKorisnika(List<korisnik> listaKorisnika, string email, string lozinka)
        {
            korisnik odabraniKorisnik = null;

            foreach (var item in listaKorisnika)
            {
                if(item.email == email && item.lozinka == lozinka)
                {
                    odabraniKorisnik = item;
                }
            }

            return odabraniKorisnik;
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
                aktivnost_id = 3 
            };

            using(var context = new Entities())
            {
                context.korisnik.Add(noviKorisnik);
                context.SaveChanges();
            }

        }

        public static void PromijeniPodatke(korisnik odabraniKorisnik, string email, string telefon, string pretplata) 
        {
            using (var context = new Entities())
            {
                context.korisnik.Attach(odabraniKorisnik);
                odabraniKorisnik.email = email;
                odabraniKorisnik.telefon = telefon;
                odabraniKorisnik.pretplata = pretplata;

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

        public static void Pretplata(korisnik odabraniKorisnik, string pretplata)
        {
            using (var context = new Entities())
            {
                context.korisnik.Attach(odabraniKorisnik);
                odabraniKorisnik.pretplata = pretplata;
                context.SaveChanges();
            }

        }

    }
}
