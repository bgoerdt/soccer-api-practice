using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SoccerAPI.Models
{
	public class Comment
	{
		public int Id { get; set; }
		public string Body { get; set; }
		public string Author { get; set; }

		public int TeamId { get; set; }
		public Team Team { get; set; }
	}
}