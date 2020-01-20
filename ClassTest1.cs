using System;
using System.Collections.Generic;
					
public class Program
{
	public class Red
	{
		string xz { get; set; }
		List<int> az = new List<int>();
		
		public Red(int x, int y, int z)
		{
			this.az[0] = x;
			this.az[1] = y;
			this.az[2] = z;
		}
	}
	public static void Main()
	{
		Console.WriteLine("Hello World");
	}
}
