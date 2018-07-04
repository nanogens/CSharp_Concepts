using System;
using System.Collections;

#region Notes
// In a hashtable, we can store pairs of values and associated keys.  
// The values are organized on the basis of the keys.  These keys can be used to get the respective
// values from the hash table.  .NET has encapsulated the functionality of hashtable in a class
// called Hashtable.
//
// The Hashtable class provides the Add() function to store the key and its value. 
// Note that the key value pairs may not get stored in the hashtable in the same sequence in which
// they are added.  In which order they would get stored depends upon the hashing function used
// by the Hashtable class.
// 
// The GetEnumerator() method of the Hashtable class returns the reference of the IDictionaryEnumerator
// interface.  We have displayed the value and the respective keys using the Value and Key properties
// of the IDictionaryEnumerator interface.
// 
// We can use the ICollection interface to iterate through the keys and values.  The sequence in which 
// the values would get displayed in unspecified.  The Hashtable class contains properties Keys and
// Values that return the reference of the ICollection interface.
//
// To remove an item from the hashtable, we can use the Remove() function.  The Remove() method 
// removes the value from the hashtable using the specified keys.
#endregion

namespace CSharp_Concepts
{
    class HashTableClass
    {
        private Hashtable h;
        public HashTableClass()
        {
            h = new Hashtable();
        }
        ~HashTableClass()
        {
        }
        public void HashTableAdd()
        { 
            h.Add("mo", "Monday");
            h.Add("tu", "Tuesday");
            h.Add("we", "Wednesday");
            h.Add("th", "Thursday");
            h.Add("fr", "Friday");
            h.Add("sa", "Saturday");
            h.Add("su", "Sunday");

            IDictionaryEnumerator e = h.GetEnumerator();
            while(e.MoveNext())
            {
                Console.WriteLine(e.Key + "\t" + e.Value);
            }

            Console.WriteLine("\n The Keys are : ");
            ICollection k = h.Keys;
            foreach(object i in k)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("\n The values are : ");
            ICollection v = h.Values;
            foreach (object i in v)
            {
                Console.WriteLine(i);
            }
            Console.Write("\n");
            h["su"] = "Sun";
            h["mo"] = "Mon";
            Console.WriteLine(h["fr"]);
            Console.WriteLine(h["su"]);
            Console.WriteLine(h["mo"]);
        }
	}
}
