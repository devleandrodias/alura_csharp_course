using System.Collections.Generic;

namespace AluraStore
{
    internal interface IProductDAO
    {
        void Add(Product product);

        void Update(Product product);

        void Remove(Product product);

        IList<Product> Products();
    }
}
