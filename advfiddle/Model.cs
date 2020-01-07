using System;
using System.ComponentModel.DataAnnotations;

namespace HelloWorldMvcApp
{
	public class SampleViewModel
	{
		[Required]
		[MinLength(10)]
		[MaxLength(100)]
		[Display(Name = "Ask Magic 8 Ball any question:")]
		public string Question { get; set; }

		//See here for list of answers
		public string Answer { get; set; }
	}
	
	public class Monster
	{
		public string Name { get; set; }
		public int Offense { get; set; }
		public int Defense { get; set; }
		public double Damage { get; set; }
		
		public Monster(string n, int o, int d, double dm)
		{
			this.Name = n;
			this.Offense = o;
			this.Defense = d;
			this.Damage = dm;
		}
		
		public string Attack(int x)
		{
			var rand = new Random();
			double y=Convert.ToDouble(rand.Next(x));
			double hp = this.Damage*y;
			return "This Orc does " + hp + " damage";
		}
	}
}
