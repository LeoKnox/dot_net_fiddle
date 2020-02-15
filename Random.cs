using System;
					
public class Program
{
	public static void Main()
	{
		Random random = new Random();
        // ... Get 3 random numbers.
        //     These are always 5, 6, 7, 8 or 9.
        Console.WriteLine("RANDOM: " + random.Next(1, 7));
        Console.WriteLine("RANDOM: " + random.Next(1, 7));
        Console.WriteLine("RANDOM: " + random.Next(1, 7));
	}
}
