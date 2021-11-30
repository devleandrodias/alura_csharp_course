using AluraStore.Entities;
using System.Collections.Generic;
using static AluraStore.DAO.ProductDAO;

namespace AluraStore.Interfaces
{
    internal interface IProductDAO
    {
        void Add(Product product);

        void Update(Product product);

        void Remove(Product product);

        IList<Product> Products();
    }

    internal interface IProductDAOADO
    {
        void Add(ProductADO product);

        void Update(ProductADO product);

        void Remove(ProductADO product);

        IList<ProductADO> Products();
    }
}
