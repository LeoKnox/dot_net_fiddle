using System;
					
public class Program
{
	interface Dps
	{
		string Name{ get; set; }
		int Str();
	}
	
	class Melee : Dps
	{
		public string Name { get; set; }
		public int Str()
		{
			Console.WriteLine("10");
			return 10;
		}
		//int Weapon { get; set; }
	}
	
	public static void Main()
	{
		Melee rogue = new Melee();
		rogue.Name = "Yeah!";
		rogue.Str();
		Console.WriteLine("Hello {0}", rogue.Name);
	}
}
