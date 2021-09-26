﻿using AluraDesignPatterns.Discounts;
using AluraDesignPatterns.Interfaces;
using AluraDesignPatterns.Taxs;
using System;

namespace AluraDesignPatterns
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DiscountCalculator calculator = new();

            Budget budget = new(2000);

            budget.AddItem(new Item("iPhone", 500));
            budget.AddItem(new Item("iPad", 1000));
            budget.AddItem(new Item("iMac", 2000));

            double discount = DiscountCalculator.Calculate(budget);

            Console.WriteLine($"Discount: {discount:C2}");

            Console.ReadLine();
        }

        private static void Strategy()
        {
            ITax iss = new ISS();

            ITax icms = new ICMS();

            Budget budget = new(500);

            TaxCalculator.CalculateTax(budget, iss);

            TaxCalculator.CalculateTax(budget, icms);
        }
    }
}
