using AluraDesignPatterns.Interfaces;
using System;

namespace AluraDesignPatterns
{
    internal class TaxCalculator
    {
        public static void CalculateTax(Budget budget, ITax tax)
        {
            Console.WriteLine(tax.Calculate(budget));
        }
    }
}
