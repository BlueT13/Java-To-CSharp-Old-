using System;

namespace Ex04
{
	class Account
	{
		public void PrintAccount()
		{
			double balance = 0.0;
			string result = string.Format("{0:0.00}", balance);
			Console.WriteLine($"Balance: {result}");

			double amount;
			Console.Write("Enter deposit amout: ");
			amount = Convert.ToDouble(Console.ReadLine());
			balance += amount;
			result = string.Format("{0:0.00}", balance);
			Console.WriteLine($"Balance: {result}");

			Console.Write("Enter deposit amount: ");
			amount = Convert.ToDouble(Console.ReadLine());
			balance += amount;
			result = string.Format("{0:0.00}", balance);
			Console.WriteLine($"Balance: {result}");
		}
	}
}
