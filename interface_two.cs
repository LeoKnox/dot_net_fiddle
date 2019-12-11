using System;
					
public class Program
{
	interface Sword
	{
		string SwordType { get; set; }
		int SwordDamage();
	}
	
	interface FireSpell
	{
		string FireType { get; set; }
		int FireDamage();
	}
	
	class Character : Sword, FireSpell
	{
		public string CharacterName { get; set; }
		public string SwordType { get; set; }
		public string FireType { get; set; }
		
		public Character(string charname, string EssTee, string FffTee)
		{
			this.CharacterName = charname;
			this.SwordType = EssTee;
			this.FireType = FffTee;
		}
		
		public int SwordDamage()
		{
			return 8;
		}
		public int FireDamage()
		{
			return 7;	
		}
	}
	
	class Monster
	{
		public String Name { get; set; }
		private int HP { get; set; }
		
		public Monster(string name)
		{
			this.Name = name;
			this.HP = 5;
		}
		
		public int TakeDamage(int dam)
		{
			return this.HP - dam;
		}
	}
	
	public static void Main()
	{
		Character player1 = new Character("Aelien", "Long Sword", "FireBall");
		Monster monster1 = new Monster("Ord");
		Console.WriteLine("{0} swings {1} for {2} damage! and casts {3} for {4} damage!", player1.CharacterName, player1.SwordType, player1.SwordDamage(), player1.FireType, player1.FireDamage());
		Console.WriteLine("{0} takes {1} damage! and now has {2} HP!", monster1.Name, player1.SwordDamage(), monster1.TakeDamage(player1.SwordDamage()));
	}
}
