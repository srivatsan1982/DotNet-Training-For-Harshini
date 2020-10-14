using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    class TestDispose:IDisposable {
        public TestDispose()
        {
            Console.WriteLine("Constructed!");
        }

        ~TestDispose() {
            Console.WriteLine("Destructed!");
        }

        public void Add() {
            Console.WriteLine("Add!");
        }
        public void Dispose()
        {
            Console.WriteLine("Dispose Destructed!");
        }
    }
    class UsingKeyWord
    {
        public static void Main(string[] args) {
           
            using (TestDispose obj = new TestDispose())
            {
                obj.Add();
                Console.ReadLine();
            }
        }
    }
}
