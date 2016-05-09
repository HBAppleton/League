using League.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace League.Repository
{
    public interface ITeamRepository : IGenericRepository<Team>
    {
        Team GetById(long Id);

        IEnumerable<Team> GetActive();
    }
}
