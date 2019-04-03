using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1.Enum;

namespace ConsoleApp1.Ekwipunek
{
	class Weapon
	{
		

		private const int GOOD_GUY_DAMAGE = 10;
		private int BAG_GUY_DAMAGE = 15;

		private int damage;

		public int Damage
		{ 
			get
			{
				return damage;
			}
		}

		

		public Weapon(Faction faction)
		{
			switch (faction)
			{
				case Faction.GoodGuy:
					damage = GOOD_GUY_DAMAGE;
					break;
				case Faction.BadGuy:
					damage = BAG_GUY_DAMAGE;
					break;
				default:
					break;
			}
		}
	}
}
