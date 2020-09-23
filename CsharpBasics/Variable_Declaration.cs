using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    class Variable_Declaration
    {
        //Variable Declaration
        //    * <access specifier> <data type> <variable name>


        const string x = "a";
        static int a;
        static long b;
        static float c;
        static double d;
        static decimal Dec;

        static void Main(string[] args) {
           
       
            string sample;
            /*Assignment Operator
             * variable = value
             */
            sample = args[0];
            
            //Implicit Converter
            b = 10;
            c = 10.15f;
            d = 25.24868763847658437564385d;
            Dec = 25.24868763847658437564385M;

            //Explicit Type Converter
            a =(int)b;
            c = (float)Dec;
            Dec = (decimal)d;
            a = (int)Dec;

            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
            Console.WriteLine(d);
            Console.WriteLine(Dec);
            Console.WriteLine(sample);
            Console.ReadLine();
        }
    }
}
