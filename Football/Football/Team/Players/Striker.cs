using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Football.Players
{
    public class Striker:FootballPlayer
    {
        public Striker() { }
        public Striker(string name, int age, int number, double height) : base(name, age, number, height)
        {
        }
    }
}
