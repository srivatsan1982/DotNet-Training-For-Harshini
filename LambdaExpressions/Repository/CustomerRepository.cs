using LambdaExpressions.Delegates;
using LambdaExpressions.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace LambdaExpressions.Repository
{
    class CustomerRepository
    {
        private List<Customer> _customers;
        public CustomerRepository(List<Customer> customers)
        {
            _customers = customers;
        }

        public Customer FindById(int id)
        {
            foreach (Customer customerItem in _customers)
            {
                if (customerItem.Id == id)
                    return customerItem;
            }
            return null;
        }

        public Customer FindByFirstName(string firstName)
        {
            foreach (var item in _customers)
            {
                if (item.FirstName == firstName)
                    return item;
            }
            return null;
        }

        public Customer FindCustomerByStringFields(CompareString compareString,string firsName)
        {
            foreach (var item in _customers)
            {
                if (compareString(item.FirstName,firsName))
                    return item;
            }
            return null;
        }

        public Customer FindCustomerByIntegerFields(CompareIntegers compareIntegers, int id)
        {
            foreach (var item in _customers)
            {
                if (compareIntegers(item.Id, id))
                    return item;
            }
            return null;
        }
        public Customer FindCustomerByFuncDelegate(Func<int,int,bool> compareFunc, int id)
        {
            foreach (var item in _customers)
            {
                if (compareFunc(item.Id, id))
                    return item;
            }
            return null;
        }
        public Customer FindCustomerByFuncDelegate(Func<Customer, bool> compareFunc)
        {
            foreach (var item in _customers)
            {
                if (compareFunc(item))
                    return item;
            }
            return null;
        }

        public bool CheckCustomerExists(Predicate<Customer> compareFunc)
        {
            foreach (var item in _customers)
            {
                if (compareFunc(item))
                    return true;
            }
            return false;
        }

        public void AddCustomerIfExists(Predicate<Customer> compareFunc,Action<Customer> action)
        {
            foreach (var item in _customers)
            {
                if (compareFunc(item))
                    action(item);
            }
        }
        public int Add()
        {
            int a = 10;
            int b = 10;
            if (a > b)
                return 1;
            else
                return 0;
        }
    }
}
