using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StarWarsGame.Model
{
	public class Unit
	{
		public Unit()
		{
			Strength = 10;
		}

		public int BuildCost { get; set; }
		public int UpgradeCost { get; set; }
		public int Initiative { get; set; }
		public int MovementRatePerTurn { get; set; }
		public Faction Alignment { get; set; }
		public int Strength { get; set; }
		public int Fuel { get; set; }
	}
}
