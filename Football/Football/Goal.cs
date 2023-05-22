using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Football
{
    public class Goal
    {
        private double minute;
        public FootballPlayer Player { get; set; }
        public double GameTime2 { get { return GameTime2; } set { GameTime2 = value; } }
        public Goal()
        { }
        public Goal(double minute, FootballPlayer player)
        {
            Minute = minute;
            Player = player;
        }
       
        public double Minute
        {
           
            get
            {
                return minute;
            }

            set
            {
                minute = Math.Round(value, 2);
            }
        }
       
    }
}
