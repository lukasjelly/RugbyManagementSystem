using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamClass
{
    public class Team
    {
        private string teamName;
        private string ground;
        private string coach;
        private string yearFounded;
        private string region;
        private List<string> teamPlayers;

        public string TeamName
        {
            get { return teamName; }
        }

        public string Ground
        {
            get { return ground; }
        }

        public string Coach
        {
            get { return coach; }
        }

        public string YearFounded
        {
            get { return yearFounded; }
        }
        
        public string Region
        {
            get { return region; }
        }

        public List<string> TeamPlayers
        {
            get { return teamPlayers; }
        }

        public Team(string myTeamName, string teamGround, string teamCoach, string teamYearFounded, string teamRegion, List<string> myTeamPlayers)
        {
            teamName = myTeamName;
            ground = teamGround;
            coach = teamCoach;
            yearFounded = teamYearFounded;
            region = teamRegion;
            teamPlayers = myTeamPlayers;
        }
        public Team(string myTeamName, string teamGround, string teamCoach, string teamYearFounded, string teamRegion)
        {
            teamName = myTeamName;
            ground = teamGround;
            coach = teamCoach;
            yearFounded = teamYearFounded;
            region = teamRegion;
        }
    }
}
