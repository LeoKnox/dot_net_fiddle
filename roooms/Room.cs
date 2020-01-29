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
		for (int a = y-1; a < y + l; a++)
		{
			ar[x, a] = 0;
			ar[x+w, a] = 0;
		}
		for (int b = x; b < x + w; b++)
		{
			ar[b, y - 1] = 0;
			ar[b, y + l - 1] = 0;
		}
		/*for (int c = y; c < y + l; c++)
		{
			for (int d = x; d < x + w -1; d++)
			{
				ar[c, d] = 4;
			}
		}*/
	}
	
	public static void AddDoor(int[,] ad, int dw, int d, int l, int w)
	{
		switch (dw)
		{
			case 0:
				ad[l, w+d] = 4;
				break;
			case 3:
				ad[l+d, w-1] = 4;
				break;
		}
	}
	
	public static void DrawRoom(int[,] dr)
	{
		for (int x = 0; x < 20; x++)
		{
			for (int y = 0; y < 20; y++)
			{
				Console.Write(dr[x,y]);
			}
			Console.WriteLine();
		}
	}
	
	public static void Main()
	{
		int[,] dunarr = new int[20, 20];
		Console.WriteLine(dunarr[3, 4]);
		FillArray(dunarr);
		AddRoom(dunarr, 2, 2, 4, 5);
		AddRoom(dunarr, 12, 8, 8, 6);
		AddDoor(dunarr, 3, 3, 12, 8);
		DrawRoom(dunarr);
	}
}
