using System.Collections.Generic;

namespace ProductManagement.Repository
{
    interface ISuppilerRepository : IRepository<Supplier>
    {
        IEnumerable<Supplier> GetSuppliersByCompanyName(string companyName);
    }
}
