using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LakoparkProject
{
    class HappyLiving
    {
        List<lakopark> lakoparkok = new List<lakopark>();

        public HappyLiving(List<lakopark> lakoparkok)
        {
            this.lakoparkok = lakoparkok;
        }

        internal List<lakopark> Lakoparkok { get => lakoparkok;}
    }
}
