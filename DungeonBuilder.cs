using System;
using System.Text;
					
public class Program
{
	interface Room
	{
		void width(int w);
		//void height(int h);
	}
	
	class DrawRoom : Room
	{
		int wid;
		
		public void width(int width)
		{
			wid = width;
		}
		
		public void dw()
		{
			var wall = new StringBuilder();
			Console.WriteLine("red: " + wid);
			for (int x = 0; x  < wid; x++)
			{
				wall.Append("*");
			}
			Console.WriteLine(wall.ToString());
		}
	}
	
	public class HallWay
	{
		public void Draw()
		{
			Console.WriteLine("red");
		}
	}
	
	public static void Main()
	{
		Random rnd = new Random();
		int x = rnd.Next(2, 6);
		DrawRoom hall = new DrawRoom();
		hall.width(x);
		hall.dw();
	}
}
