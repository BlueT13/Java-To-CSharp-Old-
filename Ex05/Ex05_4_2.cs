using System;

namespace Ex05
{
	class Ex05_4_2
	{
		public void PrintEx05_4_2()
		{
			Console.Write("Enter month (1~12): ");
			int month = Convert.ToInt32(Console.ReadLine());

			switch(month)
			{
				case 1:
					Console.WriteLine("winter");
					break;
				case 2:
					Console.WriteLine("winter");
					break;
				case 3:
					Console.WriteLine("spring");
					break;
				case 4:
					Console.WriteLine("spring");
					break;
				case 5:
					Console.WriteLine("spring");
					break;
				case 6:
					Console.WriteLine("summer");
					break;
				case 7:
					Console.WriteLine("summer");
					break;
				case 8:
					Console.WriteLine("summer");
					break;
				case 9:
					Console.WriteLine("fall");
					break;
				case 10:
					Console.WriteLine("fall");
					break;
				case 11:
					Console.WriteLine("fall");
					break;
				case 12:
					Console.WriteLine("winter");
					break;
				default:
					Console.WriteLine("invalid input");
					break;
			}
				
		}
	}
}
