using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StarWarsGame.Model.Units.SnubfighterTypes
{
	public class TIEDDefender : Snubfighter
	{
		public TIEDDefender()
		{
			BuildCost = 3600000;
			UpgradeCost = 960000;
			MovementRatePerTurn = 1680;
		}
	}
}
