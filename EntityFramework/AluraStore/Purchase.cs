namespace AluraStore
{
    internal class Purchase
    {
        public Purchase()
        {

        }

        public int Id { get; internal set; }
        public double Quantity { get; internal set; }
        public int ProductId { get; set; }
        public Product Product { get; internal set; }
        public double Price { get; internal set; }
    }
}
