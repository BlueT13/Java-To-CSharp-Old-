using System;

namespace Ex04
{
	class AssignmentIncDecOperator
	{
		public void PrintAssignmentIncDecOperator()
		{
			int a = 3, b = 3, c = 3;

			a += 3;	//a = a+3
			b *= 3;	//b = b*3
			c %= 2; //c = c%2
			Console.WriteLine($"a = {a}, b = {b}, c = {c}");

			int d = 3;
			a = d++;    // a=3, d=4
			Console.WriteLine($"a = {a}, d = {d}");

			a = ++d;    // d=5, a=5
			Console.WriteLine($"a = {a}, d = {d}");

			a = d--;    //a=5, d=4
			Console.WriteLine($"a = {a}, d = {d}");

			a = --d;    //d=3, a=3
			Console.WriteLine($"a = {a}, d = {d}");
		}
	}
}
