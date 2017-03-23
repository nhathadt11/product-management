using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductManagement.ViewModel
{
    public class CategoryViewModel
    {
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }
        public string Description { get; set; }
        public string DisplayName
        {
            get
            {
                return string.Format("{0,-5}{1,-35}{2,-50}", CategoryID, CategoryName, Description);
            }
        }
    }
}
