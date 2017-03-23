using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace ProductManagement.Repository
{
    public class ProductRepository : Repository<Product>, IProductRepository
    {
        public ProductRepository(DbContext context) : base(context)
        {
        }

        IEnumerable<Product> IProductRepository.GetProductByName(string name)
        {
            return Context.Set<Product>()
                          .Where(p => p.ProductName.Contains(name));
        }
    }
}
