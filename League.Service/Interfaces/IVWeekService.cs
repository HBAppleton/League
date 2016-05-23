using League.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace League.Service
{
    public interface IVWeekService : IEntityService<Vweek>
    {
        Vweek GetById(long Id);
        IEnumerable<Vweek> GetBySeason(int Season);
        IEnumerable<Vweek> GetActive();

        DateTime GetSeasonStartDate(int year);
        DateTime GetSeasonFieldaysDate(int year);
    }
}
