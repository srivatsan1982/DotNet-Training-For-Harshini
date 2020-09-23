using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
			Namespaces
	1.Namespace is a collection of classes.
	2.Namespace provides re-usability of existing classes.
	3.Predefined namespaces include classes to perform basic i/o operations.
	4.Namespaces are used to create a group of logically related classes.
	5.For Example, Console is a class that belongs to the predefined namespace ,System.
	

	A namespace can be considered as a container for some classes.It can be compared 
	to a folder,which consists of files.Namespaces can be used to group related classes 
	together.It also helps you to avoid the problem of name collisions.A namespace can 
	also contain other namespaces,just as a folder can contain other folders as well as
	files. To access the classes and methods defined with in a class, the (.) operator 
	can be used.
	
	For example in the statement, System.Console.WriteLine(),System is a namespace,
	Console is a class defined with in the namespace and WriteLine()is a method of
	the Console class.Since the Console class has been defined in the System  Namespaces.
	its real name is not Console but System.Console,and any code outside this namespace 
	must refer to it as such. This is also known as Fully_Qualified name.To avoid the 
	Fully_Qualified class names, the Using Keyword is used. the above st can also  be
	written as:
	
		using System;
		Console.WriteLine();
	
	A program can also include multiple using statements.You have to use fully qualified 
	names to access a class if there is more than one class with the same name with in the
	namespace spacified by using statement at the beginning of the program.
	
	For example 
		using System;
		using Mynamespace;
	
	Let as assume that a class called Console is defined in the namespace,mynamespace 
	also.In that case the use of the Console class will be ambiguous.So to refer you 
	use fully_qualified name,System.Console and use Mynammespace.Console.
	The Only purpose  of the using command is to save typing the long fully-qualified 
	name repetedly and simplify the code.
	
	
	*/

namespace Mynamespace
{
    public class HelloWorld
    {
        public static int SayHi()
        {
            Console.WriteLine("Hellow World !");
            return 0;
        }

    }
    //}
    //class Test
    //{
    //    public static void Main()
    //    {
    //        Mynamespace.HelloWorld.SayHi();
    //    }
    //}

    namespace Consts
    {
        public class PI
        {
            public static double value = 3.14159;
            //		private PI(){}	//Private Constructor
            PI() { }
        }
        public class three
        {
            public static int value = 3;
            //		private three(){}	//Private Constructor
            three() { }
        }
    }
    namespace MyMath
    {
        public class Routine
        {
            public static long Add(params int[] args)
            {
                int ctr = 0;
                long Answer = 0;
                for (ctr = 0; ctr < args.Length; ctr++)
                {
                    Answer += args[ctr];
                }
                return Answer;
            }
            public static long Subtract(int arg1, int arg2)
            {
                long Answer = 0;
                Answer = arg1 - arg2;
                return Answer;
            }
        }


    }

    class MyMathApp
    {
        public static void Main()
        {
            long Result = 0;
            Result = MyMath.Routine.Add(1, 2, 3);
            Console.WriteLine("Add Result is {0}", Result);

            Result = MyMath.Routine.Subtract(5, 2);
            Console.WriteLine("Subtract Result is {0}", Result);

            Console.WriteLine("\n The Value of PI is {0}", Consts.PI.value);
            Console.WriteLine("\n The Value of three is {0}", Consts.three.value);
        }
    }
}

namespace Testing {
    public class HelloWorld {
        public static void TestMessage() {
            Console.WriteLine("I am from Testing.HelloWorld!");
        }
    }
}