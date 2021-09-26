using AluraDesignPatterns.Discounts;

namespace AluraDesignPatterns.Taxs
{
    internal class IKCV : TaxTemplate
    {
        public override bool UseMaxTax(Budget budget)
        {
            return budget.Value >= 500 && HaveItemOverOneHundredDollars(budget);
        }

        public override double MaxTax(Budget budget) => budget.Value * 0.1;

        public override double MinTax(Budget budget) => budget.Value * 0.06;

        private static bool HaveItemOverOneHundredDollars(Budget budget)
        {
            foreach (Item item in budget.Items)
            {
                if (item.Value > 100) return true;
            }

            return false;
        }
    }
}
