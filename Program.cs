using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Games
{

    class Game
    {
        public int NoofPlayers;
        public string country;

        public int NoOfPlayers
        {
            get { return NoofPlayers; }
            set { NoofPlayers = value; }
        }
        public string Country
        {
            get { return country; }
            set { country = value; }
        }
        public Game()
        {

        }



        public Game(int _noofplayers, string _country)
        {
            NoofPlayers = _noofplayers;
            country = _country;
        }
        public void WorldCup(string country, string game)
        {
            Console.WriteLine("{0} {1}{2}", country, game, DateTime.Now.ToString("yyyy"));




        }
        class Cricket : Game
        {
            public string coachName;
            public string CoachName
            {
                get { return coachName; }
                set { coachName = value; }

            }
            public Cricket()
            {

            }
            public Cricket(string _coachname, int _noofplayers, string _country) : base(_noofplayers, _country)
            {
                coachName = _coachname;
            }

        }
        class Football : Game
        {
            public string leaguename;
            public string Leaguename
            {
                get { return leaguename; }
                set { leaguename = value; }
            }
            public Football()
            {

            }
            public Football(string _leaguename, int _noofplayers, string _country) : base(_noofplayers, _country)
            {
                leaguename = _leaguename;
            }

        }
        class ShowGameDetails
        {

            public void ShowCricket(string coachname, int NoofPlayers, string country)
            {
                Console.WriteLine("showing all the cricket players------------{0},{1},{2}", coachname, NoofPlayers, country);

            }
            public void ShowFootBall(string leaguename, int NoofPlayers, string country)
            {
                Console.WriteLine("showing information about footlball players------------{0},{1},{2}", leaguename, NoofPlayers, country);



            }
        } 
        class Program
        {
            static void Main(string[] args)
            {
                Cricket India = new Cricket();
                Cricket Australia = new Cricket();
                Football Spain = new Football();
                Football England = new Football();
                ShowGameDetails show = new ShowGameDetails();
                Console.WriteLine("------------Cricket Information--------------------------------");
                show.ShowCricket("John Wright",11, "India" );
                show.ShowCricket("John Buchanan",11, "Australia" );
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("------------FootBall Information-----------------------------------");
                show.ShowFootBall("Spanish League",11, "Spain");
                show.ShowFootBall("English Premiur League",11, "England" );
                Console.WriteLine();
                Console.WriteLine();
                Game g1 = new Game();
                g1.WorldCup("India", "Cricket");
                g1.WorldCup("Spain", "Football");


            }
        }
    }
}
    
