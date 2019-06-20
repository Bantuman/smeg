using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smeg
{
    public class Path
    {
        public List<Unit> Units { get; private set; }
        public City CityA { get; private set; }
        public City CityB { get; private set; }
    }
}
