using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sombrero_kifőzde
{
    public abstract class AlkoholosItal : Ital
    {
        public double Alkohol_tartalom {  get; set; }
        protected AlkoholosItal(string nev, int ar, double alkohol_tartalom) : base(nev, ar)
        {
            Alkohol_tartalom = alkohol_tartalom;
        }
    }
}
