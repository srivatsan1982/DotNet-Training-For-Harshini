using LambdaExpressions.Models;
using LambdaExpressions.Models.Datas;
using LambdaExpressions.Repository;
using System;
using System.Collections.Generic;
namespace LambdaExpressions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the First Name to Search:");
            string name = Console.ReadLine();
            //var repo = new CustomerRepository(CustomerData.Customers);
            //repo.FindByFirstName(name);
            //repo.FindCustomerByIntegerFields((a, b) => { return a == b; }, 1);
            //repo.FindCustomerByStringFields((a, b) => { return a == b; }, name);
            //repo.FindCustomerByFuncDelegate(customer=>customer.Id==1);
            //repo.FindCustomerByFuncDelegate(customer => customer.FirstName == name);
            //repo.FindCustomerByFuncDelegate(customer => customer.FirstName == name || customer.LastName==name);
            //repo.CheckCustomerExists(customer => customer.FirstName == name || customer.LastName == name);
            var dupCustomers = new List<Customer>();
            //repo.AddCustomerIfExists(customer => customer.FirstName == name,(a)=>dupCustomers.Add(a));

            var repoGenericsCustomer = new GenericRepository<Customer>(CustomerData.Customers);
            repoGenericsCustomer.CheckCustomerExists(customer => customer.FirstName == name || customer.LastName == name);
            repoGenericsCustomer.AddCustomerIfExists(customer => customer.FirstName == name, (a) => dupCustomers.Add(a));
            var repoGenericsEmployee = new GenericRepository<Employee>(EmloyeeData.Employees);
            repoGenericsEmployee.CheckCustomerExists(employee => employee.FirstName == name || employee.LastName == name);
            var dupEmployees = new List<Employee>();
            repoGenericsEmployee.AddCustomerIfExists(employee => employee.FirstName == name, (a) => dupEmployees.Add(a));
        }
        public static bool Comp(string a, string b) => a == b;
        public static bool CompareFirstName(string a, string b) => a == b;
        
    }
}
