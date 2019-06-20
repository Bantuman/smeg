using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smeg
{
    public enum CityType
    {
        House,
        Factory,
        Artillery,
        Fortress,
        Powerplant
    }

    public class City
    {
        public int Units { get; private set; }
        public CityType Type { get; set; }

        public City(int units, CityType type)
        {
            Units = units;
            Type = type;
        }
    }
}
