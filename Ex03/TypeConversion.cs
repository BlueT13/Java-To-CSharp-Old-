using System;

namespace Ex03
{
	class TypeConversion
	{
		public void PrintTypeConversion()
		{
			byte b = 127;
			int i = 100;
			int hex = 0x12340041;

			Console.WriteLine(b + i);
			Console.WriteLine(10/4);
			Console.WriteLine(10.0/4);
			Console.WriteLine((char)hex); 
			Console.WriteLine((byte)(b+i)); //수정필요
			Console.WriteLine($"{(int)2.9+1.8}");
			Console.WriteLine((int)(2.9+1.8));
			Console.WriteLine((int)2.9+(int)1.8);
		}
	}
}
