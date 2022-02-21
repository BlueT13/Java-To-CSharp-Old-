using System;

namespace Ex05
{
	class Ex05_1
	{
		public void PrintEx05_1()
		{
			Console.Write("Enter x and y: ");
			int x = Convert.ToInt32(Console.ReadLine());
			int y = Convert.ToInt32(Console.ReadLine());

			if (x >= 100 && x <= 200)
				if (y >= 100 && y <= 200)
					Console.WriteLine($"({x}, {y}) is inside the rectangle.");
				else
					Console.WriteLine($"({x}, {y}) is not inside the rectangle.");
			else
				Console.WriteLine($"({x}, {y}) is not inside the rectangle.");


		}
	}
}
