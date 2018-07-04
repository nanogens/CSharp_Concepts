using System;

#region Notes
// If we declare the property as abstract, it is necessary to declare the class containing the property as 
// abstract.  Since we cannot create the objects of the abstract class, it becomes necessary to derive a 
// class from it and implement the property.
// To declare the property abstract, we have to write the get and set keywords without any accessor body.
// The derived class must implement the property as shown below.
#endregion

namespace CSharp_Concepts
{
	abstract class Dimensions
	{
        protected int height;
        public abstract int Height
        {
            get;
            set;
        }
	}
    class Window : Dimensions
    {
        public Window()
        {
            height = 0;
            Console.WriteLine("\n ABSTRACT PROPERTIES \n");
        }
        public override int Height
        {
            get
            {
                return height;
            }
            set
            {
                height = value;
            }
        }
    }
}
