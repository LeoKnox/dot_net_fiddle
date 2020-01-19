using System;
					
public class Program
{
	public class Runner
	{
		public string Name { get; set; }
		pbulic string Type { get; set; }
		public int Use { get; set; }
		
		public Runner(string n, string t, int u)
		{
			this.Name = n;
			this.Type = t;
			this.Use = u;
		}
	}
	
	public static void Main()
	{
		Runner test = new test("Howard", "Red", 13);
		string[] names = { "Strange", "Wayne", "Tree" };
		int[] stats = new int[7];
		Console.WriteLine("Hello World");
	}
}
