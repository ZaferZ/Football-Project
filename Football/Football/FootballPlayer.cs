using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Football
{
    public abstract class FootballPlayer:Person
    {
        private int number;
        private double height;
        public FootballPlayer() { }
        public FootballPlayer(string name, int age, int number, double height) : base(name, age)
        {
            Number = number;
            Height = height;
        }

        public int Number 
        {
            get {
                return number;
            }
            protected set {
                if (value<=0)
                {
                    throw new NegativeNumberException("Player number cannot be negative or zero",value);
                }
                number = value;
            }
        }
        public double Height
        {
            get
            {
                return number;
            }
            protected set
            {
                if (value <= 0)
                {
                    throw new NegativeNumberException("Player height cannot be negative or zero", value);
                }
                height = value;
            }
        }
    }


}
