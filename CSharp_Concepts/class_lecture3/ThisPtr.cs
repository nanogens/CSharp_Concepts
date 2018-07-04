using System;

namespace CSharp_Concepts
{
    class ThisPtr
    {
        private int i; // the object's i and j should be referred to with this.i or this.j in the methods of the class
        private float j;

        public void setdata(int i, float j)
        {
            this.i = i; // the this. refers to the object's i and j (above), not the locally created i and j 
            this.j = j;
        }
        public void printvars()
        {
            Console.WriteLine("\n Value of i : " + this.i);
            Console.WriteLine("\n Value of j : " + this.j);
        }
        public void printout()
        {
            Console.WriteLine("\n THIS POINTER ");
            this.setdata(10, 20.5f);
            this.printvars();
        }
    }
}
