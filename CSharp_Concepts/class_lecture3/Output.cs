using System;

namespace CSharp_Concepts
{
    class Output
    {
        public void outkast(out int o)
        {
            o = 5;
            o = o + 1;
            Console.WriteLine("\n Value of o : " + o);
        }
        public void printout()
        {
            int f; // with the out keyword, we don't need to assign the value of f here because o is assigned within the class's method

            Console.WriteLine("\n OUT VARIABLE ");
            //Console.WriteLine("\n Initial value of f : " + f); // this complains if we did not assign f, but this issue is not related to the issue of not having to initialize f when using the out keyword
            this.outkast(out f);
            Console.WriteLine("\n Value of f after using out variable function : " + f);
        }
    }
}
