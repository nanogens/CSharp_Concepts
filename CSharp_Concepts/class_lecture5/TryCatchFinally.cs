using System;

#region Notes
// The finally block is used to perform clean up operations before the program ends.
// The finally block is guaranteed to get executed reguardless of whether an exception is thrown.
// So instead of writing the clean up code in both the try block (if the exception is not thrown) and 
// catch block (if the exception is thrown), we should write the code in the finally block.
// This prevents duplication of code.
// If the catch block is absent, the exception is handled by the CLR.  Then the code in the finally 
// block is executed and the execution of the program is terminated.
#endregion

namespace CSharp_Concepts
{
    class TryCatchFinally 
    {
        private int[] a = new int[5];
        private int b;
        public TryCatchFinally()
        {
            b = 2;
            Console.WriteLine("\n TRY CATCH FINALLY \n");
        }
        public void Finally()
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
            finally
            {
                Console.WriteLine("\n Finally!");
            }
            Console.WriteLine("\n Remaining program...");
        }
    }
}
