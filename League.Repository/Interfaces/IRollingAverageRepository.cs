using League.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace League.Repository
{
    public interface IRollingAverageRepository : IGenericRepository<VRollingAverage>
    {
        VRollingAverage GetById(long id);
    }
}
