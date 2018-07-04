using System;

#region Notes
// This program shows the use of the "base" keyword to call the one argument constructor in the
// base class before the one argument constructor of the derived class gets called
#endregion

namespace CSharp_Concepts
{
    class Base
    {
        private int i;
        // if we provide a one argument constructor in the base class, then the responsibility of 
        // adding a zero argument constructor also lies with us.
        public Base()
        {
            printheader();
            Console.Write("\n In (zero argument) Base Constructor...\n");
        }
        public Base(int ii) 
        {
            this.i = ii;
            Console.Write("\n In (one argument) Base Constructor...\n");
        }
        public void printheader()
        {
            Console.WriteLine("\n BASE KEYWORD \n");
        }
    }
    class BaseDerv : Base 
    {
        public BaseDerv()
        {
            Console.Write("\n In (zero argument) Derived Constructor...\n");
        }
        public BaseDerv(int ii) : base(ii) // we use the base keyword so that the one argument constructor in the base class gets called first (which is necessary)
        {
            Console.Write("\n In (one argument) Derived Constructor...\n");
        }
    }
}
