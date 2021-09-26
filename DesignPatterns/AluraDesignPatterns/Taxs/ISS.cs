namespace AluraDesignPatterns.Taxs
{
    internal class ISS : Tax
    {
        public ISS() : base()
        {

        }

        public ISS(Tax tax) : base(tax)
        {

        }

        public override double Calculate(Budget budget)
        {
            return budget.Value * 0.06 + CalculateAnotherTax(budget);
        }
    }
}
