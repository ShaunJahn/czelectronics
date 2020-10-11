using czelectronics.Data;
using czelectronics.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace czelectronics.Repository.Customers
{
    public class Customers : ICustomers
    {
        private readonly CzElectornicsDbContext _context;

        public Customers(CzElectornicsDbContext context)
        {
            _context = context;
        }
        public List<Customer> GetCustomers()
        {
            return  _context.Customers.AsNoTracking().ToList();
        }
        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
