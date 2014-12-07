using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StarWarsGame.Model.Units.SnubfighterTypes
{
	public class T65XWing : Snubfighter
	{
		public T65XWing()
		{
		BuildCost = 1799988;
		UpgradeCost = 1080000;
		MovementRatePerTurn = 1050;
		}
	}
}
