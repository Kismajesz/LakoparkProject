using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows;

namespace LakoparkProject
{
    class HappyLiving
    {
        private List<Lakopark> Lakoparkok;
       public HappyLiving(String fajlNev)
        {
            Lakoparkok = new List<Lakopark>();
            StreamReader reader = new StreamReader(fajlNev);
            String nevsor = reader.ReadLine();
            //Peek() - Megnézi a köv karaktert , de nem olvassa be
            while (reader.Peek() != -1 && nevsor != null) 
            {
                String[] utcaAdatok = reader.ReadLine().Split(';');
                int utcakSzama = Int32.Parse(utcaAdatok[0]);
                int MaxHazSzam = Int32.Parse(utcaAdatok[1])*utcakSzama;
                int[,] hazak = new int[utcakSzama, Int32.Parse(utcaAdatok[1])];
                String hazAdatSor = reader.ReadLine();
                while(reader.Peek() != -1 && !hazAdatSor.Equals(""))
                {
                    String[] hazAdatok = hazAdatSor.Split(';');
                    hazak[Int32.Parse(hazAdatok[0])-1, Int32.Parse(hazAdatok[1])-1] = Int32.Parse(hazAdatok[2]);
                    hazAdatSor = reader.ReadLine();
                }
                Lakopark lakopark = new Lakopark(nevsor,utcakSzama,MaxHazSzam,hazak);
                Lakoparkok.Add(lakopark);
                if (reader.Peek() != -1)
                {
                    nevsor = reader.ReadLine();
                }
            }

        }
    }

}


