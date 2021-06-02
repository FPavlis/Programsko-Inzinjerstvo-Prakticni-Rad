using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KindergartenJoy
{
    public class Obavijest
    {
        public List<int> Pretplatnici {get; set; }
        public string Naslov { get; set; }
        public DateTime DatumIVrijeme { get; set; }
        public string Opis { get; set; }

    }
}
