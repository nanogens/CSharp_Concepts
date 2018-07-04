using System;

namespace CSharp_Concepts
{
	class ArrofObjects
	{
		private Sample[] s;

		private void arraysetup()
		{
			s = new Sample[5]; // pointer created on the Stack

			s[0] = new Sample(); // objects created on the Heap 
			s[1] = new Sample();
			s[2] = new Sample();
			s[3] = new Sample();
			s[4] = new Sample();

			s[0].printout();
			s[1].printout();
			s[2].printout();
			s[3].printout();
			s[4].printout();
		}
		public void printout()
		{
			this.arraysetup();
			//Console.Write("\n Array value [2] is : " + this.s[2]);
		}
	}

	class Sample
	{
		static byte numtimes = 0;
		public void printout()
		{
			Console.Write("\n Sample object created " + numtimes);
			numtimes++;
		}
	}
}
