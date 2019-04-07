using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Remainder
{
    class Program
    {
        static void Main(string[] args)
        {
            // Simple remainder app from page 45.

            int a = 22;
            int b = 3;
            int quotient = a / b;
            int remainder = a % b;

            Console.WriteLine(a + "/" + b + " is " + quotient + " with remainder " + remainder);
            Console.WriteLine("Checking work: " + quotient + "*" + b + " + " + remainder + " is " + (quotient * b + remainder));
            Console.ReadKey();

        }
    }
}
