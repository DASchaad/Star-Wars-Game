using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StarWarsGame.Model
{
	public class Campaign
	{
		public string Name { get; set; }

		public List<Faction> Factions { get; set; }

		public List<Mission> Missions {get; set;}
	}
}
