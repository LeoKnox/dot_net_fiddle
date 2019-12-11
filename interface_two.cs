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
		public string SwordType { get; set; }
		public string FireType { get; set; }
		
		public Character(string EssTee, string FffTee)
		{
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
		Character Aelien = new Character("Long Sword", "FireBall");
		Console.WriteLine("Aelien swings {0} for {1}", Aelien.SwordType, Aelien.SwordDamage());
	}
}
