using System;

namespace Ex03
{
	class Ex03_8
	{
		public void PrintEx03_8()
		{
			int hour;
			int minute;
			int second;
			
			Console.Write("hour: ");
			hour = int.Parse(Console.ReadLine());

			Console.Write("minute: ");
			minute = int.Parse(Console.ReadLine());

			Console.Write("second: ");
			second = int.Parse(Console.ReadLine());

			int total = hour * 60 * 60 + minute * 60 + second;
			Console.WriteLine("Total: {0} sec.",total);

		}
	}
}
