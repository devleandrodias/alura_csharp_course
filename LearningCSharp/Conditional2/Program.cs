using System;

namespace Conditional2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Execution 8 program - Conditional 2");

            int johnAge = 16, quantityPeople = 2;

            bool isAccompained = quantityPeople >= 2;

            if (johnAge >= 18 && isAccompained == true)
            {
                Console.WriteLine("Can enter!");
            }

            else
            {
                Console.WriteLine("Can't enter");
            }

            Console.ReadLine();
        }
    }
}
