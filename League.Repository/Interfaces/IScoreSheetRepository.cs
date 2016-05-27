using League.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace League.Repository
{
    public interface IScoreSheetRepository : IGenericRepository<Scoresheet>
    {
        Scoresheet GetById(long Id);

        IEnumerable<Scoresheet> GetByDrawId(long DrawId);
        IEnumerable<Scoresheet> GetByBowlerId(long BowlerId);
    }
}
