using System;
using System.Collections;

#region Notes
// Like HashTable, the SortedList class maintains pairs of keys and values.  
// The difference between the two is that in the SortedList class, the values are sorted by keys and are accessible
// by key as well as by index.
// We have added the key-value pairs in the list by using the Add() method.
// Like HashTable, the SortedList class also uses IDictionaryEnumerator interface to iterate through the list 
// elements.  The Remove() method deletes the value of the specified key.  To get the list of keys and values
// we have used the Keys and Values properties respectively.
#endregion

namespace CSharp_Concepts
{
	class SortedListClass
    {
        private SortedList s;
        public SortedListClass()
        {
            s = new SortedList();
        }
        ~SortedListClass()
        {
        }
        public void SortedListAdd()
        {
            s.Add("Maharastra", "Mumbai");
            s.Add("Karnataka", "Bangalore");
            s.Add("Andhra Pradesh", "Hyderabad");
            s.Add("TN", "Chennai");
            s.Add("Bihar", "Patna");
            s.Add("Rajasthan", "Jaipur");
            s.Add("Orissa", "Bhubaneshwar");

            Console.WriteLine("\n Elements in the SortedList : ");
            IDictionaryEnumerator e = s.GetEnumerator();
            while(e.MoveNext())
            {
                Console.WriteLine(e.Key + "\t" + e.Value);
            }
            s.Remove("TN");
            Console.WriteLine("\n ------------------------------ ");

            Console.WriteLine("\n The Keys are : ");
            ICollection k = s.Keys;
            foreach(object i in k)
            {
                Console.WriteLine(i + " ");
            }
            Console.WriteLine("\n ------------------------------ ");

            Console.WriteLine("The Values are :");
            ICollection v = s.Values;
            foreach(object i in v)
            {
                Console.WriteLine(i + " ");
            }
            Console.WriteLine("\n ------------------------------ ");

            Console.WriteLine("\n Value at 3rd Index 3 : " + s.GetByIndex(3));
            Console.WriteLine("\n Key at 3rd Index : " + s.GetKey(3));
            Console.WriteLine("\n The index of key Bihar : " + s.IndexOfKey("Bihar"));
            Console.WriteLine("\n The index of value Jaipur : " + s.IndexOfValue("Jaipur"));
        }
	}
}
