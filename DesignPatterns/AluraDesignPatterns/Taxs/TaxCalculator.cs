using AluraDesignPatterns.Interfaces;
using System;

namespace AluraDesignPatterns.Taxs
{
    internal class TaxCalculator
    {
        public static void CalculateTax(Budget budget, ITax tax)
        {
            Console.WriteLine(tax.Calculate(budget));
        }
    }
}
