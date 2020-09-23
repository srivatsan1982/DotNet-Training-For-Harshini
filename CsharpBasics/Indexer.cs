using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    public class Indexer
    {
        private string[] arr = new string[5];

        public string this[int index]
        {
            get
            {
                return arr[index];
            }
            set
            {
                arr[index] = value;
            }
        }

        public static void Main(string[] args)
        {
            Indexer id = new Indexer();

            id[0] = "Srivatsan";
            id[1] = "Madhavan";
            id[2] = "Srivasini";
            id[3] = "Anju";
            id[4] = "Bhoomi";

            for (int i = 0; i <= 4; i++)
            {
                Console.WriteLine(id[i]);
            }
        }
    }
}
