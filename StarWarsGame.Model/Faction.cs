using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StarWarsGame.Model
{
	public class Faction
	{
		public string Name { get; set; }
		public List<UnitTypeAndAvailability> AvailableUnitTypes { get; set; }

	}
}
