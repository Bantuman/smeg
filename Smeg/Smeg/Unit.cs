using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smeg
{
    public class Unit
    {
        public int Size { get; set; }
        public Faction Faction { get; private set; }
        public int Progress { get; set; } // Progress on current path (0 - 100)
    }
}
