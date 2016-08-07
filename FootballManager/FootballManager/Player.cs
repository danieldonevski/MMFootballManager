using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballManager
{
    public abstract class Player : ITrainable
    {
        //private string _name;
        //private string _lastName;
        //private int _shirtNumber;
        //private int _stamina;
        //private int _attackingSkill;
        //private int _defendingSkill;
        //private int _ballControlSkill;
        //private int _sprintSkill;
        protected int _skillRating;
        protected TimeSpan _timeTrained = new TimeSpan();
        protected int _hours;

        public Player(string firstName, string lastName, int shirtNumber)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.ShirtNumber = shirtNumber;
        }

        public string FirstName { get; protected set; }
        public string LastName { get; protected set; }
        public int ShirtNumber { get; set; }
        protected int Stamina { get; private set; } = 50;
        protected int AttackingSkill { get; private set; } = 50;
        protected int DefendingSkill { get; private set; } = 50;
        protected int BallControlSkill { get; private set; } = 50;
        protected int SprintSkill { get; private set; } = 50;
        protected int SkillRating { get { return _skillRating; } private set { _skillRating = value; } }
        protected TimeSpan TimeTrained { get { return _timeTrained; } }

        public virtual void Train(TimeSpan time)
        {
            _timeTrained += time;

            _hours = time.Hours;

            if (time.Days > 0)
            {
                _hours += time.Days * 24;
            }

            Stamina += _hours / 10;
            AttackingSkill += _hours / 10;
            DefendingSkill += _hours / 10;
            BallControlSkill += _hours / 10;
            SprintSkill += _hours / 10;
            SkillRating = (Stamina + AttackingSkill + DefendingSkill + BallControlSkill + SprintSkill) / 5;

        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
