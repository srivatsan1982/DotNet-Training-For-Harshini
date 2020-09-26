using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    struct Employee
    {
        public Employee(int empId, string firstName, string middleName, string lastName, DateTime dob,string nickName) {
            EmployeeId = empId;
            FirstName = firstName;
            MiddleName = middleName;
            LastName = lastName;
            DOB = dob;
            NickName = nickName;
        }
        public string NickName { get; set; }
        public int EmployeeId;
        public string FirstName;
        public string MiddleName;
        public string LastName;
        public DateTime DOB;
        public Employee GetEmployee()
        {
            return new Employee();
        }
    }

    public class Structures
    {
        void Display(int EmployeeId, string FirstName, string MiddleName, string LastName, string DOB) {
            Console.WriteLine(string.Format("Employee Id {0},First Name {1},Middle Name {2},Last Name {3},DOB {4}",
                               EmployeeId, FirstName, MiddleName, LastName, DOB));
        }

        private static void DisplayEmployee(Employee emp)
        {
            Console.WriteLine(string.Format("Employee Id {0},First Name {1},Middle Name {2},Last Name {3},DOB {4}",
                               emp.EmployeeId, emp.FirstName, emp.MiddleName, emp.LastName, emp.DOB));
        }

        public static void Main(string[] args)
        {
            //Employee employee1 = new Employee(1, "Guru", "", "Guru", new DateTime());
            //Employee emp1 = new Employee(1, "Anju", "", "Singh", new DateTime(2000, 6, 1));

            //Employee emp2 = new Employee(2, "Bhoomi","", "Patel", new DateTime(2000, 6, 1));

            Employee[] emp = new Employee[2];
            for (int i = 0; i < emp.Length; i++)
            {
                Console.WriteLine("Enter the details for Employee{0}", i + 1);

                emp[i].EmployeeId = i + 1;
                Console.Write("Enter the First Name:");
                emp[i].FirstName = Console.ReadLine();
                Console.Write("Enter the Middle Name:");
                emp[i].MiddleName = Console.ReadLine();
                Console.Write("Enter the Last Name:");
                emp[i].LastName = Console.ReadLine();
                Console.Write("Enter the Date Of Birth:");
                emp[i].DOB =DateTime.Parse(Console.ReadLine());
            }

            foreach (Employee employee in emp)
            {
                //Since this is a Instance Function, we need to create object of the class to access the method.
                Structures structures = new Structures();
                structures.Display(employee.EmployeeId, employee.FirstName, employee.MiddleName, employee.LastName, employee.DOB.ToShortDateString());
                
                //Since this is a Static Method, no object is required to call this method.
                DisplayEmployee(employee);
            }
            Console.ReadLine();
        }
    }
}
