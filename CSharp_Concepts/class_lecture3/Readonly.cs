using System;

namespace CSharp_Concepts
{
    class Readonly
    {
        #region Fields
        public const int rate = 4000;
        public readonly string name;
        #endregion

        #region Methods
        public Readonly()
        {

        }
        public Readonly(string n)
        {
            name = n;  // readonly variables can only be assigned in the constructor of the class and nowhere else
        }
        public void printout()
        {
            Console.WriteLine("\n READONLY");
            Console.WriteLine("\n Value of rate : " + rate);
            Console.WriteLine("\n Value of name : " + name);
        }
        #endregion
    }
}
