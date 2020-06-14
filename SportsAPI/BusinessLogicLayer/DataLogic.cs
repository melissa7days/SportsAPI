using SportsAPI.DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportsAPI.BusinessLogicLayer
{
    public class DataLogic
    {
        public static List<SportsTree> SportsList { get; set; }

        public DataLogic()
        {
            this.Sports();
        }

        public List<SportsTree> Sports()
        {
            SportsList = new List<SportsTree>
            {
                new SportsTree(1, "Soccer"),
                new SportsTree(2, "Rugby")
            };
            return SportsList;
        }
    }

  
}
