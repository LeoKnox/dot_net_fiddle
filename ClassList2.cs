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
		Corn Kay = new Corn();
		Kay.AddKernal(3);
		Console.WriteLine("Hello World");
	}
}
