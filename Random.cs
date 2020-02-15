using System;
					
public class Program
{
	public static void Main()
	{
		Random random = new Random();
        Console.WriteLine("RANDOM6: " + random.Next(1, 7));
        Console.WriteLine("RANDOM6: " + random.Next(1, 7));
        Console.WriteLine("RANDOM6: " + random.Next(1, 7));
		for (int i = 0; i < 10; i++)
		{
			Console.WriteLine("RANDOM: " + random.Next(1, 21));
		}
	}
}
