using System;
namespace CsharpBasics
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Welcome to C#!");
            Console.WriteLine("Welcome to C#!");

            //Formatted Output
            Console.WriteLine("{0} Welcome to {1}", "Harshni", "C#");
            
            //String Annotation.
            Console.WriteLine($"{"Harshni"}, Welcome to {"C#"}");

            Console.Write("Enter the Student Name:");
            string studentName = Console.ReadLine();
            Console.Write("Enter the Subject Name:");
            string subjectName = Console.ReadLine();

            //Formatted Output
            Console.WriteLine("{0} Welcome to {1}", studentName, subjectName);

            //String Annotation.
            Console.WriteLine($"{studentName}, Welcome to {subjectName}");

            Console.ReadKey();
        }
    }
}
