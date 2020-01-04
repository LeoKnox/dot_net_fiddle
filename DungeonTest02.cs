using System;
using System.Collections.Generic;
					
public class Program
{
	public class Room
	{
		public int height;
		public int width;
		public int length;
		public List<string> items = new List<string>();
		public List<string> mobs = new List<string>();
		
		public Room(int hh, int ww, int ll)
		{
			this.height = hh;
			this.width = ww;
			this.length = ll;
		}
		
		public void AddMob(string x)
		{
			this.mobs.Add(x);
		}
	}
	
	public static void Main()
	{
		Room newdun = new Room(8, 4, 5);
		newdun.AddMob("Orc");
		newdun.AddMob("Goblin");
		Console.Write("Room is {0} by {1} and contains", newdun.length, newdun.width);
		foreach (var mob in newdun.mobs)
		{
			Console.Write(" {0} and", mob);
		}
		Console.WriteLine(" more!");
	}
}
