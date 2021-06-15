using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KindergartenJoy
{
    public partial class aktivnost
    {
        public void DodajAktivnost(string naziv, string opis, DateTime vrijeme)
        {
            aktivnost novaAktivnost = new aktivnost()
            {
                naziv = naziv,
                opis = opis,
                vrijeme = vrijeme,
            };
            using (var context = new Entities())
            {
                context.aktivnost.Add(novaAktivnost);
                context.SaveChanges();
            }
        }

    }
}
