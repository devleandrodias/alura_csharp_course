using AluraDesignPatterns.Discounts;
using AluraDesignPatterns.Taxs;
using System;

namespace AluraDesignPatterns
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Budget budget = new(500);

            budget.ApplyExtraDiscount();

            Console.ReadLine();
        }

        private static void Decorator()
        {
            Tax iss = new ISS(new ICMS());

            Budget budget = new(500);

            double value = iss.Calculate(budget);

            Console.Write(value);
        }

        private static void ChainOfResponsability()
        {
            DiscountCalculator calculator = new();

            Budget budget = new(2000);

            budget.AddItem(new Item("iPhone", 500));
            budget.AddItem(new Item("iPad", 1000));
            budget.AddItem(new Item("iMac", 2000));

            double discount = DiscountCalculator.Calculate(budget);

            Console.WriteLine($"Discount: {discount:C2}");
        }

        private static void Strategy()
        {
            Tax iss = new ISS();

            Tax icms = new ICMS();

            Budget budget = new(500);

            TaxCalculator.CalculateTax(budget, iss);

            TaxCalculator.CalculateTax(budget, icms);
        }
    }
}
