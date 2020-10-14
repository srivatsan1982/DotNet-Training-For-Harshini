using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CsharpBasics;
namespace CSharp
{
    //public class Delegates
    //{
    //    delegate int NumberChanger(int n);
    //    //delegate bool Comparer(int a, int b);

    //    //public static bool CompareInt(int x, int y) {
    //    //    return x > y;
    //    //}

    //    static int num = 10;
    //    public static int AddNum(int p)
    //    {
    //        num += p;
    //        return num;
    //    }

    //    public static int MultNum(int q)
    //    {
    //        num *= q;
    //        return num;
    //    }

    //    public static int getNum()
    //    {
    //        return num;
    //    }

    //    public static void Main(string[] args) {

    //        //Console.Write("Enter the First Value:");
    //        //int anju = int.Parse(Console.ReadLine());

    //        //Console.Write("Enter the Second Value:");
    //        //int bhoomi = int.Parse(Console.ReadLine());

    //        //Comparer comp = new Comparer(CompareInt);

    //        //Console.WriteLine(comp(anju, bhoomi));

    //        Console.Write("Enter the Value:");
    //        int anju = int.Parse(Console.ReadLine());

    //        NumberChanger nc;
    //        NumberChanger nc1 = new NumberChanger(AddNum);
    //        NumberChanger nc2 = new NumberChanger(MultNum);

    //        nc = nc1 + nc2;

    //        Console.WriteLine(nc(anju));
    //    }
    //}

    public class Delegate_Test
    {
        public static int ReturnDelegateResult(NumericDelegate numericDelegate, int a, int b)
        {
            if (numericDelegate != null)
                return numericDelegate(a, b);
            return 0;
        }
    }
    public class Delegates
    {
        public static void Main(string[] args)
        {
            NumericDelegate numericDelegateAdd = new NumericDelegate(DelegateImplementor.Add);
            NumericDelegate numericDelegateSubract = new NumericDelegate(DelegateImplementor.Subract);
            Console.Write("Enter the first number:");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Enter the second number:");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Addition: {0}", numericDelegateAdd(a, b));
            Console.WriteLine("Subraction: {0}", numericDelegateSubract(a, b));
            Console.WriteLine("Delegate_Test Result 1 :{0}", Delegate_Test.ReturnDelegateResult(numericDelegateAdd, a, b));
            Console.WriteLine("Delegate_Test Result 2 :{0}", Delegate_Test.ReturnDelegateResult(numericDelegateSubract, a, b));
            Console.WriteLine("Delegate_Test Result 3 :{0}", Delegate_Test.ReturnDelegateResult(null, a, b));
           
            NumericDelegate nc = numericDelegateAdd + numericDelegateSubract;
            Console.WriteLine("Multi Cast: {0}", nc(a,b));
            Console.ReadLine();
        }

    }
    public class DelegateImplementor
    {
        public static int Add(int a, int b)
        {
            return a + b;
        }

        public static int Subract(int a, int b)
        {
            return a - b;
        }
        public static string StringConcatenation(string a, string b)
        {
            return a + b;
        }
    }
}
