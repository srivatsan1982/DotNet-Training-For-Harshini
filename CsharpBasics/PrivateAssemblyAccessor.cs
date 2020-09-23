using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PrivateAssembly;

namespace CSharp
{
    public class PrivateAssemblyAccessor
    {
        public static void Main(string[] args) {

            var objMath = new PrivateAssembly.Math();
            Console.WriteLine(objMath.Add(1, 2, 3, 4, 5));
            Console.WriteLine(objMath.Subraction(10, 20));
            Console.WriteLine(objMath.Multiplication(10, 20, 30, 40, 50));
            Console.WriteLine(objMath.Division(10, 5));
        }
    }
}
