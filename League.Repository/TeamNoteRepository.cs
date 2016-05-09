using League.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace League.Repository
{
    public class TeamNoteRepository : GenericRepository<Teamnote>, ITeamNoteRepository
    {
        public TeamNoteRepository(MyDbContext context): base(context)
        {

        }

        public override IEnumerable<Teamnote> GetAll()
        {
            return _entities.Set<Teamnote>().AsEnumerable();
        }


        public Teamnote GetById(long Id)
        {
            return FindBy(t => t.Id == Id).FirstOrDefault();
        }

        public IEnumerable<Teamnote> GetByTeamId(long TeamId)
        {
            return _entities.Set<Teamnote>().Where(t => t.TeamId == TeamId).AsEnumerable();
        }

        public IEnumerable<Teamnote> GetByTeamSeason(long TeamId, int Season)
        {
            return _entities.Set<Teamnote>().Where(t => t.TeamId == TeamId).Where(t => t.Season == Season).AsEnumerable();
        }
    }
}
