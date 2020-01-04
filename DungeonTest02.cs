using System;
using System.Collections.Generic;
					
public class Program
{
	public class Room
	{
		public int height { get; set; }
		public int width { get; set; }
		public int length { get; set; }
		public List<string> items = new List<string>();
		public List<string> mobs = new List<string>();
		
		public Room(int hh, int ww, int ll)
		{
			this.height = hh;
			this.width = ww;
			this.length = ll;
		}
		
		public void AddItem(string y)
		{
			this.items.Add(y);
		}
		
		public void AddMob(string x)
		{
			this.mobs.Add(x);
		}
		
		public override string ToString()
		{
			return ("Room is {0} by {1}. Containing {2}.", length, width, height);
		}
	}
	
	public static void Main()
	{
		Room newdun = new Room(8, 4, 5);
		newdun.AddMob("Orc");
		newdun.AddMob("Goblin");
		Console.Write(newdun.ToString());
		foreach (var mob in newdun.mobs)
		{
			Console.Write(" {0} and", mob);
		}
		Console.WriteLine(" more!");
	}
}
