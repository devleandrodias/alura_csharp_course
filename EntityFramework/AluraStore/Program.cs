namespace AluraStore
{
    partial class Program
    {
        static void Main(string[] args)
        {
            Product bread = new()
            {
                Name = "Bread",
                Unity = "Unity",
                UnitPrice = 0.20,
                Category = "Bakehouse"
            };

            Purchase purchase = new() { };

            purchase.Product = bread;
            purchase.Quantity = 6;
            purchase.Price = bread.UnitPrice * purchase.Quantity;

            using StoreContext context = new();

            context.Purchases.Add(purchase);

            context.SaveChanges();
        }
    }
}
