using System;

namespace CSharp_Concepts
{
	class Str
	{
		private string s1;
		private string s2;
		private string s3;
		private string sub;

		int fin;
		int lin;

		public Str()
		{
			fin = 0;
			lin = 0;
			s1 = "kicit";
			s2 = "Nagpur";
			s3 = "";
			Console.WriteLine("\n STRINGS \n");
            Console.Write("\n Result : s1 : " + s1);
            Console.Write("\n Result : s2 : " + s2);
            Console.Write("\n Result : s3 : " + s3);
        }
		public void Str_At()
		{
            Console.Write("\n Str_At \n");
			Console.Write("\n Result : Char at 3rd position : " + s1[2]);
		}
		public void Str_Concat()
		{
            Console.Write("\n Str_Concat \n");
            s3 = string.Concat(s1, s2);
            Console.Write("\n Result : " + s3);
            Console.WriteLine("\n Length of s3 : " + s3.Length);
		}
		public void Str_Replace()
		{
            Console.Write("\n Str_Replace \n");
            s3 = s3.Replace('p', 'P');
			Console.Write("\n Result : " + s3);
		}
		public void Str_Copy()
		{
            Console.Write("\n Str_Copy \n");
            s3 = string.Copy(s2);  // Copy() - if the destination string is smaller in length, its length is increase automatically
			Console.Write("\n Result : " + s3);
		}
		public void Str_CompareTo()
		{
            Console.Write("\n Str_CompareTo \n");
            int c = s2.CompareTo("\n Result : " + s3);  // CompareTo() - compares two strings alphabetically.
			if(c < 0)
			{
				Console.WriteLine("\n Result : s2 is less that s3.");
			}
			if(c == 0)
			{
				Console.WriteLine("\n Result : s2 is equal to s3.");
			}
			if(c > 0)
			{
				Console.WriteLine("\n Result : s2 is greater than s3.");
			}

			if(s1 == s3)
			{
				Console.WriteLine("\n Result : s1 is equal to s3.");
			}
			else
			{
				Console.WriteLine("\n Result : s1 is not equal to s3.");
			}
		}

		public void Str_ToUpper()
		{
            Console.Write("\n Str_ToUpper \n");
            Console.Write("\n Original : " + s1);
            s3 = s1.ToUpper(); // ToUpper() method creates a new object, stores in it the converted upper case string and returns the address of this object.
                               // The address is collected in s3.
            Console.Write("\n Result : " + s3);
        } 

		public void Str_Insert()
		{
            Console.Write("\n Str_Insert \n");
            s3 = s2.Insert(6, "Mumbai");
			Console.Write("\n Result : " + s3);
		}

		public void Str_Remove()
		{
            Console.Write("\n Str_Remove \n");
            Console.Write("\n Original : " + s2);
            s3 = s2.Remove(0, 1);
			Console.WriteLine("\n Result : " + s3);
		}

		public void Str_IndexOf()
		{
            Console.Write("\n Str_IndexOf \n");
            Console.Write("\n Original : " + s1);
            fin = s1.IndexOf('i');
			Console.WriteLine("Result : First index of i in s1 : " + fin);
		}

		public void Str_LastIndexOf()
		{
            Console.Write("\n Str_LastIndexOf \n");
            Console.Write("\n Original : " + s1);
            lin = s1.LastIndexOf('i');
			Console.WriteLine("Result : Last index of i in s1 : " + lin);
		}

		public void Str_Substring()
		{
            Console.Write("\n Str_Substring \n");
            Console.Write("\n Original (s1) : " + s1);
            Console.Write("\n Original (fin) : " + fin);
            Console.Write("\n Original (lin) : " + lin);
            sub = s1.Substring(fin, lin);
			Console.Write("\n Result : Substring (sub) : " + sub);
		}

		public void Str_Format()
		{
            Console.Write("\n Str_Format \n");
            int i = 10;
			float f = 9.8f;
			s3 = string.Format("\n Result : Value of i : {0} \n Value of f : {1}", i, f);
            Console.Write("\n Original : " + s3);
            Console.Write(s3);
		}
	}
}
