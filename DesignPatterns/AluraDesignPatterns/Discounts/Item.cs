namespace AluraDesignPatterns.Discounts
{
    public class Item
    {
        public Item(string name, double value)
        {
            Name = name;
            Value = value;
        }

        public string Name { get; private set; }

        public double Value { get; private set; }
    }
}
