using ProductManagement;
using ProductManagement.Service;
using ProductManagement.ViewModel;
using System;
using System.Collections.Generic;

namespace ConsoleClientApp
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductService productService = new ProductService();
            SupplierService suppilerService = new SupplierService();
            CategoryService categoryService = new CategoryService();

            while (true)
            {
                Console.WriteLine("\n-------Welcome-------");
                switch (Menu())
                {
                    case 1:
                        Console.WriteLine("\n-------All Products-------");
                        Console.WriteLine(string.Format("{0,-5}{1,-35}{2,-10}", "ID", "Name", "Price"));
                        productService.GetAll()
                                      .ForEach(p => Console.WriteLine(p.DisplayName));
                        break;
                    case 2:
                        Console.WriteLine("\n-------All Suppilers-------");
                        Console.WriteLine(string.Format("{0,-5}{1,-35}{2,-10}", "ID", "Company Name", "City"));
                        suppilerService.GetAll()
                                       .ForEach(s => Console.WriteLine(s.DisplayName));
                        break;
                    case 3:
                        Console.WriteLine("\n-------All Categories-------");
                        Console.WriteLine(string.Format("{0,-5}{1,-35}{2,-50}", "ID", "Name", "Description"));
                        categoryService.GetAll()
                                       .ForEach(c => Console.WriteLine(c.DisplayName));
                        break;
                    case 4:
                        string searchValue;
                        Console.Write("Enter product name: ");
                        searchValue = Console.ReadLine();
                        Console.WriteLine("\n-------Search result for: " + searchValue + "-------");
                        List<ProductViewModel> products = productService.SearchProductByName(searchValue);
                        if (products.Count != 0)
                        {
                            Console.WriteLine(string.Format("{0,-5}{1,-35}{2,-10}", "ID", "Name", "Price"));
                            products.ForEach(p => Console.WriteLine(p.DisplayName));
                        }
                        else
                        {
                            Console.WriteLine("No product found!");
                        }
                        break;
                    case 5:
                        Console.Write("Enter company name: ");
                        searchValue = Console.ReadLine();
                        Console.WriteLine("\n-------Search result for: " + searchValue + "-------");
                        List<SupplierViewModel> suppilers = suppilerService.SearchSuppilerByCompanyName(searchValue);
                        if (suppilers.Count != 0)
                        {
                            Console.WriteLine(string.Format("{0,-5}{1,-35}{2,-10}", "ID", "Company Name", "City"));
                            suppilers.ForEach(s => Console.WriteLine(s.DisplayName));
                        }
                        else
                        {
                            Console.WriteLine("No suppiler found!");
                        }
                        break;
                    case 6:
                        int productId;
                        ProductViewModel productToUpdate;
                        do { Console.Write("Enter Product ID: "); }
                        while (!int.TryParse(Console.ReadLine(), out productId));
                        if ((productToUpdate = productService.Get(productId)) != null)
                        {
                            Console.Write("Enter product name: ");
                            productToUpdate.ProductName = Console.ReadLine();
                            productService.Update(productToUpdate);
                        }
                        else
                        {
                            Console.WriteLine("Product not found!");
                        }
                        break;
                    default:
                        Environment.Exit(Environment.ExitCode);
                        break;
                }
            }
        }
        static int Menu()
        {
            int choice;
            Console.WriteLine("1.   List all Products.");
            Console.WriteLine("2.   List all Suppliers.");
            Console.WriteLine("3.   List all Categories.");
            Console.WriteLine("4.   Search Products by Product name.");
            Console.WriteLine("5.   Search Suppliers by Company Name.");
            Console.WriteLine("6.   Update Product name by Id.");
            Console.WriteLine("7.   Quit.");
            do { Console.Write("Your choice: "); }
            while (!int.TryParse(Console.ReadLine(), out choice) || choice < 1 || choice > 8);
            return choice;
        }
    }
}
