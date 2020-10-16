using System;
using System.Collections;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    //class BoxingUnBoxing
    //{
    //    public static void Main(string[] args)
    //    {
    //        int i = 10;
    //        //Boxing
    //        object obj = i;
    //        Console.WriteLine(obj.ToString() + obj.ToString());
    //        //UnBoxing
    //        int x = (int)obj;
    //        Console.WriteLine(x + x);
    //    }
    //}
    //public class TestClass<T>
    //{
    //    // define an Array of Generic type with length 5
    //    T[] obj = new T[5];
    //    System.Collections.Generic.IDictionary<T, T> queries;
    //    int count = 0;

    //    // adding items mechanism into generic type
    //    public void Add(T item)
    //    {
    //        //checking length
    //        if (count + 1 < 6)
    //        {
    //            obj[count] = item;

    //        }
    //        count++;
    //    }
    //    //indexer for foreach statement iteration
    //    public T this[int index]
    //    {
    //        get { return obj[index]; }
    //        set { obj[index] = value; }
    //    }
    //    //public T this[T t] {
    //    //    get { return queries[t]; }
    //    //    set { queries[t] = value; }
    //    //}
    //}
    //class ProgramGenerics
    //{
    //    static void Main(string[] args)
    //    {
    //        //instantiate generic with Integer
    //        TestClass<int> intObj = new TestClass<int>();

    //        //adding integer values into collection
    //        intObj.Add(1);
    //        intObj.Add(2);
    //        intObj.Add(3);     //No boxing
    //        intObj.Add(4);
    //        intObj.Add(5);

    //        //displaying values
    //        for (int i = 0; i < 5; i++)
    //        {
    //            Console.WriteLine(intObj[i]);   //No unboxing
    //        }

    //        TestClass<string> strObj = new TestClass<string>();
    //        strObj.Add("Harshni");
    //        strObj.Add("Bhoomi");
    //        for (int i = 0; i < 2; i++)
    //        {
    //            Console.WriteLine(strObj[i]);   //No unboxing
    //        }
    //        Console.ReadKey();
    //    }
    //}

    //class ProgramGenericsMethod
    //{
    //    //Generic method
    //    static void Swap<T>(ref T a, ref T b)
    //    {
    //        T temp;
    //        temp = a;
    //        a = b;
    //        b = temp;
    //    }
    //    static void Main(string[] args)
    //    {
    //        // Swap of two integers.
    //        int a = 40, b = 60;
    //        Console.WriteLine("Before swap: {0}, {1}", a, b);

    //        Swap<int>(ref a, ref b);

    //        Console.WriteLine("After swap: {0}, {1}", a, b);

    //        Console.ReadLine();
    //    }
    //}

    //public class ProgramDictionary
    //{
    //    static void Main(string[] args)
    //    {
    //        //define Dictionary collection

    //        Dictionary<int, string> dObj = new Dictionary<int, string>();
    //        //add elements to Dictionary

    //        dObj.Add(120, "Anju");
    //        dObj.Add(1, "Tom");
    //        dObj.Add(2, "John");
    //        dObj.Add(3, "Maria");
    //        dObj.Add(4, "Max");
    //        dObj.Add(5, "Ram");
    //        dObj.Add(6, "Madhuri");

    //        Console.WriteLine(dObj[120]);

    //        //print data
    //        for (int i = 1; i <= dObj.Count; i++)
    //        {
    //            Console.WriteLine(dObj[i]);
    //        }
    //        Console.ReadKey();
    //    }
    //}

    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        // Pass reference type by value
    //        ArrayList arrayList = new ArrayList() { 0, 1, 2, 3 };
    //        Console.WriteLine("Pass by Value");

    //        PassByValue(arrayList);

    //        // What should be the output of below line ??
    //        Console.WriteLine(arrayList[1]);
    //        arrayList = new ArrayList() { 0, 1, 2, 3 };

    //        Console.WriteLine("Pass by Reference");

    //        PassByReference(ref arrayList);

    //        // What should be the output of below line ??
    //        Console.WriteLine(arrayList[1]);

    //        Console.Read();
    //    }

    //    private static void PassByValue(ArrayList arrayList)
    //    {

    //        Console.WriteLine(arrayList[1]);
    //        // Now Change the first position value
    //        arrayList[1] = 90;
    //        arrayList = new ArrayList() { 101, 102, 103, 104 };

    //        Console.WriteLine(arrayList[1]);
    //    }

    //    private static void PassByReference(ref ArrayList arrayList)
    //    {

    //        Console.WriteLine(arrayList[1]);

    //        // Now Change the first position value
    //        arrayList[1] = 90;
    //        arrayList = new ArrayList() { 90, 101, 102, 103 };

    //        Console.WriteLine(arrayList[1]);
    //    }
    //}

    //class Program
    //{
    //    //		/// <summary>
    //    //		/// The main entry point for the application.
    //    //		/// </summary>
    //    //		/// 
    //    //Example for Boxing and UnBoxing
    //    [STAThread]
    //    static void Main(string[] args)
    //    {
    //        int i = 10;
    //        object o = i;	// Boxing is normal datatype to Object type
    //        Console.WriteLine(o.ToString() + o.ToString());
    //        int k = (int)o;	//UnBoxing	Object type to normal datatype
    //        Console.WriteLine(k + k);
    //        Object o1 = (Object)i;
    //        Console.WriteLine(o1.ToString());
    //    }
    //}

    //		Reflection

    //public class Program
    //{
    //    public static void Main(string[] args)
    //    {
    //        TestReflection obj = new TestReflection();

    //        Type t = obj.GetType();

    //        ConstructorInfo[] cons = t.GetConstructors();
    //        foreach (ConstructorInfo constructor in cons)
    //        {
    //            Console.WriteLine(constructor.IsConstructor);
    //            Console.WriteLine(constructor.Name);
    //        }

    //        PropertyInfo prop = t.GetProperty("MyProperty");

    //        MethodInfo[] mi = t.GetMethods();
    //        Console.WriteLine("List of methods in TestReflection:");
    //        foreach (MethodInfo meth in mi)
    //        {
    //            Console.WriteLine(meth.Name);
    //        }
    //        Console.WriteLine("Full class name of TestReflection is:");
    //        Console.WriteLine(t.FullName);
    //        Console.Read();
    //    }
    //}
    //public class TestReflection
    //{
    //    public TestReflection()
    //    {

    //    }
    //    public TestReflection( int a)
    //    {

    //    }
    //    public int MyProperty { get; set; }
    //    public void Test()
    //    {
    //        Console.WriteLine("Test");
    //    }
    //}

    //		Factory Method
    //		A method going to create an obj directly that creating method  is called as factory method.

    //public class Class52Test
    ////private class Class52Test
    //{
    //    public void Test()
    //    {
    //        Console.WriteLine("Iam inside Test()");
    //    }
    //}
    //public class Class52Demo
    //{
    //    public Class52Test CreateObj()
    //    {
    //        return new Class52Test();
    //    }
    //}
    //public class ProgramFactory
    //{
    //    public static void Main(string[] args)
    //    {
    //        var obj = new Class52Demo();
    //        var obj1 = obj.CreateObj();
    //        obj1.Test();
    //    }
    //}

    //Tuple
    //class ProgramTuple
    //{
    //    static void Main()
    //    {
    //        // Create three-item tuple.
    //        Tuple<int, string, bool, string,bool> tuple =
    //            new Tuple<int, string, bool, string,bool>(1, "cat", true, "test",false);

    //        // Access tuple properties.

    //        if (tuple.Item1 == 1)
    //        {
    //            Console.WriteLine(tuple.Item1);
    //        }
    //        if (tuple.Item2 == "dog")
    //        {
    //            Console.WriteLine(tuple.Item2);
    //        }
    //        if (tuple.Item3)
    //        {
    //            Console.WriteLine(tuple.Item3);
    //        }
    //        Console.WriteLine(tuple.Item4);
    //    }
    //}

    class ProgramDynamic
    {
        static dynamic _y;

        static void Main()
        {
            // Use dynamic local.
            dynamic a = 1;
            Console.WriteLine(a);

            // Dynamic now has a different type.
            a = new string[0];
            Console.WriteLine(a);

            // Assign to dynamic method result.
            a = Test();
            Console.WriteLine(a);

            // Use dynamic field.
            //_y = "carrot";
            _y = new ExpandoObject();
            _y.Error = "test";
            _y.blahblah = 123;
            _y.anju = "Testing";
            _y.harshni = "sample";
            // You can call anything on a dynamic variable,
            // ... but it may result in a runtime error.
            Console.WriteLine(_y.Error);
        }

        static dynamic Test()
        {
            return 1;
        }
    }
}
