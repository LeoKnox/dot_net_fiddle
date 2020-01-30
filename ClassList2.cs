using System;
using System.Collections.Generic;
					
public class Program
{
	public class Corn
	{
		List<int> Kernal = new List<int>();
		
		public void AddKernal(int i )
		{
			this.Kernal.Add(i);
		}
	}
	
	public static void Main()
	{
		Console.WriteLine("Hello World");
	}
}
