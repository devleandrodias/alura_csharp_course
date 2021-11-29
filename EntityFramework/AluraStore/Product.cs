namespace AluraStore
{
    internal class Product
    {
        public int Id { get; internal set; }
        public string Name { get; internal set; }
        public string Category { get; internal set; }
        public double UnitPrice { get; internal set; }
        public string Unity { get; internal set; }

        public override string ToString()
        {
            return $"Product {Id}, {Name} - {Category}, {UnitPrice}";
        }
    }
}