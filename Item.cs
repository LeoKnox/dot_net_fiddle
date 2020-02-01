using System;
					
public class Program
{
	public class Item
	{
		string Style { get; set; }
		int? Value { get; set; }
		string Treasure {get; set; }
		public Item(string s, int v, string t)
		{
			this.Style = s;
			this.Value = v;
			this.Treasure = t;
		}
		
		public int? GetValue()
		{
			return this.Value;
		}
	}
	
	public static void Main()
	{
		Item Chest = new Item("Chest", 300, "Axe");
		
		Console.WriteLine("Has {0} value!", Chest.GetValue());
	}
}
