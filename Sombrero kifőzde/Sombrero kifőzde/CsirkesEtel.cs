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
        public CsirkesEtel(string nev, string tortilla, int ar, string hus) : base(nev, tortilla, ar)
        {
            Hus = hus;
        }
    }
}
