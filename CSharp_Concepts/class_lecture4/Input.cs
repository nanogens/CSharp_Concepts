using System;

namespace CSharp_Concepts
{
    class Input
    {
        private int i;
        private string s;
        private float f;
        private float t;

        public Input()
        {
            i = 0;
            s = "";
            f = 0;
            t = 0;
        }
        public void In()
        {
            Console.WriteLine("\n INPUT \n");
            Console.Write("\n Enter an integer : ");
            s = Console.ReadLine();
            i = int.Parse(s);

            Console.Write("\n Enter a float : ");
            s = Console.ReadLine();
            f = float.Parse(s);

            t = f + i;
            Console.Write("\n Result : " + t);
        }
    }
}
