using System;
using System.Collections.Generic;
					
public class Program
{
	public class Strs
	{
		public string a { get; set; }
		public string b { get; set; }
		
		public Strs(string a, string b)
		{
			this.a = a;
			this.b = b;
		}
	}
	
	public static void Main()
	{
		Dictionary<string, int> nums = new Dictionary<string, int>();
		Dictionary<int, Strs> lets = new Dictionary<int, Strs>();
		Strs bbb = new Strs("Three", "Four");
		Strs ccc = new Strs("One", "Three");
		lets[1] = bbb;
		lets[2] = ccc;
		nums.Add("One", 1);
		nums.Add("Two", 2);
		nums["Three"] = 3;
		nums["Four"] = 4;
		Console.WriteLine("Hello World " + nums["One"]);
		Console.WriteLine(lets[1].a + " " + lets[1].b);
	}
}
