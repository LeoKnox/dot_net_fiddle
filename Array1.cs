using System;
					
public class Program
{
	public class Adventures
	{
		public string name;
		public int hp;
	}
	
	public static void Main()
	{
		int[] numbs = new int[4];
		Adventures adv0 = new Adventures();
		adv0.name = "ssss";
		adv0.hp = 3;
		Adventures[] peeps = { adv0 }; 
		Console.WriteLine("Hello World");
	}
}
