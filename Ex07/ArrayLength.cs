using System;

namespace Ex07
{
	class ArrayLength
	{
		public void PrintArrayLength()
		{
			int[] intArray = new int[5];
			int sum = 0;

			string inputdata = "";
			string[] token;

			Console.Write("Enter " + intArray.Length + " integers>> ");
			inputdata = Console.ReadLine();
			token = inputdata.Split(' '); // 스페이스로 분리
			for (int i = 0; i < intArray.Length; i++)
				intArray[i] = Convert.ToInt32(token[i]);


			for (int i = 0; i < intArray.Length; i++)
				sum += intArray[i];

			Console.WriteLine("Average: " + (double)sum / intArray.Length);
		}
	}
}
