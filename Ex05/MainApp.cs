using System;

namespace Ex05
{
	class MainApp
	{
		static void Main(string[] args)
		{
			TernaryOperator ternaryOperator = new TernaryOperator();
			ternaryOperator.PrintTernaryOperator();
			Console.WriteLine();

			BitOperator bitOperator = new BitOperator();    //수정필요
			bitOperator.PrintBitOperator();				//출력값이 다르게나옴
			Console.WriteLine();

			MultipleOfThree multiple = new MultipleOfThree();
			multiple.PrintMultipleOfThree();
			Console.WriteLine();

			Grading grading = new Grading();
			grading.PrintGrading();
			Console.WriteLine();

			NestedIf nestedIf = new NestedIf();
			nestedIf.PrintNestedIf();
			Console.WriteLine();

			GradingSwitch gradingSwitch = new GradingSwitch();
			gradingSwitch.PrintGradingSwitch();
			Console.WriteLine();

			CoffeePrice coffee = new CoffeePrice();
			coffee.PrintCoffePrice();
			Console.WriteLine();

			DanglingElse danglingElse = new DanglingElse();
			danglingElse.PrintDanglingElse();
			Console.WriteLine();

			Ex05_1 ex05_1 = new Ex05_1();
			ex05_1.PrintEx05_1();
			Console.WriteLine();

			Ex05_2 ex05_2 = new Ex05_2();
			ex05_2.PrintEx05_2();
			Console.WriteLine();

			Ex05_3 ex05_3 = new Ex05_3();
			ex05_3.PrintEx05_3();
			Console.WriteLine();

			Ex05_4_1 ex05_4_1 = new Ex05_4_1();
			ex05_4_1.PrintEx05_4_1();
			Console.WriteLine();

			Ex05_4_2 ex05_4_2 = new Ex05_4_2();
			ex05_4_2.PrintEx05_4_2();
			Console.WriteLine();
		}
	}
}
