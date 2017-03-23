using System.Collections.Generic;

namespace ProductManagement.Repository
{
    interface IProductRepository : IRepository<Product>
    {
        IEnumerable<Product> GetProductByName(string name);
    }
}
