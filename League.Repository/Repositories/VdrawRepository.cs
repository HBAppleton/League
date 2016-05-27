using League.Model;
using League.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace League.Repository
{
    public class VdrawRepository : GenericRepository<Vdraw>, IVdrawRepository
    {
        public VdrawRepository(MyDbContext context) : base(context)
        {
        }

        public override IEnumerable<Vdraw> GetAll()
        {
            return _entities.Set<Vdraw>().OrderBy(d => d.Season).ThenBy(d => d.Round).ThenBy(d => d.RoundWeek).ThenBy(d => d.Lane).AsEnumerable();
        }

        public Vdraw GetById(long id)
        {
            return FindBy(w => w.Id == id).FirstOrDefault();
        }

        public IEnumerable<Vdraw> GetBySeason(int season)
        {
            return _entities.Set<Vdraw>().Where(d => d.Season == season).OrderBy(d=>d.Season).ThenBy(d=>d.Round).ThenBy(d=>d.RoundWeek).ThenBy(d=>d.Lane).AsEnumerable();
        }

        public IEnumerable<Vdraw> GetActive()
        {
            DateTime _date = DateTime.Now;

            return GetBySeason(_date.Year);
        }
    }
}
