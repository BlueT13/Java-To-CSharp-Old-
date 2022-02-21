using System;

namespace Ex06
{
	class Ex06_1
	{
		public void PrintEx06_1()
		{
			int[] x = new int[] { 87, 68, 94, 100, 83, 78, 85, 91, 76, 87, 55, 60, 99, 63, 80 };
			int max = x[0];
			int min = x[0];
			double sum = 0;
			double sum2 = 0;
			double m = 0;
			double v = 0;
			double sigma = 0;

			for (int i = 0; i < x.Length; i++)
			{
				if (x[i] > max)
					max = x[i];
				if (x[i] < min)
					min = x[i];

				sum += x[i];
			}
			
			m = sum / x.Length;

			for (int i = 0; i<x.Length; i++)
				sum2 += Math.Pow((x[i] - m), 2);

			v = sum2 / x.Length;
			sigma = Math.Sqrt(v);

			Console.WriteLine("max = " + max);
			Console.WriteLine("min = " + min);
			Console.WriteLine("m = " + m);
			Console.WriteLine("V = " + v);
			Console.WriteLine("sigma = " + sigma);
		}
	}
}
