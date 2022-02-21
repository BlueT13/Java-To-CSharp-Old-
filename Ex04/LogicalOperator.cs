using System;

namespace Ex04
{
	class LogicalOperator
	{
		public void PrintLogicalOperator()
		{
			Console.WriteLine('a'>'b');
			Console.WriteLine(3 >= 2);
			Console.WriteLine(-1 < 0);
			Console.WriteLine(3.45 <= 2);
			Console.WriteLine(3 == 2);
			Console.WriteLine(3 != 2);
			Console.WriteLine(!(3 != 2));

			Console.WriteLine((3 > 2) && (3 > 4));
			Console.WriteLine((3 != 2) || (-1 > 0));
			Console.WriteLine((3 != 2) ^ (-1 > 0));
		}
	}
}
