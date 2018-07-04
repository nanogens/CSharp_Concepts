using System;

namespace CSharp_Concepts
{
    class Enumeration
    {
        // -- EnumUsage1
        enum person
        {
            married,
            unmarried,
            divorced,
            spinster
        }
        enum emp
        {
            skilled,
            semiskilled,
            highlyskilled,
            unskilled
        }

        public void EnumUsage1()
        {
            //person p;
            emp e;

            //p = person.married;
            e = emp.skilled;

            if (e == emp.skilled)
            {
                Console.Write("\n Qualified for promotion!\n");
            }
            Console.Write("\n Position of 'skilled' keyword in enum strcture : " + (int)emp.skilled);
            string[] str = Enum.GetNames(e.GetType());
            int i = 0;
            Console.Write("\n");
            foreach (string s in str)
            {
                Console.Write("\n " + i + "th keyword in enum structure : " + s);
                i++;
            }
        }

        // -- EnumUsage2
        enum color_null
        {
            red,
            green,
            blue
        }
        enum color_i : int
        {
            red,
            green = 500,
            blue
        }
        enum color_b : byte
        {
            red,
            green = 5,
            blue
        }

        public void EnumUsage2()
        {
            color_null cn;
            color_b by;
            color_i it;

            cn = color_null.red;
            by = color_b.red;
            it = color_i.red;

            Console.Write("\n");
            int i = 0;
            string[] str = Enum.GetNames(cn.GetType());
            foreach (string s in str)
            {
                Console.Write("\n " + i + "th keyword in enum structure : " + s);
                i++;
            }
            i = 0;

            Console.Write("\n");
            str = Enum.GetNames(by.GetType());
            foreach (string s in str)
            {
                Console.Write("\n " + i + "th keyword in enum structure : " + s);
                i++;
            }
            i = 0;

            Console.Write("\n");
            str = Enum.GetNames(it.GetType());
            foreach (string s in str)
            {
                Console.Write("\n " + i + "th keyword in enum structure : " + s);
                i++;
            }

            int itemvalue = (int)color_b.green;
            Console.Write("\n\n Integer value of green item in Enum color_b : " + itemvalue);
        }
    }
}