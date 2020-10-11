using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace czelectronics.Repository
{
    public interface IStatuses : IDisposable
    {
       List<Data.Models.Status> GetStatuses();
    }
}
