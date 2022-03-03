using System;

namespace Ex03
{
	class Ex03_6
	{
		public void PrintEx03_6()
		{
			int price = 20_100;
			long cardNumber = 1234_5678_9012_3456L;
			uint controlBits = 0b10110100_01011011_10110011_11111000;
			long maxLong = 0x7fff_ffff_ffff_ffffL;
			int age = 2______5;

			Console.WriteLine($"{price}");
			Console.WriteLine($"{cardNumber}");
			Console.WriteLine($"{controlBits:x}"); 
			Console.WriteLine($"{maxLong:x}"); 
			Console.WriteLine($"{age}");
		}
	}
}
