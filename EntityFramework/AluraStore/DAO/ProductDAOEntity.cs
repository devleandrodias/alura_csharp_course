using AluraStore.Data;
using AluraStore.Entities;
using AluraStore.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AluraStore.DAO
{
    internal class ProductDAOEntity : IDisposable, IProductDAO
    {
        private readonly StoreContext _context;

        public void Add(Product product)
        {
            _context.Products.Add(product);

            _context.SaveChanges();
        }

        public IList<Product> Products()
        {
            return _context.Products.ToList();
        }

        public void Remove(Product product)
        {
            _context.Products.Remove(product);

            _context.SaveChanges();
        }

        public void Update(Product product)
        {
            _context.Products.Update(product);

            _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
