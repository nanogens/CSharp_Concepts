using System;

#region Notes
// Structure Features 
// Object on stack
// Variable directly refers to structure
// Always passed by value
// Cannot be inherited
// Cannot have protected modifier
// Always provide 0-arg constructor
// Cannot provide our own 0-arg constructor
// Can have virtual methods
//
// Also the features of a Structure :
// Fast creation
// Destroyed when control goes out of scope
// Created either using new or without new
#endregion

namespace CSharp_Concepts
{
    class StructClass
    {
        string name;
        int age;
        float sal;
        public StructClass()
        {
			Console.WriteLine("\n STRINGS \n");
        }
        public void emp(string n, int a, float s)
        {
            name = n;
            age = a;
            sal = s;
        }
        public void show()
        {
            Console.Write("\n Name : " + name);
            Console.Write("\n Age : " + age);
            Console.Write("\n Salary : " + sal);
            Console.Write("\n");
        }
    }
}
