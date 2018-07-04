using System;

#region Notes
// The example shown in the slide shows how we can make an object behave like an array.  In this program
// arr is a float array and it belongs to the same class in which we have declared the indexer.  When we write
// the statement a[3]= 43.2f the set accessor gets called.  The index 3 would get called in the variable value.
// When we write the statement :
// Console.WriteLine(a[3]);
// the get accessor gets called.  The index 3 would get collected in the variable index and the element at fourth
// place would be returned.
#endregion

namespace CSharp_Concepts
{
    class OneDIndexer
	{
        private float[] arr;

        public OneDIndexer()
        {
            arr = new float[] { 12.5f, 34.3f, 5.2f, 6.1f, 7.5f, 88.8f, 22.9f };
            Console.WriteLine("\n 1-D INDEXERS \n");
        }

        public float this [int index]
        {
            get
            {
                return arr[index];
            }
            set
            {
                arr[index] = value;
            }
        }
	}
}
