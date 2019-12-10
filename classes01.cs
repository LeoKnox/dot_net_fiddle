using System;
					
public class Program
{
	class Rogue
	{
		public string Name;
		public int Str;
		public int Dex;
		public int HP;
		
		public Rogue()
		{
			Name = "Colette";
			Str = 5;
			Dex = 6;
			HP = 10;
		}
		
		public int AttackOne()
		{
			return Str+Dex;
		}
	}
	public static void Main()
	{
		Rogue rog = new Rogue();
		Console.WriteLine("Hello World + {0}", rog.Str);
	}
}
