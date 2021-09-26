using AluraDesignPatterns.Discounts;
using System.Collections.Generic;

namespace AluraDesignPatterns
{
    internal class Budget
    {
        public double Value { get; private set; }

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
    }
}
