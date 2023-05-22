using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Football
{
     public class NegativeNumberException:Exception
    {
        public int Number { get; private set; }
        public double NumberD { get; private set; }
        public NegativeNumberException(){}
        public NegativeNumberException(string message) : base(message) { }
        public NegativeNumberException(string message, int number) : base(message) 
        {
            Number = number;
        }
        public NegativeNumberException(string message, double number) : base(message)
        {
            NumberD = number;
        }
    }
    public class NotEnoughPlayersExeption : Exception
    { 
        public int PlayerCout { get; private set; }
        public NotEnoughPlayersExeption() { }
        public NotEnoughPlayersExeption(string message) : base(message) { }
        public NotEnoughPlayersExeption(string message, int number) : base(message)
        {
            PlayerCout = number;
        }
    }
    public class NotInTimeRangeExeption : Exception
    {
        public double Time { get; private set; }
        public NotInTimeRangeExeption() { }
        public NotInTimeRangeExeption(string message) : base(message) { }
        public NotInTimeRangeExeption(string message, double time) : base(message)
        {
            Time = time;
        }
    }
    public class PlayerNotInGameExeption : Exception
    { 
        public FootballPlayer Player { get; private set; }
        public PlayerNotInGameExeption() { }
        public PlayerNotInGameExeption(string message):base(message) { }
        public PlayerNotInGameExeption(string message, FootballPlayer player) : base(message) {
            Player = player;
        }
    }
    public class PlayerExeption : Exception
    {
        public FootballPlayer Player { get; private set; }
        public PlayerExeption() { }
        public PlayerExeption(string message) : base(message) { }
        public PlayerExeption(string message, FootballPlayer player) : base(message)
        {
            Player = player;
        }
    }
}
