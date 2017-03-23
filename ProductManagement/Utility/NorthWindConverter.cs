using ProductManagement.ViewModel;

namespace ProductManagement.Utility
{
    public class NorthwindConverter
    {
        public static ProductViewModel ToProductViewModel(Product model)
        {
            return new ProductViewModel
            {
                ProductID = model.ProductID,
                ProductName = model.ProductName,
                UnitsOnOrder = model.UnitsOnOrder
            };
        }
        public static Product ToProduct(ProductViewModel viewModel)
        {
            return new Product
            {
                ProductID = viewModel.ProductID,
                ProductName = viewModel.ProductName,
                UnitsOnOrder = viewModel.UnitsOnOrder
            };
        }
        public static CategoryViewModel ToCategoryViewModel(Category model)
        {
            return new CategoryViewModel
            {
                CategoryID = model.CategoryID,
                CategoryName = model.CategoryName,
                Description = model.Description,
            };
        }
        public static Category ToCategory(CategoryViewModel viewModel)
        {
            return new Category
            {
                CategoryID = viewModel.CategoryID,
                CategoryName = viewModel.CategoryName,
                Description = viewModel.Description
            };
        }
        public static SupplierViewModel ToSupplierViewModel(Supplier model)
        {
            return new SupplierViewModel
            {
                SupplierID = model.SupplierID,
                CompanyName = model.CompanyName,
                City = model.City
            };
        }
        public static Supplier ToSupplier(SupplierViewModel viewModel)
        {
            return new Supplier
            {
                SupplierID = viewModel.SupplierID,
                CompanyName = viewModel.CompanyName,
                City = viewModel.City
            };
        }
    }
}
