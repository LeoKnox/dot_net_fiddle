using System;
					
public class Program
{	
	public static int Roll(int a, int b)
	{
		Random random = new Random();
		return random.Next(a, b+1);
	}
	
	public static void Main()
	{
		int sum = 0;
		int two = 0;
		int three = 0;
		int four = 0;
	
		for (int i = 0; i < 100; i++)
		{
			System.Threading.Thread.Sleep(1); // required to change seed in loop
			sum += Roll(1, 6) + Roll(1, 6) + Roll(1, 6) + Roll(1, 6);
			two += Roll(1, 8) + 2 + Roll(1, 8) + 2;
			three += Roll(1, 12) + Roll(1, 12);
			four += Roll(1, 8) + Roll(1, 8) + Roll(1, 6);
		}
		Console.WriteLine("2d6: {0}", sum);
		Console.WriteLine("1d8+2: {0}", two);
		Console.WriteLine("1d12: {0}", three);
		Console.WriteLine("1d6+1d4: {0}", four);
	}
}
