using System;
					
public class Program
{

	struct Stats{
		private string Name;
		private int Str;
		private int HP;
	
		public Stats(string name, int str, int hp)
		{	
			this.Name = name;
			this.Str = str;
			this.HP = hp;
		}
		
		public string Who()
		{
			return this.Name;
		}
		
	}
	public static void Main()
	{
		Stats wizard = new Stats("Elric", 5, 33);
		Console.WriteLine("Hello {0}", wizard.Who());
	}
}
