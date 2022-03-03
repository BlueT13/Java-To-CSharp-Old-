using System;

namespace Ex06
{
	class DoWhileSample
	{
		public void PrintDoWhileSample()
		{
			char c = 'a';

			do
			{
				Console.Write(c);
				c = (char)(c + 1);
			} while (c <= 'z');
		}
	}
}
