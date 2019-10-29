using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TanarSeged.Model
{
    class Diak
    {
        public string Nev { get; set; }
        public int Osztalyzat { get; set; }
        public bool Hianyzas { get; set; }

        public Diak(string nev, int osztalyzat = 0, bool hianyzas = false)
        {
            Nev = nev;
            Osztalyzat = osztalyzat;
            Hianyzas = hianyzas;
        }

        
    }
}
