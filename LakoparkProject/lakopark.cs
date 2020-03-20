using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LakoparkProject
{
    class Lakopark
    {
        private int[,] hazak;
        private int maxHazSzam;
        private string nev;
        private int utcakSzama;

        public Lakopark(string nev, int utcakSzama , int maxHazSzam, int[,] hazak)
        {
            this.Nev = nev;
            this.UtcakSzama = utcakSzama;
            this.MaxHazSzam = maxHazSzam;
            this.Hazak = hazak;

        }

        public int[,] Hazak { get => hazak; set => hazak = value; }
        public int MaxHazSzam { get => maxHazSzam; set => maxHazSzam = value; }
        public string Nev { get => nev; set => nev = value; }
        public int UtcakSzama { get => utcakSzama; set => utcakSzama = value; }
    }
}
