using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SoccerAPI.Models
{
    public class Team
    {
        public int Id { get; set; }
        public string Name { get; set; }
		public int Rank { get; set; }
		public string Confederation { get; set; }
		public string Nickname { get; set; }
		public string Coach { get; set; }
    }
}