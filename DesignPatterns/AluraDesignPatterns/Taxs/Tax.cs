namespace AluraDesignPatterns.Taxs
{
    internal abstract class Tax
    {
        public Tax AnotherTax { get; set; }

        public Tax()
        {
            AnotherTax = null;
        }

        public Tax(Tax tax)
        {
            AnotherTax = tax;
        }

        public abstract double Calculate(Budget budget);

        protected double CalculateAnotherTax(Budget budget)
        {
            if (AnotherTax == null) return 0;

            return AnotherTax.Calculate(budget);
        }
    }
}
