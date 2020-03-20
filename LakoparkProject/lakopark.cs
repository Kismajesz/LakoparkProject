using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LakoparkProject
{
    class lakopark
    {
        private int[,] hazak;
        private int maxHazSzam;
        private string nev;
        private int utcakSzama;

        public lakopark(string nev, int utcakSzama , int maxHazSzam, int[,] hazak)
        {
            this.nev = nev;
            this.utcakSzama = utcakSzama;
            this.maxHazSzam = maxHazSzam;
            this.hazak = hazak;

        }

        public int[,] Hazak { get => hazak;  }
        public int MaxHazSzam { get => maxHazSzam;  }
        public string Nev { get => nev; }
        public int UtcakSzama { get => utcakSzama; }
    }
}
