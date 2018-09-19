using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14Sept2018SportsLeague
{
  class Match
    {
        public Player ManOfTheMatch { get; set; }
        public Player HighScore { get; set; }
        protected internal TeamScore TeamA { get; set; }
        protected internal TeamScore TeamB { get; set; }
    }
}
