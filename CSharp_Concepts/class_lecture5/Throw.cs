using System;

namespace CSharp_Concepts
{
    class Throw
    {
        public Throw()
        {

        }
        public void Fun(int i)
        {
            if (i > 10)
            {
                throw new Exception("\n Value out of range. \n");
            }
            else
            {
                Console.WriteLine(i);
            }
        }
    }

}
