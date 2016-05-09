using League.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace League.Repository
{
    public class ScoresheetRepository : GenericRepository<Scoresheet>,  IScoreSheetRepository
    {
        public ScoresheetRepository(MyDbContext context) : base(context)
        {

        }

        public override IEnumerable<Scoresheet> GetAll()
        {
            return _entities.Set<Scoresheet>().AsEnumerable();
        }

        public Scoresheet GetById(long Id)
        {
            return _dbset.Where(s => s.Id == Id).FirstOrDefault();
        }

        public IEnumerable<Scoresheet> GetByDrawId(long DrawId)
        {
            return _entities.Set<Scoresheet>().Where(s => s.DrawId == DrawId).AsEnumerable();
        }

        public IEnumerable<Scoresheet> GetByBowlerId(long BowlerId)
        {
            return _entities.Set<Scoresheet>().Where(s => s.BowlerId == BowlerId).AsEnumerable();
        }
    }
}
