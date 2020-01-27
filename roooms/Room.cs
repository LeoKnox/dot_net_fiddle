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
		
		public Room()
		{
		}
		
		public Room(int l, int w, int x, int y)
		{
			this.length = l;
			this.width = w;
			this.locx = x;
			this.locy = y;
		}
	}
	
	public int[,] FillArray(int[,] fa)
	{
		for (int x = 0; x < 20; x++)
		{
			fa[x, 0] = 1;
		}
		return fa;
	}
	
	public static void Main()
	{
		int[,] dunarr = new int[20, 20];
		for (int i = 0; i < 20; i++)
		{
			for (int j = 0; j < 20; j++)
			{
				if (i < 5 && i > 2 && j > 1 && j < 6)
				{
					dunarr[i, j] = 2;
				}
				else if (i <= 5 && i >=2 && j >= 1 && j<= 6)
				{
					dunarr[i, j] = 8;
				}
				else
				{
					dunarr[i, j] = 1;
				}
			}
		}
				
		Console.WriteLine(dunarr[3, 4]);
		for (int x = 0; x < 20; x++)
		{
			for (int y = 0; y < 20; y++)
			{
				Console.Write(dunarr[x, y]);
			}
			Console.WriteLine();
		}
	}
}
