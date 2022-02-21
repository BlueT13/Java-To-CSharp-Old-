using System;

namespace Ex03
{
	class Ex03_12
	{
		public void PrintEx03_12()
		{
			double a; //가로
			double b; //세로
			double c; //방의 넓이
			double d; //방의 평수

			Console.Write("방의 가로 길이와 세로 길이를 입력하시오: ");
			a = double.Parse(Console.ReadLine());
			b = double.Parse(Console.ReadLine());

			c = a * b;
			d = c / 3.3058;

			Console.WriteLine($"방의 넓이는 {c}m^2이고 방의 평수는 {d}평이다.");

		}
	}
}
