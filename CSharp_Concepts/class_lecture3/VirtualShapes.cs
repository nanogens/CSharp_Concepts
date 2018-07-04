using System;

#region Notes
// This program demonstrates the use of virtual functions being overridden in the derived class.
// Only the overridden function in the derived class then runs, not the virtual one in the base class.
// Only if there is no such override function in the derived class does the function in the base class run.
#endregion

namespace CSharp_Concepts
{
	class VirtualShapes
	{
		public virtual void draw()
		{
			Console.Write("\n Virtual Method in Base Class : VirtualShapes...");
		}
		public void printheader()
		{
			Console.Write("\n VIRTUAL METHODS - VIRTUALSHAPES \n");
		}
	}
	class Rectangle : VirtualShapes
	{
		public override void draw()
		{
			Console.Write("\n Derived Class Override of Virtual Method in Base Class : Rectangle...");
		}
	}
	class Circle : VirtualShapes
	{
		public override void draw()
		{
			Console.Write("\n Derived Class Override of Virtual Method in Base Class : Circle...");
		}
	}
}
