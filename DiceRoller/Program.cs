using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// The Try It Out! from page 110 - create a program that adds together a number of dice rolls specified by the user.

namespace DiceRoller
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dice roller!");
            Random random = new Random();
            bool keepRolling = true;

            do
            {
                Console.WriteLine("Enter how many dice to roll, or type \"exit\" or \"quit\" to exit:");
                string input = Console.ReadLine();

                if (input == "quit" || input == "exit")
                    keepRolling = false;
                else
                {
                    int numDice = Convert.ToInt32(input);
                    int runningTotal = 0;
                    for (int i = 0; i < numDice; i++)
                    {
                        runningTotal += random.Next(6) + 1;
                    }

                    Console.WriteLine($"You rolled {numDice} dice for a total of {runningTotal}");
                }

            } while (keepRolling);
        }
    }
}
