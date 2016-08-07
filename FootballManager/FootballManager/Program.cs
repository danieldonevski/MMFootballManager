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

            Console.Write("Write your name: ");
            string name = Console.ReadLine();

            Coach coach = new Coach(name);
          
            coach.AddPlayer(new Goalkeeper("Daniel", "Donevski", 13));
            coach.AddPlayer(new Defender("Petko","Stoyanov",4));
            coach.AddPlayer(new Midfielder("Ivan", "Stanchev", 10));
            coach.AddPlayer(new Forward("Stefan", "Staynov", 7));

            Random r = new Random();

            foreach (var player in coach.Team)
            {

                int i = r.Next(10, 100);
                player.Train(new TimeSpan(i,0,0));
            }

            foreach (var player in coach.Team)
            {
                Console.WriteLine(player);

            }

            Console.WriteLine("---------------------");
        }
    }
}
