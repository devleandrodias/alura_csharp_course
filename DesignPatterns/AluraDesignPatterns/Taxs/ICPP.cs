namespace AluraDesignPatterns.Taxs
{
    internal class ICPP : TaxTemplate
    {
        public override double MaxTax(Budget budget) => budget.Value * 0.07;

        public override double MinTax(Budget budget) => budget.Value * 0.05;

        public override bool UseMaxTax(Budget budget) => budget.Value >= 500;
    }
}
