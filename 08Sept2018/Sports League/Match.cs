using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsLeague
{
 public   class Match
    {
        public Player ManOfTheMatch { get; set; }
        public Player HighScore { get; set; }
        public TeamScore TeamA { get; set; }
        public TeamScore TeamB { get; set; }
    }
}
