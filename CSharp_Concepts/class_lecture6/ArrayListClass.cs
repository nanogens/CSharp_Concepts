using System;
using System.Collections;

#region Notes
// 
#endregion

namespace CSharp_Concepts
{
    class ArrayListClass
    {
        public ArrayListClass()
        {
            Console.WriteLine("\n ARRAYLISTCLASS \n");
        }
        ~ArrayListClass()
        { 
        }
        public static void TestArrayList()
        {
            ArrayList arr = new ArrayList();
            arr.Add('a');
            arr.Add(43);
            arr.Add(6.7);
            arr.Add("Rahul");
            arr.Insert(1, "Deepti");
            for(int i = 0;i< arr.Count; i++) // number of elements in the array is give by Count
            {
                Console.Write("\n arr[" + i + "]" + arr[i]);
            }
        }
	}
}
