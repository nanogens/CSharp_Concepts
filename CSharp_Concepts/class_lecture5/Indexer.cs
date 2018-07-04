using System;

#region Notes
// An Indexer is a special type of property.  If a class contains an array as a data member, an indexer lets us access
// the array within the class using an object as though the object itself were an array.  This is done using the []
// operator.  
// Like properties, we use the get and set accessors in Indexers.  The difference between a property an an Indexer 
// is that an Indexer is nameless.  It uses the keyword 'this'.  'this' reference refers to the object we are 
// indexing.
// Not for use with jagged arrays.
// Can have string as subscript.
#endregion

namespace CSharp_Concepts
{
    class Indexer
    {
        private int height;
        public Indexer()
        {
            height = 0;
            Console.WriteLine("\n INDEXERS \n");
        }
        public int this[int index]
        {
            get
            {
                // code
                return height;
            }
            set
            {
                // code
                height = value;
            }
        }
    }
    
}
