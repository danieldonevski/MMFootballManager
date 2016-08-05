using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballManager
{
    public abstract class Player
    {
        //private string _name;
        //private string _lastName;
        //private int _shirtNumber;
        //private int _stamina;
        //private int _attackingSkill;
        //private int _defendingSkill;
        //private int _ballControlSkill;
        //private int _sprintSkill;
        private int _skillRating;
        private TimeSpan _timeTrained = new TimeSpan();
        public Player(string firstName,string lastName, int shirtNumber)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.ShirtNumber = shirtNumber;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int ShirtNumber { get; set; }
        public int Stamina { get; private set; } = 50;
        public int AttackingSkill { get; private set; } = 50;
        public int DefendingSkill { get; private set; } = 50;
        public int BallControlSkill { get; private set; } = 50;
        public int SprintSkill { get; private set; } = 50;
        public int SkillRating { get { return _skillRating; } private set { _skillRating = value; } } 
        public TimeSpan TimeTrained { get { return _timeTrained; } }
        public void Train(TimeSpan time)
        {
            _timeTrained += time;

            int hours = time.Hours;

            if (time.Days > 0)
            {
                hours += time.Days * 24;
            }
            for (int i = 0; i < hours ; i++)
            {

                if (hours >= 10)
                {
                    Stamina += 1;
                    AttackingSkill += 1;
                    DefendingSkill += 1;
                    BallControlSkill += 1;
                    SprintSkill += 1;
                    SkillRating = (Stamina + AttackingSkill + DefendingSkill + BallControlSkill + SprintSkill) / 5;
                    hours -= 10;
                }
            }
        }
    }
}
