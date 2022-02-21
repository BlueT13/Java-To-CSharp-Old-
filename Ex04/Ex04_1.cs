using System;

namespace Ex04
{
	class Ex04_1
	{
		public void PrintEx04_1()
		{
			double won;
			double dollar;

			Console.Write("Price in won: ");
			won = Convert.ToDouble(Console.ReadLine());

			dollar = won / 1170;
			dollar = Math.Round(dollar, 2);
			Console.WriteLine($"--> ${dollar}");
		}
	}
}
