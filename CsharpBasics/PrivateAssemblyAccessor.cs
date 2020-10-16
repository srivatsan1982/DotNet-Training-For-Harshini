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

            var objMath = new Mathematics();
            Console.WriteLine(objMath.Add(10,20));
            Console.WriteLine(objMath.Subract(10, 20));
            Console.WriteLine(objMath.Multiply(10, 20));
            Console.WriteLine(objMath.Divide(10, 5));
        }
    }
}
