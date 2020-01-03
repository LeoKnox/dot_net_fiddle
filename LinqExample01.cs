using System;
using System.Linq;
using System.Collections.Generic;
					
public class Program
{
	public static void Main()
	{
		string[] heroes = {"Aelien", "Xingu", "Colette", "Ynzon"};
		IEnumerable<string> living = from hero in heroes where hero.Length > 5 select hero;
		foreach (var alive in living) {
			Console.WriteLine(alive);
		}
		Console.WriteLine("Hello World");
	}
}
