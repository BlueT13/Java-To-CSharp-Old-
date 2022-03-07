﻿using System;

namespace Ex07
{
	class IrregularArray
	{
		public void	PrintIrregularArray()
		{
			int[][] intArray = new int[4][];
			intArray[0] = new int[3];
			intArray[1] = new int[2];
			intArray[2] = new int[3];
			intArray[3] = new int[2];

			for (int i = 0; i < intArray.Length; i++)
				for (int j = 0; j < intArray[i].Length; j++)
					intArray[i][j] = (i + 1) * 10 + j;

			for (int i = 0; i < intArray.Length; i++)
			{
				for (int j = 0; j < intArray[i].Length; j++)
					Console.Write(intArray[i][j] + " ");
				Console.WriteLine();
			}
		}
	}
}
