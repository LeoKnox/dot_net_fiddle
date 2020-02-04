using System;
					
public class Program
{
	public static void Main()
	{
		int[] Arr = { 3, 7, 9 };
		try
		{
			Console.WriteLine(Arr[4]);
		}
		catch (Exception e)
		{
			Console.WriteLine(e.Message);
		}
		finally
		{
			Console.WriteLine(0);
		}
	}
}
