using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sombrero_kifőzde
{
    public class CsirkesEtel : Etel
    {
        public string Hus {  get; set; }
        public CsirkesEtel(string nev, string tortilla, int ar, string hus, string osszetevok) : base(nev, tortilla, ar, osszetevok)
        {
            Hus = hus;
        }

        public override string ToString()
        {
            return "Az étel neve: " + Nev + "\nAz étel hústípusa: " + Hus + "\nAz étel ára: " + Ar + "\nTortillás?: " + Tortilla + "\n\n";
        }
        public override string HusIras()
        {
            return Hus;
        }
    }
}
