using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace ProductManagement.Repository
{
    class SuppilerRepository : Repository<Supplier>, ISuppilerRepository
    {
        public SuppilerRepository(DbContext context) : base(context)
        {
        }

        public IEnumerable<Supplier> GetSuppliersByCompanyName(string companyName)
        {
            return Context.Set<Supplier>()
                          .Where(s => s.CompanyName.Contains(companyName));
        }

        IEnumerable<Supplier> ISuppilerRepository.GetSuppliersByCompanyName(string companyName)
        {
            throw new NotImplementedException();
        }
    }
}
