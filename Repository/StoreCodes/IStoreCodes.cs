using czelectronics.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace czelectronics.Repository.StoreCodes
{
    public interface IStoreCodes : IDisposable
    {
        List<StoreCode> GetStoreCodes();
    }
}
