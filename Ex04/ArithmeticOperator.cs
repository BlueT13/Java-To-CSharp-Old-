using System;

namespace Ex04
{
	class ArithmeticOperator
	{
		public void PrintArithmeticOperator()
		{
			Console.Write("Enter number: ");
			int time = Convert.ToInt32(Console.ReadLine());
			int second = time % 60;
			int minute = (time / 60) % 60;
			int hour = (time / 60) / 60;

			Console.WriteLine($"hour: {hour}");
			Console.WriteLine($"minute: {minute}");
			Console.WriteLine($"second:	{second}");
		}
	}
}
