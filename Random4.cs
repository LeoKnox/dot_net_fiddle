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
			int hit = Roll(1, 20);
			if (hit > 17)
			{
			 sum += Roll(2, 12) + 4;
			 two += Roll(1, 8) + 2 + 4;
			 three += Roll(1, 12) + 4;
			 four += Roll(1, 6) + 4;
			}
			System.Threading.Thread.Sleep(1);
			int hit2 = Roll(1, 20);
			if (hit2 > 17)
			{
			 sum += Roll(2, 12) + 4;
			 two += Roll(1, 8) + 2+ 4;
			 three += Roll(1, 12) + 4;
			 four += Roll(1, 6) + 4;
			}
			System.Threading.Thread.Sleep(1);
			int hit3 = Roll(1, 20);
			if (hit3 > 17)
			{
				four += Roll(1, 6) + 4;
			}
		}
		Console.WriteLine("2d6: {0}", sum);
		Console.WriteLine("1d8+2: {0}", two);
		Console.WriteLine("1d12: {0}", three);
		Console.WriteLine("1d8+1d8: {0}", four);
	}
}
