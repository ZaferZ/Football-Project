using Football.Players;
using Football.Team;
using Football.Team.Managament;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Football
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Test 
            /*
            To create a player use the classes: 
            Goalkeeper
            Defender
            Midfielder
            Striker
            Object from these classes could only be created using consructor (string name, int age, int number, double height);

            To crate a Team add the playerst to a list of football players(List<FootballPlayer>) and create a Coach(string name, int age)
            then you are ready to create a Team
            Create a team using Team(string name, Coach coach, List<FootballPlayer> players)
            
            To create a game you must have two teams and three refereees (One main referee and two assistant referees)
            Once you have created a game you can:
            declare goals using the method GOAL(FootballPlayer player,double minute);
            add extra time using method ExtraTime(double extraTime);
            give the result of the game using method GameResult();
            give the winner of the game using method Winner();
             */


            //Goalkeeper donaruma = new Goalkeeper("Gianluigi Donnarumma", 24, 99, 1.96);
            //Defender ramos = new Defender("Sergio Ramos", 37, 4, 1.84);
            //Defender marquinhos = new Defender("Marcos Aoas Correa", 29, 5, 1.83);
            //Defender kimpembe = new Defender("Presnel Kimpembe", 27, 3, 1.83);
            //Midfielder verratti = new Midfielder("Marco Verratti", 30, 6, 1.65);
            //Midfielder wijnaldum = new Midfielder("Georginio Wijnaldum", 32, 25, 1.75);
            //Midfielder hakimi = new Midfielder("Achraf Hakimi", 24, 2, 1.81);
            //Midfielder bernat = new Midfielder("Juan Bernat", 30, 14, 1.77);
            //Striker neymar = new Striker("Neymar da Silva Santos Junior", 31, 10, 1.75);
            //Striker mbappe = new Striker("Kylian Mbappe", 24, 7, 1.78);
            //Striker messi = new Striker("Lionel Messi", 35, 33, 1.7);
            //Striker hasan = new Striker("Hasan Mehmedov", 18, 15, 1.75);
            //List<FootballPlayer> psgPlayers = new List<FootballPlayer> { donaruma, ramos, marquinhos, kimpembe, verratti, wijnaldum, hakimi, bernat, neymar, mbappe, messi };
            //List<FootballPlayer> psgPlayers2 = new List<FootballPlayer> { donaruma, ramos, marquinhos, kimpembe, verratti, wijnaldum, hakimi, bernat, neymar, mbappe, hasan };
            //Coach galtie = new Coach("Christophe Galtie", 56);
            //Football.Team.Team psg = new Football.Team.Team("PSG", galtie, psgPlayers);
            //Football.Team.Team psg2 = new Football.Team.Team("Real Madrid", galtie, psgPlayers2);
            //Referee kabakov = new Referee("Georgi Kabakov", 37);
            //Referee drumev = new Referee("Dimitur Drumev", 20);
            //Referee zafer = new Referee("Zafer Bayraktarov", 19);
            //Game psgVsPsg = new Game(psg, psg2, kabakov, drumev, zafer);
            //psgVsPsg.GOAL(messi, 13.546);
            //psgVsPsg.GOAL(messi, 45.696);
            //psgVsPsg.GameResult();
            //psgVsPsg.GOAL(hasan, 34.546);
            //Console.WriteLine(psgVsPsg.Winner());
            //Console.WriteLine(psgVsPsg.GameResult());
            //psgVsPsg.ListAllGoals();

            //Test 2 User input
            //Team.Team team1 = CreateTeam();
            //Team.Team team2 = CreateTeam();
            //Game macht1 = CreateGame(team1, team2);

                Console.ReadLine();

        }
        static Game CreateGame(Team.Team team1, Team.Team team2)
        {
            Game game = new Game(team1, team2, EnterReferee(), EnterReferee(), EnterReferee());
            return game;
        }
        static Team.Team CreateTeam()
        {
            Team.Team team = new Team.Team(TeamName(), EnterCoach(), EnterTeamPlayers());
            return team;
        }
        static Coach EnterCoach()
        {
            Console.Clear();
            Console.Write("Enter coach name:");
            string name = Console.ReadLine();
            Console.Write("Enter coach age(number):");
            int age = int.Parse(Console.ReadLine());
            Coach coach = new Coach(name,age);
            return coach;
        }
        static Referee EnterReferee()
        {
            Console.Clear();
            Console.Write("Enter referee name:");
            string name = Console.ReadLine();
            Console.Write("Enter referee age(number):");
            int age = int.Parse(Console.ReadLine());
            Referee referee = new Referee(name,age);
            return referee;
        }
        static string TeamName()
        {
            Console.Write("Enter team name: ");
            string name = Console.ReadLine();
            return name;
        }
        static List<FootballPlayer> EnterTeamPlayers()
        {
            Console.Clear();
            Console.WriteLine("Choose game formation");
            Console.WriteLine("a          b             c\n");
            Console.WriteLine("   * *       * * *         *     ");
            Console.WriteLine(" * * * *     * * *     * * * * * ");
            Console.WriteLine(" * * * *    * * * *     * * * *  ");
            Console.Write("a,b or c: ");
            List<FootballPlayer> team = new List<FootballPlayer>();
            Striker striker = new Striker();
            Midfielder midfielder = new Midfielder();
            Defender defender = new Defender();
            Goalkeeper goalkeeper = new Goalkeeper();
            string inData;
            string[] data;
            string input = Console.ReadLine();
            Console.WriteLine("Input format: Name,age,number,height\n Sample: Lionel Messi,35,33,1.7");
            switch (input)
            {//4,4,2
                case "a":
                   
                    for (int i = 0; i < 2; i++)
                    {
                        Console.WriteLine($"Enter striker {i+1}: ");
                        inData = Console.ReadLine();
                        data = inData.Split(',');
                        striker = new Striker(data[0], int.Parse(data[1]), int.Parse(data[2]), double.Parse(data[3]));
                        team.Add(striker);
                    }
                    for (int i = 0; i < 4; i++)
                    {
                        Console.WriteLine($"Enter Midfielder {i + 1}: ");
                        inData = Console.ReadLine();
                        data = inData.Split(',');
                        midfielder = new Midfielder(data[0], int.Parse(data[1]), int.Parse(data[2]), double.Parse(data[3]));
                        team.Add(midfielder);
                    }
                    for (int i = 0; i < 4; i++)
                    {
                        Console.WriteLine($"Enter Defender {i + 1}: ");
                        inData = Console.ReadLine();
                        data = inData.Split(',');
                        defender = new Defender(data[0], int.Parse(data[1]), int.Parse(data[2]), double.Parse(data[3]));
                        team.Add(defender);
                    }
                    Console.WriteLine($"Enter Goalkeeper: ");
                    inData = Console.ReadLine();
                    data = inData.Split(',');
                    goalkeeper = new Goalkeeper(data[0], int.Parse(data[1]), int.Parse(data[2]), double.Parse(data[3]));
                    team.Add(goalkeeper);
                    break;

                    //4,3,3
                case "b":

                    for (int i = 0; i < 3; i++)
                    {
                        Console.WriteLine($"Enter striker {i + 1}: ");
                        inData = Console.ReadLine();
                        data = inData.Split(',');
                        striker = new Striker(data[0], int.Parse(data[1]), int.Parse(data[2]), double.Parse(data[3]));
                        team.Add(striker);
                    }
                    for (int i = 0; i < 3; i++)
                    {
                        Console.WriteLine($"Enter Midfielder {i + 1}: ");
                        inData = Console.ReadLine();
                        data = inData.Split(',');
                        midfielder = new Midfielder(data[0], int.Parse(data[1]), int.Parse(data[2]), double.Parse(data[3]));
                        team.Add(midfielder);
                    }
                    for (int i = 0; i < 4; i++)
                    {
                        Console.WriteLine($"Enter Defender {i + 1}: ");
                        inData = Console.ReadLine();
                        data = inData.Split(',');
                        defender = new Defender(data[0], int.Parse(data[1]), int.Parse(data[2]), double.Parse(data[3]));
                        team.Add(defender);
                    }
                    Console.WriteLine($"Enter Goalkeeper: ");
                    inData = Console.ReadLine();
                    data = inData.Split(',');
                    goalkeeper = new Goalkeeper(data[0], int.Parse(data[1]), int.Parse(data[2]), double.Parse(data[3]));
                    team.Add(goalkeeper);
                    break;
                   //3,5,1
                case "c":

                    for (int i = 0; i < 3; i++)
                    {
                        Console.WriteLine($"Enter striker {i + 1}: ");
                        inData = Console.ReadLine();
                        data = inData.Split(',');
                        striker = new Striker(data[0], int.Parse(data[1]), int.Parse(data[2]), double.Parse(data[3]));
                        team.Add(striker);
                    }
                    for (int i = 0; i < 3; i++)
                    {
                        Console.WriteLine($"Enter Midfielder {i + 1}: ");
                        inData = Console.ReadLine();
                        data = inData.Split(',');
                        midfielder = new Midfielder(data[0], int.Parse(data[1]), int.Parse(data[2]), double.Parse(data[3]));
                        team.Add(midfielder);
                    }
                    for (int i = 0; i < 4; i++)
                    {
                        Console.WriteLine($"Enter Defender {i + 1}: ");
                        inData = Console.ReadLine();
                        data = inData.Split(',');
                        defender = new Defender(data[0], int.Parse(data[1]), int.Parse(data[2]), double.Parse(data[3]));
                        team.Add(defender);
                    }
                    Console.WriteLine($"Enter Goalkeeper: ");
                    inData = Console.ReadLine();
                    data = inData.Split(',');
                    goalkeeper = new Goalkeeper(data[0], int.Parse(data[1]), int.Parse(data[2]), double.Parse(data[3]));
                    team.Add(goalkeeper);
                    break;
                default:break;
            }
            return team;

        }
    }
}
