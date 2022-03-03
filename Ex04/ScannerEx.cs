using System;

namespace Ex04
{
	class ScannerEx
	{
		public void PrintScannerEx()
		{
			Console.WriteLine("Enter name, city, age, weight, marriage.");
			string name = Console.ReadLine();
			Console.Write($"Name: {name}", ", ");
			Console.WriteLine();

			string city = Console.ReadLine();
			Console.Write($"City: {city}", ", ");
			Console.WriteLine();

			int age = int.Parse(Console.ReadLine());
			Console.Write($"Age: {age}", ", ");
			Console.WriteLine();

			double weight = Convert.ToDouble(Console.ReadLine());
			Console.Write($"Weight: {weight}", ", ");
			Console.WriteLine();

			bool marriage =Convert.ToBoolean(Console.ReadLine());
			Console.WriteLine($"Marriage: {marriage}");
		}
	}
}
