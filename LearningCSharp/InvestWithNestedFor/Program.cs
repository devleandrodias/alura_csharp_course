using System;

namespace InvestWithNestedFor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Execution 13 program - Invest with Nested For");

            double valueInvested = 1000;

            double factor = 1.0036;

            for (int counterYear = 1; counterYear <= 5; counterYear++)
            {
                for (int index = 1; index <= 12; index++)
                {
                    valueInvested *= factor;

                    Console.WriteLine($"Year {counterYear} - {index} month USD {valueInvested:C2}");
                }

                Console.WriteLine();

                factor += 0.001;
            }

            Console.WriteLine($"Total value invested {valueInvested:C2}");

            Console.ReadLine();
        }
    }
}
