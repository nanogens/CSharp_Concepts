using System;

namespace CSharp_Concepts
{
    class SingleCatch
    {
        private int[] a = new int[5];
        private int b;
        public SingleCatch()
        {
            b = 2;
            Console.WriteLine("\n SINGLE CATCH \n");
        }
        public void NeedOnlyOneCatch()
        {
            try
            {
                int i = 10 / b;
                a[10] = 9;
            }
            catch (Exception e)
            {
                Console.WriteLine("\n " + e);
            }
            Console.WriteLine("\n Remaining program...");
        }
    }
}
