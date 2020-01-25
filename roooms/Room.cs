using System;
using System.Collections.Generic;
					
public class Program
{
	public class Door
	{
		int wall { get; set; }
		int pos { get; set; }
	}
	
	public class Room
	{
		int length { get; set; }
		int width { get; set; }
		int locx { get; set; }
		int locy { get; set; }
		List<Door> doors = new List<Door>();
	}
	
	public static void Main()
	{
		Console.WriteLine("Hello World");
	}
}
