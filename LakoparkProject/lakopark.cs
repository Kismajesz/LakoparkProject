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

        public lakopark(int[,] hazak, int maxHazSzam, string nev, int utcakSzama)
        {
            this.hazak = hazak;
            this.maxHazSzam = maxHazSzam;
            this.nev = nev;
            this.utcakSzama = utcakSzama;
        }

        public int[,] Hazak { get => hazak;  }
        public int MaxHazSzam { get => maxHazSzam;  }
        public string Nev { get => nev; }
        public int UtcakSzama { get => utcakSzama; }
    }
}
