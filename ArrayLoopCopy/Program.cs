using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayLoopCopy
{
    class Program
    {
        static void Main(string[] args)
        {
            // The Try It Out! on page 80.  Copy from one array to another using a loop and the array.Length property.

            string[] arrA = new string[] { "one", "two", "buckle", "my", "shoe", "three", "four", "lock", "the", "door" };
            string[] arrB = new string[arrA.Length];

            for (int i = 0; i < arrA.Length; i++)
            {
                arrB[i] = arrA[i];
            }

            Console.WriteLine($"First array: [" + string.Join(",", arrA) + "]");
            Console.WriteLine($"Second array: [" + string.Join(",", arrB) + "]");
            Console.ReadKey();
        }
    }
}
