namespace AluraStore
{
    class Program
    {
        // ADO - Access Data Object

        static void Main(string[] args)
        {
            PersistUsingAdoNet();
        }

        private static void PersistUsingAdoNet()
        {
            Product p = new()
            {
                Name = "Harry Potter e a Ordem da Fênix",
                Category = "Livros",
                Price = 19.89
            };

            using (var repo = new ProductDAO())
            {
                repo.Add(p);
            }
        }
    }
}
