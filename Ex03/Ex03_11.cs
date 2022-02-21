using System;

namespace Ex03
{
	class Ex03_11
	{
		public void PrintEx03_11()
		{
			double r;
			double r2;
			double r3;
			const double pi = 3.1415926536;

			Console.Write("원의 반지름(실수값)을 입력하시오: ");
			r = double.Parse(Console.ReadLine());

			r2 = 2 * pi * r;
			r3 = pi * r * r;

			Console.WriteLine($"반지름이 {r}인 원의 둘레길이는 {r2}, 넓이는 {r3} 이다.");
		}
	}
}
