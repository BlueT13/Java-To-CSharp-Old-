using System;

namespace Ex05
{
	class TernaryOperator
	{
		public void PrintTernaryOperator()
		{
			int a = 3, b = 5;
			int difference = (a > b) ? (a - b) : (b - a);
			Console.WriteLine("Difference is " +difference);
		}
	}
}
