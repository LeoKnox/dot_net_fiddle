using System;
					
public class Program
{
	public class Item
	{
		string Style { get; set; }
		int Gold { get; set; }
		string Treasure {get; set; }
		public Item(string s, int g, string t)
		{
			this.Style = s;
			this.Gold = g;
			this.Treasure = t;
		}
		
		public int GetGold()
		{
			return this.Gold;
		}
	}
	
	public static void Main()
	{
		Item Chest = new Item("Chest", 300, "Axe");
		
		Console.WriteLine("Contains {0} gp!", Chest.GetGold());
	}
}
