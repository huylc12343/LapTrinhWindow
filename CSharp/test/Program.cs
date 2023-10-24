using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Program
    {
        static unsafe void Main(string[] args)
        {
            int i = 50;
            double x = 7.98;
            int* ptr = &i;
            Console.WriteLine("{0} {1} {2}", i, (uint)ptr, x);
        }
    }
}