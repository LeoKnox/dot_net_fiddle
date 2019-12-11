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
	
	public static void Main()
	{
		Character player1 = new Character("Aelien", "Long Sword", "FireBall");
		Console.WriteLine("{0} swings {1} for {2} damage! and casts {3} for {4} damage!", player1.CharacterName, player1.SwordType, player1.SwordDamage(), player1.FireType, player1.FireDamage());
	}
}
