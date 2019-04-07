using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            // The classic FizzBuzz from page 76.

            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0)
                {
                    Console.Write("Fizz");
                }

                if (i % 5 == 0)
                {
                    Console.Write("Buzz");
                }

                else if (i % 5 != 0 && i % 3 != 0)
                {
                    Console.Write(i);
                }

                Console.Write("\n");
            }

            Console.ReadKey();
        }
    }
}
