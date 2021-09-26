namespace AluraDesignPatterns.Discounts
{
    internal class DiscountForOverFiveHundredDollars : IDiscount
    {
        public IDiscount Next { get; set; }

        public double Discount(Budget budget)
        {
            if (budget.Value >= 500)
            {
                return budget.Value * 0.07;
            }

            return Next.Discount(budget);
        }
    }
}
