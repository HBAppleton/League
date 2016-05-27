using League.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace League.Repository
{
    public class RollingAverageRespository : GenericRepository<VRollingAverage>, IRollingAverageRepository
    {
        public RollingAverageRespository(MyDbContext context) : base(context)
        {
        }

        public VRollingAverage GetById(long id)
        {
            return _dbset.Where(r => r.Id == id).FirstOrDefault();
        }

        public override IEnumerable<VRollingAverage> GetAll()
        {
            return _entities.Set<VRollingAverage>().AsEnumerable();
        }

    }
}



