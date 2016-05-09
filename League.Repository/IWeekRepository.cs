using League.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace League.Repository
{
    public interface IWeekRepository : IGenericRepository<Week>
    {
        Week GetById(long Id);

        IEnumerable<Week> GetBySeason(int Season);
    }
}
