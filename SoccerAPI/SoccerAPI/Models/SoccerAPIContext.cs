using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace SoccerAPI.Models
{
    public class SoccerAPIContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public SoccerAPIContext() : base("name=SoccerAPIContext")
        {
        }

        public System.Data.Entity.DbSet<SoccerAPI.Models.Team> Teams { get; set; }

        public System.Data.Entity.DbSet<SoccerAPI.Models.Player> Players { get; set; }

		public System.Data.Entity.DbSet<SoccerAPI.Models.Comment> Comments { get; set; }
    
    }
}
