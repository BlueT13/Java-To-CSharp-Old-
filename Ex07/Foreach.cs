using System;

namespace Ex07
{
	class Foreach
	{
		enum Week { MONDAY, TUESDAY, WENDSEDAY, THURSDAY, FRIDAY, SATURDAY, SUNDAY}

		public void PrintForeach()
		{
			int[] num = new int[] { 1, 2, 3, 4, 5 };
			int sum = 0;
			foreach (int k in num)
				sum += k;
			Console.WriteLine("Sum: " + sum);

			string[] names = new string[] {"apple", "pear", "banana", "cherry"
			, "strawberry","grapes" };

			foreach (string s in names)
				Console.Write(s + " ");
			Console.WriteLine();
		}
	}
}
