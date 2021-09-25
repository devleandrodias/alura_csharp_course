using AluraDesignPatterns.Interfaces;
using AluraDesignPatterns.Taxs;
using System;

namespace AluraDesignPatterns
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
