using System;

namespace Ex05
{
	class GradingSwitch
	{
		public void PrintGradingSwitch()
		{
			char grade;
			Console.Write("Enter score(0~100): ");
			int score = Convert.ToInt32(Console.ReadLine());

			switch (score / 10)
			{
				case 10:
				case 9:
					grade = 'A';
					break;
				case 8:
					grade = 'B';
					break;
				case 7:
					grade = 'C';
					break;
				case 6:
					grade = 'D';
					break;
				default:
					grade = 'F';
					break;
			}
			Console.WriteLine("Grade is " + grade);
		}
	}
}
