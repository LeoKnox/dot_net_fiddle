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
	public static void Main()
	{
		DrawRoom hall = new DrawRoom();
		hall.width(3);
		hall.dw();
	}
}
