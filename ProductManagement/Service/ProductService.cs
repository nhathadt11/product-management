using ProductManagement.Utility;
using ProductManagement.ViewModel;
using System.Collections.Generic;
using System.Linq;

namespace ProductManagement.Service
{
    public class ProductService : Service<Product, ProductViewModel>, IProductService
    {   
        public ProductService() : base(NorthwindConverter.ToProduct, NorthwindConverter.ToProductViewModel)
        {
        }

        public List<ProductViewModel> SearchProductByName(string name)
        {
            return NorthWindRepository.Find(p => p.ProductName.Contains(name))
                                      .Select(p => NorthwindConverter.ToProductViewModel(p))
                                      .ToList();
        }

        public override void Update(ProductViewModel product)
        {
            Product productToUpdate = NorthWindRepository.Get(product.ProductID);
            productToUpdate.ProductName = product.ProductName;
            NorthWindRepository.Commit();
        }
    }
}
