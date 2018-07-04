using System;

namespace CSharp_Concepts
{
    class MultipleCatch
    {
        private int[] a = new int[5];
        private int b;
        public MultipleCatch()
        {
            b = 2;
            Console.WriteLine("\n MULTIPLE CATCH \n");
        }
        public void ManyCatches()
        {
            try
            {
                int i = 10 / b;
                a[10] = 9;
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("\n " + e);
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine("\n Index Out of Bounds...");
            }
            Console.WriteLine("\n Remaining program...");
        }
    }
}
