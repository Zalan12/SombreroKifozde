using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sombrero_kifőzde
{
    public abstract class Etel
    {
        public string Nev { get; set; }
        public string Tortilla {  get; set; }

        public string Osszetevok { get; set; }
        public int Ar {  get; set; }

        protected Etel(string nev, string tortilla, int ar, string osszetevok)
        {
            Nev = nev;
            Tortilla = tortilla;
            Ar = ar;
            Osszetevok = osszetevok;
        }

        public abstract string ToString();
        public abstract string HusIras();
    }
}
