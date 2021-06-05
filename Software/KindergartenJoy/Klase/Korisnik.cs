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

    }
}
