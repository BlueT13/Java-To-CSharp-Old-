using System;

namespace Ex06
{
	class ArrayAccess
	{
		public void PrintArrayAccess()
		{
			int[] intArray = new int[5];

			int max = 0;
			Console.WriteLine("Enter 5 positive integers.");
			for (int i = 0; i < 5; i++)
			{
				intArray[i] = Convert.ToInt32(Console.ReadLine());
				if (intArray[i] > max)
					max = intArray[i];
			}
			Console.WriteLine("Max: " + max);
		}
	}
}
