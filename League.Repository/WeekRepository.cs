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

        public Week GetById(long Id)
        {
            return FindBy(w => w.Id == Id).FirstOrDefault();
        }

        public IEnumerable<Week> GetBySeason(int Season)
        {
            return _entities.Set<Week>().Where(w => w.Season == Season).AsEnumerable();
        }

        public IEnumerable<Week> GetActive()
        {
            DateTime _date = DateTime.Now;

            return GetBySeason(_date.Year);
        }
    }
}
