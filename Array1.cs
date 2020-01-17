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
		Adventures adv0 = new Adventures();
		adv0.name = "ssss";
		adv0.hp = 3;
		Adventures[] peeps = { adv0 }; 
		Console.WriteLine("Hello World");
	}
}
