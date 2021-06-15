using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KindergartenJoy
{
    public partial class dijete
    {
        public static List<dijete> DohvatiListuDjece()
        {
            using (var context = new Entities())
            {
                List<dijete> listaDjece = context.dijete.ToList();

                return listaDjece;
            }
        }
    }
}
