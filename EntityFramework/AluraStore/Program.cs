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
            using var repo = new ProductDAOEntity();

            IList<Product> products = repo.Products();

            Product product = products.First();

            product.Price = 29.89;

            repo.Update(product);
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
            using var repo = new ProductDAOEntity();

            IList<Product> products = repo.Products();

            repo.Remove(products.First());
        }

        private static void RemoveProductUsingAdoNet()
        {
            using var repo = new ProductDAO();

            IList<Product> products = repo.Products();

            repo.Remove(products.First());
        }

        private static void GetProductsUsingEntity()
        {
            using var repo = new ProductDAOEntity();

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
                Name = "Harry Potter e a Ordem da Fênix",
                Category = "Livros",
                Price = 19.89
            };

            using var repo = new ProductDAOEntity();

            repo.Add(p);
        }

        private static void PersistUsingAdoNet()
        {
            Product p = new()
            {
                Name = "Harry Potter e a Ordem da Fênix",
                Category = "Livros",
                Price = 19.89
            };

            using var repo = new ProductDAO();

            repo.Add(p);
        }
    }
}
