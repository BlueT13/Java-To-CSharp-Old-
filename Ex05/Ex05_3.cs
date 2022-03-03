using System;

namespace Ex05
{
	class Ex05_3
	{
		public void PrintEx05_3()
		{
			Console.Write("Enter x1, y1 and r1: ");
			double x1 = Convert.ToDouble(Console.ReadLine());
			double y1 = Convert.ToDouble(Console.ReadLine());
			double r1 = Convert.ToDouble(Console.ReadLine());

			Console.Write("Enter x2, y2 and r2: ");
			double x2 = Convert.ToDouble(Console.ReadLine());
			double y2 = Convert.ToDouble(Console.ReadLine());
			double r2 = Convert.ToDouble(Console.ReadLine());

			double distance = Math.Sqrt(Math.Pow(x2 - x1,2) + Math.Pow(y2 - y1,2));
			if (distance <= r1 + r2)
				Console.WriteLine("--> overlapped");
			else
				Console.WriteLine("--> not overlapped");
		}
	}
}
