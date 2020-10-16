using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SharedAssembly;

namespace CSharp
{
    public class AccessSharedAssembly
    {
        public static void Main(string[] args) {
            var objShared = new SharedMathematics();
            objShared.Add(10, 20);
        }
    }
}
