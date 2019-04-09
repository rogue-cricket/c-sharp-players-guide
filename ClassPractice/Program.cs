using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// The Try It Out!  From page 123 on creating two classes 

namespace ClassPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Color red = new Color(255, 0, 0);
            Ball bigRedBall = new Ball(200, red);
            Ball randoBall = new Ball(40);

            Console.WriteLine("Throw the red ball once!");
            bigRedBall.Throw();
            Console.WriteLine(bigRedBall.GetThrown());

            Console.WriteLine("Throw the random ball twice!");
            randoBall.Throw();
            randoBall.Throw();
            Console.WriteLine(randoBall.GetThrown());

            Console.WriteLine("Pop the red ball and try to throw it!");
            bigRedBall.Pop();
            bigRedBall.Throw();
            Console.WriteLine(bigRedBall.GetThrown());

            Console.ReadKey();
        }
    }
}
