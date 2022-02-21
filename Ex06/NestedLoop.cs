using System;

namespace Ex06
{
	class NestedLoop
	{
		public void PrintNestedLoop()
		{
			for (int i=1; i<10; i++)
			{
				for(int j=1; j<10;j++)
				{
					Console.Write(i + "*" + j + "=" + i * j);
					Console.Write('\t');
				}
				Console.WriteLine();
			}
		}
	}
}
