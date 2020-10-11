using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using czelectronics.Data;
using Microsoft.EntityFrameworkCore;

namespace czelectronics.Repository.Status
{
    public class Statuses : IStatuses
    {
        private readonly CzElectornicsDbContext _context;

        public Statuses(CzElectornicsDbContext context)
        {
            _context = context;
        }
        public List<Data.Models.Status> GetStatuses()
        {
            var statuses = _context.Statuses.AsNoTracking().ToList();
            return statuses;
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
