using System;
using System.Collections.Generic;
					
public class Program
{
	public class Dungeon
	{
		public List<Room> Rooms = new List<Room>();
		
		public void AddRoom(Room r)
		{
			this.Rooms.Add(r);
		}
	}
	
	public class Room
	{
		public int Length { get; set; }
		public int Width { get; set; }
		
		public Room MakeRoom()
		{
			Random random = new Random();
			int x = random.Next(1, 12);
			int y = random.Next(1, 12);
			
			this.Length = x;
			this.Width = y;
			return this;
		}
	}
	
	public static void Main()
	{
		Room test = new Room();
		Dungeon big = new Dungeon();
		test.MakeRoom();
		big.AddRoom(test);
		big.AddRoom(test); // doesn't work repeats same number, for now have to generate in Main()
		Console.WriteLine("Hello World ");
		foreach (var r in big.Rooms)
		{
			Console.WriteLine(r.Length + " " + r.Width);
		}
	}
}
