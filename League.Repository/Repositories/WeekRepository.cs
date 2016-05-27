using League.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace League.Repository
{
    public class WeekRepository : GenericRepository<Week>, IWeekRepository
    {
        public WeekRepository(MyDbContext context) : base(context)
        {

        }

        public override IEnumerable<Week> GetAll()
        {
            return _entities.Set<Week>().AsEnumerable();
        }

        public Week GetById(long id)
        {
            return FindBy(w => w.Id == id).FirstOrDefault();
        }

        public IEnumerable<Week> GetBySeason(int season)
        {
            return _entities.Set<Week>().Where(w => w.Season == season).AsEnumerable();
        }

        public IEnumerable<Week> GetActive()
        {
            DateTime _date = DateTime.Now;

            return GetBySeason(_date.Year);
        }
    }
}
