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
	}
	
	public static void Main()
	{
		Console.WriteLine("Hello World");
	}
}
