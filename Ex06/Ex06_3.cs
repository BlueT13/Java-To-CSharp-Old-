using System;

namespace Ex06
{
	class Ex06_3
	{
		public void PrintEx06_3()
		{
			int[] count = new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0};
			int[] responses = new int[] { 1, 2, 6, 4, 8, 5, 9, 7, 8, 10,
										  1, 6, 3, 8, 6, 10, 3, 8, 2, 7,
										  6, 5, 7, 6, 8, 7, 5, 6, 6, 5,
										  6, 7, 5, 6, 4, 8, 6, 8, 10, 6};

			Console.WriteLine("Rating   Frequency");
			for (int i=0; i<responses.Length; i++)
			{
				switch (responses[i])
				{
					case 1:
						count[0]++;
						break;

					case 2:
						count[1]++;
						break;

					case 3:
						count[2]++;
						break;

					case 4:
						count[3]++;
						break;

					case 5:
						count[4]++;
						break;

					case 6:
						count[5]++;
						break;

					case 7:
						count[6]++;
						break;

					case 8:
						count[7]++;
						break;

					case 9:
						count[8]++;
						break;

					case 10:
						count[9]++;
						break;
					
					default:
						Console.WriteLine("에러");
						break;
				}
			}
			for (int j = 0; j < 10; j++)
				Console.WriteLine($"    {j + 1}		{count[j]}");
		}
	}
}
