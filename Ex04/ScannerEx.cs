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

			string city = Console.ReadLine();
			Console.Write($"City: {city}", ", ");

			int age = int.Parse(Console.ReadLine());
			Console.Write($"Age: {age}", ", ");

			double weight = Convert.ToDouble(Console.ReadLine());
			Console.Write($"Weight: {weight}", ", ");

			bool marriage =Convert.ToBoolean(Console.ReadLine());
			Console.WriteLine($"Marriage: {marriage}");
		}
	}
}
