using czelectronics.Data;
using czelectronics.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace czelectronics.Repository.StoreCodes
{
    public class StoreCodes : IStoreCodes
    {
        private readonly CzElectornicsDbContext _context;

        public StoreCodes(CzElectornicsDbContext context)
        {
            _context = context;
        }
        public List<StoreCode> GetStoreCodes()
        {
            return _context.StoreCodes.AsNoTracking().ToList();
        }
        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
