using System;
using System.Collections;

#region Notes
// Since the Collections namespace provides Queue class, it is obvious that it would also provide
// Stack class.  Needless to say that the Stack class provides 'Last In First Out' way to store 
// and retrieve the elements.  The program given in the slide shows how to use this class:
//
// The Stack class provides the Push() and Pop() methods to store and retrieve the stack elements.
//
// The Pop() method returns the element at the top of the stack and then removes it.
// We have displayed the stack elements using IEnumerator interface.  We can use the Peek() method
// to obtain the element at the top without removing it from the stack.
#endregion

namespace CSharp_Concepts
{
    class StackClass
    {
        private Stack st;
        public StackClass()
        {
            st = new Stack();
        }
        ~StackClass()
        { 
        }
        public void Stacker()
        { 
            st.Push(10);
            st.Push(11);
            st.Push(12);
            st.Push(13);
        }
        public void StackerPrint()
        {
            Console.WriteLine("\n Element popped : {0}", st.Pop());
            IEnumerator e = st.GetEnumerator();
            while(e.MoveNext())
            {
                Console.WriteLine("\n " + e.Current);
            }
        }
	}
}
