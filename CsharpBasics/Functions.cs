using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    class Functions
    {

        //<Access Specifier> <Access Modifier> <Return Type> <Function Name>(<comma separated parameters>)
        public void Add(int a, int b)
        {
            Console.WriteLine("The addition of {0} and {1} is {2}", a, b, a + b);
        }

        public void Add(string a, string b)
        {
            Console.WriteLine("The concatenation of {0} and {1} is {2}", a, b, a + b);
        }
        public void Add(decimal a, decimal b)
        {
            Console.WriteLine("The concatenation of {0} and {1} is {2}", a, b, a + b);
        }

        public void Message()
        {
            Console.WriteLine("I am from Message function!");
        }

        public int Sum(int a, int b)
        {
            return a + b;
        }
        //		//		Value parameter
        public static void Increment(int var2)
        {
            var2++;
        }
        //		Reference parameter
        public static void Increment(ref int var3)
        {
            var3++;
        }

        //	OUT Parameter(if u want to return more than one value use out parameter)
        public static int add(int var1, int var2, out int result, out string stringResult)
        {
            stringResult = "Harshni";
            result = var1 - var2;
            return var1 + var2;

        }

        static void Main(string[] args)
        {

            Functions objFunctions;
            objFunctions = new Functions();

            objFunctions.Message();
            objFunctions.Add(10, 20);
            objFunctions.Add("Srivatsan", "Seshadri");
            objFunctions.Add(10.00M, 11.00M);
            int y = objFunctions.Sum(10, 20);

            Console.WriteLine("The sum of {0} and {1} is {2}", 10, 20, objFunctions.Sum(10, 20));

            int var2 = 10;
            Console.WriteLine("Before fn call the value of var2 is {0}  ", var2);
            //			// Function call by value
            Increment(var2);
            Console.WriteLine("After fn call the value of var2 is {0}  ", var2);
            //			//						// Function call by Reference
            int var1 = 10;
            Increment(ref var1);
            Console.WriteLine("After fn call the value of var3 is {0}  ", var1);
            int a;
            string x;
            int b = add(10, 20, out a,out x);

            Console.WriteLine("The Value of result is {0}", b);
            Console.WriteLine("The Value of out parameter is {0}", a);
            Console.WriteLine("The Value of out string parameter is {0}", x);
            func(new int[] { 1,2,3,4 });
            func(1, 2);
            func(1, 2, 3, 4, 5, 6, 7, 8);
        }

        public static void func(params int[] arr)
        {
            Console.WriteLine("No of elements in the array is {0}", arr.Length);
        }
    }
}
