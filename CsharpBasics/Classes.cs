using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasics
{

    class Calculator
    {
        int a;
        int b;

        public int X { get; }

        public int A
        {
            get { return a; }
            set { a = value; }
        }

        public int B
        {
            get { return b; }
            set { b = value; }
        }

        //public Calculator()
        //{
        //}

        public Calculator(int a, int b)
        {
            this.A = a;
            this.B = b;
            this.X = 10;
        }

        ~Calculator()
        {
            this.A = 0;
            this.B = 0;
            Console.Write("cleared");
            Console.ReadLine();
        }
        /// <summary>
        /// To perfor Addition
        /// </summary>
        /// <returns></returns>
        public int Add()
        {
            return (this.A + this.B);

        }

        /// <summary>
        /// To do substraction
        /// </summary>
        /// <returns></returns>
        public int Substraction()
        {
            return (this.A - this.B);
        }

        /// <summary>
        /// To perform Division
        /// </summary>
        /// <returns></returns>
        public int Division()
        {
            return (this.A / this.B);
        }

        /// <summary>
        /// To perform Multiplication
        /// </summary>
        /// <returns></returns>
        public int Multiplication()
        {
            return (this.A * this.B);
        }
    }
    public enum CalculatorEnum
    {
        Addition = 1,
        Substraction = 2,
        Division = 4,
        Multiplication = 3
    }
    class Classes
    {
        static void Main(string[] args)

        {
            int a = 0;
            int b = 0;


            Console.WriteLine("Enter the value of A:");
            a = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the value of B:");
            b = int.Parse(Console.ReadLine());

            Calculator objCalc = new Calculator(a, b);

            Console.WriteLine("For {0} press {1}", CalculatorEnum.Addition.ToString(), (int)CalculatorEnum.Addition);
            Console.WriteLine("For {0} press {1}", CalculatorEnum.Substraction.ToString(), (int)CalculatorEnum.Substraction);
            Console.WriteLine("For {0} press {1}", CalculatorEnum.Multiplication.ToString(), (int)CalculatorEnum.Multiplication);
            Console.WriteLine("For {0} press {1}", CalculatorEnum.Division.ToString(), (int)CalculatorEnum.Division);

            //int choice = int.Parse(Console.ReadLine());
           
            int choice = (int)Enum.Parse(typeof(CalculatorEnum), "addition", true);

            switch (choice)
            {
                case (int)CalculatorEnum.Addition:
                    Console.WriteLine("Addition:{0}", objCalc.Add());
                    break;
                case (int)CalculatorEnum.Substraction:
                    Console.WriteLine("Substraction:{0}", objCalc.Substraction());
                    break;
                case (int)CalculatorEnum.Multiplication:
                    Console.WriteLine("Multiplication:{0}", objCalc.Multiplication());
                    break;
                case (int)CalculatorEnum.Division:
                    Console.WriteLine("Division:{0}", objCalc.Division());
                    break;

                default:
                    Console.WriteLine("Please check the choice again");
                    break;
            }
            Console.ReadKey();
        }
    }
}
