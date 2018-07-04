using System;

#region Notes
// This program demonstrates inheritance where a PROTECTED variable in the base class is
// incremented in the base class and decremented in the derived class.
#endregion

namespace CSharp_Concepts
{
    class Inheritance
    {
        protected int count; // declard as protected so derived classes can access it
                             // if it is private, derived classes cannot access it
        public Inheritance()
        {
            count = 0;
            printheader();
        }
        public void increment()
        {
            count += 1;
        }
        public void printout()
        {
            Console.Write("\n Value of count : " + count);
            Console.Write("\n");
        }
        public void printheader()
        {
            Console.WriteLine("\n INHERITANCE ");
        }
    }
    class Inheritance1 : Inheritance
    {
        public Inheritance1()
        {

        }
        public void decrement()
        {
            count -= 1;
        }
    }
}
