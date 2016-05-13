using League.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace League.Repository
{
    public class AveragesRepository : GenericRepository<Average>, IAveragesRepository
    {
        public AveragesRepository(MyDbContext context) : base(context)
        {

        }

        public Average GetById(long id)
        {
            return _dbset.Where(b => b.Id == id).FirstOrDefault();
        }

        public int ResetAverages(long weekId)
        {
            return 1;
        }

        public int GetBowlerAverage(long bowlerId, long weekId)
        {
            MyDbContext db = new MyDbContext();

            ResetAverages(weekId);

            var query = (from a in db.Averages
                         join s in db.Scoresheets on a.ScoreSheetId equals s.Id
                         where s.BowlerId == bowlerId
                         select a.SeriesAverage).Average();

            decimal ldcAverage = Convert.ToDecimal(query);
            int liAverage = Convert.ToInt16(Math.Floor(ldcAverage));

            if (liAverage < 100)
            {
                // maximum Handicap is 100, Handicap is 200 - Average; so minimum Average must be 100
                liAverage = 100;
            }

            return liAverage; 

        }
    }
}
