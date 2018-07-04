using System;

#region Notes
// Lastly, Indexer cannot be declared as static.  Indexers work in the same way as properties when declared as virtual.
#endregion

namespace CSharp_Concepts
{
    class TwoDIndexer
    {
        private int[,] arr2;

        public TwoDIndexer()
        {
            arr2 = new int[,] { { 12, 34, 5, 6 },{ 7, 88, 22, 2 } };
            Console.WriteLine("\n 2-D INDEXERS \n");
        }

        public int this[int index1, int index2]
        {
            get
            {
                return arr2[index1, index2];
            }
            set
            {
                arr2[index1, index2] = value;
            }
        }
    }
}
