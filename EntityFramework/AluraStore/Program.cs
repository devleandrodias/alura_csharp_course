using System;
using System.Collections.Generic;
using System.Linq;

namespace AluraStore
{
    class Program
    {
        // ADO - Access Data Object

        // CRUD - Create, Read, Update, Delete

        static void Main(string[] args)
        {
            PersistUsingAdoNet();

            PersistUsingEntity();

            GetProductsUsingAdoNet();

            GetProductsUsingEntity();

            RemoveProductUsingAdoNet();

            RemoveProductUsingEntity();

            UpdateProductUsingAdoNet();

            UpdateProductUsingEntity();
        }

        private static void UpdateProductUsingEntity()
        {
            using StoreContext context = new();

            IList<Product> products = context.Products.ToList();

            Product product = products.First();

            product.Price = 29.89;

            context.Products.Update(product);

            context.SaveChanges();
        }

        private static void UpdateProductUsingAdoNet()
        {
            using var repo = new ProductDAO();

            IList<Product> products = repo.Products();

            Product product = products.First();

            product.Price = 39.89;

            repo.Update(product);
        }

        private static void RemoveProductUsingEntity()
        {
            using StoreContext context = new();

            IList<Product> products = context.Products.ToList();

            context.Products.Remove(products.First());

            context.SaveChanges();
        }

        private static void RemoveProductUsingAdoNet()
        {
            using var repo = new ProductDAO();

            IList<Product> products = repo.Products();

            repo.Remove(products.First());
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
