using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smeg
{
    public class Player
    {
        public Faction Faction { get; set; }
        public string Name { get; private set; }
        public int Id { get; private set; }

        public Player(string name)
        {
            Name = name;
        }
    }
}
