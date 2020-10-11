using czelectronics.Data;
using czelectronics.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace czelectronics.Repository.Products
{
    public class ProductsTypes : IProductsTypes
    {
        private readonly CzElectornicsDbContext _context;

        public ProductsTypes(CzElectornicsDbContext context)
        {
            _context = context;
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public List<ProductType> GetProductsTypes()
        {
            return _context.ProductTypes.ToList();
        }
    }
}
