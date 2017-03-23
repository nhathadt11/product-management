using ProductManagement.Utility;
using ProductManagement.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductManagement.Service
{
    public class CategoryService : Service<Category, CategoryViewModel>
    {
        public CategoryService() : base(NorthwindConverter.ToCategory, NorthwindConverter.ToCategoryViewModel)
        {
        }

        public override void Update(CategoryViewModel entity)
        {
            throw new NotImplementedException();
        }
    }
}
