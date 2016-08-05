using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballManager
{
    class Program
    {
        static void Main(string[] args)
        {
            Coach ivan = new Coach();
            ivan.AddPlayer(new Goalkeeper("Daniel", "Donevski", 12));
            foreach (var item in ivan.team)
            {
                item.Train(new TimeSpan(10,0,0));
                Console.WriteLine(item.SkillRating);
            }
            
        }
    }
}
