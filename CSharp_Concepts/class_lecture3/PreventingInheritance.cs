using System;

#region Notes
// This program demonstrates the use of the "sealed" keyword to prevent a class from being 
// inherited.
#endregion

namespace CSharp_Concepts
{
    sealed class PreventingInheritance
    {
        public int i;
        public PreventingInheritance()
        {
            i = 0;
        }
        // A sealed class prevents inheritance.
        // We cannot even have a virtual function in our sealed class because no derived class is possible
        // and thus there is no way to override the virtual class.
        //public virtual void printout()
        //{
            //Console.Write("\n Value of i : " + i);
        //}
    }

    // Cannot inherit from a sealed class. 
    // Remove sealed in base class to inherit it.
    /*
    class PreventingInheritance1 : PreventingInheritance
    {
        private int j;
        public PreventingInheritance1()
        {
            j = 0;
        }
        public override void printout()
        {
            Console.Write("\n Value of j : " + j);
        }
    }
    */
}
