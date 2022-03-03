using System;

namespace Ex02
{
	class Addition2
	{
		public void PrintAddition2()
		{
			int number1;
			int number2;

			Console.Write("Enter first integer: ");
			number1 = int.Parse(Console.ReadLine());

			Console.Write("Enter second integer ");
			number2 = int.Parse(Console.ReadLine());

			int sum = number1 + number2;

			string sum8 = Convert.ToString(sum, 8);
			string sum16 = Convert.ToString(sum, 16);
			Console.Write("Sum is {0} in octal, {1} in decimal, {2} in hexadecimal.",sum8,sum,sum16);
		}
	}
}
