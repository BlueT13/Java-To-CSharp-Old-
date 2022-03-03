using System;

namespace Ex06
{
	class Ex06_2
	{
		public void PrintEx06_2()
		{
			double p = 1000;
			double r = 0.05;
			int n = 10;

			Console.WriteLine("Year		Amount on deposit");
			for (int i =1; i<=10;i++)
			{
				double a = p * Math.Pow(1 + r, i);
				Console.WriteLine($"	{i}		{a}");
			}
		}
	}
}
