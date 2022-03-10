using System;

namespace Ex04
{
	class ScannerEx
	{
		public void PrintScannerEx()
		{
			string[] token;

			Console.WriteLine("Enter name, city, age, weight, marriage.");
			string inputdata = Console.ReadLine();
			token = inputdata.Split(' ');
			Console.Write($"Name: {token[0]}, ");
			Console.Write($"City: {token[1]}, ");
			Console.Write($"Age: {Convert.ToInt32(token[2])}, ");
			Console.Write($"Weight: {Convert.ToDouble(token[3])}kg, ");
			Console.WriteLine($"Marriage: {Convert.ToBoolean(token[4])}");
		}
	}
}
