using System;

namespace Ex05
{
	class DanglingElse
	{
		public void PrintDanglingElse()
		{
			int x = 6;
			int y = 4;

			if (x > 5)
				if (y > 5)
					Console.WriteLine("A");
				else
					Console.WriteLine("B");
		}
	}
}
