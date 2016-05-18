using League.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace League.Repository
{
    public interface IVWeekRepository : IGenericRepository<Vweek>
    {
        Vweek GetById(long id);

        IEnumerable<Vweek> GetBySeason(int season);
        IEnumerable<Vweek> GetActive();
    }
}

