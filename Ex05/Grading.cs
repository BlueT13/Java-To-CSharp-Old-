using System;

namespace Ex05
{
	class Grading
	{
		public void PrintGrading()
		{
			char grade;

			Console.Write("Enter score(0~100): ");
			int score = int.Parse(Console.ReadLine());

			if (score >= 90)
				grade = 'A';
			else if (score >= 80)
				grade = 'B';
			else if (score >= 70)
				grade = 'C';
			else if (score >= 60)
				grade = 'D';
			else
				grade = 'F';

			Console.WriteLine("Grade is " + grade);
		}
	}
}
