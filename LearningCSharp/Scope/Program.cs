using System;

namespace Scope
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Execution 9 program - Scope");

            int johnAge = 16, quantityPeople = 2;

            bool isAccompained = quantityPeople >= 2;

            string aditionalMessage;

            if (isAccompained)
            {
                aditionalMessage = "John are accompained!";
            }

            else
            {
                aditionalMessage = "John aren't accompained";
            }

            if (johnAge >= 18 || isAccompained)
            {
                Console.WriteLine("Can enter!");
            }

            else
            {
                Console.WriteLine("Can't enter");
            }

            Console.WriteLine(aditionalMessage);

            Console.ReadLine();
        }
    }
}
