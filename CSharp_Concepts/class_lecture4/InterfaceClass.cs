using System;

#region Notes
// Unlike an AbstractClass, we can only declare but not implement functions in an Interface class.
// Objects of an interface cannot be created.  An interface is created with the intention that it 
// would be used only as the base interface (or class) of other classes.  A class that derives 
// itself from an interface is said to be implementing the interface.  An interface FORCES the 
// classes that derive from it to implement the methods declared in the interface.
// Interface class sounds like some kind of base class template (MT)
// If you want to implement some methods within the base class and have derived classes implement
// some of the methods, use an abstract class. (MT)
// The difference between an Interface and an Abstract class is that we cannot derive a class from
// multiple abstract classes.  However we can implement multiple interfaces in a class.  Neither
// an abstract class nor an interface can be marked as sealed because sealed modifier prevents 
// inheritance.
#endregion

namespace CSharp_Concepts
{
    interface shapes
    {
        void draw();
    }

    class InterfaceClass : shapes
    {
       public void draw()
       {
           Console.Write("\n Interface Class (from shapes) - draw() \n");
       }
    }
    // We cannot do what's below because an interface CANNOT implement a function, only declare it
    // for later usage by a derived function.
    /*
    interface class shapes
    {
        public void draw()
        {
        }
    }
    interface class shapes2
    {
        interface public void draw();
        public void erase()
        {
        }
    }
    */
}
