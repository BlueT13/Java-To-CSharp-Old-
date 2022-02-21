using System;

namespace Ex04
{
	class Account
	{
		public void PrintAccount()
		{
			double balance = 0.0;
			Console.WriteLine($"Balance: {.2f}",balance);	//수정필요

			double amount;
			Console.Write("Enter deposit amout: ");
			amount = Convert.ToDouble(Console.ReadLine());
			balance += amount;
			Console.WriteLine($"Balance: {.2f}", balance);	//수정필요

			Console.Write("Enter deposit amount: ");
			amount = Convert.ToDouble(Console.ReadLine());
			balance += amount;
			Console.WriteLine($"Balance: {balance}");		//수정필요
		}
	}
}
