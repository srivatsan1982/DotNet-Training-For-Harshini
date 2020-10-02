using System;
using System.IO;
namespace chap13
{
    /*
	
        Streams
            Streams provide a way to read/write bytes to and from a storage medium.
            Streams hide the implementation details of i/o operations.
            Streams can be used to perform 3 fundamental operations:
                Read from a stream into a data type.
                Write the contents of a data type to a stream.
                Seak particular positions within a stream.
			
        C-Sharp provides support for i/o through the classes of the System.IO namespace.
        All i/o operations are handeled in the form of streams.
        The two basic streams used are i/p and o/p streams.
        The i/p stream is used for a read operation and 
        The o/p stream is used for performing a write operation.
	
        Streams can be used for  :
            Sequential file access
                Read from and write to the beginning of a file.
            Random file access
                Read from and write to any locations with in a file.
			
        File Stream Class
            The object of the FileStream class provide random access to files using the Seek() Method.
            The seek() method allows read/write positions to be moved with in a file.
            The general structure of the Seek () method is 
            seek(byte_position,referance_point)
            The method takes 2 parameters byte_position and referance_poimt,The byte_position is
            relative to the referance_point.The referance_poimt can be Begin,Current or End. These
            reference points are represented by the properties of the SeekOrgin class.
		
            The reference point,Begin provides the seek reference position as the begining of a stream.
            The reference point,Current ,provides the seek reference position as the current position with in a stream and 
            The reference point ,End,provides the seek reference position as the end of a stream.
		
        properties of seekOrgin
            Seekorgin.Begin -->	Refers to the begining of the file position.
            Seekorgin.Current --> Refers to the current file position.
            Seekorgin.End --> Returns to the end of the file position.
		
        The object of the FileStream class are used to provide random access to files.
        The FileStreram constructor takes parameters that are used to initialize the 
        members of the class.
	
        The FileStream Class Constructor
            Initialize a new instance of the FileStream object for the specified file.
            The general structure of the constructor can be given as:
            public FileStream(path, FileMode, FileAccess);
            In this code :
                path --> represents the filename or file path.
                Filemode ---> Determines how the file is opened or created.
                FileAccess-->Determines how the file may be accessed by the fileStream object.
            The diffferent values that can be used with FileMode are :
            1.Append --> This opens the file if it exists and seeks the end of the file,or 
            creates a new file.FileMode.Append can only be used along with FileAccess.Write.
            2.Create --> This specifies that the operating system should create a new file.
            If the file already exists,it willbe overwritten.
            3.CreateNew --> this specifies that the operating sysytem should create a new file.
            4.Open--> This specifies that the operating system should open an existing  file.
            5.OpenorCreate -->	This specifies that the operating system shold open a file if exists;
            otherwise a new file should be created.
		
		
			

    */


    //    class File_Write
    //    {
    //        /// <summary>
    //        /// The main entry point for the application.
    //        /// </summary>
    //        [STAThread]
    //        static void Main(string[] args)
    //        {
    //            try
    //            {
    //                //FileStream fs = new FileStream(@"E:\test1.txt", FileMode.Create, FileAccess.Write);
    //                //FileStream fs = new FileStream(@"e:\testfile.txt", FileMode.OpenOrCreate, FileAccess.Write);
    //                //FileStream fs = new FileStream(@"F:\HARSHINI_TRAINING\CsharpBasics\test.ini", FileMode.Append, FileAccess.Write);
    //                //FileStream fs = new FileStream(@"E:\test1.bin", FileMode.CreateNew, FileAccess.Write);
    //                //FileStream fs = new FileStream(@"F:\HARSHINI_TRAINING\CsharpBasics\test.ini", FileMode.CreateNew, FileAccess.Write);
    //                //FileStream fs = new FileStream(@"e:\testfile.bin", FileMode.OpenOrCreate, FileAccess.Write);

    //                StreamWriter w = new StreamWriter(fs);
    //                Console.WriteLine("Enter a string:");
    //                string str = Console.ReadLine();
    //                w.Write(str);
    //                w.Flush();
    //                w.Close();
    //            }
    //            catch (IOException ex)
    //            {
    //                Console.WriteLine(ex);
    //            }
    //        }
    //    }
    //}
    //class File_Read
    //{
    //    public static void Main(string[] args)
    //    {
    //        FileStream fs1 = new FileStream(@"F:\HARSHINI_TRAINING\CsharpBasics\test.ini", FileMode.Open, FileAccess.Read);
    //        StreamReader sr = new StreamReader(fs1);

    //        sr.BaseStream.Seek(0, SeekOrigin.Begin);
    //        string str = sr.ReadLine();
    //        while (str != null)
    //        {
    //            Console.WriteLine("{0} ", str);
    //            str = sr.ReadLine();
    //        }
    //        sr.Close();
    //    }
    //}
    //}
    //Set the commandline arg first 
    //right click the project select properties select configuration properties
    //then select the debug option then type the parameters(filename) in the commandlin args .
    //    class writting
    //    {
    //        public static void Main(string[] args)
    //        {
    //            if (args.Length < 1)
    //            {
    //                Console.WriteLine("Must Include file name ");
    //            }
    //            else
    //            {
    //                StreamWriter myfile = File.CreateText(args[0]);
    //                myfile.WriteLine("Mary had a little lamb,");
    //                myfile.WriteLine(" Whose Fleece was white as snow");

    //                for (int ctr = 0; ctr < 10; ctr++)
    //                    myfile.WriteLine("{0}", ctr);
    //                myfile.WriteLine("Everywhere that Mary went that lamb was sure to go");
    //                myfile.Flush();
    //                myfile.Close();


    //            }
    //        }
    //    }
    //}
    //    public class Reading
    //    {
    //        public static void Main(string[] args)
    //        {
    //            if (args.Length < 1)
    //            {
    //                Console.WriteLine("Must Include file name ");
    //            }
    //            else
    //            {
    //                string buffer;
    //                StreamReader myfile = File.OpenText(args[0]);
    //                //while ((buffer = myfile.ReadLine()) != null)
    //                //{
    //                //    Console.WriteLine(buffer);
    //                //}
    //                //myfile.Close();
    //                while (!myfile.EndOfStream)
    //                {
    //                    Console.WriteLine(myfile.ReadLine());
    //                }
    //                myfile.Close();
    //            }

    //        }
    //    }

}