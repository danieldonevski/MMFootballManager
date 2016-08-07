using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballManager
{
    class Defender : Player
    {
        public Defender(string firstName, string lastName, int shirtNumber) 
            : base(firstName, lastName, shirtNumber)
        {

        }

        public override string ToString()
        {
           return string.Format("Hi im {0} {1} Im a Defender and my skill rating si {2}!", 
               FirstName, LastName, SkillRating);
        }
    }
}
