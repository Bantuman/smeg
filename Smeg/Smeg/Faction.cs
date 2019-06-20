using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smeg
{
    public class Faction
    {
        private IMeta currentMeta;
        public List<City> OwnedCities { get; set; }
        public List<Player> Players { get
            {
                List<Player> players = new List<Player>();
                foreach(Player player in currentMeta.gameHandle.Players)
                {
                    if (player.Faction == this)
                    {
                        players.Add(player);
                    }
                }
                return players;
            }
        }
    }
}
