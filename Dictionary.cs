using System;
using System.Collections.Generic;
					
public class Program
{
	public static void Main()
	{
		Dictionary<string, int> nums = new Dictionary<string, int>();
		nums.Add("One", 1);
		nums.Add("Two", 2);
		nums["Three"] = 3;
		nums["Four"] = 4;
		Console.WriteLine("Hello World " + nums["One"]);
	}
}
