using League.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace League.Repository
{
    public interface ITeamNoteRepository : IGenericRepository<Teamnote>
    {
        Teamnote GetById(long Id);

        IEnumerable<Teamnote> GetByTeamId(long TeamId);
        IEnumerable<Teamnote> GetByTeamSeason(long TeamId, int Season);
    }
}
