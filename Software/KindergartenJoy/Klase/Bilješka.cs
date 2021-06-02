using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KindergartenJoy.Klase
{
    public class Bilješka
    {
        public int KorisnikId { get; set; }
        public int DijeteId { get; set; }
        public string Sadržaj { get; set; }
        public DateTime Datum { get; set; }
    }
}
