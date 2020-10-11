using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace czelectronics.Data.Models
{
    public class ProductType
    {
        public ProductType()
        {
            ProductNavigation = new HashSet<Product>();
        }
        public int ProductTypeId { get; set; }
        public string Type { get; set; }

        //Navigation
        public virtual ICollection<Product> ProductNavigation { get; set; }
    }
}
