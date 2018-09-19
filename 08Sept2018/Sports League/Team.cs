using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsLeague
{
    public class Team
    {
        public string TeamName { get; set; }
        public Player[] Players = new Player[StaticVariables.NumberOfPlayers];
    }
}