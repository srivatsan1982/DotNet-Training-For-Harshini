using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    /* An Interface is like a pure abstract class,but its differs from a class in a number of ways.
       An interface does not  provide any implementation code.An interface is said to provide a 
       specification or guideline for what will be happening but not the details.All of an interface's 
       members are assumed to be public.If you try to declare a different scope modifier for a member of 
       an interface you will get an error.

       Interface contain only methods,properties,events,and indexers;they do not contain  data members,
       constructors or destructors

       An interface might not seem as all powerful as class,but interface can be used where a class can't.
       A class can inherit from only one other class and can implement multiple interfaces.


   //	*/
    //	
    //	Defining an Interface with Method members
    //interface ICalculator
    //{
    //    int Add(int a, int b);
    //}

    //class Calculator : ICalculator
    //{
    //    public int Add(int a, int b)
    //    {
    //        return a + b;
    //    }
    //    public static void Main(string[] args)
    //    {
    //        ICalculator obj = new Calculator();
    //        Console.WriteLine("The Sum is {0}", obj.Add(10, 20));
    //        Display(10, 20, obj);
    //    }
    //    static void Display(int a,int b,ICalculator calcObj)
    //    {
    //        Console.WriteLine("The Sum is {0}", calcObj.Add(a, b));
    //    }
    //}

    //    interface Ishape
    //    {
    //        double Area();
    //        double Circumference();
    //        int Sides();
    //    }

    //    public class Circle : Ishape
    //    {
    //        public int x, y;
    //        public double radius;
    //        private const float PI = 3.14159F;

    //        public Circle()
    //        {
    //            x = 0;
    //            y = 0;
    //            radius = 0.0;

    //        }
    //        public double Area()
    //        {
    //            return PI * radius * radius;
    //        }

    //        public double Circumference()
    //        {
    //            return ((double)(2 * PI * radius));
    //        }

    //        public int Sides()
    //        {
    //            return 1;
    //        }

    //    }

    //    public class Square : Ishape
    //    {
    //        public int side;
    //        public double Area()
    //        {
    //            return ((double)(side * side));

    //        }
    //        public double Circumference()
    //        {
    //            return ((double)(4 * side));
    //        }
    //        public int Sides()
    //        {
    //            return 4;
    //        }
    //        public Square()
    //        {
    //            side = 0;
    //        }

    //    }

    //    //<summary>
    //    //Summary description for Class1.
    //    //</summary>
    //    class shape
    //    {

    //        [STAThread]
    //        static void Main(string[] args)
    //        {
    //            Circle mycircle = new Circle();
    //            mycircle.radius = 5;
    //            Square mysquare = new Square();
    //            mysquare.side = 4;

    //            Console.WriteLine("\n Displaying the Circle Information :");
    //            displayinfo(mycircle);

    //            Console.WriteLine("\n Displaying the Square Information :");
    //            displayinfo(mysquare);

    //        }
    //        static void displayinfo(Ishape Myshape)
    //        {
    //            Console.WriteLine("Area :{0} ", Myshape.Area());
    //            Console.WriteLine("Sides :{0} ", Myshape.Sides());
    //            Console.WriteLine("Circumference : {0} ", Myshape.Circumference());
    //        }
    //    }
    //}
    //	Defining properties in an Interface
    //    public interface IShape
    //    {
    //        int Sides { get; set; }
    //        double Area();
    //    }
    //    public class Square : IShape
    //    {
    //        private int side;
    //        public Square()
    //        {

    //        }


    //        public int Sides
    //        {
    //            get
    //            {
    //                return side;
    //            }
    //            set
    //            {
    //                side = value;
    //            }
    //        }

    //        public double Area()
    //        {
    //            return ((double)(Sides * Sides));
    //        }
    //    }
    //    public class Props
    //    {
    //        public static void Main()
    //        {
    //            Square mysquare = new Square();
    //            mysquare.Sides = 5;

    //            Console.WriteLine("\n Displaying Square Information :");
    //            Console.WriteLine("Area : {0} ", mysquare.Area());
    //            Console.WriteLine("Sides : {0}", mysquare.Sides);

    //        }
    //    }
    //}
    //	Defining Multiple Interface
    //    public interface IShape
    //    {
    //        int Sides
    //        {
    //            get;
    //        }

    //        double Area();
    //    }

    //    public interface IShapeDisplay
    //    {
    //        void Display();
    //    }

    //    public class Square : IShape, IShapeDisplay
    //    {
    //        private int InSides;

    //        public int Sides
    //        {
    //            get { return InSides; }
    //        }

    //        public double Area()
    //        {
    //            return ((double)(Sides * Sides));
    //        }

    //        public double Circumference()
    //        {
    //            return ((double)(Sides * Sides));
    //        }

    //        public Square()
    //        {
    //            InSides = 4;
    //        }

    //        public void Display()
    //        {
    //            Console.WriteLine("\n Displaying Square Information :");
    //            Console.WriteLine("Side length :{0} ", this.Sides);
    //            Console.WriteLine("Sides :{0} ", this.Sides);
    //            Console.WriteLine("Area : {0} ", this.Area());
    //        }

    //    }

    //    public class Multi
    //    {
    //        public static void Main()
    //        {
    //            Square mysquare = new Square();
    //            //mysquare.Sides = 7;

    //            mysquare.Display();
    //        }
    //    }
    //}

    //}
    ////	Using Explicit Interface members
    //
    /*
        when you implement an interface that has a member name that clashes with another name already in use.
        if a class includes 2 or more interfaces with same member name that member needs to implement only once.
        This single implementation of the method satisfies both interface.

        sometimes you want to implement the method independently for both interfaces.In this case you need to use
        explicit interface implementations.An explicit implementation is done by including the interface name with the 
        member name when you define the member.You must also use casting to call the method.
     */
    //    public interface IShape
    //    {
    //        double Area();
    //        int Sides { get; }
    //        void Display();
    //    }
    //    public interface IShapeDisplay
    //    {
    //        void Display();
    //    }
    //    public class Square : IShape, IShapeDisplay
    //    {
    //        private int InSides;
    //        public int SideLength;
    //        public int Sides
    //        {
    //            get { return InSides; }
    //        }
    //        public double Area()
    //        {
    //            return ((double)(SideLength * SideLength));
    //        }
    //        public double Circumference()
    //        {
    //            return ((double)(Sides * SideLength));
    //        }
    //        public Square()
    //        {
    //            InSides = 4;
    //        }
    //        void IShape.Display()
    //        {
    //            Console.WriteLine("\n Displaying Square Shape's Information :");
    //            Console.WriteLine("Side length :{0} ", this.SideLength);
    //            Console.WriteLine("Sides :{0} ", this.Sides);
    //            Console.WriteLine("Area : {0} ", this.Area());
    //        }
    //        void IShapeDisplay.Display()
    //        {
    //            Console.WriteLine("\n This method could draw the  Shape.... :");
    //        }

    //    }

    //    public class Explicit
    //    {
    //        public static void Main()
    //        {
    //            Square mySquare = new Square();
    //            mySquare.SideLength = 7;
    //            IShape ish = mySquare;
    //            IShapeDisplay ishd = mySquare;

    //            ish.Display();
    //            ishd.Display();

    //        }
    //    }
    //}
    //
    ////	Hiding Interface Members

    //    public interface IShape
    //    {

    //        //members leftout to simplify example.
    //        int ShapeShifter(int val);
    //        int Sides { get; set; }
    //    }
    //    public class Shape : IShape
    //    {
    //        private int InSides;
    //        public int Sides
    //        {
    //            get { return InSides; }
    //            set { InSides = value; }

    //        }
    //        int IShape.ShapeShifter(int val)
    //        {
    //            Console.WriteLine("Shifting Shape ...");
    //            val += 1;
    //            return val;

    //        }
    //        public Shape()
    //        {
    //            Sides = 5;
    //        }
    //    }
    //    public class Hide
    //    {
    //        public static void Main()
    //        {
    //            Shape myShape = new Shape();
    //            Console.WriteLine("My Shape has been created.");
    //            Console.WriteLine("Using get accesser. Sides = {0}", myShape.Sides);

    //            //myShape.Sides = myShape.ShapeShifter(myShape.Sides);  // ==> Error

    //            IShape tmp = myShape;

    //            myShape.Sides = tmp.ShapeShifter(myShape.Sides);

    //            Console.WriteLine("ShapeShifter Called . Sides = {0}", myShape.Sides);


    //        }
    //    }
    //}
    //        //Deriving New Interface from Existing Intreface
    public interface IShape
    {
        long Area();
        long Circumference();
        int Sides { get; set; }

    }

    internal interface I3DShape : IShape
    {
        int Depth { get; set; }
    }

    public class Test : I3DShape
    {
        public int Depth { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int Sides { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public long Area()
        {
            throw new NotImplementedException();
        }

        public long Circumference()
        {
            throw new NotImplementedException();
        }
    }

    public class Hide
    {
        public static void Main()
        {
            Test b = new Test();
            //I3DShape a = new I3DShape();
            b.Area(); // first implement in some other class and then use it.

        }
    }
}
