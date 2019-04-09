using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// The Try It Out! on page 96 - recursive Fibonacci generator

namespace Fibonacci
{
    class Program
    {

        /// <summary>
        /// Recursive method to find a given number in the Fibonacci sequence.
        /// </summary>
        /// <param name="n">Which number in the sequence to return.</param>
        /// <returns>The nth Fibonacci number.</returns>
        static int Fibonacci(int n)
        {
            if (n < 1)
            {
                Console.WriteLine("Very funny");
                return 0;
            }
            else if (n == 1)
            {
                return 1;
            }

            else if (n == 2)
            {
                return 1;
            }

            return Fibonacci(n - 1) + Fibonacci(n - 2);
        }
        static void Main(string[] args)
        {

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(Fibonacci(i));
            }
            Console.ReadKey();
        }
    }
}
