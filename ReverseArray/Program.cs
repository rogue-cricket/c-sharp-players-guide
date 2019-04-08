using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// The Try It Out! on page 82 - reversing an array using methods

namespace ReverseArray
{
    class Program
    {
        static int[] GenerateNumbers(int len)
        {
            int[] generatedArray = new int[len];

            for (int i = 0; i < len; i++)
            {
                generatedArray[i] = i;
            }
            return generatedArray;
        }

        static int[] Reverse(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                int tmp = arr[i];
                arr[i] = arr[arr.Length - 1 - i];
                arr[arr.Length - 1 - i] = tmp;

            }
            return arr;
        }

        static void PrintNumbers(int[] arr)
        {
            foreach (int num in arr)
            {
                Console.Write(num + ", ");
            }
        }
        static void Main(string[] args)
        {
            int[] numbers = GenerateNumbers(10);
            Reverse(numbers);
            PrintNumbers(numbers);
            Console.ReadKey();
        }
    }
}
