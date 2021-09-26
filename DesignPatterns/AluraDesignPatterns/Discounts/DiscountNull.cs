namespace AluraDesignPatterns.Discounts
{
    internal class DiscountNull : IDiscount
    {
        public IDiscount Next { get; set; }

        public double Discount(Budget budget)
        {
            return 0;
        }
    }
}
