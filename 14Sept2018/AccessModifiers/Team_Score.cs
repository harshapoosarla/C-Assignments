using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14Sept2018SportsLeague
{
      class TeamScore : Team
    {
        public PlayerScore[] PlayerScorer { get; set; }
        public bool IsWinner { get; set; }
        public int Score { get; set; }
        public Player HighestScorer { get; set; }
    }
}


