//#define Trace
using System;
using System.Diagnostics;
using System.Reflection;

namespace CSharpBasics
{
    #region [Conditional Attribute]
    //public class Myclass
    //{

    //    [Conditional("Trace")]
    //    public static void Message(string msg)
    //    {
    //        Console.WriteLine(msg);
    //    }
    //}

    //public class Attributes
    //{
    //    static void function1()
    //    {
    //        Myclass.Message("In Function 1.");
    //        function2();
    //    }
    //    static void function2()
    //    {
    //        Myclass.Message("In Function 2.");
    //    }

    //    public static void Main()
    //    {
    //        Myclass.Message("In Main function.");
    //        function1();
    //        Console.ReadKey();
    //    }
    //}
    #endregion

    #region [Obsolete Attribute]
    //public class Attributes
    //{
    //    [Obsolete("Don't use OldMethod, use NewMethod instead", true)]
    //    static void OldMethod()
    //    {
    //        Console.WriteLine("It is the old method");
    //    }
    //    static void NewMethod()
    //    {
    //        Console.WriteLine("It is the new method");
    //    }
    //    public static void Main(string[] args)
    //    {
    //        OldMethod();
    //    }
    //}
    #endregion

    #region [Attribute Usage]
    [AttributeUsage(AttributeTargets.Class |
AttributeTargets.Constructor |
AttributeTargets.Field |
AttributeTargets.Method |
AttributeTargets.Property,
AllowMultiple = true)]
    public class DeBugInfo : System.Attribute
    {
        private int bugNo;
        private string developer;
        private string lastReview;
        public string message;

        /// <summary>
        /// Constructor of the DebugInfo Class.
        /// </summary>
        /// <param name="bg">Bug Number</param>
        /// <param name="dev">Developer</param>
        /// <param name="d">Date</param>
        public DeBugInfo(int bg, string dev, string d)
        {
            this.bugNo = bg;
            this.developer = dev;
            this.lastReview = d;
        }

        public int BugNo
        {
            get
            {
                return bugNo;
            }
        }

        public string Developer
        {
            get
            {
                return developer;
            }
        }

        public string LastReview
        {
            get
            {
                return lastReview;
            }
        }

        public string Message
        {
            get
            {
                return message;
            }
            set
            {
                message = value;
            }
        }
    }

    [DeBugInfo(bg: 120, dev: "Harshni", d: "16/03/2017")]
    [DeBugInfo(45, "Srivatsan", "12/8/2012", Message = "Return type mismatch")]
    [DeBugInfo(49, "Aashish", "10/10/2012", Message = "Unused variable")]
    class Rectangle
    {
        //member variables
        protected double length;
        protected double width;
        public Rectangle(double l, double w)
        {
            length = l;
            width = w;
        }
        [DeBugInfo(55, "Srivatsan", "19/10/2012", Message = "Return type mismatch")]
        public double GetArea()
        {
            return length * width;
        }
        [DeBugInfo(56, "Srivatsan", "19/10/2012")]
        public void Display()
        {
            Console.WriteLine("Length: {0}", length);
            Console.WriteLine("Width: {0}", width);
            Console.WriteLine("Area: {0}", GetArea());
        }
    }

    public class Attributes
    {
        static void Main(string[] args)
        {
            Rectangle r = new Rectangle(4.5, 7.5);
            r.Display();
            Type type = typeof(Rectangle);

            //iterating through the attribtues of the Rectangle class
            foreach (Object attributes in type.GetCustomAttributes(false))
            {
                DeBugInfo dbi = (DeBugInfo)attributes;
                if (null != dbi)
                {
                    Console.WriteLine("Bug no: {0}", dbi.BugNo);
                    Console.WriteLine("Developer: {0}", dbi.Developer);
                    Console.WriteLine("Last Reviewed: {0}", dbi.LastReview);
                    Console.WriteLine("Remarks: {0}", dbi.Message);
                }
            }

            //iterating through the method attribtues
            foreach (MethodInfo m in type.GetMethods())
            {
                foreach (Attribute a in m.GetCustomAttributes(true))
                {
                    if (a.GetType() == typeof(DeBugInfo))
                    {
                        DeBugInfo dbi = (DeBugInfo)a;
                        if (null != dbi)
                        {
                            Console.WriteLine("Bug no: {0}, for Method: {1}", dbi.BugNo, m.Name);
                            Console.WriteLine("Developer: {0}", dbi.Developer);
                            Console.WriteLine("Last Reviewed: {0}", dbi.LastReview);
                            Console.WriteLine("Remarks: {0}", dbi.Message);
                        }
                    }
                }
            }

            Console.ReadLine();
        }
    }
    #endregion
}
