using AluraDesignPatterns.Discounts;
using System.Collections.Generic;

namespace AluraDesignPatterns
{
    enum EBudgetStatus
    {
        ON_APPROVAL = 1,
        APPROVED = 2,
        DISAPPROVED = 3,
        FINISHED = 4
    }

    internal class Budget
    {
        public double Value { get; private set; }

        public EBudgetStatus Status { get; set; }

        public List<Item> Items { get; set; }

        public Budget(double value)
        {
            Value = value;
            Items = new List<Item>();
        }

        public void AddItem(Item item)
        {
            Items.Add(item);
        }

        public void ApplyExtraDiscount()
        {
            if (Status == EBudgetStatus.ON_APPROVAL) Value -= (Value * 0.5);

            if (Status == EBudgetStatus.APPROVED) Value -= (Value * 0.2);
        }
    }
}
