using System;
using System.Collections;

#region Notes
// The IComparer interface provides methods to compare two objects.
// Most of the classes implement this interface so that the user can easily compare two objects of the class.
//
// Let us create a program that shows how to implement the IComparer interface.  In this program we would
// write a class emp maintaining the information of employees.
// Another class mysort would implement the IComparer interface.
//
// Here we have firstly instantiated an array e of type emp.
//
// We have then instantiated an object of type MySort.  In the MySort class we have defined the Compare() method
// of the IComparer interface and written our own sorting logic in it.  Next, to sort the array e, we have called 
// the Sort() method of the Array class.  To the Sort() method, we have to pass the array to be sorted and 
// referece to the IComparer interface.  The Sort() method calls the Compare() method.
//
// The Compare() method returns 0, 1 or -1 indicating wheather the objects being compared are equal or one is smaller or
// larger than the other.  In our case, since the MySort class is derived from IComparer we have passed reference to the 
// MySort's object.  Hence, the Compare() method of mysort class gets called.
//
// Once the array is sorted, we have displayed the array elements.  We have overridden the ToString() method in the 
// Emp class.  This is because we wanted to display the sorted elements using the statement s1.ToString.  Had we not
// overridden this method in Empclass, ToString() of the base class would have got called, which we do not want.  
// In the ToString() of Emp class we have concatenated the values of the data members in a string and returned it.
#endregion

namespace CSharp_Concepts
{
    class MySort : IComparer
    {
        public int Compare(object a, object b)
        {
            int i1 = ((Emp)a).id;
            int i2 = ((Emp)b).id;
            string n1 = ((Emp)a).name;
            string n2 = ((Emp)b).name;
            if(i1 == i2)
            {
                return n1.CompareTo(n2);
            }
            if(i1 < i2)
            {
                return -1;
            }
            return 1;
        }
    }
    class Emp
    {
        public string name;
        public int id;
        public float balance;

        public Emp(int i,string n, float b)
        {
            id = i;
            name = n;
            balance = b;
        }
        public new string ToString()
        {
            return id + " " + name + " " + balance;
        }
    }
}
