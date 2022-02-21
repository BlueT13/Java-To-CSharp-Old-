using System;

namespace Ex05
{
	class MultipleOfThree
	{
		public void PrintMultipleOfThree()
		{
			Console.Write("Enter number: ");
			int number = Convert.ToInt32(Console.ReadLine());

			if (number % 3 == 0)
				Console.WriteLine("is a multiple of 3.");
			else
				Console.WriteLine("is not a multiple of 3.");
		}
	}
}
