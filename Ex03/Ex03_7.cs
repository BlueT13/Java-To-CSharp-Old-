using System;

namespace Ex03
{
	class Ex03_7
	{
		public void PrintEx03_7()
		{
			double a;

			Console.Write("inch: ");
			a = double.Parse(Console.ReadLine());

			Console.WriteLine("cm: " + a * 2.54);
		}
	}
}
