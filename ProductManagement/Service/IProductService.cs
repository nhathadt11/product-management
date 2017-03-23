using ProductManagement.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductManagement.Service
{
    interface IProductService : IService<Product ,ProductViewModel>
    {
        List<ProductViewModel> SearchProductByName(string name);
    }
}
