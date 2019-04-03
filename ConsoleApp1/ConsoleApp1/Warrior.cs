using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1.Enum;
using ConsoleApp1.Ekwipunek;
using System.Threading;

namespace ConsoleApp1
{
	class Warrior
	{
		private const int GOOD_GUY_START_HEALTH = 100;
		private const int BAD_GUY_START_HEALTH = 100;
		private readonly Faction FACTION;

		private int health;
		private string name;
		private bool isAlive;

		public bool IsAlive
		{
			get
			{
				return isAlive;
			}
		}

		private Weapon weapon;
		private Armor armor;
		// --------------------------------------------------
		public Warrior(string name, Faction faction)
		{
			this.name = name;
			FACTION = faction;
			isAlive = true;

			switch (faction)
			{
				case Faction.GoodGuy:
					weapon = new Weapon(faction);
					armor = new Armor(faction);
					health = GOOD_GUY_START_HEALTH;
					break;
				case Faction.BadGuy:
					weapon = new Weapon(faction);
					armor = new Armor(faction);
					health = BAD_GUY_START_HEALTH;
					break;
				default:
					break;

			}
		}
		//--------------------------------------------------


		public void Attack(Warrior enemy)
		{
			int damage = weapon.Damage - enemy.armor.ArmorPoints;

			enemy.health -= damage;
			if(enemy.health <=0)
			{
				enemy.isAlive = false;
				Kolory.Kolor($"{enemy.name} is DEAD!", ConsoleColor.Red);
				Kolory.Kolor($"{ name} WIN !!", ConsoleColor.Green);
				
				
			}
			else
			{
				Console.WriteLine($"{name} Atakuje {enemy.name}. Obrażenia : {damage}. Pozostalo {enemy.health} pkt zdrowia");
			}
			Thread.Sleep(50);
		}

	}
}
