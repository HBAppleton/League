using League.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace League.Repository
{
    public interface IVDrawRepository : IGenericRepository<Vdraw>
    {
        Vdraw GetById(long id);

        IEnumerable<Vdraw> GetBySeason(int Season);
        IEnumerable<Vdraw> GetByWeekId(long WeekId);
        IEnumerable<Vdraw> GetByTeamId(long TeamId);
        IEnumerable<Vdraw> GetByBowlerId(long BowlerId);
        IEnumerable<Vdraw> GetByScoresheetId(long ScoresheetId);
    }
}
