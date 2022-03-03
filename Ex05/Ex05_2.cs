using System;

namespace Ex05
{
	class Ex05_2
	{
		public void PrintEx05_2()
		{
			Console.Write("Enter a, b and r: ");
			double a = Convert.ToDouble(Console.ReadLine());
			double b = Convert.ToDouble(Console.ReadLine());
			double r = Convert.ToDouble(Console.ReadLine());

			Console.Write("Enter x and y: ");
			double x = Convert.ToDouble(Console.ReadLine());
			double y = Convert.ToDouble(Console.ReadLine());

			double distance = Math.Sqrt(Math.Pow((x - a), 2) + Math.Pow((y - b), 2));

			if (distance <= r)
				Console.WriteLine($"({x}, {y}) is inside the circle");
			else
				Console.WriteLine($"({x}, {y}) is not inside the circle");

		}
	}
}
