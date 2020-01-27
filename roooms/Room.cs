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
	
	public static void FillArray(int[,] fa)
	{
		for (int x = 0; x < 20; x++)
		{
			for (int y=0; y < 20; y++)
			{
				fa[x, y] = 1;
			}
		}
	}
	
	public static void AddRoom(int[,] ar, int x, int y, int l, int w)
	{
		for (int a = y; a < y + l; a++)
		{
			ar[x, a] = 0;
			ar[x+w, a] = 0;
		}
		for (int b = x; b < x + w; b++)
		{
			ar[b, y] = 0;
			ar[b, y+l] = 0;
		}
		for (int c = y + 1; c < y + l + 1; c++)
		{
			for (int d = x + 1; d < x + w - 1; d++)
			{
				ar[c, d] = 4;
			}
		}
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
		FillArray(dunarr);
		AddRoom(dunarr, 2, 2, 4, 5);
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
