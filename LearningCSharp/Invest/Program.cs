using System;

namespace InvestWithWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Execution 11 program - Invest with while");

            double valueInvested = 1000;

            short index = 1;

            while (index <= 12)
            {
                valueInvested += valueInvested * 0.0036;

                Console.WriteLine($"{index} month USD {valueInvested:C2}");

                index++;
            }

            Console.ReadLine();
        }
    }
}
