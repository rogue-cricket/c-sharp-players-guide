using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cylinders
{
    class Program
    {
        static void Main(string[] args)
        {
            // Cylinder calculator on the Try It Out! of page 49
            float PI = 3.1415926f;

            Console.WriteLine("Enter the height of your cylinder: ");
            double cylinderHeight = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the radius of your cylinder: ");
            double cylinderRadius = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("The volume is: " + (PI * cylinderRadius * cylinderRadius * cylinderHeight));
            Console.WriteLine("The surface area is: " + ((2 * PI * cylinderRadius) * (cylinderRadius + cylinderHeight)));
            Console.ReadKey();
        }
    }
}
