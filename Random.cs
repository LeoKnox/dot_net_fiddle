using System;
					
public class Program
{
	public static void Main()
	{
		Random random = new Random();
        int ac = random.Next(10, 18);
		Console.WriteLine("ac = " + ac);
		int sumy = 0;
		int sumz = 0;
		int suma = 0;
		for (int i = 0; i < 10; i++)
		{
			int x = random.Next(1, 21);
			int y = random.Next(1, 13);
			int z = random.Next(1, 7) + random.Next(1, 7);
			int a = random.Next(3, 11);
			if (x > ac)
			{
				Console.WriteLine("RANDOM: " + x);
				Console.WriteLine("1d12: " + y);
				Console.WriteLine("2d6: " + z);
				Console.WriteLine("1d8+2: " + a);
				sumy += y;
				sumz += z;
				suma += a;
			}
		}
		Console.WriteLine(sumy);
		Console.WriteLine(sumz);
		Console.WriteLine(suma);
	}
}
