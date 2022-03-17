using System;

namespace Ex04
{
	class MainApp
	{
		static void Main(string[] args)
		{
			ScannerEx scannerEx = new ScannerEx();
			scannerEx.PrintScannerEx();
			Console.WriteLine("");

			ArithmeticOperator arithmeticOperator = new ArithmeticOperator();
			arithmeticOperator.PrintArithmeticOperator();
			Console.WriteLine("");

			AssignmentIncDecOperator assignmentIncDecOperator = new AssignmentIncDecOperator();
			assignmentIncDecOperator.PrintAssignmentIncDecOperator();
			Console.WriteLine("");

			LogicalOperator logicalOperator = new LogicalOperator();
			logicalOperator.PrintLogicalOperator();
			Console.WriteLine("");

			Account account = new Account();
			account.PrintAccount();
			Console.WriteLine("");

			Ex04_1 ex04_1 = new Ex04_1();
			ex04_1.PrintEx04_1();
			Console.WriteLine("");

			Ex04_2 ex04_2 = new Ex04_2();
			ex04_2.PrintEx04_2();
			Console.WriteLine("");

			Ex04_3 ex04_3 = new Ex04_3();
			ex04_3.PrintEx04_3();
			Console.WriteLine("");

			Ex04_4 ex04_4 = new Ex04_4();
			ex04_4.PrintEx04_4();
			Console.WriteLine("");
		}
	}
}
