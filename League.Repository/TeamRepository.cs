using League.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace League.Repository
{
    public class TeamRepository : GenericRepository<Team>, ITeamRepository
    {
        public TeamRepository(MyDbContext context) : base(context)
        {

        }

        public override IEnumerable<Team> GetAll()
        {
            return _entities.Set<Team>().OrderByDescending(t=>t.ActiveFlag).ThenBy(t=>t.TeamName).AsEnumerable();
        }

        public IEnumerable<Team> GetActive()
        {
            return _entities.Set<Team>().Where(t => t.ActiveFlag == "Y").OrderBy(t=>t.TeamName).AsEnumerable();
        }

        public Team GetById(long Id)
        {
            return _dbset.Where(t => t.Id == Id).FirstOrDefault();
        }

    }
}
