namespace AluraDesignPatterns.Discounts
{
    internal interface IDiscount
    {
        double Discount(Budget budget);

        IDiscount Next { get; set; }
    }
}
