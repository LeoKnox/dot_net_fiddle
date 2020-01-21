using System;
using System.Collections.Generic;
					
public class Program
{
	public class Color
	{
		public List<string> Red = new List<string>();
		
		public void AddRed(string x)
		{
			this.Red.Add(x);
		}
		
	}
	public static void Main()
	{
		Color ddd = new Color();
		ddd.AddRed("arrr");
		Console.WriteLine("Hello World " + ddd.Red[0]);
	}
}
