namespace SoccerAPI.Migrations
{
	using System;
	using System.Data.Entity;
	using System.Data.Entity.Migrations;
	using System.Linq;
	using SoccerAPI.Models;
	
	internal sealed class Configuration : DbMigrationsConfiguration<SoccerAPI.Models.SoccerAPIContext>
	{
		public Configuration()
		{
			AutomaticMigrationsEnabled = false;
		}

		protected override void Seed(SoccerAPI.Models.SoccerAPIContext context)
		{

			context.Teams.AddOrUpdate( t => t.Name,
				new Team { Id = 1, Name = "United States", Rank = 13, Confederation = "CONCACAF", Nickname = "The Yanks", Coach = "Jurgen Klinsman" },
				new Team { Id = 2, Name = "Germany", Rank = 2, Confederation = "UEFA", Nickname = "Die Mannschaft", Coach = "Joachim Low" }
				//new Team { Id = 3, CountryName = "Portugal" },
				//new Team { Id = 4, CountryName = "Ghana" }
				);

			context.Players.AddOrUpdate(p => p.Name,
				new Player { Name = "Tim Howard", Number = 1, Position = "Goalkeeper", TeamId = 1 },
				new Player { Name = "DeAndre Yedlin", Number = 2, Position = "Defender", TeamId = 1 },
				new Player { Name = "Omar Gonzalez", Number = 3, Position = "Defender", TeamId = 1 },
				new Player { Name = "Michael Bradley", Number = 4, Position = "Midfielder", TeamId = 1 },
				new Player { Name = "Matt Besler", Number = 5, Position = "Defender", TeamId = 1 },
				new Player { Name = "John Brooks", Number = 6, Position = "Defender", TeamId = 1 },
				new Player { Name = "DaMarcus Beasley", Number = 7, Position = "Defender", TeamId = 1 },
				new Player { Name = "Clint Dempsey", Number = 8, Position = "Forward", TeamId = 1 },
				new Player { Name = "Aron Johannsson", Number = 9, Position = "Forward", TeamId = 1 },
				new Player { Name = "Mix Diskerud", Number = 10, Position = "Midfielder", TeamId = 1 },
				new Player { Name = "Alejandro Bedoya", Number = 11, Position = "Midfielder", TeamId = 1 },
				new Player { Name = "Bran Guzan", Number = 12, Position = "Goalkeeper", TeamId = 1 },
				new Player { Name = "Jermaine Jones", Number = 13, Position = "Midfielder", TeamId = 1 },
				new Player { Name = "Brad Davis", Number = 14, Position = "Midfielder", TeamId = 1 },
				new Player { Name = "Kyle Beckerman", Number = 15, Position = "Midfielder", TeamId = 1 },
				new Player { Name = "Julian Green", Number = 16, Position = "Midfielder", TeamId = 1 },
				new Player { Name = "Jozy Altidore", Number = 17, Position = "Forward", TeamId = 1 },
				new Player { Name = "Chris Wondolowski", Number = 18, Position = "Forward", TeamId = 1 },
				new Player { Name = "Graham Zusi", Number = 19, Position = "Midfielder", TeamId = 1 },
				new Player { Name = "Geoff Cameron", Number = 20, Position = "Defender", TeamId = 1 },
				new Player { Name = "Timmy Chandler", Number = 21, Position = "Defender", TeamId = 1 },
				new Player { Name = "Nick Rimando", Number = 22, Position = "Goalkeeper", TeamId = 1 },
				new Player { Name = "Fabian Johnson", Number = 23, Position = "Defender", TeamId = 1 },

				new Player { Name = "Manuel Neuer", Number = 1, Position = "Goalkeeper", TeamId = 2 },
				new Player { Name = "Kevin Grosskreutz", Number = 2, Position = "Defender", TeamId = 2 },
				new Player { Name = "Matthias Ginter", Number = 3, Position = "Defender", TeamId = 2 },
				new Player { Name = "Benedikt Hoewedes", Number = 4, Position = "Defender", TeamId = 2 },
				new Player { Name = "Mats Hummels", Number = 5, Position = "Defender", TeamId = 2 },
				new Player { Name = "Sami Khedira", Number = 6, Position = "Midfielder", TeamId = 2 },
				new Player { Name = "Bastian Schweinsteiger", Number = 7, Position = "Midfielder", TeamId = 2 },
				new Player { Name = "Mesut Oezil", Number = 8, Position = "Midfielder", TeamId = 2 },
				new Player { Name = "Andre Schuerrle", Number = 9, Position = "Forward", TeamId = 2 },
				new Player { Name = "Lukas Podolski", Number = 10, Position = "Forward", TeamId = 2 },
				new Player { Name = "Miroslav Klose", Number = 11, Position = "Forward", TeamId = 2 },
				new Player { Name = "Ron-Robert Zieler", Number = 12, Position = "Goalkeeper", TeamId = 2 },
				new Player { Name = "Thomas Mueller", Number = 13, Position = "Forward", TeamId = 2 },
				new Player { Name = "Julian Draxler", Number = 14, Position = "Midfielder", TeamId = 2 },
				new Player { Name = "Erik Durm", Number = 15, Position = "Defender", TeamId = 2 },
				new Player { Name = "Philipp Lahn", Number = 16, Position = "Midfielder", TeamId = 2 },
				new Player { Name = "Per Mertesacker", Number = 17, Position = "Defender", TeamId = 2 },
				new Player { Name = "Toni Kroos", Number = 18, Position = "Midfielder", TeamId = 2 },
				new Player { Name = "Mario Goetze", Number = 19, Position = "Forward", TeamId = 2 },
				new Player { Name = "Jerome Boateng", Number = 20, Position = "Defender", TeamId = 2 },
				new Player { Name = "Shkodran Mustafi", Number = 21, Position = "Defender", TeamId = 2 },
				new Player { Name = "Roman Weidenfeller", Number = 22, Position = "Goalkeeper", TeamId = 2 },
				new Player { Name = "Christoph Kramer", Number = 23, Position = "Midfielder", TeamId = 2 }
				);

			context.Comments.AddOrUpdate(c => c.Body,
				new Comment { Body = "USA! USA! USA!", Author = "fan@usa.com", TeamId = 1 },
				new Comment { Body = "there's no way the US will get out of the group of death", Author = "debbie@downer.com", TeamId = 1 },
				new Comment { Body = "Germany has advanced to the quarterfinals in the last 15 world cups", Author = "statsguy@sportshistory.com", TeamId = 2 },
				new Comment { Body = "germany will win!!", Author = "deutsch@land.com", TeamId = 2 }
				);
		}
	}
}
