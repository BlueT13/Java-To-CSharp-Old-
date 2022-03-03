using System;

namespace Ex05
{
	class NestedIf
	{
		public void PrintNestedIf()
		{
			Console.Write("Enter score(0~100): ");
			int score = int.Parse(Console.ReadLine());

			Console.Write("Enter year(1~4): ");
			int year = int.Parse(Console.ReadLine());

			if (score >= 60)
			{
				if (year != 4)
					Console.WriteLine("Pass!");
				else if (score >= 70)
					Console.WriteLine("Pass!");
				else
					Console.WriteLine("Fail!");
			}
			else
				Console.WriteLine("Fail!");
		}
	}
}
