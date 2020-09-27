using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    class TestAccessSpecifier
    {
        public static void Main(string[] args)
        {
            Student dt = new Student();
            dt.display();
        }
    }

    class SubStudent : Student
    {
        public void AccessBaseClassMembers()
        {
            base.display();
        }
        public static void Main(string[] test)
        {
            SubStudent student = new SubStudent();
            student.display();
        }
    }
}
