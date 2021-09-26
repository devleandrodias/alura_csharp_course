using System;

namespace AluraDesignPatterns.Taxs
{
    internal class TaxCalculator
    {
        public static void CalculateTax(Budget budget, Tax tax)
        {
            Console.WriteLine(tax.Calculate(budget));
        }
    }
}
