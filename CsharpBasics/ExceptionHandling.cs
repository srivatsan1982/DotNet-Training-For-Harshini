using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    /*
     Exceptions
        An exception is an erroneous situation that occurs during program execution.
        Exeception handling provides a structured and uniform way of handling the 
        system-level errors.
        All execeptions are represented by an instance of a defined class,System.Exception.
        Some of the system-level execeptions are :
            A division by zero
            A reference to a null value
            Out of memory
            Index out of range etc.
		
        Causes of exceptions
            Exceptional conditions arise when an operation cannot be completed normaly during
            the processing of a C-Sharp statements and expressions.For example if the denominator
            is zero ,an integer division operation throws the error,System.DivideByZero Exception.
            The exception System.IO.IOException is thrown when you try to access an illegal stream 
            object as discussed above.
		
            Whenever an exception occurs ,C-Sharp creates an exception object and sends it to the 
            program in which the exception occured.This action is known as throwing an exception.
            The exception object contains information about the type of error.You need to handle 
            an exception in your program using an exception-handler that will process the exception.
		
        Exception handling can be implemented using the folling keywords
            try
            catch
            finally.
		
		
	
	
	
    try block gaurds the statements that may throw an exception.if an exception occurs with in a 
        try block, the appropriate exception handler that is associated with the try block handles the exception. 
        A try block must have atleast one catch or finally block.
	
        A you can associate an exception handler with try block by providing 1 or more catch handlers 
        immediately after the try block.The catch statement takes as a parameter an object of 
        the Exception class that refers to the exception caught.Once the exception is caught, 
        the statements with in the catch block are executed.The catch block is used to handle 
        the exceptions that occure in a try block.
	
        Finaly is used to guarntee exception of statements,regardless of whetheer an exception
        has occured.You can have only one finaly block for an exception-handler.It is not 
        mandatory to have a finaly block after a try block.
		
    Common Exceptions in the System Namespace :
	
	

	
        */
    //    class Class1
    //    {
    //        public static void add(int a, int b)
    //        {
    //            int res = a / b;
    //            Console.WriteLine(res);
    //        }

    //        public static void Main(string[] args)
    //        {
    //            Class1.add(10, 0);
    //            Console.Read();
    //        }
    //    }
    //}
    //    class Class1
    //    {
    //        public static void add(int a, int b)
    //        {

    //            try
    //            {
    //                int res = a / b;
    //                Console.WriteLine(res);
    //            }
    //            catch (DivideByZeroException ex)
    //            {
    //                Console.WriteLine("Exception Caught ,{0}", ex);
    //            }
    //            catch (Exception ex)
    //            {
    //                Console.WriteLine("Exception Caught ,{0}", ex);
    //            }
    //            finally
    //            {
    //                Console.WriteLine("After handling the Exception");
    //            }
    //        }

    //        public static void Main(string[] args)
    //        {
    //            Class1.add(10, 0);

    //        }
    //    }
    //}
    //    class Add_nums
    //    {
    //        int result;
    //        public void Add_num()
    //        {
    //            result = 0;
    //        }
    //        public void add(int a, int b)
    //        {
    //            try
    //            {
    //                result = a / b;
    //                Console.WriteLine(result);
    //            }
    //            catch (DivideByZeroException e)
    //            {
    //                Console.WriteLine("Exception Caught ,{0}", e);
    //            }
    //            finally
    //            {
    //                Console.WriteLine("Result is  {0} ", result);
    //            }

    //        }
    //        public static void Main()
    //        {
    //            Add_nums a = new Add_nums();
    //            //a.add(10, 0);	//Exception will occurs
    //            a.add(10, 2);
    //        }

    //    }
    //}


    //class error
    //{
    //    public static void Main()
    //    {
    //        int[] myarray = new int[5];
    //        for (int ctr = 0; ctr < 10; ctr++)
    //        {
    //            myarray[ctr] = ctr;
    //        }
    //    }
    //}
    //}
    //    internal class error
    //    {
    //        public static void Main()
    //        {
    //            int[] myarray = new int[5];

    //            try
    //            {
    //                for (int ctr = 0; ctr < 10; ctr++)
    //                {
    //                    myarray[ctr] = ctr;
    //                }
    //            }
    //            catch (IndexOutOfRangeException ex)
    //            {
    //                Console.WriteLine("The exception was caught {0} {1}",ex.Message, ex.StackTrace);
    //            }
    //            Console.WriteLine("At end of class");
    //        }
    //    }
    //}

    //}
    //Using Exception handling
    //    internal class error
    //    {
    //        public static void Main()
    //        {
    //            int[] myarray = new int[5];

    //            try
    //            {
    //                for (int ctr = 0; ctr < 10; ctr++)
    //                {
    //                    myarray[ctr] = ctr;
    //                }
    //            }
    //            catch (Exception e)
    //            {
    //                Console.WriteLine("The exception was caught : \n {0}", e);
    //            }
    //            Console.WriteLine("At end of class");
    //        }
    //    }
    //}

    //	Multiple Catches for a single Try

    //    class error
    //    {
    //        public static void Main()
    //        {
    //            int[] myarray = new int[5];

    //            try
    //            {
    //                for (int ctr = 0; ctr < 10; ctr++)
    //                {
    //                    myarray[ctr] = ctr;
    //                }
    //            }
    //            catch (IndexOutOfRangeException e)
    //            {
    //                Console.WriteLine("You were very goofy  trying to use a bad array index ", e);
    //            }
    //            catch (Exception e)
    //            {
    //                Console.WriteLine("The exception was caught : \n {0}", e);
    //            }
    //            Console.WriteLine("\nDone with the catch statements,Done with program\n");
    //        }
    //    }
    //}
    //		class error
    //		{
    //			public static void Main()
    //			{
    //				int [] myarray = new int[5];
    //			
    //				try
    //				{
    //					for (int ctr = 0;ctr < 10;ctr++)
    //					{
    //						myarray[ctr]=ctr;
    //					}
    //				}
    //				catch( Exception e)
    //				{
    //					Console.WriteLine("The exception was caught : \n {0}",e);
    //				}
    //				finally
    //			{
    //				Console.WriteLine ("Done with Exception handling");
    //			}
    //	
    //				Console.WriteLine("At end of Program");
    //			}
    //		}



    //    class lastFile
    //    {
    //        public static void Main(string[] args)
    //        {
    //            try
    //            {
    //                int ctr = 0;
    //                if (args.Length > 0)
    //                {
    //                    Console.WriteLine("Format : ListFile Filename");
    //                    return;
    //                }
    //                else
    //                {
    //                    Console.WriteLine("args.Length =", args.Length);
    //                    //					FileStream fstr = new FileStream(args[0],FileMode.Open,FileAccess.Read );
    //                    FileStream fstr = new FileStream(@"E:\testfile.txt", FileMode.Open, FileAccess.Read);
    //                    try
    //                    {
    //                        StreamReader sReader = new StreamReader(fstr);
    //                        string line;
    //                        while ((line = sReader.ReadLine()) != null)
    //                        {
    //                            ctr++;
    //                            Console.WriteLine("{0}: {1}", ctr, line);
    //                        }
    //                    }
    //                    catch (Exception e)
    //                    {
    //                        Console.WriteLine("Exception during read/write : {0} \n ", e);
    //                    }
    //                    finally
    //                    {
    //                        fstr.Close();

    //                    }

    //                }
    //            }
    //            catch (System.IO.FileNotFoundException)
    //            {
    //                Console.WriteLine("ListFile could not find the file ");
    //            }
    //            catch (Exception e)
    //            {
    //                Console.WriteLine("Exception : {0} \n\n ", e);
    //            }
    //        }
    //    }
    //}

    internal class UserDefinedException : Exception
    {
        public string Message;
        public string Source;

        //public UserDefinedException(string Message, string Source) {
        //    this.Message = Message;
        //    this.Source = Source;
        //}
    }

    class TestUserDefinedException
    {
        public string Add(int a, int b)
        {
            if (a > b)
            {
                //throw new UserDefinedException("Test", "Test");
                //throw new UserDefinedException { Message = "A is greater than b", Source = "testing" };

                throw new UserDefinedException { Message = "A is greater than B", Source = "TestUserDefinedException" };

            }
            return null;
        }

        public static void Main(string[] args)
        {
            TestUserDefinedException t = new TestUserDefinedException();
            try
            {
                t.Add(10, 5);
            }
            catch (UserDefinedException ex)
            {
                Console.WriteLine(ex.Message + " " + ex.Source);
            }


        }
    }
}
