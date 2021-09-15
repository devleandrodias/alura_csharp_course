using System;

namespace InvestWithFor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Execution 12 program - Invest with For");

            double valueInvested = 1000;

            for (int index = 1; index <= 12; index++)
            {
                valueInvested *= 1.0036;

                Console.WriteLine($"{index} month USD {valueInvested:C2}");
            }

            Console.ReadLine();
        }
    }
}
