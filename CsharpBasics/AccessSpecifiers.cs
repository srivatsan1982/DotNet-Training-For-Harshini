using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    /*	Access Specifiers.
     *	Public		-->	Unlimited  Access.
     *	Private		--> The Access is limited  to the class where the keyword is defined.
     *	Protected	--> Restrict the accesibility of members to the same class and classes derived from it.
     *	Internal	-->	Limit the access to the file within the same assembly.(private class/fn  we can give rights to access with in the project)
     *	Protected Internal--> To provide access with in the program file that contains the class defination and to the derived classes.
     * 
			
    */

    class Student
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>

        string name;

        public void Assign_dtls()
        {
            name = "John Joseph";

        }

        public void disp()
        {
            Console.WriteLine("Name of the Student is {0}", name);

        }

        //By default This is a private method so we can't access the method outside the class.
        //internal void display()
        //internal void display()
        //protected void display()
        protected internal void display()
        {
            Console.WriteLine("Name of the Student is {0}", name);

        }

        //[STAThread]
        private static void Main(string[] args)
        {
            Student stu = new Student();
            stu.Assign_dtls();
            stu.disp();
            stu.display();
            //with in the class it will work but outside the class it will not work because it is private.
        }
    }



    class Access_student
    {
        Student a = new Student();

        public void Disp_details()
        {
            a.disp(); // public method we can access any were(access is not limited)
            a.display(); //using internal keyword we can access the private function 
                         //			can be accessed from the same program file and not from outside the program file.

        }

        public void Assign_det()
        {
            a.Assign_dtls();
        }

        private static void Main(string[] args)
        {
            Access_student stud = new Access_student();
            stud.Assign_det();
            stud.Disp_details();
        }

    }
}

////				Inheritence


//	Single Inheritence

//class Car
//{
//    string ModelNumber;
//    string CarCategory;
//    string CarMake;
//    string CarName;

//    public void SetCarDetails(string modelNo, string carCat, string carMake, string carName)
//    {
//        this.ModelNumber = modelNo;
//        this.CarCategory = carCat;
//        this.CarMake = carMake;
//        this.CarName = carName;
//    }

//    protected internal void GetCarDetails()
//    {
//        Console.WriteLine("{0},{1},{2},{3}", ModelNumber, CarCategory, CarMake, CarName);
//    }
//}

//class Maruthi : Car
//{
//    public void GetMaruthiCarDetails()
//    {
//        GetCarDetails();
//    }

//    public static void Main(string[] a)
//    {
//        Maruthi maruti = new Maruthi();
//        maruti.SetCarDetails("ALTO LXI", "HATCH BACK", "MARUTI", "ALTO");
//        maruti.GetMaruthiCarDetails();
//        Console.ReadLine();
//    }
//}

class pcp
{
    private int dos, msoffice, foxpro;

    public void pcp_get_fees()
    {

        Console.Write("Enter the fees amount for Dos :");
        dos = Int32.Parse(Console.ReadLine());
        Console.Write("Enter the fees amount for msoffice :");
        msoffice = Int32.Parse(Console.ReadLine());
        Console.Write("Enter the fees amount for foxpro :");
        foxpro = Int32.Parse(Console.ReadLine());
    }

    public void pcp_list_fees()
    {

        Console.WriteLine("Dos : {0}", dos);
        Console.WriteLine("MsOffice : {0}", msoffice);
        Console.WriteLine("Foxpro : {0}", foxpro);
    }

}

class hdca : pcp
{
    private int unix, c, cplus;

    public void hdca_get_fees()
    {
        pcp_get_fees();
        Console.Write("Enter the fees amount for Unix :");
        unix = Int32.Parse(Console.ReadLine());
        Console.Write("Enter the fees amount for C :");
        c = Int32.Parse(Console.ReadLine());
        Console.Write("Enter the fees amount for Cplus :");
        cplus = Int32.Parse(Console.ReadLine());
    }

    public void hdca_list_fees()
    {
        pcp_list_fees();
        Console.WriteLine("Unix : {0}", unix);
        Console.WriteLine("C : {0}", c);
        Console.WriteLine("C++ : {0}", cplus);
    }
}

class Course
{
    private static void Main(string[] args)
    {
        //Console.Write("Enter the fees for PCP \n");

        pcp p;
        p = new pcp();
        p.pcp_get_fees();
        Console.Write("Enter the fees for hdca \n");
        hdca h = new hdca();
        h.hdca_get_fees();
        Console.WriteLine("\n The Output ");
        Console.Write("The fees Details for PCP \n");
        p.pcp_list_fees();
        Console.Write("The fees Details for HDCA \n");
        h.hdca_list_fees();
        Console.ReadLine();
    }
}

