using System;
					
public class Program
{
	public class Monster
	{
		private string Type { get; set; }
		private int HP { get; set; }
		private int Str { get; set; }
		
		public Monster(string t, int h, int s)
		{
			this.Type = t;
			this.HP = h;
			this.Str = s;
		}
		
		public int GetHp()
		{
			return this.HP;
		}
	}
	
	public static void Main()
	{
		Monster  Grog = new Monster("Orc", 44, 20);
		Console.WriteLine(Grog.GetHp());
	}
}
