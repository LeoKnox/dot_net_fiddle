using System;
using System.Collections.Generic;
					
public class Program
{
	public class Room
	{
		public int h;
		public int w;
		public List<string> mobs = new List<string>();
		
		public Room(int hh, int ww)
		{
			this.h = hh;
			this.w = ww;
		}
		
		public void AddMob(string x)
		{
			this.mobs.Add(x);
		}
	}
	
	public static void Main()
	{
		Room newdun = new Room(3, 4);
		newdun.AddMob("Orc");
		newdun.AddMob("Goblin");
		Console.Write("Room is {0} by {1} and contains", newdun.h, newdun.w);
		foreach (var mob in newdun.mobs)
		{
			Console.Write(" {0} and", mob);
		}
		Console.WriteLine("more!");
	}
}
