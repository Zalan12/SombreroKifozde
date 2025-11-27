using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sombrero_kifőzde
{
    public abstract class UditoItal : Ital
    {
        
        public bool Szensav { get; set; }
        protected UditoItal(string nev, int ar, bool szensav) : base(nev, ar)
        {
            Szensav = szensav;
        }
    }
}
