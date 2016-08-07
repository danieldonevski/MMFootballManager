using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballManager
{
    public class Coach
    {
        private string _playerName;
        private int _irrelevantNumber;
        private List<Player> _team = new List<Player>();
       
        public Coach(string name)
        {
            PlayerName = name;
            Console.WriteLine("---------------------");
            Console.WriteLine($"Hello {PlayerName} this is your Team!");
            Console.WriteLine("---------------------");
        }

        public List<Player> Team { get { return _team; } set { _team = value; } }

        public string PlayerName
        {
            get { return _playerName; }

            set
            {
                while (true)
                {
                    if (value != string.Empty && !int.TryParse(value, out _irrelevantNumber))
                    {
                        _playerName = value;
                        break;
                    }
                    Console.WriteLine("Invalid input!");
                    Console.Write("Try again: ");
                    value = Console.ReadLine();
                }
            }
        }


        public void AddPlayer(Player player)
        {
            if (Team.Count == 22)
            {
                throw new ApplicationException("The team is full!");
            }

            foreach (var member in Team)
            {
                if (member.ShirtNumber == player.ShirtNumber)
                {
                    throw new ApplicationException("The shirt is full!");
                }
            }

            Team.Add(player);
        }

        public void RemovePlayer(Player player)
        {
            Team.Remove(player);
        }
    }
}
