using System;

namespace Ex04
{
	class Ex04_2
	{
		public void PrintEx04_2()
		{
			Console.Write("Enter number(100 ~ 999): ");
			int number = Convert.ToInt32(Console.ReadLine());

			int a = number/100;
			int b = number%100/10;
			int c = number % 100 % 10;

			Console.WriteLine($"{a}  {b}  {c}");
		}
	}
}
