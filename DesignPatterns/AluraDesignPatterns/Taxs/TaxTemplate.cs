namespace AluraDesignPatterns.Taxs
{
    internal abstract class TaxTemplate : Tax
    {
        public override double Calculate(Budget budget)
        {
            return UseMaxTax(budget) ? MaxTax(budget) : MinTax(budget);
        }

        public abstract bool UseMaxTax(Budget budget);

        public abstract double MinTax(Budget budget);

        public abstract double MaxTax(Budget budget);
    }
}
