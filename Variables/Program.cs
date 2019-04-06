using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            // The exercises in this part are mostly playing around with integer variables.
            int a = 5;
            int b = 2;

            Console.WriteLine("a: " + a);
            Console.WriteLine("b: " + b);

            b = a;

            Console.WriteLine("b: " + b);

            a = -3;

            Console.WriteLine("a: " + a);
            Console.ReadKey();

            /* Quiz:
             * 1.  Name three things all variables have.
             *      - Name, type, and value.
             * 2. True/False:  You can use a variable before it is declared.
             *      - False.
             * 3. How many times must a variable be declared?
             *      - One time.
             * 4. Out of the following, which are legal variable names?  answer, 1stValue, value1, $message, delete-me, delete_me, PI
             *      - The legal names are:  answer, value1, delete_me, PI.
             */
        }
    }
}
