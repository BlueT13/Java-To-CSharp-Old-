using System;

namespace Ex06
{
	class Ex06_4
	{
		public void PrintEx06_4()
		{
			for(int i =2;i<10;i++)
			{
				for(int j=1;j<10;j++)
				{
					Console.WriteLine(i + "*" + j + "=" + i * j);
				}
				Console.WriteLine();
			}
		}
	}
}
