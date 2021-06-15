using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KindergartenJoy.Klase
{
    public partial class dnevnik
    {
        public int KorisnikId { get; set; }
        public int TipRadnjaId { get; set; }
        public string Sadržaj { get; set; }
        public DateTime DatumIVrijeme { get; set; }
        public string SiguronosnaKopijaSQL { get; set; }
    }
}
