using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    enum Colors
    {
        Red, Blue, Green
    }

    enum MaxVal
    {
        Min = 10, Max = 100
    }
    enum Choice : uint
    {
        ASquarePlusBSquare = 1,
        APlusBWholeSquare = 2,
        AMinusBWholeSquare = 3,
    }
    class Operators
    {
        static void Main(string[] args)
        {
            //	Operators https://www.tutorialspoint.com/csharp/csharp_operators.htm
            //int a = 100, b = 10, sum, subt, prod, div, mod;
            //int var1 = 10, var2 = 20;
            //sum = a + b;
            //subt = a - b;
            //prod = a * b;
            //div = a / b;
            //mod = a % b;
            //Console.WriteLine("The sum is = {0}", sum);
            //Console.WriteLine("The Sum of {0} + {1}  is :{2} ", a, b, sum);
            //Console.WriteLine("The Subtraction of {0} - {1}  is :{2} ", a, b, subt);
            //Console.WriteLine("The product of {0} * {1}  is :{2} ", a, b, prod);
            //Console.WriteLine("The division of {0} / {1}  is :{2} ", a, b, div);
            //Console.WriteLine("The modulo of {0} % {1}  is :{2} ", a, b, mod);

            ////////			Arithametic Asignment opperator			
            //var1 += var2;//var1=var1+var2 var2+=var1;var2=var2+var1;
            //var2 += var1;
            //Console.WriteLine("The value in var1 is  {0} ", var1);
            //Console.WriteLine("The value in var2 is  {0} ", var2);

            //var2 -= var1;
            //Console.WriteLine("The value in var1 is  {0} ", var1);
            //Console.WriteLine("The value in var2 is  {0} ", var2);

            /*C# - Decision Making
             * https://www.tutorialspoint.com/csharp/csharp_decision_making.htm*/

            //if..else
            int a = 10;

            if (a > 0)
            {
                Console.WriteLine("a is a positive number");
            }
            else
            {
                Console.WriteLine("a is a negetive number");
            }

            int age = 100;
            if (age >= 18 && age <= 99)
            {
                Console.WriteLine("Elegible to vote");
            }
            else if (age <= 18)
            {
                Console.WriteLine("Not Elegible");
            }
            else
            {
                Console.WriteLine("Not Elegible to vote");
            }

            ////Switch Case
            int s = 0;//int.Parse(Console.ReadLine());
        GET_INFO:
            if (!int.TryParse(Console.ReadLine(), out s))
                goto GET_INFO;

            switch (s)
            {
                case 12:
                    Console.WriteLine("Dozen");
                    break;
                case 6:
                    Console.WriteLine("Half Dozen");
                    break;
                case 24:
                    Console.WriteLine("Two Dozen");
                    break;
                default:
                    Console.WriteLine("Default");
                    break;
            }

            ////Multiple Switch Case
            int ss = 12;
            switch (ss)
            {
                case 6:
                case 12:
                    Console.WriteLine("Half Dozen or Dozen");
                    break;
                case 24:
                case 36:
                    Console.WriteLine("Two Dozen or Three Dozen ");
                    break;
                default:
                    Console.WriteLine("Default");
                    break;
            }

            ////Ternary or Conditional Operator

            string var; age = 19;
            var = ((age > 18) && (age < 99)) ? "valid" : "Not Valid";
            Console.WriteLine("The Given age is {0} age ", var);

            /***Getting Input from the Console Window***/

            //int a = Console.Read();
            //string str = Console.ReadLine();

            int b, choice;
            Console.Write("Enter the First Number:");

            a = int.Parse(Console.ReadLine());
            Console.Write("Enter the Second Number:");
            b = int.Parse(Console.ReadLine());

            Console.WriteLine("Press 1 to perform a^2 + b^2");
            Console.WriteLine("Press 2 to perform (a + b)^2");
            Console.WriteLine("Press 3 to perform (a - b)^2");
            Console.Write("Enter your choice:");

            choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case (int)Choice.ASquarePlusBSquare:
                    Console.WriteLine("The result of {0}^2 + {1}^2 is : {2}", a, b, ((a + b) * (a - b)));
                    break;
                case (int)Choice.APlusBWholeSquare:
                    Console.WriteLine("The result of ({0} + {1})^2 is : {2}", a, b, ((a ^ 2 + b ^ 2 + (2 * a * b))));
                    break;
                case (int)Choice.AMinusBWholeSquare:
                    Console.WriteLine("The result of ({0} - {1})^2 is : {2}", a, b, ((a ^ 2 + b ^ 2 - (2 * a * b))));
                    break;
                default:
                    Console.WriteLine("Select a valid choice");
                    break;
            }

            Console.WriteLine((int)Colors.Red);
            Console.WriteLine((int)Colors.Blue);
            Console.WriteLine((int)Colors.Green);

            //Pre-Increment and Post increment.
            //int i = 10;
            //int postincrement = i++;
            //Console.WriteLine("Post Increment value is:{0}", postincrement);
            //int preincrement = ++i;
            //Console.WriteLine("Pre Increment value is:{0}", preincrement);

            //int postdecrement = i--;
            //Console.WriteLine("Post Increment value is:{0}", postdecrement);
            //int predecrement = --i;
            //Console.WriteLine("Pre Increment value is:{0}", predecrement);

            Console.ReadLine();
        }
    }
}
