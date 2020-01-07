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
		public Decimal Damage { get; set; }
		
		public Monster(string n, int o, int d, int dm)
		{
			this.Name = n;
			this.Offense = o;
			this.Defense = d;
			this.Damage = dm;
		}
	}
}
