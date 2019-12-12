using System;
					
public class Program
{
	class Room
	{
		private string RoomName { get; set; }
		private int Width { get; set; }
		private int Height { get; set; }
		
		public Room(string name, int w, int h)
		{
			this.RoomName = name;
			this.Width = w;
			this.Height = h;
		}
		
		public void DisplayRoom()
		{
			Console.WriteLine("Room {0} is {1} by {2}.", this.RoomName, this.Width.ToString(), this.Height.ToString());
		}
	}
	
	public static void Main()
	{
		Room first = new Room("Entry", 5, 4);
		first.DisplayRoom();
	}
}
