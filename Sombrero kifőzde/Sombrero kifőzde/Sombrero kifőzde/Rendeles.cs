using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sombrero_kifőzde
{
    public class Rendeles
    {
        public Etel Etel { get; set; }
        public Ital Ital { get; set; }
        public int Osszar {  get; set; }
        public bool Elvitel { get; set; }

        public Rendeles(Etel etel, Ital ital, int osszar, bool elvitel)
        {
            Etel = etel;
            Ital = ital;
            Osszar = osszar;
            Elvitel = elvitel;
        }
    }
}
