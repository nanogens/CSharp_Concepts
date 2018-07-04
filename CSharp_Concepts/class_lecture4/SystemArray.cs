using System;

namespace CSharp_Concepts
{
	class SystemArray
	{

		private int[] arr1;
		private int[] arr2;

		public SystemArray()
		{
			arr1 = new int[5] { 1, 4, 7, 8, 9 };
			arr2 = new int[10];
		}

		public void Array_CopyTo_SetValue()
		{
			Console.Write("\n - Array_CopyTo & SetValue -\n");
			arr1.CopyTo(arr2, 0);
			Printelements();

			arr2.SetValue(5, 0);
			Printelements();
		}

		private void Printelements()
		{
			Console.WriteLine("\n Elements of arr2 : \n");
			foreach (int i in arr2)
			{
				Console.Write(i + " , ");
			}
			Console.Write("\n");
		}

		public void Array_NumElements()
		{
			Console.Write("\n - Array_NumElements -\n");
			Console.WriteLine("\n Number of elements in arr1 : " + arr1.Length);
			Console.WriteLine("\n Number of elements in arr2 : " + arr2.Length);
		}

		public void Array_Reverse()
		{
			Console.Write("\n - Array_Reverse -\n");
			Array.Reverse(arr2);
			Printelements();
		}

		public void Array_Copy()
		{
			Console.Write("\n - Array_Copy - \n");
			Array.Copy(arr1, 2, arr2, 6, 2); // copy from arr1 the 2nd position onwards to arr2 6th position onwards TWO elements.
			Printelements();
		}

		public void Array_Sort()
		{
			Console.Write("\n - Array_Sort - \n");
			Array.Sort(arr2);
			Printelements();
		}

		public void Array_IndexOf()
		{
			Console.Write("\n - Array_IndexOf - \n");
			Console.WriteLine("\n Index position of the (first occurance of the) number 8 in the array is " + Array.IndexOf(arr2, 8));
		}

		public void Array_Clear()
		{
			Console.Write("\n - Array_Clear - \n");
			Array.Clear(arr2, 3, 3);
			Printelements();
		}
	}
}