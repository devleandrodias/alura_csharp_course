using System;

namespace Conditional
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Execution 7 program - Conditional");

            int johnAge = 16, quantityPeople = 2;

            if (johnAge >= 18)
            {
                Console.WriteLine("Over 18 years old, can enter!");
            }

            else if (quantityPeople >= 2)
            {
                Console.WriteLine("Under 18 years old, can enter");
            }

            else
            {
                Console.WriteLine("Under 18 years old, can't enter");
            }

            Console.ReadLine();
        }
    }
}
