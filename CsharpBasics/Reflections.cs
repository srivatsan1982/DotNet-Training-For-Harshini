using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace CSharp
{
    class TestReflection
    {

        public TestReflection()
        {

        }
        public string a;
        public void SampleFunction() { Console.WriteLine("I am from Sample Function"); }
        public int Sample { get; set; }

    }
    class Reflections
    {
        public static void Main(string[] args)
        {

            var tInfo = typeof(TestReflection);
            Console.WriteLine("The full name is {0}", tInfo.FullName);
            var ctorInfo = tInfo.GetConstructors();

            foreach (var ctor in ctorInfo)
            {
                Console.WriteLine("Constructor Info {0}", ctor.Name);
            }

            var fInfo = tInfo.GetFields();
            foreach (var field in fInfo)
            {
                Console.WriteLine("Field Info {0}", field.Name);
                if (field.FieldType == typeof(string))
                    field.SetValue(new TestReflection(), "120");
                Console.WriteLine("Field Info {0}", field.GetValue(new TestReflection()));

            }

            var mInfo = tInfo.GetMethods();
            foreach (var method in mInfo)
            {
                Console.WriteLine("Method Info {0}", method.Name);
            }

            var pInfo = tInfo.GetProperties();
            foreach (var prop in pInfo)
            {
                Console.WriteLine("Property Info {0}", prop.Name);
            }
        }
    }
}
