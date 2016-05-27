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
            return _entities.Set<Draw>().AsEnumerable();
        }

        public Draw GetById(long id)
        {
            return _dbset.Where(d => d.Id == id).FirstOrDefault();
        }

        public IEnumerable<Draw> GetByWeekId(long weekid)
        {
            return _dbset.Where(d => d.WeekId == weekid).AsEnumerable(); 
        }

    }
}
