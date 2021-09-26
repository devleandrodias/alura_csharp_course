using AluraDesignPatterns.Interfaces;

namespace AluraDesignPatterns.Taxs
{
    internal abstract class TaxTemplate : ITax
    {
        public double Calculate(Budget budget) => UseMaxTax(budget) ? MaxTax(budget) : MinTax(budget);

        public abstract bool UseMaxTax(Budget budget);

        public abstract double MinTax(Budget budget);

        public abstract double MaxTax(Budget budget);
    }
}
