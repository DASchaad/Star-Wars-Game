using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using StarWarsGame.Model.Units;

namespace StarWarsGame.Model
{
	class Program
	{
		static void Main(string[] args)
		{
			var campaign = new Campaign()
			{
				Factions = new List<Faction>()
				{
					new Faction()
					{
						Name = "Republic",
						AvailableUnitTypes = new List<UnitTypeAndAvailability>()
						{ 
						}
					},
					new Faction()
				}
			};

			foreach(Faction faction in campaign.Factions)
			{
				Console.WriteLine(faction.Name);

				foreach (UnitTypeAndAvailability typeAndAvailability in faction.AvailableUnitTypes)
				{
					Console.WriteLine(typeAndAvailability.UnitType.Name);
				}
			}

			Console.ReadKey();
		}
	}
}
