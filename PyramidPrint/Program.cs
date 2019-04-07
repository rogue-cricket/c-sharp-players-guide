using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PyramidPrint
{
    class Program
    {
        static void Main(string[] args)
        { 
            // The Try It Out! print a pyramid on page 76
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0;  j < (5 - i); j++)
                {
                    Console.Write(" ");
                }

                for (int j = 0; j < (1 + i*2); j++)
                {
                    Console.Write("*");
                }

                Console.Write("\n");
            }

            Console.ReadKey();
        }
    }
}
