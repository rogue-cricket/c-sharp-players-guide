using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriangleArea
{
    class Program
    {
        static void Main(string[] args)
        {
            // Triangle app from the Try It Out! on page 44.
            float baseLen = 5.0f;
            float height = 6.0f;
            float area = baseLen * height / 2;

            Console.WriteLine("Area of triangle with base " + baseLen + " and height " + height + " is " + area);
            Console.ReadKey();
        }
    }
}
