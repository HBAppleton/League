using League.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace League.Repository
{
    public class DrawRepository : GenericRepository<Draw>, IDrawRepository
    {
        public DrawRepository(MyDbContext context) : base(context)
        {
        }

        public override IEnumerable<Draw> GetAll()
        {
            return _entities.Set<Draw>().Include(w => w.WeekId).Include(t => t.TeamId).AsEnumerable();
        }

        public Draw GetById(long id)
        {
            return _dbset.Include(w => w.WeekId).Include(t => t.TeamId).Where(d => d.Id == id).FirstOrDefault();
        }

        public IEnumerable<Draw> GetByWeekId(long id)
        {
            return _dbset.Include(w => w.WeekId).Include(t => t.TeamId).Where(d => d.WeekId == id).AsEnumerable(); 
        }
    }
}
