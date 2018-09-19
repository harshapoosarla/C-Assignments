using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsLeague
{
  public  class League
    {
        public string LeagueName { get; set; }
        public League(string LeagueName)
        {
            this.LeagueName = LeagueName;
        }
    }
}
