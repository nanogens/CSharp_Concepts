using System;

namespace CSharp_Concepts
{
    // - 3 ways of declaring an AbstractClass -
	abstract class shapes0
	{
        abstract public void draw();
	}
    abstract class shapes1
    {
        public void draw()
        {
        }
    }
    abstract class shapes2
    {
        abstract public void draw();
        public void erase()
        {
        }
    }

    // - 2 ways of Implementating  -
    class ImplementAbsClass0 : shapes0
    {
        override public void draw()
        {
            Console.Write("\n In ImplementAbsClass1 - draw() \n");
        }
    }
    class ImplementAbsClass2 : shapes2
    {
        override public void draw()
        {
            Console.Write("\n In ImplementAbsClass2 - draw() \n");
        }
    }
}


