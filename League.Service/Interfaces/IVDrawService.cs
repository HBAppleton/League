using League.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace League.Service.Interfaces
{
    public interface IVDrawService : IEntityService<Vdraw>
    {
        Vdraw GetById(long Id);
/*
        Vdraw GetBySeason(int Season);
        Vdraw GetByWeekId(long WeekId);
        Vdraw GetByTeamId(long TeamId);
        Vdraw GetByBowlerId(long BowlerId);
        Vdraw GetByScoresheetId(long ScoresheetId);
*/
    }
}
