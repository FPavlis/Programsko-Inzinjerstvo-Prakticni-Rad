using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KindergartenJoy
{
    public partial class upis
    {
        public int Roditelj { get; set; }
        public dijete Dijete { get; set; }
        public DateTime DatumUpisa { get; set; }

        public dijete UpisiDijete(string ime, string prezime, string spol, DateTime datumRođenja, int oib)
        {
            dijete novoDijete = new dijete
            {
                ime = ime,
                prezime = prezime,
                spol = spol,
                datum_rodjenja = datumRođenja,
                oib = oib
            };

            using (var context = new Entities())
            {
                context.dijete.Add(novoDijete);
                context.SaveChanges();
            }

            return novoDijete;
        }

        public static List<upis> DohvatiSveUpise()
        {
            using (var context = new Entities())
            {
                List<upis> upisi = context.upis.ToList();

                return upisi;
            }
        }
    }
}
