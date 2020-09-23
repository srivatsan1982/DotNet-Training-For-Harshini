using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mynamespace.MyMath;

namespace CSharp
{
    partial class FirstClass
    {
        public void FirstClassFunction()
        {
            Console.WriteLine("I am from the First Class File!");
            Routine.Add(1, 2);
        }
    }
}
