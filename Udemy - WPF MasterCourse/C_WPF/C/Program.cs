#region Summary
// This is to show the Console.Readline() method is used to prevent the Console window from closing when the
// console program ends.
// This is to showcase how using var will automatically create the correct type of variable (int, float..etc)
// that we are returning from a function.
#endregion


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C
{
	class Program
	{

		static double numberThree = 12.34; 
		static void Main(string[] args)
		{
			Console.WriteLine("Hello World! Enter a phrase : ");
			var message = Console.ReadLine(); // enter the line
			Console.WriteLine(message); // prints the line it read
			Console.ReadLine();

			var numberOne = 23;
			Console.WriteLine(numberOne); // prints the line it read
			Console.ReadLine();

			var numberTwo = 23.45f;
			Console.WriteLine(numberTwo); // prints the line it read
			Console.ReadLine();

			Console.WriteLine(numberThree); // prints the line 
			Console.ReadLine();
		}
	}

	class SimpleMath
	{

	}
}
