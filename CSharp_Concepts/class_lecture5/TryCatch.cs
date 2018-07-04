using System;

#region Notes
// When do Exceptions occur :
// - Falling short of memory.
// - Dividing a value by zero.
// - Inability to open a file.
// - Exceeding the bounds of an array.
// - Attempting to initialize an object to an impossible value.
#endregion

namespace CSharp_Concepts
{
    class TryCatch
    {
        private int a;
        private int b;
        public TryCatch()
        {
            a = 0;
            b = 0;
        }
        public void DivByZero()
        {
            try
            {
                a = 10 / b;
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("\n " + e);
            }
            Console.WriteLine("\n Remaining program...");
        }
	}
}
