using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14Sept2018SportsLeague
{
     class Team : Player
    {
        public string TeamName { get; set; }
        public Player[] Players = new Player[StaticVariables.NumberOfPlayers];
    }
}