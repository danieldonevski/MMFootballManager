using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballManager
{
    public class Coach
    {
        public List<Player> team = new List<Player>(22);
        public void AddPlayer(Player player)
        {
            team.Add(player);
        }
        public void RemovePlayer(Player player)
        {
            team.Remove(player);
        }
    }
}
