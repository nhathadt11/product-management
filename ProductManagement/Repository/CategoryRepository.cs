using System.Data.Entity;

namespace ProductManagement.Repository
{
    class CategoryRepository : Repository<Category>
    {
        public CategoryRepository(DbContext context) : base(context)
        {
        }
    }
}
