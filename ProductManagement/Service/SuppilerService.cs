using System;
using System.Collections.Generic;
using System.Linq;
using ProductManagement.ViewModel;
using ProductManagement.Utility;

namespace ProductManagement.Service
{
    public class SupplierService : Service<Supplier, SupplierViewModel>, ISupplierService
    {
        public SupplierService() : base(NorthwindConverter.ToSupplier, NorthwindConverter.ToSupplierViewModel)
        {
        }

        public List<SupplierViewModel> SearchSuppilerByCompanyName(string name)
        {
            return NorthWindRepository.Find(s => s.CompanyName.Contains(name))
                                      .Select(s => NorthwindConverter.ToSupplierViewModel(s))
                                      .ToList();
        }

        public override void Update(SupplierViewModel viewModel)
        {
            throw new NotImplementedException();
        }
    }
}
