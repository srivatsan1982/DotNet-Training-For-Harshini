using LambdaExpressions.Delegates;
using System;
using System.Collections.Generic;
using System.Text;

namespace LambdaExpressions.Repository
{
    public class GenericRepository<T>
    {
        private List<T> data;
        public GenericRepository(List<T> data)
        {
            this.data = data;
        }

        public T FindCustomerByFuncDelegate(Func<T, bool> compareFunc)
        {
            foreach (var item in data)
            {
                if (compareFunc(item))
                    return item;
            }
            return default(T);
        }

        public bool CheckCustomerExists(Predicate<T> compareFunc)
        {
            foreach (var item in data)
            {
                if (compareFunc(item))
                    return true;
            }
            return false;
        }

        public void AddCustomerIfExists(Predicate<T> compareFunc, Action<T> action)
        {
            foreach (var item in data)
            {
                if (compareFunc(item))
                    action(item);
            }
        }
    }
}
