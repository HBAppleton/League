using League.Model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace League.Service.Interfaces
{
    public interface IWeekService : IEntityService<Week>
    {
        Week GetById(long Id);
        IEnumerable GetBySeason(int Season);
        IEnumerable GetActive();
    }
}
