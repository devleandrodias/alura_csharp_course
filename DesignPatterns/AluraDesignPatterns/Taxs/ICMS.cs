namespace AluraDesignPatterns.Taxs
{
    internal class ICMS : Tax
    {
        public ICMS() : base()
        {

        }

        public ICMS(Tax tax) : base(tax)
        {

        }

        public override double Calculate(Budget budget)
        {
            return budget.Value * 0.1 + CalculateAnotherTax(budget);
        }
    }
}
