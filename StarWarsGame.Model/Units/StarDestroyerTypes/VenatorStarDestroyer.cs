using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StarWarsGame.Model.Units.StarDestroyerTypes
{
	public class VenatorStarDestroyer : StarDestroyer
	{
		public VenatorStarDestroyer()
		{
			BuildCost = 177000000;
			MovementRatePerTurn = 975;
		}

	}
}
