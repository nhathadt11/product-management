namespace ProductManagement.ViewModel
{
    public class SupplierViewModel
    {
        public int SupplierID { get; set; }
        public string CompanyName { get; set; }
        public string City { get; set; }
        public string DisplayName
        {
            get
            {
                return string.Format("{0,-5}{1,-35}{2,-10}", SupplierID, CompanyName, City);
            }
        }
    }
}
