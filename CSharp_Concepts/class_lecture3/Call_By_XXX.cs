using System;

#region Notes
// This program demonstrates call-by-value vs call-by-reference.
#endregion

namespace CSharp_Concepts
{
    class Call_By_XXX
    {
        public void call_by_reference(ref int i)
        {
            i = i + 1;
            Console.WriteLine("\n Value of i : " + i);
        }
        public void call_by_value(int i)
        {
            i = i + 1;
            Console.WriteLine("\n Value of i : " + i);
        }
        public void printout()
        {
            int r = 1;

            // Call by value
            Console.WriteLine("\n CALL BY VALUE ");
            Console.WriteLine("\n Initial value of r : " + r);
            this.call_by_value(r);
            Console.WriteLine("\n Value of r after using call_by_value function : " + r);

            Console.WriteLine("\n --------------------- ");

            // Call by value
            Console.WriteLine("\n CALL BY REFERENCE ");
            Console.WriteLine("\n Initial value of r : " + r);
            this.call_by_reference(ref r);
            Console.WriteLine("\n Value of r after using call_by_reference function : " + r);
        }
    }
}
