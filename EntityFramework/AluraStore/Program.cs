using System;
using System.Collections.Generic;
using System.Linq;

namespace AluraStore
{
    class Program
    {
        // ADO - Access Data Object

        static void Main(string[] args)
        {
            //PersistUsingAdoNet();

            // PersistUsingEntity();

            // GetProductsUsingAdoNet();

            GetProductsUsingEntity();
        }

        private static void GetProductsUsingEntity()
        {
            using StoreContext context = new();

            IList<Product> products = context.Products.ToList();

            foreach (Product product in products)
            {
                Console.WriteLine(product.Name);
                Console.WriteLine(product.Price);
                Console.WriteLine(product.Category);
                Console.WriteLine("\n===================================\n");
            }

            Console.ReadLine();
        }

        private static void GetProductsUsingAdoNet()
        {
            using var repo = new ProductDAO();

            IList<Product> products = repo.Products();

            foreach (Product product in products)
            {
                Console.WriteLine(product.Name);
                Console.WriteLine(product.Price);
                Console.WriteLine(product.Category);
                Console.WriteLine("\n===================================\n");
            }

            Console.ReadLine();
        }

        private static void PersistUsingEntity()
        {
            Product p = new()
            {
                Name = "Harry Potter e a Ordem da Fênix - Entity",
                Category = "Livros",
                Price = 19.89
            };

            using StoreContext context = new();

            context.Products.Add(p);

            context.SaveChanges();
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
