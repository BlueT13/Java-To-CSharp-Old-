using System;

namespace Ex06
{
	class Ex06_5
	{
		public void PrintEx06_5()
		{
			for (int i = 2; i < 10; i+=2)
			{
				for (int j = 1; j < 10; j++)
				{
					for (int k = i; k <= i + 1; k++)
						Console.Write(k + "*" + j + "=" + k * j+"\t");
					Console.WriteLine();
				}
				Console.WriteLine();
			}

		}
	}
}
