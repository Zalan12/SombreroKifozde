using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sombrero_kifőzde
{
    public class Husmentes : Etel
    {
        public string Hus { get; set; }
        public Husmentes(string nev, string tortilla, int ar, string hus) : base(nev, tortilla, ar)
        {
            Hus = hus;
        }

        public override string ToString()
        {
            return "Az étel neve: " + Nev + "\nAz étel hústípusa: " + Hus + "\nAz étel ára: " + Ar + "\nTortillás?: " + Tortilla + "\n\n";
        }
    }
}
