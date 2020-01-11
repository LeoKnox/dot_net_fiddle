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
			this.Length = 3;
			this.Width = 4;
			return this;
		}
	}
	
	public static void Main()
	{
		Room test = new Room();
		Dungeon big = new Dungeon();
		test.MakeRoom();
		big.AddRoom(test);
		Console.WriteLine("Hello World " + big.Rooms[0].Length);
	}
}