//--------------------------------------
internal class Base
{

    //public virtual void disp()
    //public void disp()
    public virtual void disp()
    {
        Console.WriteLine("Base Class");
    }

}

internal class Derived : Base
{
    public new void disp()
    {
        Console.WriteLine("Derived class");
    }
    //public override void disp()
    //{
    //    Console.WriteLine("Derived class");
    //}

    private static void Main()
    {

        Base d = new Derived();
        d.disp();

        Derived c = new Derived();
        c.disp();

        Base b = new Base();
        b.disp();
    }
}
//}
public class Printer
{
    public virtual void Print()
    {

    }
}

public class DesktopPrinter : Printer
{
    public override void Print()
    {
        Console.WriteLine("Printing from Desktop Printer");
    }
}

public class XeroxPrinter : Printer
{
    public override void Print()
    {
        Console.WriteLine("Printing from Xerox Printer");
    }
}
public class BillPrinting
{
    private static void Main()
    {
        string printer = "DESKTOP";
        switch (printer)
        {
            case "DESKTOP":
                Printer DESKTOP = new DesktopPrinter();
                DESKTOP.Print();
                break;
            case "XEROX":
                Printer XEROX = new XeroxPrinter();
                XEROX.Print();
                break;
            default:
                Printer printer1 = new Printer();
                printer1.Print();
                break;
        }

    }
}
//}
class Vehicle
{
    protected double distance = 0.0;
    protected double hour = 0.0;
    protected double fuel = 0.0;

    public Vehicle(double distance, double hour, double fuel)
    {
        this.distance = distance;
        this.hour = hour;
        this.fuel = fuel;
    }

    public void Average()
    {
        double average = 0.0;
        average = distance / fuel;
        Console.WriteLine("Vehicle Average is {0:0.00}", average);
    }

    public virtual void Speed()
    {
        double speed = 0.0;
        speed = distance / hour;
        Console.WriteLine("Vehicle Speed is {0:0.00}", speed);
    }
}

class Car : Vehicle
{
    public Car(double distance, double hour, double fuel)
        : base(distance, hour, fuel)
    {
        //base.distance = 0;
        //base.hour = 0;
        //base.fuel = 0;
    }
    new public void Average()
    {
        double average = 0.0;
        average = distance / fuel;
        Console.WriteLine("Car Average is {0:0.00}", average);
    }

    public override void Speed()
    {
        double speed = 0.0;
        speed = distance / hour;
        Console.WriteLine("Car Speed is {0:0.00}", speed);
    }
}

class Program
{
    static void Main(string[] args)
    {
        double distance, hour, fuel = 0.0;
        Console.WriteLine("Enter the Distance");
        distance = Double.Parse(Console.ReadLine());
        Console.WriteLine("Enter the Hours");
        hour = Double.Parse(Console.ReadLine());
        Console.WriteLine("Enter the Fuel");
        fuel = Double.Parse(Console.ReadLine());
        Car objCar = new Car(distance, hour, fuel);
        Vehicle objVeh = objCar;
        objCar.Average();
        objVeh.Average();
        objCar.Speed();
        objVeh.Speed();
        Console.Read();
    }
}
//}

//internal class A
//{
//    public virtual void Test()
//    {
//        Console.WriteLine("A.Test");
//    }
//}

//internal class B : A
//{
//    public override void Test()
//    {
//        Console.WriteLine("B.Test");
//    }
//}

//internal class Program
//{
//    private static void Main()
//    {
//        // Compile-time type is A.
//        // Runtime type is A as well.
//        A ref1 = new A();
//        ref1.Test();

//        // Compile-time type is A.
//        // Runtime type is B.
//        A ref2 = new B();
//        ref2.Test();
//        //}
//    }
//}

//class Mybase
//{
//    public virtual void dimension()
//    //		public  void dimension()
//    {
//        Console.WriteLine("This is the Dimension method");

//    }

//}
//class MyDerived : Mybase
//{
//    public override void dimension()
//    {
//        int h = 0;
//        h++;
//    }
//    public static void Main()
//    {

//        Mybase my = new MyDerived();
//        int height;
//        height = 10;
//        my.dimension();
//        Console.WriteLine("Dimension is {0}", height);
//    }
//}
