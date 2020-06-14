using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportsAPI.DataAccessLayer
{
    public class SportsTree
    {
        public int SportId { get; set; }
        public string SportName { get; set; }

        public SportsTree(int sportsId, string sportsName)
        {
            SportId = sportsId;
            SportName = sportsName;
        }
    }
}
