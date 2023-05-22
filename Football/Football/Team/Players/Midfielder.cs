using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Football.Players
{
    public class Midfielder:FootballPlayer
    {
        public Midfielder() { }
        public Midfielder(string name, int age, int number, double height) : base(name, age, number, height)
        {
        }
    }
}
