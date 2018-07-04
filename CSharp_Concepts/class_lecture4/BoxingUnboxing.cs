using System;

namespace CSharp_Concepts
{
	class BoxingUnboxing
	{
        int i;
        object o;
        public BoxingUnboxing()
        {
            i = 0;
            Console.WriteLine("\n BOXING / UNBOXING \n");
        }
        public void Printout()
        {
            Console.Write("\n Details are in the class so look inside...");
            i = 10;    
            o = i;  // boxing into an object
            i = (int)o;    // unboxing (note : we have to specify what data type the object unboxes into... in this case its an int
        }
	}
}
