using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PositiveOrNegative
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your first number: ");
            int firstNum = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter your second number: ");
            int secondNum = Convert.ToInt32(Console.ReadLine());

            bool firstNumSign = firstNum >= 0;
            bool secondNumSign = secondNum >= 0;

            if (firstNumSign == secondNumSign)
                Console.WriteLine("The result of their multiplication will be positive!");
            else
                Console.WriteLine("The result of their multiplication will be negative!");

            Console.ReadKey();
        }
    }
}
