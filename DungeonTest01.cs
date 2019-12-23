using System;
using System.Collections.Generic;
					
public class Program
{
	public class Monster
	{
		public string MonsterName { get; set; }
		public int HP { get; set; }
	}
	
	public class Room
	{
		public string RoomName { get; set; }
		public int Height { get; set; }
		public int Width { get; set; }
		public List<Monster> Mobs = new List<Monster>();
	}
	
	public static void Main()
	{
		Monster Orc = new Monster();
		Orc.MonsterName = "Red";
		Orc.HP = 4;
		Room Main = new Room();
		Main.Mobs.Add(Orc);
		Console.WriteLine("Hello World " + Main.Mobs[0].MonsterName);
	}
}
