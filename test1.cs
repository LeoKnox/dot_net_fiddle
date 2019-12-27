using System;
					
public class Program
{
	public class Test
	{
		public string Name { get; set; }
		public int Str { get; set; }
		public int Int { get; set; }
		
		public Test(string name, int str)
		{
			Name = name;
			Str = str;
		}
		
		public int Boost()
		{
			return(Str+3);
		}
	}
	public static void Main()
	{
		var names = new List<string> { "<name>", "first", "second" };
		
		Console.WriteLine("Hello World");
		foreach (var word in names)
		{
			Console.WriteLine("Hello {0}", word.ToUpper());
		}
		Console.WriteLine("Total of {0}", names.Count);
		
		if (spot != -1)
			Console.WriteLine("You've got a message");
		else
			Console.WriteLine("Fun");
		
		Test name1 = new Test("chuck", 12);
		Console.WriteLine("Hello {0}", name1.Name);
		Console.WriteLine("{0} boosts strength from {1} to {2}", name1.Name, name1.Str, name1.Boost());
	}
}
