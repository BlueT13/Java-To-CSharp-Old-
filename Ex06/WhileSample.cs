using System;

namespace Ex06
{
	class WhileSample
	{
		public void PrintWhileSample()
		{
			int count = 0;
			int sum = 0;
			Console.WriteLine("Enter numbers (-1 denotes the end of input) ");

			int n = Convert.ToInt32(Console.ReadLine());
			while (n != -1)
			{
				sum += n;
				count++;
				n = Convert.ToInt32(Console.ReadLine());
			}

			if (count == 0)
				Console.WriteLine("No input");
			else
			{
				Console.WriteLine("Count: " + count);
				Console.WriteLine("Average: " + (double)sum / count);
			}
		}
	}
}
