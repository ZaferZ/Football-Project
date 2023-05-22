using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Football.Team
{
    public class Team
    {
        public string Name { get; private set; }    
        public Coach TeamCoach { get; private set; }
        public List<FootballPlayer> Players { get; set; } = new List<FootballPlayer>();
        public Team(string name, Coach teamCoach, List<FootballPlayer> players)
        {
            if (players.Count < 11 && players.Count > 22)
            {
                throw new NotEnoughPlayersExeption("Team must contain at least 11 players, but not more that 22");
            }
            Name = name;
            TeamCoach = teamCoach;
            Players = players;
        }

        public int AverageAgeOfPlayersOnTeam() 
        {
            if (Players.Count <11 ||Players.Count>22)
            {
                throw new NotEnoughPlayersExeption("Team must contain at least 11 players and max 22 players",Players.Count);
            }
            int br = 0;
            int sum = 0;
            foreach (var player in Players)
            {
                br++;
                sum+=player.Age;
            }
            return sum / br;
        }
        
    }
}
