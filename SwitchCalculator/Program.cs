using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write your first number:");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Write your second number:");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the operation between them (+, -, /, *, or ^):");
            string op = Console.ReadLine();
            string result;

            switch (op)
            {
                case "+":
                    result = "" + (num1 + num2);
                    break;
                case "-":
                    result = "" + (num1 - num2);
                    break;
                case "/":
                    result = "" + (num1 / num2);
                    break;
                case "*":
                    result = "" + (num1 * num2);
                    break;
                case "^":
                    result = "" + Math.Pow(num1, num2);
                    break;
                default:
                    result = "not a real thing";
                    break;
            }

            Console.WriteLine($"{num1}{op}{num2} is {result}.");
            Console.ReadKey();
        }
    }
}
