using System;

namespace CSharp_Concepts
{
	class JaggedArray
	{
		private int[][] arr;

		public JaggedArray(byte selector)
		{
			arr = new int[2][]; // this says our jagged array will contain 2 rows
			                    // columns are now mentioned because jagged arrays permit us to have different number of elements in the second dimension
			if (selector == 0)
			{
				arr[0] = new int[4] { 3, 5, 7, 9 }; // 2nd dimension for row 0.  It is necessary to tell the compiler the second dimension which we do here
				arr[1] = new int[2] { 11, 13 }; // 2nd dimension for row 1.
			}
			else
			{
				arr[0] = new int[4] { 3, 5, 7, 9 };
				arr[1] = new int[6] { 11, 13, 14, 15, 16, 17 };
			}
		}
		public void Printout()
		{
			int a = arr[0].Length;
			int b = arr[1].Length;

			Console.WriteLine("\n JAGGED ARRAY ");

			for (int x = 0; x < a; x++)
			{
				Console.WriteLine("\n arr[0][" + x + "] = " + arr[0][x]);
			}

			Console.Write("\n --------------- \n");

			for (int y = 0; y < b; y++)
			{
				Console.WriteLine("\n arr[1][" + y + "] = " + arr[1][y]);
			}

		}
	}
}
