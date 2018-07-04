using System;

namespace CSharp_Concepts
{
    class Parameter
    {
        public Parameter()
        {
        }
        public void paramtr(params int[] x)
        {
            Console.WriteLine("\n Value of x[0] : " + x[0]);
            Console.WriteLine("\n Value of x[1] : " + x[1]);
            Console.WriteLine("\n Value of x[2] : " + x[2]);
        }
        public void printout()
        {
            Console.WriteLine("\n PARAMETER VARIABLE ");
            int i = 5;
            int j = 6;
            int k = 7;
            this.paramtr(i, j, k);
        }
    }
}
