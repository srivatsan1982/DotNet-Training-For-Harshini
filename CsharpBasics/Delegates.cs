using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    public class Delegates
    {
        delegate int NumberChanger(int n);
        //delegate bool Comparer(int a, int b);

        //public static bool CompareInt(int x, int y) {
        //    return x > y;
        //}

        static int num = 10;
        public static int AddNum(int p)
        {
            num += p;
            return num;
        }

        public static int MultNum(int q)
        {
            num *= q;
            return num;
        }

        public static int getNum()
        {
            return num;
        }

        public static void Main(string[] args) {

            //Console.Write("Enter the First Value:");
            //int anju = int.Parse(Console.ReadLine());

            //Console.Write("Enter the Second Value:");
            //int bhoomi = int.Parse(Console.ReadLine());

            //Comparer comp = new Comparer(CompareInt);

            //Console.WriteLine(comp(anju, bhoomi));

            Console.Write("Enter the Value:");
            int anju = int.Parse(Console.ReadLine());

            NumberChanger nc;
            NumberChanger nc1 = new NumberChanger(AddNum);
            NumberChanger nc2 = new NumberChanger(MultNum);

            nc = nc1 + nc2;

            Console.WriteLine(nc(anju));
        }
    }
}
