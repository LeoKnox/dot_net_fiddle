using System;
					
public class Program
{
	public static void UseParams(params object[] list)
	{
		for (int i = 0; i < list.Length; i++)
		{
			Console.WriteLine(list[i]);
		}
	}
	
	public static void Main()
	{
		int[] red = { 4, 3, 2, 5 };
		UseParams(3, "five", 10.2f);
		object[] array = new object[2];
		array[0] = "cool";
		array[1] = -4;
		Console.WriteLine("Hello World");
	}
}
