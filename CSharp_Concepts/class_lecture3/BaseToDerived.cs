using System;

#region Notes
// This program demonstrates that a calculation done in the constructor of the derived class
// first goes to the base constructor (in this case getting the value of i) BEFORE running the
// calculation in the derived class.
#endregion

namespace CSharp_Concepts
{
	class BaseTo
	{
        protected int i;
        public BaseTo()
        {
            Console.WriteLine("\n BASETODERV ");
            i = 4;
        }
	}
    class BaseToDerv : BaseTo
    {
        int j;
        public BaseToDerv()
        {
            j = i * 4;
            Console.Write("\n Value of j : " + j);
        }
    }
}
