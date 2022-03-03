using System;

namespace Ex06
{
	class Ex06_6
	{
		public void PrintEx06_6()
		{
			int count0 = 0;
			int count1 = 0;
			int[] parity = new int[8];
			for (int i = 0; i < parity.Length; i++)
			{
				Console.Write("8개의 비트를 입력하시오: ");
				parity[i] = Convert.ToInt32(Console.ReadLine());

				if (parity[i] == 0)
					count0++;
				else
					count1++;
			}
			if (count0 % 2 == 0)
			{
				for (int j = 0; j < parity.Length; j++)
				{
					Console.Write(parity[j]);
					Console.Write(" ");
				}
				Console.Write("0");
			}
			else
			{
				for(int k = 0; k<parity.Length; k++)
				{
					Console.Write(parity[k]);
					Console.Write(" ");
				}
				Console.Write("1");
			}
		}
	}
}
