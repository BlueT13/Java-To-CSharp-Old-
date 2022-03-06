using System;

namespace Ex07
{
	class MainApp
	{
		static void Main(string[] args)
		{
			ArrayLength arrayLength = new ArrayLength();
			arrayLength.PrintArrayLength();
			Console.WriteLine();

			Foreach @foreach = new Foreach();
			@foreach.PrintForeach();
			Console.WriteLine();

			ScoreAverage scoreAverage = new ScoreAverage();
			scoreAverage.PrintScoreAverage();
			Console.WriteLine();

		}
	}
}
