namespace AluraDesignPatterns.Discounts
{
    internal class DiscountForFiveItems : IDiscount
    {
        public IDiscount Next { get; set; }

        public double Discount(Budget budget)
        {
            if (budget.Items.Count == 5)
            {
                return budget.Value * 0.1;
            }

            return Next.Discount(budget);
        }
    }
}
