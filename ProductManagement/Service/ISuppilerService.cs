using ProductManagement.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductManagement.Service
{
    interface ISupplierService : IService<Supplier, SupplierViewModel>
    {
        List<SupplierViewModel> SearchSuppilerByCompanyName(string name);
    }
}
