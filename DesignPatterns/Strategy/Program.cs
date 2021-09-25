using Strategy.Interfaces;
using Strategy.Taxs;
using System;

namespace Strategy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ITax iss = new ISS();

            ITax icms = new ICMS();

            Budget budget = new(500);

            TaxCalculator.CalculateTax(budget, iss);

            TaxCalculator.CalculateTax(budget, icms);

            Console.ReadLine();
        }
    }
}
