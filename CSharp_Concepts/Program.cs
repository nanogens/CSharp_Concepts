// This decides which of the program/s will run.
// You have to uncomment it accordingly.
#region ifdef
//#define _CALLBY
//#define _OUTPUT
//#define _PARAMETER
//#define _THISPTR
//#define _READONLY
//#define _INHERITANCE
//#define _BASEKEYWORD
//#define _BASETODERIVED
//#define _VIRTUALSHAPES 
//#define _NEWMODIFIER
//#define _NAMESPACETEST
//#define _NESTEDNAMESPACETEST
//#define _ARRAY
//#define _ARRAYOFOBJECTS
//#define _RECTANGULARARRAY
//#define _JAGGEDARRAY
//#define _SYSTEMARRAY
//#define _STR
//#define _INPUT
//#define _ABSTRACTCLASS
//#define _INTERFACECLASS
//#define _STRUCTCLASS
//#define _BOXINGUNBOXING
//#define _ENUMUSAGE
//#define _PROPERTIESACCESSORS
//#define _ABSTRACTPROPERTIES
//#define _INDEXER
//#define _ONEDINDEXER
//#define _TWODINDEXER
//#define _TRYCATCH
//#define _MULTIPLECATCH
//#define _SINGLECATCH
//#define _TRYCATCHFINALLY
//#define _THROW
//#define _USERDEFINEDEXCEPTIONS
//#define _ARRAYLISTCLASS
//#define _BITARRAYCLASS
//#define _QUEUECLASS
//#define _STACKCLASS
//#define _HASHTABLECLASS
//#define _SORTEDLISTCLASS
//#define _ICOMPARECLASS
#define _SIMPLEFORM
#endregion

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#if _NAMESPACE
using NamespaceTest;
#endif

#if _NESTEDNAMESPACETEST
using College.Library;
#endif

