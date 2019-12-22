using System;
					
public class Program
{
	public class ClassArray
	{
		public int[] nums{ get; set; }
		
		public ClassArray(int[] ca)
		{
			this.nums = ca;	
		}
		
		public int Roller(int a)
		{
			return nums[a];	
		}
	}
	
	public static void Main()
	{
		ClassArray[] sed = new ClassArray[] {[0, 1, 2, 3, 4]}; // this line isn't working
		ClassArray sed.nums = new[] {0, 1, 2, 3, 4}; // not working either
		Console.WriteLine(sed.Roller(3));
	}
}
