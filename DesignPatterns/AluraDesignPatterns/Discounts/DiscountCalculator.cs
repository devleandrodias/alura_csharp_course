using System;

namespace AluraDesignPatterns.Discounts
{
    internal class DiscountCalculator
    {
        public static double Calculate(Budget budget)
        {
            IDiscount d1 = new DiscountForFiveItems();

            IDiscount d2 = new DiscountForOverFiveHundredDollars();

            IDiscount d3 = new DiscountNull();

            d1.Next = d2;
            d2.Next = d3;

            return d1.Discount(budget);
        }
    }
}
