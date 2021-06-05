using System;
using System.Collections.Generic;
using System.Linq;
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
                status = "Neaktivan",
                prezime = prezime,
                email = email,
                telefon = telefon
            };

            using(var context = new Entities())
            {
                context.korisnik.Add(noviKorisnik);
                context.SaveChanges();
            }

        }

    }
}
