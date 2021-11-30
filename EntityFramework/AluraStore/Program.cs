using AluraStore.Data;
using AluraStore.Entities;
using System;
using System.Collections.Generic;

namespace AluraStore
{
    partial class Program
    {
        static void Main(string[] args)
        {
            OneToOne();
        }

        private static void OneToOne()
        {
            Customer customer = new()
            {
                Name = "Leandro",
                DeliveryAddress = new()
                {
                    Stree = "Faria Lima",
                    Number = "AP 23 - 5 Andar",
                    Complement = "Next to MacDonnald"
                }
            };

            using StoreContext context = new();

            context.Customers.Add(customer);

            context.SaveChanges();
        }

        private static void OneToMany()
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

        private static void ManyToMany()
        {
            Product iPhone = new()
            {
                Name = "iPhone 13 Pro Max",
                Category = "Electronics",
                UnitPrice = 1399,
                Unity = "Unity"
            };

            Product macbook = new()
            {
                Name = "MacBook Pro M1",
                Category = "Electronics",
                UnitPrice = 1999,
                Unity = "Unity"
            };

            List<Product> products = new();

            products.Add(iPhone);
            products.Add(macbook);

            Sale christmas = new()
            {
                Products = products,
                Description = "Happy Christmas",
                StartDate = DateTime.Now,
                FinishDate = DateTime.Now.AddMonths(1),
            };

            using StoreContext context = new();

            context.Sales.Add(christmas);

            context.SaveChanges();
        }
    }
}
