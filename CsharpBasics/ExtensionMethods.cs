using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    class SamplePrivateConstructor
    {

        public static int a, b;
        private SamplePrivateConstructor(int a,int b)
        {
            a = a;
            b = b;
        }

        public static SamplePrivateConstructor GetInstance(int a,int b)
        {
            return new SamplePrivateConstructor(a, b);
        }

    }
    class AccessPrivateConstructor
    {
        static void Main(string[] args)
        {
            SamplePrivateConstructor cons = SamplePrivateConstructor.GetInstance(10, 20);
            Console.WriteLine("{0}",SamplePrivateConstructor.a + SamplePrivateConstructor.b);
        }
    }
    static class ExtensionMethods
    {
        static int a;
        static ExtensionMethods()
        {
            a = 10;
        }

        static void Add(int a, int b)
        {
            Console.WriteLine("{0}", a + b);
        }

        static void Main(string[] args)
        {
            ExtensionMethods.Add(10, 20);
        }
    }

    static class ExtensionMethod
    {
        public static int GetLength(this string str)
        {
            return str.Length;
        }
        public static bool CheckPalindrome(this string str)
        {
            char[] tempstr = str.ToCharArray();
            Array.Reverse(tempstr);
            string revstr = new string(tempstr);
            return str.Equals(revstr, StringComparison.OrdinalIgnoreCase);
        }
    }

    public class AccessExtensionMethods
    {
        static void Main(string[] args)
        {
            string str = "Malayalam";
            Console.WriteLine(str.GetLength());
            Console.WriteLine(str.CheckPalindrome());
        }
    }
}
