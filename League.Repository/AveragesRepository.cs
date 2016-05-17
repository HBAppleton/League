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

        public void ResetAverages(long weekId)
        {
            _entities.HbaSAveragesAudit((int)weekId);
        }

    }
}
