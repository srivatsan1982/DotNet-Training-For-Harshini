using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CSharp
{
    class Threading
    {
        //    public static void CallToChildThread()
        //    {
        //        try
        //        {
        //            Console.WriteLine("Child thread starts");

        //            // do some work, like counting to 10
        //            for (int counter = 0; counter <= 10; counter++)
        //            {
        //                Thread.Sleep(500);
        //                Console.WriteLine(counter);
        //            }

        //            Console.WriteLine("Child Thread Completed");
        //        }

        //        catch (ThreadAbortException e)
        //        {
        //            Console.WriteLine("Thread Abort Exception");
        //        }
        //        finally
        //        {
        //            Console.WriteLine("Couldn't catch the Thread Exception");
        //        }
        //    }

        //    static void Main(string[] args)
        //    {
        //        ThreadStart childref = new ThreadStart(CallToChildThread);
        //        Console.WriteLine("In Main: Creating the Child thread");

        //        Thread childThread = new Thread(childref);
        //        childThread.Start();

        //        //stop the main thread for some time
        //        Thread.Sleep(2000);

        //        //now abort the child
        //        Console.WriteLine("In Main: Aborting the Child thread");

        //        childThread.Abort();
        //        Console.ReadKey();
        //    }

        //Task

        static int GenerateNumbers()
        {
            int i;
            for (i = 0; i < 7; i++)
            {
                Console.WriteLine("Method1 - Number: {0}", i);
                Thread.Sleep(1000);
            }
            return i;
        }

        static string PrintCharacters()
        {
            string str = "dotnet";
            for (int i = 0; i < str.Length; i++)
            {
                Console.WriteLine("Method2 - Character: {0}", str[i]);
                Thread.Sleep(1000);
            }
            return str;
        }

        static int PrintArray()
        {
            int[] arr = { 1, 2, 3, 4, 5 };
            foreach (int i in arr)
            {
                Console.WriteLine("Method3 - Array: {0}", i);
                Thread.Sleep(1000);
            }
            return arr.Count();
        }

        static async void Example()
        {
            // This method runs asynchronously.
            //int t = await Task.Run(() => Allocate());
            //Console.WriteLine("Compute: " + t);
            int ex = await Task.Run(() => Allocate());
            Console.WriteLine("Compute: " + ex);
        }

        static int Allocate()
        {
            // Compute total count of digits in strings.
            int size = 0;
            for (int z = 0; z < 10; z++)
            {
                for (int i = 0; i < 10; i++)
                {
                    string value = i.ToString();
                    if (value == null)
                    {
                        return 0;
                    }
                    size += value.Length;
                }
            }
            return size;
        }

        public static void Main(string[] args)
        {
            Task<int> genum = new Task<int>(GenerateNumbers);
            Task<int> array = new Task<int>(PrintArray);
            Task<string> str = new Task<string>(PrintCharacters);
            genum.Start();
            array.Start();
            str.Start();
            Console.WriteLine("{0}", genum.Result);
            Console.WriteLine("{0}", array.Result);
            Console.WriteLine("{0}", str.Result);

            //Task<int> gennum = new Task<int>(GenerateNumbers);
            //Task<string> genchar = new Task<string>(PrintCharacters);
            //Task<int> genarray = new Task<int>(PrintArray);

            //gennum.Start();
            //genchar.Start();
            //genarray.Start();
            //Console.WriteLine("{0}", gennum.Result);
            //Console.WriteLine("{0}", genchar.Result);
            //Console.WriteLine("{0}", genarray.Result);
            // Start computation.
            Example();
            // Handle user input.
            string result = Console.ReadLine();
            Console.WriteLine("You typed: " + result);
            Console.ReadKey();
        }
    }
}
