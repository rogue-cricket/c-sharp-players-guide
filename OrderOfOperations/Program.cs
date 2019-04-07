using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderOfOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            // The order of operations Try It Out! on page 56
            double a = 1.0 + 1 + 1.0f;
            Console.WriteLine($"a is {a}");

            int x = (int)(7 + 3.0 / 4.0 * 2);
            Console.WriteLine($"x is {x}");

            Console.WriteLine((1 + 1) / 2 * 3);
            Console.ReadKey();
        }
    }
}
