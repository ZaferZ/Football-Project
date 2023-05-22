using Football.Team;
using Football.Team.Managament;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Football
{
    public class Game
    {
        private Team.Team team1;
        private Team.Team team2;
        public List<Goal> Team1Goals { get; private set; } = new List<Goal>();
        public List<Goal> Team2Goals { get; private set; } = new List<Goal>();
        public double gameTime = 90;

        public Team.Team Team1 {
            get
            {
                return team1;
            }
            private set
            {
                if (value.Players.Count != 11)
                {
                    throw new NotEnoughPlayersExeption("Team must contain 11 players only", value.Players.Count);
                }
                team1 = value;
            }
        }
        public Team.Team Team2
        {
            get
            {
                return team2;
            }
            private set
            {
                if (value.Players.Count != 11)
                {
                    throw new NotEnoughPlayersExeption("Team must contain 11 players only", value.Players.Count);
                }
                team2 = value;
            }
        }
        public Referee MainReferee { get; private set; }
        public Referee[] AssistantReferies { get; private set; } = new Referee[2];
        public double GameTime { get { return gameTime; } }

       

        public Game(Football.Team.Team teams1, Football.Team.Team teams2, Team.Managament.Referee referee, Team.Managament.Referee asistantReferee1, Team.Managament.Referee asistantReferee2)
        {
            Team1 = teams1;
            Team2 = teams2;
            MainReferee = referee;
            AssistantReferies[0] = asistantReferee1;
            AssistantReferies[1] = asistantReferee2;
        }
        public void GOAL(FootballPlayer player,double minute)
        {
            Goal goal = new Goal(minute, player);
            if (team1.Players.Contains(player) && team2.Players.Contains(player))
            {
                throw new PlayerExeption("Player cannot play in both teams", player);
            }
            if (team1.Players.Contains(player))
            {
                Team1Goals.Add(goal);
            }
            else if (team2.Players.Contains(player))
            {
                Team2Goals.Add(goal);
            } else throw new PlayerNotInGameExeption("The given player is not in game",player);
        }
        public void ExtraTime(double extraTime) 
        {
            if (extraTime<=0)
            {
                throw new NotInTimeRangeExeption("Extra time must be possitive number", extraTime);
            }
            gameTime += extraTime;
        }
        public string GameResult()
        {    
           return $"{team1.Name}-{Team1Goals.Count} : {Team2Goals.Count}-{team2.Name}";   
        }
        public string Winner()
        {
            if (Team1Goals.Count > Team2Goals.Count)
            {
                return $"{team1.Name}\n Match duration: {gameTime}";
            }
            else if (Team2Goals.Count > Team1Goals.Count)
            {
               return $"{team2.Name}\n Match duration: {gameTime}";
            }
            else
            {
               return $"Draw\n Match duration: {gameTime}"; 
            }
        }
        public void ListAllGoals()
        {
            string text1= $"{team1.Name} goals: ";
            string text2 = $"{team2.Name} goals: ";
            foreach (var goal in Team1Goals)
            {
                Console.WriteLine(text1 + goal.Player.Name + " "+ Math.Round(goal.Minute)+"'");
            }
            Console.WriteLine();
            foreach (var goal in Team2Goals)
            {
                Console.WriteLine(text2 + goal.Player.Name + " " + Math.Round(goal.Minute)+"'");
            }
        }
    }
}
