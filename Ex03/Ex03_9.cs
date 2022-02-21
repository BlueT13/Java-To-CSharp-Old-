using System;

namespace Ex03
{
	class Ex03_9
	{
		public void PrintEx03_9()
		{
			double c;
			double f;

			Console.Write("섭씨 온도(실수값)를 입력하시오: ");
			c = double.Parse(Console.ReadLine());

			f = c * 9 / 5 + 32;
			Console.WriteLine($"화씨 온도는 {f}");

		}
	}
}
