using System;
using System.Collections;

#region Notes
// The Queue class is a collection of objects, which are stored and retrieved in "First In First Out" manner.
// We can use the Queue class to develop an application that can receive the messages on the basis of the date of receipt.
// We have used the Enqueue() method of the Queue class to add elements at the end of the queue.  
//
// Peek() - If we want to get the element at the head but do not want to remove it from the queue, we can use the Peek() method.
// Unlike the classes ArrayList and BitArray, the Queue class does not provie an indexer.  Hence we cannot use [] operator to access
// the queue elements.  So to access the queue elements, we have to use an interface called IEnumerator provided by the Collections 
// namespace.  The Queue class implements this interface.  We have used the GetEnumerator() method of Queue class to obtain an 
// IEnumerator reference e.  Using this reference we have iterated through the queue.  The Current property of the IEnumerator
// interface returns the element at the current position.  The reference e can be used only to iterate through the collection, not
// to modify it.  Other classes of the Collections namespace liek ArrayList and BitArray also implement the IEnumerator interface.
// So we can use it to enumerate these arrays also.
// 
// To check whether a particular element exists in the queue or not, we can use the Contains() method.  
//
// The Queue object is NOT thread safe.  It means that two different threads can access one Queue object at the same time, which 
// can prove dangerous.  To avoid such a situation the Queue class provides a static method Synchronized() that returns a synchronized
// wrapper around the specified object.  Following statements show how to use the Synchronized() method.
//
// Queue q = new Queue();
// Queue sq = Queue.Synchronized(q);
//
// We can now safely use sq to perform various operations on the queue.
#endregion

namespace CSharp_Concepts
{
    class QueueClass
    {
        private Queue q;
        private Queue sq;
        public QueueClass()
        {
            Console.WriteLine("\n QUEUE CLASS \n");
            q = new Queue();
            sq = Queue.Synchronized(q); // This is to ensure that the queue is created as a static so only one thread can access it at a time.  Without this, the queue is not thread safe.
        }
        ~QueueClass()
        {
        }
        public void SetUpQueue()
        {
            q.Enqueue("Message1");
            q.Enqueue("Message2");
            q.Enqueue("Message3");
            q.Enqueue("Message4");
            Console.WriteLine("\n First Message : {0}", sq.Dequeue());

            Console.WriteLine("\n The element at the head is {0}", sq.Peek());

            IEnumerator e = sq.GetEnumerator();
            while (e.MoveNext())
            {
                Console.WriteLine("\n " + e.Current);
            }

            bool b = sq.Contains("Message3");
            Console.WriteLine("\n Does the Queue q contain the word 'Message3' : {0}", b);
        }
    }
}
