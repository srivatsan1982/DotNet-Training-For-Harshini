using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    class EventHandling
    {
        private int value;
        public delegate void NumChangeHandler();
        public event NumChangeHandler NumberChanged;

        public EventHandling(int n)
        {
            SetValue(n);
        }

        public void OnNumChanged() {

            if (NumberChanged != null)
                NumberChanged();
            else
                Console.WriteLine("Handled via function");
        }

        public static void NumberHandler() {
            Console.WriteLine("Handled via Delegate");
        }

        public void SetValue(int n)
        {
            if (value != n)
            {
                value = n;
                OnNumChanged();
            }
        }
        static void Main(string[] args)
        {
            var obj = new EventHandling(10);
            obj.NumberChanged += new NumChangeHandler(NumberHandler);
            obj.SetValue(20);
        }
    }
}
    