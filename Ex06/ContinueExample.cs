using System;

namespace Ex06
{
	class ContinueExample
	{
		public void PrintContinueExample()
		{
			Console.WriteLine("Enter 5 numbers.");
			int sum = 0;
			for (int i = 0; i < 5; i++)
			{
				int n = Convert.ToInt32(Console.ReadLine());
				if (n <= 0)
					continue;
				else
					sum += n;
			}
			Console.WriteLine("Sum of positive numbers: " + sum);
		}
	}
}
