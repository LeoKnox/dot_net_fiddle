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
			if (hit > 14)
			{
			 sum += Roll(2, 12);
			 two += Roll(1, 8) + 2;
			 three += Roll(1, 12);
			 four += Roll(1, 8);
			}
			System.Threading.Thread.Sleep(1);
			int hit2 = Roll(1, 20);
			if (hit2 > 14)
			{
			 sum += Roll(2, 12);
			 two += Roll(1, 8) + 2;
			 three += Roll(1, 12);
			 four += Roll(1, 8);
			}
			System.Threading.Thread.Sleep(1);
			int hit3 = Roll(1, 20);
			if (hit3 > 14)
			{
				four += Roll(1, 6);
			}
		}
		Console.WriteLine("2d6: {0}", sum);
		Console.WriteLine("1d8+2: {0}", two);
		Console.WriteLine("1d12: {0}", three);
		Console.WriteLine("1d6+1d4: {0}", four);
	}
}