namespace CSharp_Concepts
{
	class Program
	{
		static void Main(string[] args)
		{
			General g = new General();

            #region LECTURE 3 (may include Lecture 2 and 1 as well)
            // ********************** CALL BY VALUE VS CALL BY REFERENCE **********************
            #if _CALLBY
            Call_By_XXX a = new Call_By_XXX();
            a.printout();
            g.ClearScreen();
            #endif

            // ********************** OUTPUT **********************
            #if _OUTPUT
            Output ok = new Output();
            ok.printout();
            g.ClearScreen();
            #endif

            // ********************** PARAMETER **********************
            #if _PARAMETER
            Parameter p = new Parameter();
            p.printout();
            g.ClearScreen();
            #endif

            // ********************** THISPTR **********************
            #if _THISPTR
            ThisPtr pt = new ThisPtr();
            pt.printout();
            g.ClearScreen();
            #endif

            // ********************** READONLY **********************
            #if _READONLY
            Readonly r = new Readonly("Manish");
            r.printout();
            g.ClearScreen();
            #endif

            // ********************** INHERITANCE **********************
            #if _INHERITANCE
            Inheritance1 inh1 = new Inheritance1();
            inh1.printout();
            inh1.increment();
            inh1.printout();
            inh1.decrement();
            inh1.printout();
            g.ClearScreen();
            #endif

            // ********************* BASE KEYWORD *********************
            #if _BASEKEYWORD
            BaseDerv b2 = new BaseDerv();
            BaseDerv b1 = new BaseDerv(10);
            g.ClearScreen();
            #endif

            // ********************* BASETODERIVED *********************
            #if _BASETODERIVED
            BaseToDerv be = new BaseToDerv();
            g.ClearScreen();
            #endif

            // ******************** VIRTUALSHAPES ********************
            #if _VIRTUALSHAPES
            VirtualShapes vs = new VirtualShapes();
            vs.printheader();
            vs.draw();
            Rectangle rc = new Rectangle();
            rc.draw();
            Circle cl = new Circle();
            cl.draw();

			g.LeaveLine();
			// Pointer for multiple objects of class VirtualShapes
			VirtualShapes[] p = {
				                  new Circle(),
			                      new Rectangle(),
			                      new Circle(),
								  new Rectangle(),
								  new Circle(),
			                    };
			for(int i = 0; i < p.Length; i++)
			{
			   p[i].draw();
			}
            g.ClearScreen();
            #endif

            // ******************** NEW MODIFIER ********************
            #if _NEWMODIFIER
            NewModifierBase nm = new NewModifierBase();
            nm.printheader();
            nm.fun();
            NewModifierDerv nmderv = new NewModifierDerv();
            nmderv.fun();
            g.ClearScreen();
            #endif

            // ******************** NAMESPACETEST ********************
            #if _NAMESPACETEST
			Mathematics matt = new Mathematics();
			matt.printout();
			g.LeaveLine();
			g.ClearScreen();
            #endif

            // ******************** NESTEDNAMESPACETEST ********************
            #if _NESTEDNAMESPACETEST
			Book b1 = new Book();
			b1.printout();
			LeaveLine();
			g.ClearScreen();
            #endif
            #endregion

            #region LECTURE 4

            // ********************** ????? **********************

            #if _NESTEDNAMESPACETEST
			Book b1 = new Book();
			b1.printout();
			g.LeaveLine();
			g.ClearScreen();
            #endif

            // ********************** ARRAYS **********************

            #if _ARRAY
			Arr arr = new Arr();
			arr.printout();
			g.LeaveLine();
			g.ClearScreen();
            #endif

            // ********************** ARRAYOFOBJECTS **********************

            #if _ARRAYOFOBJECTS
			ArrofObjects arrofobj = new ArrofObjects();
			arrofobj.printout();
			g.LeaveLine();
			g.ClearScreen();
            #endif

            // ********************** RECTANGULARARRAY **********************

            #if _RECTANGULARARRAY
			RectangularArray rectarr0 = new RectangularArray(0);
			rectarr0.Printout();
			g.LeaveLine();
			RectangularArray rectarr1 = new RectangularArray(1);
			rectarr1.Printout();
			g.LeaveLine();
			g.ClearScreen();
            #endif

            // ********************** JAGGEDARRAY **********************

            #if _JAGGEDARRAY
			JaggedArray jagg = new JaggedArray(1);
			jagg.Printout();
			g.LeaveLine();
			g.ClearScreen();
            #endif

            // ********************** SYSTEMARRAY **********************

            #if _SYSTEMARRAY
			SystemArray sysarr = new SystemArray();
			sysarr.Array_CopyTo_SetValue();
			g.Dashline();
			sysarr.Array_NumElements();
			g.Dashline();
			sysarr.Array_Copy();
			g.Dashline();
			sysarr.Array_Reverse();
			g.Dashline();
			sysarr.Array_Sort(); // If you want it sorted in decending order, you have to sort it and then reverse it.
			g.Dashline();
			sysarr.Array_IndexOf();
			g.Dashline();
			sysarr.Array_Clear();
			g.ClearScreen();
            #endif

            // ********************** STR **********************

            #if _STR
			Str st = new Str();
            g.Dashline();
            st.Str_At();
            g.Dashline();
            st.Str_Concat();
            g.Dashline();
            st.Str_Replace();
            g.Dashline();
            st.Str_Copy();
            g.Dashline();
            st.Str_CompareTo();
            g.Dashline();
            st.Str_ToUpper();
            g.ClearScreen();
            #endif

            // ********************** INPUT **********************

            #if _INPUT
            Input inp = new Input();
            inp.In();
            g.ClearScreen();
            #endif

            // ********************** ABSTRACTCLASS **********************

            #if _ABSTRACTCLASS
            ImplementAbsClass0 ac0 = new ImplementAbsClass0();
            ac0.draw();
            ImplementAbsClass2 ac1 = new ImplementAbsClass2();
            ac1.draw();
            g.ClearScreen();
            #endif

            // ********************** INTERFACECLASS **********************

            #if _INTERFACECLASS
            InterfaceClass ifc = new InterfaceClass();
            ifc.draw();
            g.ClearScreen();
            #endif

            // ********************** STRUCTURECLASS **********************

            #if _STRUCTCLASS
            StructClass sc = new StructClass();
            sc.emp("Manish", 5, 1.2f);
            sc.show();
            g.ClearScreen();
            #endif

            // ********************** BOXINGUNBOXING **********************

            #if _BOXINGUNBOXING
            BoxingUnboxing bu = new BoxingUnboxing();
            bu.Printout();
            g.Dashline();
            int i = 12;
            Console.WriteLine("\n The value is {0},{1}", i, bu);
            g.ClearScreen();
            #endif
            #endregion

            #region LECTURE 5

            // ********************** ENUMERATION **********************
 
            #if _ENUMUSAGE
            Enumeration eu = new Enumeration();
            eu.EnumUsage1();
            g.Dashline();
            eu.EnumUsage2();
            g.ClearScreen();
            #endif

            // ********************** PROPERTIESACCESSORS **********************

            #if _PROPERTIESACCESSORS
            PropertiesAccessors pa = new PropertiesAccessors();
            pa.Length = 10; // uses the set accessor for length
            int len = pa.Length; // uses the get accessor for length
            Console.Write("\n Length : " + len);
            pa.Length = pa.Length + 20;
            len = pa.Length;
            Console.Write("\n Length : " + len);
            g.ClearScreen();
            #endif

            // ********************** ABSTRACTPROPERTIES **********************

            #if _ABSTRACTPROPERTIES
            Window wd = new Window();
            wd.Height = 10;
            int h = wd.Height;
            Console.Write("\n Height : " + h + "\n");
            g.ClearScreen();
            #endif

            // ********************** INDEXERS **********************

            #if _INDEXER
            Indexer idx = new Indexer();
            idx[0] = 10;
            int getit0 = idx[0];
            idx[1] = 11;
            int getit1 = idx[1];
            Console.Write("\n Height 0 : " + getit0 + "\n");
            Console.Write("\n Height 1 : " + getit1 + "\n");
            g.ClearScreen();
            #endif

            // ********************** 1DINDEXER **********************

            #if _ONEDINDEXER
            OneDIndexer a;
            a = new OneDIndexer();
            a[3] = 43.2f;
            Console.Write(" Value of a[3] : " + a[3] + "\n");
            g.ClearScreen();
            #endif

            #if _TWODINDEXER
            TwoDIndexer b;
            b = new TwoDIndexer();
            Console.Write(" Value of b[1, 1] : " + b[1, 1] + "\n");
            Console.Write(" Setting b[1, 1] to value of 22\n");
            b[1, 1] = 22;
            Console.Write(" New Value of b[1, 1] : " + b[1, 1] + "\n");
            g.ClearScreen();
            #endif

            #if _TRYCATCH
            TryCatch tc = new TryCatch();
            tc.DivByZero();
            Console.Write("\n This is a test to see if the program can still continue despite the Exception generated..");
            g.ClearScreen();
            #endif

            #if _MULTIPLECATCH
            MultipleCatch mc = new MultipleCatch();
            mc.ManyCatches();
            g.ClearScreen();
            #endif

            #if _SINGLECATCH
            SingleCatch sc = new SingleCatch();
            sc.NeedOnlyOneCatch();
            g.ClearScreen();
            #endif

            #if _TRYCATCHFINALLY
            TryCatchFinally tcf = new TryCatchFinally();
            tcf.Finally();
            g.ClearScreen();
            #endif

            #if _THROW

            Throw thh = new Throw();
            try
            {
                thh.Fun(11);
            }
            catch(Exception e)
            {
                Console.Write("\n " + e);
            }
            g.ClearScreen();
            #endif

            #if _USERDEFINEDEXCEPTIONS
            Customer cs = new Customer("Vivaan",25,250);
            cs.GetBalance();
            try
            {
                cs.Withdraw(245);
            }
            catch(BankException e)
            {
                Console.Write("\n Transaction Failed");
                e.Inform();
            }
            g.ClearScreen();
            #endif
    
            #endregion

            #region LECTURE 6
            // ********************** ARRAYLIST CLASS **********************

            #if _ARRAYLISTCLASS
            ArrayListClass alc = new ArrayListClass(); // Don't need an instance.
            ArrayListClass.TestArrayList(); // We don't create an instance of ArrayListClass (i.e. alc not needed).  
                                            // This is because TestArrayList() is a STATIC function in the class. 
                                            // Only one copy of it can exist.
            g.ClearScreen();
            #endif

            // ********************** BITARRAY CLASS **********************

            #if _BITARRAYCLASS
            BitArrayClass bac = new BitArrayClass();
            bac.BitOperations();
            g.ClearScreen();
            #endif

            // ********************** QUEUE CLASS **********************

            #if _QUEUECLASS
		    QueueClass qc = new QueueClass();
			qc.SetUpQueue();
			g.ClearScreen();
            #endif

            // ********************** THE STACK CLASS **********************
            #if _STACKCLASS
            StackClass stc = new StackClass();
            stc.Stacker();
            stc.StackerPrint();
            g.ClearScreen();
            #endif

            // ********************** THE HASH TABLE CLASS **********************
            #if _HASHTABLECLASS
            HashTableClass htc = new HashTableClass();
            htc.HashTableAdd();
            g.ClearScreen();
            #endif

            // ********************** THE SORTED LIST CLASS **********************
            #if _SORTEDLISTCLASS
            SortedListClass slc = new SortedListClass();
            slc.SortedListAdd();
            g.ClearScreen();
            #endif

            // ********************** THE SORTED LIST CLASS **********************
            #if _ICOMPARECLASS
            Emp[] e =
            {
                new Emp(2,"Sanjay",3450),
                new Emp(1,"Rahul", 2500),
                new Emp(10,"Kavita",10000),
                new Emp(9,"Mohit",25000),
                new Emp(6,"Sapna",2500),
            };
            MySort s = new MySort();
            Array.Sort(e, s);
            foreach(Emp s1 in e)
            {
                Console.WriteLine(s1.ToString());
            }     
            g.ClearScreen();
            #endif

            #if _SIMPLEFORM
            Simple_Form sf = new Simple_Form();
            sf.Text = "Hello C#.NET";
            sf.ShowDialog();
            #endif

            #endregion
        }
    }
}
