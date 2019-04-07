using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvenAndOdd
{
    class Program
    {
        static void Main(string[] args)
        {
            // The Try It Out! from page 65.  "Write a program that asks for user input and determines if it's even or odd."

            Console.WriteLine("Enter your integer:");
            int evenOrOdd = Convert.ToInt32(Console.ReadLine());

            if (evenOrOdd % 2 == 0)
                Console.WriteLine($"{evenOrOdd} is even!");
            else
                Console.WriteLine($"{evenOrOdd} is odd!");

            Console.ReadKey();
        }
    }
}
