using System;

#region Notes
// This is just a general class for printing the clear screen at the bottom of each test case.
#endregion

namespace CSharp_Concepts
{
	class General
	{
		public void Dashline()
		{
			Console.WriteLine("\n\n --------------------------- ");
		}
		public void ClearScreen()
		{
			Console.WriteLine("\n xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx ");
			Proc();
			Clr();
		}
		public void Proc()
		{
			Console.WriteLine("\n\nPress enter to continue...");
			do
			{
			}
			while (Console.ReadKey(true).Key != ConsoleKey.Enter);
		}
		public void Clr()
		{
			Console.Clear();
		}
		public void LeaveLine()
		{
			Console.Write("\n");
		}
	}
}
