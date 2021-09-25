using Strategy.Interfaces;

namespace Strategy.Taxs
{
    internal class ICMS : ITax
    {
        public double Calculate(Budget budget)
        {
            return budget.Value * 0.1;
        }
    }
}
