using System;
using System.Collections.Generic;
					
public class Program
{
	public class Door
	{
		int wall { get; set; }
		int pos { get; set; }
		
		public Door(int w, int p)
		{
			this.wall = w;
			this.pos = p;
		}
	}
	
	public class Room
	{
		int length { get; set; }
		int width { get; set; }
		int locx { get; set; }
		int locy { get; set; }
		List<Door> doors = new List<Door>();
		
		public Room(int l, int w, int x, int y)
		{
			this.length = l;
			this.width = w;
			this.locx = x;
			this.locy = y;
		}
	}
	
	public static void Main()
	{
		Console.WriteLine("Hello World");
	}
}
