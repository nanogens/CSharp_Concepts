using System;
using System.Collections;

namespace CSharp_Concepts
{
    class BitArrayClass
    {
        private int[] a1;
        private int[] a2;
        private BitArray b1;
        private BitArray b2;
        private BitArray b3;

        public BitArrayClass()
        {
            int[] a1 = { -10, -10 };
            int[] a2 = { -10, -10 };

            b1 = new BitArray(a1);
            b2 = new BitArray(a2);
            b3 = new BitArray(5, true);
        }
        ~BitArrayClass()
        {

        }

        private void BitArrPrint(string r, BitArray arr)
        {
            Console.WriteLine("\n " + r + " : ");
            for (int i = 0; i < arr.Count; i++)
            {
                Console.WriteLine("{0},", arr[i]);
            }
        }

        public void BitOperations()
        {
            BitArrPrint("BitArray(b1)", b1);
            BitArrPrint("BitArray(b2)", b2);
            BitArrPrint("BitArray(b3)", b3);

            b1.And(b2);
            BitArrPrint("BitArray(b1) after b1 AND b2", b1);

            b1.Or(b2);
            BitArrPrint("BitArray(b1) after b1 OR b2", b1);

            b1.Xor(b2);
            BitArrPrint("BitArray(b1) after b1 XOR b2", b1);

            b1.Set(1, true);
            BitArrPrint("BitArray(b1) after b1 SET(1,true)", b1);

            b1.SetAll(true);
            BitArrPrint("BitArray(b1) after b1 SetAll(true)", b1);
        }
	}
}
