using System;

namespace Ex05
{
	class Ex05_4_1
	{
		public void PrintEx05_4_1()
		{
			Console.Write("Enter month (1~12): ");
			int month = Convert.ToInt32(Console.ReadLine());

			if (month >= 3 && month <= 5)
				Console.WriteLine("spring");
			else if (month >= 6 && month <= 8)
				Console.WriteLine("summer");
			else if (month >= 9 && month <= 11)
				Console.WriteLine("fall");
			else if (month == 12)
				Console.WriteLine("winter");
			else if (month >= 1 && month <= 2)
				Console.WriteLine("winter");
			else
				Console.WriteLine("invalid input");
		}
	}
}
