using System;
					
public class Program
{
	public static void Main()
	{
		string Test = "onxe";
		switch (Test)
		{
			case "one":
			case "onxe":
				Console.WriteLine(Test);
				break;
			default:
				Console.WriteLine("Default");
				break;
		}
		Console.WriteLine("Hello World");
	}
}
