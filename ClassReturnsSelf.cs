using System;
					
public class Program
{
	public class Room
	{
		public int Length { get; set; }
		public int Width { get; set; }
		
		public Room MakeRoom()
		{
			this.Length = 3;
			this.Width =4;
			return this;
		}
	}
	
	public static void Main()
	{
		Room test = new Room();
		test.MakeRoom();
		Console.WriteLine("Hello World " + test.Width);
	}
}
