using System;

namespace CSharp_Concepts
{
	class RectangularArray
	{
		private int[,] arr;

		public RectangularArray(byte selector)
		{
			if (selector == 0)
			{
				arr = new int[,] { { 3, 5, 7, 9 }, { 11, 13, 15, 17 } };
			}
			else
			{
				arr = new int[,] { { 2, 4, 6, 8 }, { 10, 12, 14, 16 } };
			}
		}
		public void Printout()
		{
			for (int i = 0; i < arr.GetLength(0); i++)
			{
				for (int j = 0; j < arr.GetLength(1); j++)
				{
					Console.Write("\n arr[" + i + "]" + "[" + j + "] = " + arr[i, j]);
				}
			}
			Console.Write("\n ---------------");
		}
	}
}
