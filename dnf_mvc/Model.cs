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
		public string Test { get; set; }
	}
}
