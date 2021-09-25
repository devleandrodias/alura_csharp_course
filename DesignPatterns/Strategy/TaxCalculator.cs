using Strategy.Interfaces;
using System;

namespace Strategy
{
    internal class TaxCalculator
    {
        public static void CalculateTax(Budget budget, ITax tax)
        {
            Console.WriteLine(tax.Calculate(budget));
        }
    }
}
