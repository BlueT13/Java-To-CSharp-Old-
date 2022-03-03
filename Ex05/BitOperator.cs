using System;

namespace Ex05
{
	class BitOperator
	{
		public void PrintBitOperator()	//수정필요
		{
			short a = (short)0x55ff;
			short b = (short)0x00ff;
			Console.WriteLine("[Bitwise logical operation]");
			Console.WriteLine(Convert.ToString(a & b, 16));
			Console.WriteLine(Convert.ToString(a | b, 16));
			Console.WriteLine(Convert.ToString(a ^ b, 16));
			Console.WriteLine(Convert.ToString(~a, 16));

			byte c = 20;
			//byte d = -8;
			Console.WriteLine("[Shift operation]");
			Console.WriteLine("{0}", c <<2);
			Console.WriteLine("{0}", c>>2);
			//Console.WriteLine("{0}", d>>2);
			//Console.WriteLine("{0}", d>>>2);
		}
	}
}
