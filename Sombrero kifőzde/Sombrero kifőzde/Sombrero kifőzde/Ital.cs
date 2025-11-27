using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sombrero_kifőzde
{
    public abstract class Ital
    {
        public string Nev {  get; set; }
        public int Ar {  get; set; }

        protected Ital(string nev, int ar)
        {
            Nev = nev;
            Ar = ar;
        }
    }
}
