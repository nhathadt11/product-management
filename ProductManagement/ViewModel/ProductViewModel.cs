using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductManagement.ViewModel
{
    public class ProductViewModel
    {
        public int ProductID { get; set; }
        private string _productName;
        public string ProductName
        {
            get { return _productName; }
            set
            {
                if (!string.IsNullOrEmpty(value.Trim()))
                {
                    _productName = value;
                }
            }
        }
        public short? UnitsOnOrder { get; set; }
        public string DisplayName
        {
            get
            {
                return string.Format("{0,-5}{1,-35}{2,-10}", ProductID, ProductName, UnitsOnOrder);
            }
        }
    }
}
