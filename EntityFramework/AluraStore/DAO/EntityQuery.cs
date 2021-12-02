using AluraStore.Data;
using AluraStore.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AluraStore
{
    public partial class Program
    {
        static void SaveSale()
        {
            using (StoreContext context = new())
            {
                List<Product> products = context.Products
                    .Where(x => x.Category.Equals("Electronics"))
                    .ToList();

                Sale saleNewYear = new()
                {
                    Description = "New year",
                    Products = products,
                    StartDate = DateTime.Now,
                    FinishDate = DateTime.Now.AddMonths(1),
                };

                context.Sales.Add(saleNewYear);

                context.SaveChanges();
            };
        }

        static void ShowSale()
        {
            using StoreContext context = new();

            Sale sales = context.Sales
                .Include(x => x.Products)
                .FirstOrDefault();

            Console.WriteLine("Show sales!");

            foreach (Product product in sales.Products)
            {
                Console.WriteLine(product.ToString());
            }
        }

        static void ShowProduct()
        {
            using StoreContext context = new();

            Customer customer = context.Customers
                .Include(x => x.DeliveryAddress)
                .FirstOrDefault();

            Console.WriteLine($"Address delivery: {customer.DeliveryAddress.Stree}");

            Product product = context.Products
                .Include(x => x.Sales)
                .Where(x => x.Id.Equals(2))
                .FirstOrDefault();

            foreach (Sale sale in product.Sales)
            {
                Console.WriteLine($"Sale Id: {sale.Id}");
            }
        }
    }
}
