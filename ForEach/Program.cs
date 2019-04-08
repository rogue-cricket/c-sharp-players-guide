using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForEach
{
    class Program
    {
        static void Main(string[] args)
        {
            // The Try It Out! on page 82:  Implement some basic stats things with the foreach loop.
            int[] scores = new int[] { 4, 51, -7, 13, -99, 15, - 8, 45, 90 };

            Console.WriteLine("Array is: " + String.Join(", ", scores));

            // Min value
            int currentMin = Int32.MaxValue;
            foreach (int score in scores)
            {
                currentMin = score < currentMin ? score : currentMin;
            }

            Console.WriteLine($"Minimum is {currentMin}");

            // Average value
            int accumulator = 0;
            foreach (int score in scores)
            {
                accumulator += score;
            }

            Console.WriteLine($"Average is {(float)accumulator / scores.Length}");

            Console.ReadKey();
        }
    }
}
