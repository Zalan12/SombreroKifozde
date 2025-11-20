using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sombrero_kifőzde
{
    public class DisznosEtel : Etel
    {
        public string Hus {  get; set; }
        public DisznosEtel(string nev, string tortilla, int ar, string hus) : base(nev, tortilla, ar)
        {
            Hus = hus;
        }
    }
}
