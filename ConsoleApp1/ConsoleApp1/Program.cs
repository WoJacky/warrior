using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1.Enum;

namespace ConsoleApp1
{
	class Program
	{
		static Random rnd = new Random();
		static void Main(string[] args)
		{
			Warrior goodGuy = new Warrior("Wojtek", Faction.GoodGuy);
			Warrior badGuy = new Warrior("Jacek", Faction.BadGuy);

			while (goodGuy.IsAlive && badGuy.IsAlive)
			{
				if(rnd.Next(0,10) < 5)
				{
					goodGuy.Attack(badGuy);
				}
				else
				{
					badGuy.Attack(goodGuy);
				}
			}
		}
	}
}
