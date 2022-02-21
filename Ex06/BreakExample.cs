using System;

namespace Ex06
{
	class BreakExample
	{
		public void PrintBreakExample()
		{
			Console.WriteLine("Type exit to terminate.");
			while(true)
			{
				Console.Write(">>");
				string text = Console.ReadLine();
				if (text.Equals("exit"))
					break;
			}
			Console.WriteLine("Terminating...");
		}
	}
}
