using System;
					
public class Program
{
	class Room
	{
		private string RoomName { get; set; }
		private int Width { get; set; }
		private int Height { get; set; }
		
		public Room()
		{
			Random rnd = new Random();
			this.RoomName = "none";
			this.Height = rnd.Next(7);
			this.Width = rnd.Next(9);
		}
		
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
	
	class Fighter
	{
		private string Name { get; set; }
		private int Attack { get; set; }
		
		public Fighter(string n, int a)
		{
			this.Name = n;
			this.Attack = a;
		}
		
		public int Fight()
		{
			return this.Attack;
		}
	}
	
	class Monster
	{
		private string Called { get; set; }
		private int Hp { get; set; }
		
		public Monster(string c, int h)
		{
			this.Called = c;
			this.Hp = h;
		}
		
		public void Hit(int damage)
		{
			this.Hp -= damage;
			Console.WriteLine("Monster {0} is hit and has {1} HP!", this.Called, this.Hp);
		}
	}
	
	public static void Main()
	{
		Room second = new Room("Entry", 5, 4);
		Room first = new Room();
		first.DisplayRoom();
		second.DisplayRoom();
		Fighter goodguy = new Fighter("Aelien", 3);
		Monster badguy = new Monster("Orc", 6);
		badguy.Hit(goodguy.Fight());
	}
}
