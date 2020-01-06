using System;
using System.Collections.Generic;
					
public class Program
{
	public class Monster
	{
		public string Name { get; set; }
		public int Str { get; set; }
	}
	
	public class Room
	{
		public int height { get; set; }
		public int width { get; set; }
		public int length { get; set; }
		public List<string> items = new List<string>();
		public List<Monster> mobs = new List<Monster>();
		public List<string> character = new List<string>();
		
		public Room(int hh, int ww, int ll)
		{
			this.height = hh;
			this.width = ww;
			this.length = ll;
		}
		
		public void AddChar(string s)
		{
			this.character.Add(s);
		}
		
		public void AddItem(string y)
		{
			this.items.Add(y);
		}
		
		public void AddMob(string x, int s)
		{
			Monster mobsy = new Monster();
			mobsy.Name = x;
			mobsy.Str = s;
			this.mobs.Add(mobsy);
		}
		
		public override string ToString()
		{
			return ("Room is 0 by 0. Containing." + height);
		}
	}
	
	public static void Main()
	{
		Room newdun = new Room(8, 4, 5);
		newdun.AddChar("Aelien");
		newdun.AddChar("Colette");
		newdun.AddMob("Orc", 20);
		foreach (var ch in newdun.character)
		{
			Console.Write(" {0} and", ch);
		}
		Console.WriteLine();
		Console.WriteLine(newdun.ToString());
	}
}
