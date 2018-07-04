using System;

namespace CSharp_Concepts
{
	class Arr
	{
		private int[] a;

		private void arraysetup()
		{
			a = new int[5];
			a[0] = 5;
			a[1] = 6;
			a[2] = 7;
			a[3] = 8;
			a[4] = 9;
		}
		public void printout()
		{
			this.arraysetup();
			Console.Write("\n Array value [2] is : " + this.a[2]);
		}
	}
}
