using System;

namespace Ex04
{
	class Ex04_4
	{
		public void PrintEx04_4()
		{
			int amount;
			int count;
			
			Console.Write("Amount: ");
			amount = Convert.ToInt32(Console.ReadLine());

			count = amount / 50000;
			amount = amount % 50000;
			Console.WriteLine($"50,000-won banknot: {count}");

			count = amount / 10000;
			amount = amount % 10000;
			Console.WriteLine($"50,000-won banknot: {count}");

			count = amount / 5000;
			amount = amount % 5000;
			Console.WriteLine($"50,000-won banknot: {count}");

			count = amount / 1000;
			amount = amount % 1000;
			Console.WriteLine($"50,000-won banknot: {count}");

			count = amount / 500;
			amount = amount % 500;
			Console.WriteLine($"50,000-won banknot: {count}");

			count = amount / 100;
			amount = amount % 100;
			Console.WriteLine($"50,000-won banknot: {count}");

			count = amount / 50;
			amount = amount % 50;
			Console.WriteLine($"50,000-won banknot: {count}");

			count = amount / 10;
			amount = amount % 10;
			Console.WriteLine($"50,000-won banknot: {count}");
		}
	}
}
