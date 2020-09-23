using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    partial class FirstClass
    {
        public void SecondClassFunction() {
            Console.WriteLine("I am from the Second Class File!");
        }

        static void Main(string[] args) {
            FirstClass obj = new FirstClass();
            obj.FirstClassFunction();
            obj.SecondClassFunction();
        }
    }
}
