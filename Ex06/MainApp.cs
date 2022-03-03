using System;

namespace Ex06
{
	class MainApp
	{
		static void Main(string[] args)
		{
			ForSample forSample = new ForSample();
			forSample.PrintForSample();
			Console.WriteLine();

			WhileSample whileSample = new WhileSample();
			whileSample.PrintWhileSample();
			Console.WriteLine();

			DoWhileSample doWhileSample = new DoWhileSample();
			doWhileSample.PrintDoWhileSample();
			Console.WriteLine();

			NestedLoop nestedLoop = new NestedLoop();
			nestedLoop.PrintNestedLoop();
			Console.WriteLine();

			ContinueExample continueExample = new ContinueExample();
			continueExample.PrintContinueExample();
			Console.WriteLine();

			BreakExample breakExample = new BreakExample();
			breakExample.PrintBreakExample();
			Console.WriteLine();

			ArrayAccess arrayAccess = new ArrayAccess();
			arrayAccess.PrintArrayAccess();
			Console.WriteLine();

			Ex06_1 ex06_1 = new Ex06_1();
			ex06_1.PrintEx06_1();
			Console.WriteLine();

			Ex06_2 ex06_2 = new Ex06_2();
			ex06_2.PrintEx06_2();
			Console.WriteLine();

			Ex06_3 ex06_3 = new Ex06_3();
			ex06_3.PrintEx06_3();
			Console.WriteLine();

			Ex06_4 ex06_4 = new Ex06_4();
			ex06_4.PrintEx06_4();
			Console.WriteLine();

			Ex06_5 ex06_5 = new Ex06_5();
			ex06_5.PrintEx06_5();
			Console.WriteLine();

			Ex06_6 ex06_6 = new Ex06_6();
			ex06_6.PrintEx06_6();
			Console.WriteLine();
		}
	}
}
