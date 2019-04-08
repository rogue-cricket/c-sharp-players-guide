using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// The Try It Out! on page 85 - use an enumerator to define the months of the year, ask for input, and print.

namespace MonthsOfYear
{
    enum MonthsOfYear { January=1, February=2, March=3, April=4, May=5, June=6, July=7, August=8, September=9, October=10, November=11, December= 12};
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number between 1 and 12:");
            int month = Convert.ToInt16(Console.ReadLine());
            
            if (month > 0 && month < 12)
            {
                Console.WriteLine("That month is " + (MonthsOfYear)(month));
            }
            else
            {
                Console.WriteLine("That number does not correspond to a month.");
            }

            Console.ReadKey();
        }
    }
}
