using System;
using System.Collections.Generic;
					
public class Program
{
	public class Color
	{
		private List<string> Red = new List<string>();
		
		public void AddRed(string x)
		{
			this.Red.Add(x);
		}
		
		public string ScanRed(int y)
		{
			return this.Red[y];
		}
		
	}
	public static void Main()
	{
		Color ddd = new Color();
		ddd.AddRed("arrr");
		Console.WriteLine("Hello World " + ddd.ScanRed(0));
	}
}
