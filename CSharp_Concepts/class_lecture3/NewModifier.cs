using System;

#region Notes
// This program demonstrates the use of the "new" keyword to utilize a function of the same name
// in the derived class as the virtual function in the base class.
#endregion

namespace CSharp_Concepts
{
    class NewModifierBase
    {
        public virtual void fun()
        {
            Console.Write("\n In Base Class fun()...");
        }
        public void printheader()
        {
            Console.Write("\n NEW MODIFIER \n");
        }
    }
    class NewModifierDerv : NewModifierBase
    {
        public new void fun()
        {
            Console.Write("\n In Derived Class fun()...");
        }
    }
}
