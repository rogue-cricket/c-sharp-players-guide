using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeTryOut
{
    class Program
    {
        static void Main(string[] args)
        {
            // Page 37's Try It Out - create one variable of every discussed type and print to console.
            int typeInt = -1;
            Console.WriteLine("int: " + typeInt);

            byte typeByte = 200;
            Console.WriteLine("byte: " + typeByte);

            short typeShort = -31111;
            Console.WriteLine("short: " + typeShort);

            long typeLong = 8223372036854775807L;
            Console.WriteLine("long: " + typeLong);

            sbyte typeSByte = -120;
            Console.WriteLine("sbyte: " + typeSByte);

            ushort typeUShort = 60000;
            Console.WriteLine("ushort: " + typeUShort);

            uint typeUInt = 39;
            Console.WriteLine("uint: " + typeUInt);

            ulong typeULong = 290837592837658735UL;
            Console.WriteLine("ulong: " + typeULong);

            char typeChar = 'g';
            Console.WriteLine("char: " + typeChar);

            float typeFloat = 2.1f;
            Console.WriteLine("float: " + typeFloat);

            double typeDouble = 2.333939;
            Console.WriteLine("double: " + typeDouble);

            decimal typeDecimal = 2.3234234m;
            Console.WriteLine("decimal: " + typeDecimal);

            bool typeBool = true;
            Console.WriteLine("bool: " + typeBool);

            string typeString = "oof";
            Console.WriteLine("string: " + typeString);

            Console.ReadKey();

            /* Try It Out! quiz on page 38.
             * 1.  True/False: The int type can store any number.
             *      - False
             * 2. True/False: The char type is an integral type.
             *      - True
             * 3. Order the following by how large of numbers they can store, from smallest to largest: short, long, int, byte.
             *      - byte, short, int, long
             * 4. True/False: The byte type is a signed type.
             *      - False
             * 5. Which can store higher values, int or uint?
             *      - uint
             * 6. What three types can store floating point numbers?
             *      - Float, double, decimal
             * 7. Which of the options in question 6 can store the largest numbers?
             *      - Double
             * 8. Which of the options in question 6 is the most precise?
             *      - Decimal
             * 9. In the following, should myVariable have the type int, char, or string:  myVariable = "8";
             *      - String
             * 10. What type is used to store true and false values?
             *      - Bool
             * 
             */
        }
    }
}
