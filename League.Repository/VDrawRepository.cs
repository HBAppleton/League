using League.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace League.Repository
{
    public class VDrawRepository : GenericRepository<Vdraw>, IVDrawRepository
    {
        public VDrawRepository(MyDbContext context) : base(context)
        {
        }

        public override IEnumerable<Vdraw> GetAll()
        {
            return _entities.Set<Vdraw>().AsEnumerable();
        }

        public Vdraw GetById(long Id)
        {
            return FindBy(n => n.DrawId == Id).FirstOrDefault();
        }


        public IEnumerable<Vdraw> GetBySeason(int Season)
        {
            return _entities.Set<Vdraw>().Where(n => n.Season == Season).AsEnumerable();
        }

        public IEnumerable<Vdraw> GetByWeekId(long WeekId)
        {
            return _entities.Set<Vdraw>().Where(n => n.WeekId == WeekId).AsEnumerable();
        }

        public IEnumerable<Vdraw> GetByTeamId(long TeamId)
        {
            return _entities.Set<Vdraw>().Where(n => n.TeamId == TeamId).AsEnumerable();
        }

        public IEnumerable<Vdraw> GetByBowlerId(long BowlerId)
        {
            return _entities.Set<Vdraw>().Where(n => n.BowlerId == BowlerId).AsEnumerable();
        }

        public IEnumerable<Vdraw> GetByScoresheetId(long ScoresheetId)
        {
            return _entities.Set<Vdraw>().Where(n => n.ScoresheetId == ScoresheetId).AsEnumerable();
        }

    }
}
