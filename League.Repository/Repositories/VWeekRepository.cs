using League.Model;
using League.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace League.Repository
{
    public class VWeekRepository : GenericRepository<Vweek>, IVWeekRepository
    {
        public VWeekRepository (MyDbContext context) : base(context)
        {
        }

        public override IEnumerable<Vweek> GetAll()
        {
            return _entities.Set<Vweek>().AsEnumerable();
        }

        public Vweek GetById(long id)
        {
            return FindBy(w => w.Id == id).FirstOrDefault();
        }

        public IEnumerable<Vweek> GetBySeason(int season)
        {
            return _entities.Set<Vweek>().Where(w => w.Season == season).AsEnumerable();
        }

        public IEnumerable<Vweek> GetActive()
        {
            DateTime _date = DateTime.Now;

            return GetBySeason(_date.Year);
        }
    }
}
